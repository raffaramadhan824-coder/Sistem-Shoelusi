Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace Shoelusi
    Partial Public Class Form1
        Public Sub New()
            InitializeComponent()
            Me.AcceptButton = btnMasuk
            AddHandler btnLihatPassword.Click, AddressOf TogglePasswordVisibility
            AddHandler btnLihatPassword.Paint, AddressOf DrawPasswordIcon
            AddHandler btnMasuk.Click, AddressOf LoginClick
            AddHandler lnkLupaPassword.LinkClicked, AddressOf ForgotClick
        End Sub

        Private Sub TogglePasswordVisibility(sender As Object, e As EventArgs)
            SetPasswordVisibility(txtPassword.UseSystemPasswordChar)
        End Sub

        Private Sub SetPasswordVisibility(showPassword As Boolean)
            txtPassword.UseSystemPasswordChar = Not showPassword
            btnLihatPassword.AccessibleName = If(showPassword, "Sembunyikan kata sandi", "Tampilkan kata sandi")
            btnLihatPassword.Invalidate()
        End Sub

        Private Sub DrawPasswordIcon(sender As Object, e As PaintEventArgs)
            Dim state As GraphicsState = e.Graphics.Save()
            Try
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                e.Graphics.TranslateTransform(btnLihatPassword.ClientSize.Width / 2.0F,
                                              btnLihatPassword.ClientSize.Height / 2.0F)
                Dim scale As Single = btnLihatPassword.ClientSize.Height / 26.0F
                e.Graphics.ScaleTransform(scale, scale)

                Using outline As New GraphicsPath(), stroke As New Pen(btnLihatPassword.ForeColor, 1.5F)
                    stroke.StartCap = LineCap.Round
                    stroke.EndCap = LineCap.Round
                    outline.AddBezier(-9.0F, 0.0F, -4.0F, -7.5F, 4.0F, -7.5F, 9.0F, 0.0F)
                    outline.AddBezier(9.0F, 0.0F, 4.0F, 7.5F, -4.0F, 7.5F, -9.0F, 0.0F)
                    outline.CloseFigure()
                    e.Graphics.DrawPath(stroke, outline)
                    e.Graphics.DrawEllipse(stroke, -2.4F, -2.4F, 4.8F, 4.8F)
                    If Not txtPassword.UseSystemPasswordChar Then
                        e.Graphics.DrawLine(stroke, -8.0F, -7.0F, 8.0F, 7.0F)
                    End If
                End Using
            Finally
                e.Graphics.Restore(state)
            End Try
        End Sub

        Private Sub LoginClick(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(txtNoID.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Lengkapi No ID, nama, dan kata sandi.", "Validasi Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Dim account As Data.DataRow = ModuleUtama.GetAccount(txtNoID.Text.Trim())
                If account Is Nothing Then
                    MessageBox.Show("Akun dengan No ID tersebut tidak ditemukan.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim name As String = Convert.ToString(account("Nama")).Trim()
                Dim pin As Integer
                If Not String.Equals(name, txtNama.Text.Trim(), StringComparison.OrdinalIgnoreCase) OrElse
                   Not ModuleUtama.TryReadPin(txtPassword.Text, pin) OrElse
                   account.IsNull("Kata Sandi") OrElse pin <> CInt(account("Kata Sandi")) Then
                    MessageBox.Show("Nama atau kata sandi tidak sesuai dengan database.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim division As String = ModuleUtama.AccountDivision(Convert.ToString(account("Divisi")))
                If division = String.Empty Then
                    MessageBox.Show("Divisi pada database belum dikenali. Hubungi Pemilik.", "Login Gagal")
                    Return
                End If

                Dim selectedDivision As RadioButton = Nothing
                For Each choice As RadioButton In {rbKasir, rbTeknisi, rbGudang, rbPemilik}
                    If choice.Checked Then
                        selectedDivision = choice
                        Exit For
                    End If
                Next
                If selectedDivision Is Nothing OrElse selectedDivision.Text <> division Then
                    MessageBox.Show("Pilih divisi yang sesuai dengan akun Anda.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim target As Form
                Select Case division
                    Case "Kasir"
                        target = New FrmKasir(Convert.ToString(account("No_ID")))
                    Case "Teknisi"
                        target = New FrmTeknisi(Convert.ToString(account("No_ID")))
                    Case "Staf Gudang"
                        target = New FrmGudang(Convert.ToString(account("No_ID")))
                    Case Else
                        target = New FrmPemilik(Convert.ToString(account("No_ID")))
                End Select

                Using target
                    Me.Hide()
                    Try
                        target.ShowDialog()
                    Finally
                        txtPassword.Clear()
                        SetPasswordVisibility(False)
                        Me.Show()
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Tidak dapat mengakses database: " & ex.Message, "Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ForgotClick(sender As Object, e As LinkLabelLinkClickedEventArgs)
            Using f As New Form2()
                f.SetAccountId(txtNoID.Text.Trim())
                f.ShowDialog(Me)
            End Using
        End Sub
    End Class
End Namespace
