Imports System
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class FrmPemilik
        Private activeAccountId As String

        Public Sub New()
            InitializeComponent()
            BindPageActions()
            BindSearch(dgvAkun)
            BindSearch(dgvPersetujuanBB)
            BindSearch(dgvDataLayanan)
            AddHandler btnLogout.Click, AddressOf LogoutClick
            AddHandler Me.Load, Sub(sender, e) ReloadData()
        End Sub

        Public Sub New(noId As String)
            Me.New()
            activeAccountId = noId
        End Sub
        
        Private Sub LogoutClick(sender As Object, e As EventArgs)
            Me.Close()
        End Sub

        Private Sub BindPageActions()
            dgvAkunCol5.Visible = False
            txtAkunStatus.UseSystemPasswordChar = True
            AddHandler btnTambahAkun.Click, Sub(sender, e) SaveAccount(True)
            AddHandler btnUbahAkun.Click, Sub(sender, e) SaveAccount(False)
            AddHandler btnHapusAkun.Click, AddressOf DeleteAccount
            AddHandler btnBersihkanAkun.Click, Sub(sender, e) ClearAccountInputs()
            AddHandler dgvAkun.CurrentCellChanged, Sub(sender, e) ShowSelectedAccount()
            AddHandler btnSetujuiPersetujuanBB.Click, Sub(sender, e) SetStatusPengadaan("Disetujui")
            AddHandler btnTolakPersetujuanBB.Click, Sub(sender, e) SetStatusPengadaan("Ditolak")
            BindCrud(dgvDataLayanan, New Control() {txtLayananKode, txtLayananNama, txtLayananDeskripsi, txtLayananHarga, txtLayananEstimasi},
                     btnTambahDataLayanan, btnUbahDataLayanan, btnHapusDataLayanan, btnBersihkanDataLayanan, "Data Layanan",
                     AddressOf ReloadData, AddressOf SaveService, Sub(code) DeleteRecord(Services, "Kode_Layanan", code))
            ModuleUtama.BindSearch(Me.dgvCekPenjualan, Me.txtCariCekPenjualan)
        End Sub

        Private Sub ReloadData()
            LoadAccounts()
            LoadGrid(dgvPersetujuanBB, SelectApprovals)
            LoadGrid(dgvDataLayanan, SelectServices)
            LoadGrid(dgvCekPenjualan, SelectSalesSummary)
        End Sub

        Private Sub SaveService(previousCode As String, fields As String())
            Dim code = RequireCode(fields(0), "LY")
            Dim name = RequireText(fields(1), "nama layanan")
            Dim category = RequireText(fields(2), "jenis layanan")
            Dim price = RequireAmount(fields(3), "harga", True)
            Dim estimate = RequireText(fields(4), "estimasi pengerjaan")
            If previousCode Is Nothing Then
                SaveRecord(Services, "Kode_Layanan", Nothing, code,
                           {"Nama_Layanan", "Jenis_Layanan", "Harga_Layanan", "Estimasi_Pengerjaan", "No_ID"},
                           {name, category, price, estimate, activeAccountId})
            Else
                SaveRecord(Services, "Kode_Layanan", previousCode, code,
                           {"Nama_Layanan", "Jenis_Layanan", "Harga_Layanan", "Estimasi_Pengerjaan"},
                           {name, category, price, estimate})
            End If
        End Sub

        Private Sub LoadAccounts()
            ModuleUtama.LoadGrid(dgvAkun, "SELECT [No_ID], [Nama], [Divisi] FROM [Data Akun] ORDER BY [No_ID]")
            ClearAccountInputs()
        End Sub

        Private Sub ClearAccountInputs()
            dgvAkun.CurrentCell = Nothing
            dgvAkun.ClearSelection()
            ModuleUtama.ClearInputs(New TextBox() {txtAkunID, txtAkunNama, txtAkunRole, txtAkunStatus})
            txtAkunID.ReadOnly = False
        End Sub

        Private Sub ShowSelectedAccount()
            Dim row = dgvAkun.CurrentRow
            If row Is Nothing Then Return
            txtAkunID.Text = Convert.ToString(row.Cells(0).Value)
            txtAkunNama.Text = Convert.ToString(row.Cells(1).Value)
            txtAkunRole.Text = Convert.ToString(row.Cells(2).Value)
            txtAkunStatus.Clear()
            txtAkunID.ReadOnly = True
        End Sub

        Private Sub SaveAccount(adding As Boolean)
            Dim row = ActualSelection(dgvAkun)
            If Not adding AndAlso row Is Nothing Then
                MessageBox.Show("Pilih akun yang ingin diubah.", "Data Akun")
                Return
            End If

            Dim id = txtAkunID.Text.Trim()
            Dim name = txtAkunNama.Text.Trim()
            Dim division = ModuleUtama.AccountDivision(txtAkunRole.Text)
            If id = "" OrElse name = "" OrElse division = "" Then
                MessageBox.Show("Isi No ID, nama, dan salah satu divisi: Kasir, Teknisi, Staf Gudang, atau Pemilik.", "Data Akun")
                Return
            End If
            If String.Equals(id, activeAccountId, StringComparison.OrdinalIgnoreCase) AndAlso division <> "Pemilik" Then
                MessageBox.Show("Divisi akun yang sedang digunakan harus tetap Pemilik.", "Data Akun")
                Return
            End If
            Dim changePin As Boolean = adding OrElse txtAkunStatus.Text.Length > 0
            Dim pin As Integer
            If changePin AndAlso Not ModuleUtama.TryReadPin(txtAkunStatus.Text, pin) Then
                MessageBox.Show("Masukkan kata sandi berupa angka tanpa nol di depan, maksimal 2147483647.", "Data Akun")
                Return
            End If

            Try
                Dim changed As Integer
                If adding Then
                    id = RequireCode(id, "SL")
                    changed = ModuleUtama.ExecuteChange("INSERT INTO [Data Akun] ([No_ID], [Nama], [Divisi], [Kata Sandi]) VALUES (?, ?, ?, ?)", id, name, division, pin)
                ElseIf changePin Then
                    changed = ModuleUtama.ExecuteChange("UPDATE [Data Akun] SET [Nama] = ?, [Divisi] = ?, [Kata Sandi] = ? WHERE [No_ID] = ?", name, division, pin, id)
                Else
                    changed = ModuleUtama.ExecuteChange("UPDATE [Data Akun] SET [Nama] = ?, [Divisi] = ? WHERE [No_ID] = ?", name, division, id)
                End If
                If changed <> 1 Then Throw New InvalidOperationException("Akun yang dipilih sudah tidak tersedia.")
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan akun. " & ex.Message, "Data Akun")
                Return
            End Try
            RefreshAfterWrite(AddressOf LoadAccounts)
        End Sub

        Private Sub DeleteAccount(sender As Object, e As EventArgs)
            Dim row = ActualSelection(dgvAkun)
            If row Is Nothing Then Return
            Dim id = Convert.ToString(row.Cells(0).Value)
            If String.Equals(id, activeAccountId, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Akun yang sedang digunakan tidak bisa dihapus.", "Data Akun")
                Return
            End If
            If MessageBox.Show("Hapus akun " & id & "?", "Data Akun", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Try
                For Each table In {"Data_Layanan", "Data_Pemesanan", "Data_Penjualan", "Data_Penggunaan_Bahan_Baku", "Data_Pengadaan_Bahan_Baku", "Data_Pengerjaan"}
                    If CInt(ModuleUtama.ReadRows("SELECT COUNT(*) FROM [" & table & "] WHERE [No_ID] = ?", id).Rows(0)(0)) > 0 Then
                        MessageBox.Show("Akun ini masih terhubung dengan data di " & table & ".", "Data Akun")
                        Return
                    End If
                Next
                ModuleUtama.ExecuteChange("DELETE FROM [Data Akun] WHERE [No_ID] = ?", id)
                LoadAccounts()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus akun. " & ex.Message, "Data Akun")
            End Try
        End Sub

        Private Sub SetStatusPengadaan(status As String)
            Dim row = ActualSelection(dgvPersetujuanBB)
            If row Is Nothing Then Return
            Try
                Dim changed = ExecuteChange("UPDATE Data_Pengadaan_Bahan_Baku SET Status_Pengadaan = ? WHERE Kode_Pengadaan = ? AND Status_Pengadaan = ?",
                                            status, CStr(row.Tag), "Menunggu")
                If changed = 0 Then MessageBox.Show("Hanya pengadaan berstatus Menunggu yang bisa diputuskan.", "Persetujuan Pengadaan")
                LoadGrid(dgvPersetujuanBB, SelectApprovals)
            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui pengadaan. " & ex.Message, "Persetujuan Pengadaan")
            End Try
        End Sub
    End Class
End Namespace
