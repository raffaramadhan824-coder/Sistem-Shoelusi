Imports System
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
                     AddressOf ReloadData, AddressOf SaveUsage, Sub(code) DeleteRecord(MaterialUse, "Kode_Penggunaan", code))
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
            Dim usageDate = DateText(RequireDate(fields(0)))
            Dim jobCode = RequireCode(fields(1), "PG")
            Dim materialCode = RequireCode(fields(2), "BB")
            Dim quantity = DecimalText(RequireAmount(fields(4), "jumlah pemakaian"))
            If previousCode Is Nothing Then
                Dim code = "PU" & Guid.NewGuid().ToString("N").Substring(0, 12).ToUpperInvariant()
                SaveRecord(MaterialUse, "Kode_Penggunaan", Nothing, code,
                           {"Tanggal_Penggunaan", "Kode_Pengerjaan", "Kode_Bahan_Baku", "Jumlah_Penggunaan", "No_ID", "Kondisi_Bahan_Baku"},
                           {usageDate, jobCode, materialCode, quantity, activeAccountId, "Normal"})
            Else
                Dim previous = ReadRows("SELECT Kode_Pengerjaan FROM Data_Penggunaan_Bahan_Baku WHERE Kode_Penggunaan = ?", previousCode)
                If previous.Rows.Count = 0 Then Throw New InvalidOperationException("Data pemakaian sudah tidak tersedia.")
                Dim resetSale = If(String.Equals(Convert.ToString(previous.Rows(0)(0)), jobCode, StringComparison.OrdinalIgnoreCase),
                                   "", ", Kode_Penjualan = NULL")
                Dim changed = ExecuteChange("UPDATE Data_Penggunaan_Bahan_Baku SET Tanggal_Penggunaan = ?, " &
                                            "Kode_Pengerjaan = ?, Kode_Bahan_Baku = ?, Jumlah_Penggunaan = ?" & resetSale & " WHERE Kode_Penggunaan = ?",
                                            usageDate, jobCode, materialCode, quantity, previousCode)
                If changed <> 1 Then Throw New InvalidOperationException("Data pemakaian sudah tidak tersedia.")
            End If
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
