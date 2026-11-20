Imports System
Imports System.Windows.Forms

Namespace Shoelusi
    Partial Public Class Form2
        Private ReadOnly txtOldPassword As New TextBox()
        
        Public Sub New()
            InitializeComponent()
            lblTitle.Text = "Ubah Kata Sandi"
            Dim lblOldPassword As New Label() With {
                .Text = "Kata Sandi Saat Ini",
                .Font = lblNewPassword.Font,
                .ForeColor = lblNewPassword.ForeColor,
                .Bounds = New Drawing.Rectangle(55, 184, 480, 25)
            }
            txtOldPassword.Font = txtNewPassword.Font
            txtOldPassword.Bounds = New Drawing.Rectangle(55, 211, 480, 30)
            txtOldPassword.TabIndex = 3
            txtOldPassword.UseSystemPasswordChar = True
            pnlForgot.Controls.Add(lblOldPassword)
            pnlForgot.Controls.Add(txtOldPassword)
            lblNewPassword.Top = 251
            txtNewPassword.Top = 278
            txtNewPassword.TabIndex = 4
            lblConfirmPassword.Top = 326
            txtConfirmPassword.Top = 353
            Me.AcceptButton = btnUbahPassword
            txtNewPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
            AddHandler btnUbahPassword.Click, AddressOf ChangePasswordClick
            AddHandler lnkKembali.LinkClicked, Sub(sender, e) Me.Close()
        End Sub

        Public Sub SetAccountId(noId As String)
            txtNoID.Text = noId
        End Sub

        Private Sub ChangePasswordClick(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(txtNoID.Text) OrElse String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
                MessageBox.Show("Lengkapi seluruh data.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If
            If txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Konfirmasi kata sandi belum sama.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If
            Dim oldPin As Integer
            Dim newPin As Integer
            If Not ModuleUtama.TryReadPin(txtOldPassword.Text, oldPin) OrElse Not ModuleUtama.TryReadPin(txtNewPassword.Text, newPin) Then
                MessageBox.Show("Kata sandi harus berupa angka tanpa nol di depan, maksimal 2147483647. Jika lupa, hubungi Pemilik.", "Validasi")
                Return
            End If
            Try
                Dim updated As Integer = ModuleUtama.ChangePassword(txtNoID.Text.Trim(), oldPin, newPin)
                If updated > 0 Then
                    MessageBox.Show("Kata sandi berhasil diperbarui.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("No ID atau kata sandi saat ini salah. Jika lupa, hubungi Pemilik.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui kata sandi: " & ex.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
