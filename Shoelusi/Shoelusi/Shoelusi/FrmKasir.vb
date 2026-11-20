Imports System
Imports System.Data
Imports System.Globalization
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class FrmKasir
        Private activeAccountId As String
        Private orderCatalog As DataTable
        Private Const OrderRates As String =
            "SELECT o.Kode_Pesanan, l.Harga_Layanan FROM Data_Pemesanan AS o INNER JOIN Data_Layanan AS l ON o.Kode_Layanan = l.Kode_Layanan"

        Public Sub New()
            InitializeComponent()
            dgvPesanan.Columns.Add("NamaLayanan", "Nama Layanan")
            dgvPenjualan.Columns.Add("JumlahSepatu", "Jumlah Sepatu")
            dgvPenjualan.Columns.Add("TarifLayanan", "Tarif per Pasang (Rp)")
            For Each input In {txtPenjualanKode, txtPenjualanPesanan, txtPenjualanJumlah}
                AddHandler input.TextChanged, Sub(sender, e) PreviewSale()
            Next
            BindPageActions()
            BindSearch(dgvPenjualan)
            BindSearch(dgvPesanan)
            AddHandler btnLogout.Click, Sub(sender, e) Close()
            AddHandler Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub

        Private Sub BindPageActions()
            BindCrud(dgvPenjualan, New Control() {txtPenjualanKode, txtPenjualanPesanan, dtpPenjualanTanggal, txtPenjualanTotal, txtPenjualanMetode, txtPenjualanJumlah},
                     btnTambahPenjualan, btnUbahPenjualan, btnHapusPenjualan, btnBersihkanPenjualan, "Penjualan",
                     AddressOf ReloadData, AddressOf SaveSale, Sub(code) DeleteRecord(Sales, "Kode_Penjualan", code), AddressOf PreviewSale)
            BindCrud(dgvPesanan, New Control() {txtPesananNo, txtPesananPelanggan, txtPesananLayanan, dtpPesananTanggal, txtPesananStatus},
                     btnTambahPesanan, btnUbahPesanan, btnHapusPesanan, btnBersihkanPesanan, "Pesanan",
                     AddressOf ReloadData, AddressOf SaveOrder, Sub(code) DeleteRecord(Orders, "Kode_Pesanan", code))
            BindSearch(dgvCekLayanan, txtCariCekLayanan)
            BindSearch(dgvCekPengerjaan, txtCariCekPengerjaan)
        End Sub

        Private Sub ReloadData()
            orderCatalog = ReadRows(OrderRates)
            orderCatalog.PrimaryKey = {orderCatalog.Columns("Kode_Pesanan")}
            Dim codes As New AutoCompleteStringCollection()
            For Each order As DataRow In orderCatalog.Rows
                codes.Add(CStr(order("Kode_Pesanan")))
            Next
            txtPenjualanPesanan.AutoCompleteCustomSource = codes
            txtPenjualanPesanan.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPenjualanPesanan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            LoadGrid(dgvPenjualan, SelectSales)
            LoadGrid(dgvPesanan, SelectOrders)
            LoadGrid(dgvCekLayanan, SelectServices)
            LoadGrid(dgvCekPengerjaan, SelectJobSummary)
        End Sub

        Private Sub PreviewSale()
            Dim orderCode = txtPenjualanPesanan.Text.Trim().ToUpperInvariant()
            Dim item = If(orderCatalog Is Nothing, Nothing, orderCatalog.Rows.Find(orderCode))
            Dim row = dgvPenjualan.CurrentRow
            Dim price As Decimal
            Dim hasPrice = row IsNot Nothing AndAlso CStr(row.Tag) = txtPenjualanKode.Text.Trim().ToUpperInvariant() AndAlso
                String.Equals(Convert.ToString(row.Cells(1).Value), orderCode, StringComparison.OrdinalIgnoreCase) AndAlso
                TryReadAmount(Convert.ToString(row.Cells(6).Value), price)
            If Not hasPrice AndAlso item IsNot Nothing AndAlso Not item.IsNull("Harga_Layanan") Then
                price = CDec(item("Harga_Layanan"))
                hasPrice = True
            End If
            Dim quantity As Integer
            Dim valid = Integer.TryParse(txtPenjualanJumlah.Text.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, quantity) AndAlso quantity > 0
            txtPenjualanTotal.Text = If(hasPrice AndAlso valid, PreviewTotal(quantity, price), "")
        End Sub

        Private Sub SaveSale(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PJ")
            Dim orderCode = RequireCode(fields(1), "PM")
            Dim pickup = DateText(RequireDate(fields(2)))
            Dim paymentStatus = RequireText(fields(4), "status pembayaran")
            Dim quantity As Integer
            If Not Integer.TryParse(fields(5), NumberStyles.None, CultureInfo.InvariantCulture, quantity) OrElse quantity < 1 Then
                Throw New ArgumentException("Isi jumlah sepatu dengan bilangan bulat positif.")
            End If
            Dim rate As Decimal
            Dim snapshot = If(previousCode Is Nothing, Nothing, ReadRows(
                "SELECT Harga_Layanan_Transaksi FROM Data_Penjualan WHERE Kode_Penjualan = ? AND Kode_Pemesanan = ?", code, orderCode))
            If snapshot IsNot Nothing AndAlso snapshot.Rows.Count > 0 AndAlso Not snapshot.Rows(0).IsNull(0) Then
                rate = CDec(snapshot.Rows(0)(0))
            Else
                Dim order = ReadRows(OrderRates & " WHERE o.Kode_Pesanan = ?", orderCode)
                If order.Rows.Count = 0 OrElse order.Rows(0).IsNull("Harga_Layanan") Then
                    Throw New ArgumentException("Pesanan atau tarif layanan belum tersedia.")
                End If
                rate = CDec(order.Rows(0)("Harga_Layanan"))
            End If
            Dim total = DecimalText(rate * quantity)
            Dim columns As String() = {"Kode_Pemesanan", "Tanggal_Pengambilan", "Total_Biaya", "Status_Pembayaran", "Jumlah_Sepatu", "Harga_Layanan_Transaksi"}
            Dim values As Object() = {orderCode, pickup, total, paymentStatus, quantity.ToString(CultureInfo.InvariantCulture), rate}
            If previousCode Is Nothing Then
                Array.Resize(columns, columns.Length + 1)
                Array.Resize(values, values.Length + 1)
                columns(columns.Length - 1) = "No_ID"
                values(values.Length - 1) = activeAccountId
            End If
            SaveRecord(Sales, "Kode_Penjualan", previousCode, code, columns, values)
        End Sub

        Private Sub SaveOrder(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "PM")
            Dim customer = RequireText(fields(1), "nama pelanggan")
            Dim serviceCode = RequireCode(fields(2), "LY")
            Dim orderDate = RequireDate(fields(3))
            Dim status = RequireText(fields(4), "status pesanan")
            Dim service = ReadRows("SELECT Estimasi_Pengerjaan FROM Data_Layanan WHERE Kode_Layanan = ?", serviceCode)
            If service.Rows.Count = 0 Then Throw New ArgumentException("Kode layanan belum terdaftar.")
            If previousCode Is Nothing Then
                SaveRecord(Orders, "Kode_Pesanan", Nothing, code,
                           {"Nama_Konsumen", "Kode_Layanan", "Tanggal_Pemesanan", "Status_Pesanan", "Estimasi_Pengerjaan", "No_ID"},
                           {customer, serviceCode, orderDate, status, Convert.ToString(service.Rows(0)(0)), activeAccountId})
            Else
                SaveRecord(Orders, "Kode_Pesanan", previousCode, code,
                           {"Nama_Konsumen", "Kode_Layanan", "Tanggal_Pemesanan", "Status_Pesanan"},
                           {customer, serviceCode, orderDate, status})
            End If
        End Sub
    End Class
End Namespace
