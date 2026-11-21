Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Globalization

Namespace Shoelusi
    Partial Public Class FrmGudang
        Private activeAccountId As String
        Private materialCatalog As DataTable
        Private storedSafetyStock As Double?
        Private storedDemand As String
        Private storedLeadTime As String

        Public Sub New()
            InitializeComponent()
            dgvPersediaanBB.Columns.Add("JenisBahan", "Jenis Bahan")
            dgvPersediaanBB.Columns.Add("HargaAcuan", "Harga Acuan (Rp)")
            dgvPengadaanBB.Columns.Add("HargaSatuan", "Harga Satuan")
            dgvPengadaanBB.Columns.Add("NamaBahan", "Nama Bahan")
            dgvPengadaanBB.Columns.Add("Subtotal", "Total (Rp)")
            AddHandler txtPengadaanNama.TextChanged, Sub(sender, e) PreviewPurchase()
            AddHandler txtPengadaanJumlah.TextChanged, Sub(sender, e) PreviewPurchase()
            AddHandler txtPengadaanNo.TextChanged, Sub(sender, e) PreviewPurchase()
            dgvCekPenggunaanBB.Columns.Add("KodePenggunaan", "Kode Penggunaan")
            BindPageActions()
            BindSearch(dgvPersediaanBB)
            BindSearch(dgvPengadaanBB)
            BindSearch(dgvHitungEOQ)
            BindSearch(dgvHitungROP)
            AddHandler btnLogout.Click, Sub(sender, e) Close()
            AddHandler Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub

        Private Sub BindPageActions()
            BindCrud(dgvPersediaanBB, New Control() {txtStokKode, txtStokNama, txtStokJumlah, txtStokSatuan, txtStokMinimum, txtStokJenis, txtStokHarga},
                     btnTambahPersediaanBB, btnUbahPersediaanBB, btnHapusPersediaanBB, btnBersihkanPersediaanBB, "Persediaan Bahan Baku",
                     AddressOf ReloadData, AddressOf SaveMaterial, AddressOf DeleteMaterial)
            BindCrud(dgvPengadaanBB, New Control() {txtPengadaanNo, dtpPengadaanTanggal, txtPengadaanNama, txtPengadaanJumlah, txtPengadaanStatus, txtPengadaanHarga},
                     btnTambahPengadaanBB, btnUbahPengadaanBB, btnHapusPengadaanBB, btnBersihkanPengadaanBB, "Pengadaan Bahan Baku",
                     AddressOf ReloadData, AddressOf SavePurchase, Sub(code) DeleteRecord(Purchases, "Kode_Pengadaan", code), AddressOf PreviewPurchase)
            BindSearch(dgvCekPenggunaanBB, txtCariCekPenggunaanBB)
            BindSearch(dgvCekPenjualan, txtCariCekPenjualan)
            AddHandler dgvHitungEOQ.CurrentCellChanged, Sub(sender, e) SelectEoqInputs()
            AddHandler dgvHitungROP.CurrentCellChanged, Sub(sender, e) SelectRopInputs()
            For Each input In {txtEOQD, txtEOQS, txtEOQH}
                AddHandler input.TextChanged, Sub(sender, e) UpdateEoq()
            Next
            For Each input In {txtROPAvg, txtROPMax, txtROPLTAvg, txtROPLTMax}
                AddHandler input.TextChanged, Sub(sender, e) UpdateRop()
            Next
            AddHandler btnHitungEOQ.Click, Sub(sender, e) SaveEoq()
            AddHandler btnResetEOQ.Click, Sub(sender, e) ResetEOQ()
            AddHandler btnHitungROP.Click, Sub(sender, e) SaveRop()
            AddHandler btnResetROP.Click, Sub(sender, e) ResetROP()
        End Sub

        Private Sub ReloadData()
            materialCatalog = ReadRows("SELECT Kode_Bahan_Baku, Harga_Acuan FROM Data_Bahan_Baku")
            materialCatalog.PrimaryKey = {materialCatalog.Columns("Kode_Bahan_Baku")}
            Dim codes As New AutoCompleteStringCollection()
            For Each material As DataRow In materialCatalog.Rows
                codes.Add(CStr(material("Kode_Bahan_Baku")))
            Next
            txtPengadaanNama.AutoCompleteCustomSource = codes
            txtPengadaanNama.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPengadaanNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            LoadGrid(dgvPersediaanBB, SelectMaterials)
            LoadGrid(dgvPengadaanBB, SelectPurchases)
            LoadGrid(dgvCekPenggunaanBB, SelectWarehouseUsage)
            LoadGrid(dgvCekPenjualan, SelectSalesSummary)
            LoadGrid(dgvHitungEOQ, SelectEoq, keyColumn:=5)
            LoadGrid(dgvHitungROP, SelectRop, keyColumn:=7)
        End Sub

        Private Sub SaveMaterial(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "BB")
            Dim name = RequireText(fields(1), "nama bahan baku")
            Dim quantity = RequireAmount(fields(2), "stok", True)
            Dim unit = RequireText(fields(3), "satuan")
            Dim minimum = RequireAmount(fields(4), "stok minimum", True)
            Dim category = RequireText(fields(5), "jenis bahan")
            Dim referencePrice = RequireAmount(fields(6), "harga acuan", True)
            Dim updatedOn = DateText(DateTime.Today)
            Using connection = GetConnection()
                Using transaction = connection.BeginTransaction()
                    SaveRecord(Materials, "Kode_Bahan_Baku", previousCode, code,
                               {"Nama_Bahan_Baku", "Satuan", "Stok_Minimum", "Jenis_Bahan_Baku", "Harga_Acuan"},
                               {name, unit, minimum, category, referencePrice}, transaction)
                    Dim changed = ExecuteInTransaction(transaction,
                        "UPDATE Data_Persediaan SET Jumlah_Stok_Bahan_Baku = ?, Tanggal_Update_Stok = ? WHERE Kode_Bahan_Baku = ?",
                        quantity, DateTime.Today, code)
                    If changed = 0 Then
                        SaveRecord(Stock, "Kode_Persediaan", Nothing, "ST" & code.Substring(2),
                                   {"Kode_Bahan_Baku", "Jumlah_Stok_Bahan_Baku", "Tanggal_Update_Stok"},
                                   {code, quantity, DateTime.Today}, transaction)
                    End If
                    transaction.Commit()
                End Using
            End Using
        End Sub

        Private Sub DeleteMaterial(code As String)
            Using connection = GetConnection()
                Using transaction = connection.BeginTransaction()
                    ExecuteInTransaction(transaction, "DELETE FROM Data_Persediaan WHERE Kode_Bahan_Baku = ?", code)
                    If ExecuteInTransaction(transaction, "DELETE FROM Data_Bahan_Baku WHERE Kode_Bahan_Baku = ?", code) <> 1 Then
                        Throw New InvalidOperationException("Bahan baku sudah tidak tersedia.")
                    End If
                    transaction.Commit()
                End Using
            End Using
        End Sub

        Private Sub PreviewPurchase()
            Dim code = txtPengadaanNama.Text.Trim().ToUpperInvariant()
            Dim material As DataRow = If(materialCatalog Is Nothing, Nothing, materialCatalog.Rows.Find(code))
            Dim price As Decimal
            Dim row = dgvPengadaanBB.CurrentRow
            Dim savedPrice As String = ""
            If row IsNot Nothing AndAlso CStr(row.Tag) = txtPengadaanNo.Text.Trim().ToUpperInvariant() AndAlso
               String.Equals(Convert.ToString(row.Cells(2).Value), code, StringComparison.OrdinalIgnoreCase) Then
                savedPrice = Convert.ToString(row.Cells(5).Value)
            End If
            Dim hasPrice = TryReadAmount(savedPrice, price) OrElse
                (material IsNot Nothing AndAlso Not material.IsNull("Harga_Acuan") AndAlso TryReadAmount(Convert.ToString(material("Harga_Acuan"), CultureInfo.InvariantCulture), price))
            txtPengadaanHarga.Text = If(hasPrice, price.ToString("0.####", CultureInfo.InvariantCulture), "")
            Dim quantity As Decimal
            txtPengadaanTotal.Text = If(hasPrice AndAlso TryReadAmount(txtPengadaanJumlah.Text.Trim(), quantity) AndAlso quantity > 0D,
                                        PreviewTotal(quantity, price), "")
        End Sub

        Private Sub SavePurchase(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PB")
            Dim purchaseDate = RequireDate(fields(1))
            Dim materialCode = RequireCode(fields(2), "BB")
            Dim quantity = RequireAmount(fields(3), "jumlah pembelian")
            Dim requestedStatus = fields(4).Trim()

            If previousCode IsNot Nothing AndAlso code <> previousCode Then
                Throw New ArgumentException("Kode pengadaan tidak dapat diubah.")
            End If

            If previousCode IsNot Nothing AndAlso requestedStatus.Equals("Diterima", StringComparison.OrdinalIgnoreCase) Then
                ReceivePurchase(code)
                Return
            End If

            If requestedStatus <> "" AndAlso Not requestedStatus.Equals("Menunggu", StringComparison.OrdinalIgnoreCase) Then
                Throw New ArgumentException("Pengadaan baru harus berstatus Menunggu. Pengadaan hanya dapat diterima setelah disetujui Pemilik.")
            End If

            Dim material = ReadRows("SELECT Stok_Minimum, Harga_Acuan FROM Data_Bahan_Baku WHERE Kode_Bahan_Baku = ?", materialCode)
            If material.Rows.Count = 0 Then Throw New ArgumentException("Kode bahan baku belum terdaftar.")

            Dim price As Decimal
            Dim savedPrice = If(previousCode Is Nothing, Nothing,
                ReadRows("SELECT Harga_Satuan FROM Data_Pengadaan_Bahan_Baku WHERE Kode_Pengadaan = ? AND Kode_Bahan_Baku = ?", code, materialCode))
            Dim hasSavedPrice = savedPrice IsNot Nothing AndAlso savedPrice.Rows.Count > 0 AndAlso
                TryReadAmount(Convert.ToString(savedPrice.Rows(0)(0)), price)

            If Not hasSavedPrice Then
                If material.Rows(0).IsNull("Harga_Acuan") Then
                    Throw New ArgumentException("Harga acuan belum tersedia. Isi harga bahan di tab Persediaan.")
                End If
                price = CDec(material.Rows(0)("Harga_Acuan"))
            End If

            Dim subtotal = quantity * price
            Dim minimum = If(material.Rows(0).IsNull("Stok_Minimum"), 0D, Convert.ToDecimal(material.Rows(0)("Stok_Minimum")))

            If previousCode Is Nothing Then
                SaveRecord(Purchases, "Kode_Pengadaan", Nothing, code,
                           {"Tanggal_Pengadaan", "Kode_Bahan_Baku", "Jumlah_Pembelian", "Harga_Satuan", "Subtotal_Pembelian", "Status_Pengadaan", "No_ID", "Stok_Minimum"},
                           {purchaseDate, materialCode, quantity, price, subtotal, "Menunggu", activeAccountId, minimum})
                Return
            End If

            Dim changed = ExecuteChange(
                "UPDATE Data_Pengadaan_Bahan_Baku SET Tanggal_Pengadaan = ?, Kode_Bahan_Baku = ?, Jumlah_Pembelian = ?, Harga_Satuan = ?, Subtotal_Pembelian = ?, Stok_Minimum = ? WHERE Kode_Pengadaan = ? AND Status_Pengadaan = ?",
                purchaseDate, materialCode, quantity, price, subtotal, minimum, code, "Menunggu")

            If changed <> 1 Then
                Throw New ArgumentException("Rincian hanya dapat diubah saat status pengadaan Menunggu.")
            End If
        End Sub

        Private Sub ReceivePurchase(purchaseCode As String)
            Using connection = GetConnection()
                Using transaction = connection.BeginTransaction()
                    Dim purchase = ReadRowsInTransaction(
                        transaction,
                        "SELECT Kode_Bahan_Baku, Jumlah_Pembelian FROM Data_Pengadaan_Bahan_Baku WHERE Kode_Pengadaan = ? AND Status_Pengadaan = ?",
                        purchaseCode, "Disetujui")

                    If purchase.Rows.Count <> 1 Then
                        Throw New InvalidOperationException("Pengadaan harus berstatus Disetujui sebelum diterima.")
                    End If

                    Dim materialCode = Convert.ToString(purchase.Rows(0)("Kode_Bahan_Baku"))
                    Dim quantity = Convert.ToDecimal(purchase.Rows(0)("Jumlah_Pembelian"))
                    Dim stock = ReadRowsInTransaction(
                        transaction,
                        "SELECT Jumlah_Stok_Bahan_Baku FROM Data_Persediaan WHERE Kode_Bahan_Baku = ?",
                        materialCode)

                    If stock.Rows.Count <> 1 Then
                        Throw New InvalidOperationException("Data persediaan untuk bahan " & materialCode & " belum tersedia.")
                    End If

                    Dim changed = ExecuteInTransaction(
                        transaction,
                        "UPDATE Data_Pengadaan_Bahan_Baku SET Status_Pengadaan = ? WHERE Kode_Pengadaan = ? AND Status_Pengadaan = ?",
                        "Diterima", purchaseCode, "Disetujui")

                    If changed <> 1 Then
                        Throw New InvalidOperationException("Status pengadaan berubah. Muat ulang data terlebih dahulu.")
                    End If

                    changed = ExecuteInTransaction(
                        transaction,
                        "UPDATE Data_Persediaan SET Jumlah_Stok_Bahan_Baku = Jumlah_Stok_Bahan_Baku + ?, Tanggal_Update_Stok = ? WHERE Kode_Bahan_Baku = ?",
                        quantity, DateTime.Today, materialCode)

                    If changed <> 1 Then
                        Throw New InvalidOperationException("Stok bahan baku gagal diperbarui.")
                    End If

                    transaction.Commit()
                End Using
            End Using
        End Sub

        Private Sub SelectEoqInputs()
            Dim row = dgvHitungEOQ.CurrentRow
            If row Is Nothing Then Return
            txtEOQNama.Text = Convert.ToString(row.Cells(0).Value)
            txtEOQD.Text = Convert.ToString(row.Cells(1).Value)
            txtEOQS.Text = Convert.ToString(row.Cells(2).Value)
            txtEOQH.Text = Convert.ToString(row.Cells(3).Value)
            UpdateEoq()
        End Sub

        Private Sub SelectRopInputs()
            Dim row = dgvHitungROP.CurrentRow
            If row Is Nothing Then Return
            Dim safety As Double
            storedSafetyStock = Nothing
            If ReadNumber(Convert.ToString(row.Cells(5).Value), safety) Then storedSafetyStock = safety
            storedDemand = Convert.ToString(row.Cells(1).Value)
            storedLeadTime = Convert.ToString(row.Cells(3).Value)
            txtROPAvg.Text = storedDemand
            txtROPMax.Text = Convert.ToString(row.Cells(2).Value)
            txtROPLTAvg.Text = storedLeadTime
            txtROPLTMax.Text = Convert.ToString(row.Cells(4).Value)
            UpdateRop()
        End Sub

        Private Sub UpdateEoq()
            Dim demand, orderCost, holdingCost As Double
            If ReadNumber(txtEOQD.Text, demand) AndAlso demand > 0 AndAlso
               ReadNumber(txtEOQS.Text, orderCost) AndAlso orderCost > 0 AndAlso
               ReadNumber(txtEOQH.Text, holdingCost) AndAlso holdingCost > 0 Then
                Dim result = Math.Sqrt(2 * demand * orderCost / holdingCost)
                txthasileoq.Text = FormatCalculation(result)
            Else
                txthasileoq.Clear()
            End If
        End Sub

        Private Sub UpdateRop()
            txtsafetystock.Clear()
            txtreoderpoint.Clear()

            Dim averageUse, maximumUse, averageLead, maximumLead, safety As Double

            If Not ReadNumber(txtROPAvg.Text, averageUse) OrElse averageUse <= 0 OrElse
               Not ReadNumber(txtROPLTAvg.Text, averageLead) OrElse averageLead <= 0 Then Return

            Dim hasMaximumUse = txtROPMax.TextLength > 0
            Dim hasMaximumLead = txtROPLTMax.TextLength > 0

            If hasMaximumUse <> hasMaximumLead Then Return

            If hasMaximumUse Then
                If Not ReadNumber(txtROPMax.Text, maximumUse) OrElse
                   Not ReadNumber(txtROPLTMax.Text, maximumLead) OrElse
                   maximumUse < averageUse OrElse maximumLead < averageLead Then Return

                safety = Math.Max(0, maximumUse * maximumLead - averageUse * averageLead)
            ElseIf storedSafetyStock.HasValue AndAlso
                   txtROPAvg.Text = storedDemand AndAlso txtROPLTAvg.Text = storedLeadTime Then
                safety = storedSafetyStock.Value
            Else
                Return
            End If

            txtsafetystock.Text = FormatCalculation(safety)
            txtreoderpoint.Text = FormatCalculation(averageUse * averageLead + safety)
        End Sub

        Private Sub SaveEoq()
            Dim row = ActualSelection(dgvHitungEOQ)

            If row Is Nothing OrElse txthasileoq.TextLength = 0 Then
                MessageBox.Show("Pilih bahan baku dan pastikan kebutuhan, biaya pesan, serta biaya simpan tersedia.", "EOQ")
                Return
            End If

            SaveCalculation("EOQ", Function() ExecuteChange(
                "UPDATE Data_Persediaan SET Permintaan_Tahunan = ?, Biaya_Pemesanan = ?, Biaya_Penyimpanan = ?, Nilai_EOQ = ? WHERE Kode_Bahan_Baku = ?",
                RequireAmount(txtEOQD.Text, "kebutuhan tahunan"),
                RequireAmount(txtEOQS.Text, "biaya pesan"),
                RequireAmount(txtEOQH.Text, "biaya simpan"),
                Decimal.Parse(txthasileoq.Text, CultureInfo.InvariantCulture),
                CStr(row.Tag)))
        End Sub

        Private Sub SaveRop()
            Dim row = ActualSelection(dgvHitungROP)

            If row Is Nothing OrElse txtreoderpoint.TextLength = 0 Then
                MessageBox.Show("Pilih bahan baku dan pastikan data pemakaian, lead time, serta safety stock tersedia.", "ROP")
                Return
            End If

            SaveCalculation("ROP",
                Function()
                    Dim daily = RequireAmount(txtROPAvg.Text, "pemakaian rata-rata")
                    Dim lead = RequireAmount(txtROPLTAvg.Text, "lead time rata-rata")
                    Dim hasMaximumUse = txtROPMax.TextLength > 0
                    Dim hasMaximumLead = txtROPLTMax.TextLength > 0

                    If hasMaximumUse <> hasMaximumLead Then
                        Throw New ArgumentException("Isi pemakaian maksimum dan lead time maksimum secara bersamaan, atau kosongkan keduanya.")
                    End If

                    If hasMaximumUse Then
                        Dim maximumUse = RequireAmount(txtROPMax.Text, "pemakaian maksimum")
                        Dim maximumLead = RequireAmount(txtROPLTMax.Text, "lead time maksimum")

                        If maximumUse < daily OrElse maximumLead < lead Then
                            Throw New ArgumentException("Nilai maksimum tidak boleh lebih kecil dari nilai rata-rata.")
                        End If

                        Return ExecuteChange(
                            "UPDATE Data_Persediaan SET Permintaan_Harian = ?, Lead_Time = ?, Safety_Stock = ?, Nilai_ROP = ?, Permintaan_Harian_Maksimum = ?, Lead_Time_Maksimum = ? WHERE Kode_Bahan_Baku = ?",
                            daily, lead, Decimal.Parse(txtsafetystock.Text, CultureInfo.InvariantCulture),
                            Decimal.Parse(txtreoderpoint.Text, CultureInfo.InvariantCulture),
                            maximumUse, maximumLead, CStr(row.Tag))
                    End If

                    If Not storedSafetyStock.HasValue OrElse
                       txtROPAvg.Text <> storedDemand OrElse txtROPLTAvg.Text <> storedLeadTime Then
                        Throw New ArgumentException("Untuk menghitung tanpa nilai maksimum, gunakan rata-rata yang sama dengan data tersimpan atau isi kedua nilai maksimum.")
                    End If

                    Return ExecuteChange(
                        "UPDATE Data_Persediaan SET Permintaan_Harian = ?, Lead_Time = ?, Safety_Stock = ?, Nilai_ROP = ?, Permintaan_Harian_Maksimum = NULL, Lead_Time_Maksimum = NULL WHERE Kode_Bahan_Baku = ?",
                        daily, lead, Decimal.Parse(txtsafetystock.Text, CultureInfo.InvariantCulture),
                        Decimal.Parse(txtreoderpoint.Text, CultureInfo.InvariantCulture), CStr(row.Tag))
                End Function)
        End Sub

        Private Sub SaveCalculation(title As String, save As Func(Of Integer))
            Try
                If save() <> 1 Then Throw New InvalidOperationException("Data persediaan bahan baku yang dipilih sudah tidak tersedia.")
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan perhitungan. " & ex.Message, title)
                Return
            End Try
            RefreshAfterWrite(AddressOf ReloadData)
        End Sub

        Private Sub ResetEOQ()
            dgvHitungEOQ.CurrentCell = Nothing
            dgvHitungEOQ.ClearSelection()
            ClearInputs({txtEOQNama, txtEOQD, txtEOQS, txtEOQH, txthasileoq})
        End Sub

        Private Sub ResetROP()
            dgvHitungROP.CurrentCell = Nothing
            dgvHitungROP.ClearSelection()
            storedSafetyStock = Nothing
            ClearInputs({txtROPAvg, txtROPMax, txtROPLTAvg, txtROPLTMax, txtsafetystock, txtreoderpoint})
        End Sub

        Private Function ReadNumber(value As String, ByRef result As Double) As Boolean
            Dim parsed As Decimal
            If Not TryReadAmount(value.Trim(), parsed) Then Return False
            result = CDbl(parsed)
            Return True
        End Function

        Private Function FormatCalculation(value As Double) As String
            If Double.IsInfinity(value) OrElse Double.IsNaN(value) Then Return ""
            Return value.ToString("0.##", CultureInfo.InvariantCulture)
        End Function
    End Class
End Namespace
