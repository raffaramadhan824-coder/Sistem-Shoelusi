Imports System
Imports System.Globalization
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class FrmTeknisi
        Private activeAccountId As String

        Public Sub New()
            InitializeComponent()
            dgvPenggunaanBB.Columns.Add("KodePenggunaan", "Kode Penggunaan")
            txtPenggunaanNama.ReadOnly = True
            txtPenggunaanSatuan.ReadOnly = True
            BindPageActions()
            BindSearch(dgvPengerjaan)
            BindSearch(dgvPenggunaanBB)
            AddHandler btnLogout.Click, Sub(sender, e) Close()
            AddHandler Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub

        Private Sub BindPageActions()
            BindSearch(dgvCekPesanan, txtCariCekPesanan)
            BindCrud(dgvPengerjaan, New Control() {txtPengerjaanNo, txtPengerjaanPesanan, dtpPengerjaanMulai, dtpPengerjaanSelesai, txtPengerjaanStatus},
                     btnTambahPengerjaan, btnUbahPengerjaan, btnHapusPengerjaan, btnBersihkanPengerjaan, "Pengerjaan",
                     AddressOf ReloadData, AddressOf SaveJob, Sub(code) DeleteRecord(Jobs, "Kode_Pengerjaan", code))
            BindCrud(dgvPenggunaanBB, New Control() {dtpPenggunaanTanggal, txtPenggunaanPengerjaan, txtPenggunaanKode, txtPenggunaanNama, txtPenggunaanJumlah, txtPenggunaanSatuan},
                     btnTambahPenggunaanBB, btnUbahPenggunaanBB, btnHapusPenggunaanBB, btnBersihkanPenggunaanBB, "Penggunaan Bahan Baku",
                     AddressOf ReloadData, AddressOf SaveUsage, AddressOf DeleteUsage)
            AddHandler btnLaporkanBB.Click, AddressOf ReportUsage
        End Sub

        Private Sub ReloadData()
            LoadGrid(dgvCekPesanan, SelectOrderSummary)
            LoadGrid(dgvPengerjaan, SelectJobs)
            LoadGrid(dgvPenggunaanBB, SelectUsage, keyColumn:=7)
        End Sub

        Private Sub SaveJob(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PG")
            Dim orderCode = RequireCode(fields(1), "PM")
            Dim started = RequireDate(fields(2))
            Dim finished As Object = DBNull.Value
            If fields(3) <> "" Then
                Dim endDate = RequireDate(fields(3))
                If endDate < started Then Throw New ArgumentException("Tanggal selesai harus sama dengan atau setelah tanggal mulai.")
                finished = endDate
            End If
            Dim status = RequireText(fields(4), "status pengerjaan")
            If previousCode Is Nothing Then
                SaveRecord(Jobs, "Kode_Pengerjaan", Nothing, code,
                           {"Kode_Pesanan", "Tanggal_Mulai", "Tanggal_Selesai", "Status_Pengerjaan", "No_ID"},
                           {orderCode, started, finished, status, activeAccountId})
            Else
                SaveRecord(Jobs, "Kode_Pengerjaan", previousCode, code,
                           {"Kode_Pesanan", "Tanggal_Mulai", "Tanggal_Selesai", "Status_Pengerjaan"},
                           {orderCode, started, finished, status})
            End If
        End Sub

        Private Sub SaveUsage(previousCode As String, fields As String())
            Dim usageDate = RequireDate(fields(0))
            Dim jobCode = RequireCode(fields(1), "PG")
            Dim materialCode = RequireCode(fields(2), "BB")
            Dim quantity = RequireAmount(fields(4), "jumlah pemakaian")
            Dim previousMaterial As String = Nothing
            Dim previousQuantity As Decimal = 0D
            Dim previousJob As String = Nothing

            Using connection = GetConnection()
                Using transaction = connection.BeginTransaction()
                    If previousCode IsNot Nothing Then
                        Dim previous = ReadRowsInTransaction(
                            transaction,
                            "SELECT Kode_Bahan_Baku, Jumlah_Penggunaan, Kode_Pengerjaan FROM Data_Penggunaan_Bahan_Baku WHERE Kode_Penggunaan = ?",
                            previousCode)

                        If previous.Rows.Count <> 1 Then
                            Throw New InvalidOperationException("Data pemakaian sudah tidak tersedia.")
                        End If

                        previousMaterial = Convert.ToString(previous.Rows(0)("Kode_Bahan_Baku"))
                        previousQuantity = Convert.ToDecimal(previous.Rows(0)("Jumlah_Penggunaan"))
                        previousJob = Convert.ToString(previous.Rows(0)("Kode_Pengerjaan"))
                    End If

                    Dim newMaterialStock = ReadRowsInTransaction(
                        transaction,
                        "SELECT Jumlah_Stok_Bahan_Baku FROM Data_Persediaan WHERE Kode_Bahan_Baku = ?",
                        materialCode)

                    If newMaterialStock.Rows.Count <> 1 Then
                        Throw New ArgumentException("Data persediaan untuk bahan " & materialCode & " belum tersedia.")
                    End If

                    Dim currentNewStock = Convert.ToDecimal(newMaterialStock.Rows(0)(0))
                    Dim resultingNewStock As Decimal

                    If previousCode IsNot Nothing AndAlso
                       String.Equals(previousMaterial, materialCode, StringComparison.OrdinalIgnoreCase) Then
                        resultingNewStock = currentNewStock + previousQuantity - quantity
                    Else
                        resultingNewStock = currentNewStock - quantity
                    End If

                    If resultingNewStock < 0D Then
                        Throw New ArgumentException("Stok bahan " & materialCode & " tidak mencukupi. Stok tersedia: " &
                                                    currentNewStock.ToString(CultureInfo.InvariantCulture))
                    End If

                    If previousCode IsNot Nothing AndAlso
                       Not String.Equals(previousMaterial, materialCode, StringComparison.OrdinalIgnoreCase) Then
                        Dim oldMaterialStock = ReadRowsInTransaction(
                            transaction,
                            "SELECT Jumlah_Stok_Bahan_Baku FROM Data_Persediaan WHERE Kode_Bahan_Baku = ?",
                            previousMaterial)

                        If oldMaterialStock.Rows.Count <> 1 Then
                            Throw New InvalidOperationException("Data persediaan bahan lama tidak ditemukan.")
                        End If

                        Dim returnedStock = Convert.ToDecimal(oldMaterialStock.Rows(0)(0)) + previousQuantity
                        If ExecuteInTransaction(
                            transaction,
                            "UPDATE Data_Persediaan SET Jumlah_Stok_Bahan_Baku = ?, Tanggal_Update_Stok = ? WHERE Kode_Bahan_Baku = ?",
                            returnedStock, DateTime.Today, previousMaterial) <> 1 Then
                            Throw New InvalidOperationException("Stok bahan sebelumnya gagal dikembalikan.")
                        End If
                    End If

                    Dim changed As Integer

                    If previousCode Is Nothing Then
                        Dim usageCode = "PU" & Guid.NewGuid().ToString("N").Substring(0, 12).ToUpperInvariant()
                        SaveRecord(MaterialUse, "Kode_Penggunaan", Nothing, usageCode,
                                   {"Tanggal_Penggunaan", "Kode_Pengerjaan", "Kode_Bahan_Baku", "Jumlah_Penggunaan", "No_ID", "Kondisi_Bahan_Baku"},
                                   {usageDate, jobCode, materialCode, quantity, activeAccountId, "Normal"}, transaction)
                    Else
                        Dim resetSale = If(String.Equals(previousJob, jobCode, StringComparison.OrdinalIgnoreCase),
                                           "", ", Kode_Penjualan = NULL")
                        changed = ExecuteInTransaction(
                            transaction,
                            "UPDATE Data_Penggunaan_Bahan_Baku SET Tanggal_Penggunaan = ?, Kode_Pengerjaan = ?, Kode_Bahan_Baku = ?, Jumlah_Penggunaan = ?" &
                            resetSale & " WHERE Kode_Penggunaan = ?",
                            usageDate, jobCode, materialCode, quantity, previousCode)

                        If changed <> 1 Then
                            Throw New InvalidOperationException("Data pemakaian gagal diperbarui.")
                        End If
                    End If

                    If ExecuteInTransaction(
                        transaction,
                        "UPDATE Data_Persediaan SET Jumlah_Stok_Bahan_Baku = ?, Tanggal_Update_Stok = ? WHERE Kode_Bahan_Baku = ?",
                        resultingNewStock, DateTime.Today, materialCode) <> 1 Then
                        Throw New InvalidOperationException("Stok bahan baku gagal diperbarui.")
                    End If

                    transaction.Commit()
                End Using
            End Using
        End Sub

        Private Sub DeleteUsage(code As String)
            Using connection = GetConnection()
                Using transaction = connection.BeginTransaction()
                    Dim usage = ReadRowsInTransaction(
                        transaction,
                        "SELECT Kode_Bahan_Baku, Jumlah_Penggunaan FROM Data_Penggunaan_Bahan_Baku WHERE Kode_Penggunaan = ?",
                        code)

                    If usage.Rows.Count <> 1 Then
                        Throw New InvalidOperationException("Data pemakaian sudah tidak tersedia.")
                    End If

                    Dim materialCode = Convert.ToString(usage.Rows(0)("Kode_Bahan_Baku"))
                    Dim quantity = Convert.ToDecimal(usage.Rows(0)("Jumlah_Penggunaan"))
                    Dim changed = ExecuteInTransaction(
                        transaction,
                        "UPDATE Data_Persediaan SET Jumlah_Stok_Bahan_Baku = Jumlah_Stok_Bahan_Baku + ?, Tanggal_Update_Stok = ? WHERE Kode_Bahan_Baku = ?",
                        quantity, DateTime.Today, materialCode)

                    If changed <> 1 Then
                        Throw New InvalidOperationException("Stok bahan baku tidak dapat dikembalikan.")
                    End If

                    changed = ExecuteInTransaction(
                        transaction,
                        "DELETE FROM Data_Penggunaan_Bahan_Baku WHERE Kode_Penggunaan = ?",
                        code)

                    If changed <> 1 Then
                        Throw New InvalidOperationException("Data pemakaian gagal dihapus.")
                    End If

                    transaction.Commit()
                End Using
            End Using
        End Sub

        Private Sub ReportUsage(sender As Object, e As EventArgs)
            Dim row = ActualSelection(dgvPenggunaanBB)
            If row Is Nothing OrElse cmbKondisiBB.SelectedIndex < 0 Then
                MessageBox.Show("Pilih baris penggunaan dan kondisi bahan baku.", "Laporan Bahan Baku")
                Return
            End If
            Try
                If ExecuteChange("UPDATE Data_Penggunaan_Bahan_Baku SET Kondisi_Bahan_Baku = ? WHERE Kode_Penggunaan = ?",
                                 cmbKondisiBB.Text, CStr(row.Tag)) <> 1 Then
                    Throw New InvalidOperationException("Data pemakaian sudah tidak tersedia.")
                End If
                ReloadData()
            Catch ex As Exception
                MessageBox.Show("Gagal mencatat laporan. " & ex.Message, "Laporan Bahan Baku")
            End Try
        End Sub
    End Class
End Namespace
