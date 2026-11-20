Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
            Me.pnlBrand = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lblLogo = New System.Windows.Forms.Label()
            Me.lblTagline = New System.Windows.Forms.Label()
            Me.pnlForgot = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblNoID = New System.Windows.Forms.Label()
            Me.txtNoID = New System.Windows.Forms.TextBox()
            Me.lblNewPassword = New System.Windows.Forms.Label()
            Me.txtNewPassword = New System.Windows.Forms.TextBox()
            Me.lblConfirmPassword = New System.Windows.Forms.Label()
            Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
            Me.btnUbahPassword = New System.Windows.Forms.Button()
            Me.lnkKembali = New System.Windows.Forms.LinkLabel()
            Me.pnlBrand.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlForgot.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBrand
            '
            Me.pnlBrand.BackColor = System.Drawing.Color.LightSteelBlue
            Me.pnlBrand.Controls.Add(Me.PictureBox1)
            Me.pnlBrand.Controls.Add(Me.lblLogo)
            Me.pnlBrand.Controls.Add(Me.lblTagline)
            Me.pnlBrand.Location = New System.Drawing.Point(35, 50)
            Me.pnlBrand.Name = "pnlBrand"
            Me.pnlBrand.Size = New System.Drawing.Size(490, 585)
            Me.pnlBrand.TabIndex = 0
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.Resources.shoelusi_logo
            Me.PictureBox1.Location = New System.Drawing.Point(188, 77)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'lblLogo
            '
            Me.lblLogo.BackColor = System.Drawing.Color.Transparent
            Me.lblLogo.Font = New System.Drawing.Font("Baskerville Old Face", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLogo.ForeColor = System.Drawing.Color.Teal
            Me.lblLogo.Location = New System.Drawing.Point(35, 175)
            Me.lblLogo.Name = "lblLogo"
            Me.lblLogo.Size = New System.Drawing.Size(420, 85)
            Me.lblLogo.TabIndex = 0
            Me.lblLogo.Text = "SHOE.LUSI"
            Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTagline
            '
            Me.lblTagline.BackColor = System.Drawing.Color.Transparent
            Me.lblTagline.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTagline.ForeColor = System.Drawing.Color.Black
            Me.lblTagline.Location = New System.Drawing.Point(43, 320)
            Me.lblTagline.Name = "lblTagline"
            Me.lblTagline.Size = New System.Drawing.Size(400, 163)
            Me.lblTagline.TabIndex = 1
            Me.lblTagline.Text = "Sistem Informasi Pengelolaan Servis Sepatu" & Global.Microsoft.VisualBasic.ChrW(10) & "dan Persediaan Bahan Baku"
            Me.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlForgot
            '
            Me.pnlForgot.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlForgot.Controls.Add(Me.lblTitle)
            Me.pnlForgot.Controls.Add(Me.lblNoID)
            Me.pnlForgot.Controls.Add(Me.txtNoID)
            Me.pnlForgot.Controls.Add(Me.lblNewPassword)
            Me.pnlForgot.Controls.Add(Me.txtNewPassword)
            Me.pnlForgot.Controls.Add(Me.lblConfirmPassword)
            Me.pnlForgot.Controls.Add(Me.txtConfirmPassword)
            Me.pnlForgot.Controls.Add(Me.btnUbahPassword)
            Me.pnlForgot.Controls.Add(Me.lnkKembali)
            Me.pnlForgot.Location = New System.Drawing.Point(590, 50)
            Me.pnlForgot.Name = "pnlForgot"
            Me.pnlForgot.Size = New System.Drawing.Size(610, 585)
            Me.pnlForgot.TabIndex = 1
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(45, 22)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(520, 55)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Lupa Kata Sandi"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNoID
            '
            Me.lblNoID.BackColor = System.Drawing.Color.Transparent
            Me.lblNoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNoID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblNoID.Location = New System.Drawing.Point(55, 120)
            Me.lblNoID.Name = "lblNoID"
            Me.lblNoID.Size = New System.Drawing.Size(480, 25)
            Me.lblNoID.TabIndex = 1
            Me.lblNoID.Text = "No ID"
            Me.lblNoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNoID
            '
            Me.txtNoID.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtNoID.Location = New System.Drawing.Point(55, 150)
            Me.txtNoID.Name = "txtNoID"
            Me.txtNoID.Size = New System.Drawing.Size(480, 30)
            Me.txtNoID.TabIndex = 2
            '
            'lblNewPassword
            '
            Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
            Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblNewPassword.Location = New System.Drawing.Point(55, 220)
            Me.lblNewPassword.Name = "lblNewPassword"
            Me.lblNewPassword.Size = New System.Drawing.Size(480, 25)
            Me.lblNewPassword.TabIndex = 3
            Me.lblNewPassword.Text = "Kata Sandi Baru"
            Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNewPassword
            '
            Me.txtNewPassword.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtNewPassword.Location = New System.Drawing.Point(55, 250)
            Me.txtNewPassword.Name = "txtNewPassword"
            Me.txtNewPassword.Size = New System.Drawing.Size(480, 30)
            Me.txtNewPassword.TabIndex = 4
            '
            'lblConfirmPassword
            '
            Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
            Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblConfirmPassword.Location = New System.Drawing.Point(55, 320)
            Me.lblConfirmPassword.Name = "lblConfirmPassword"
            Me.lblConfirmPassword.Size = New System.Drawing.Size(480, 25)
            Me.lblConfirmPassword.TabIndex = 5
            Me.lblConfirmPassword.Text = "Konfirmasi Kata Sandi"
            Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtConfirmPassword
            '
            Me.txtConfirmPassword.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtConfirmPassword.Location = New System.Drawing.Point(55, 350)
            Me.txtConfirmPassword.Name = "txtConfirmPassword"
            Me.txtConfirmPassword.Size = New System.Drawing.Size(480, 30)
            Me.txtConfirmPassword.TabIndex = 6
            '
            'btnUbahPassword
            '
            Me.btnUbahPassword.BackColor = System.Drawing.SystemColors.HotTrack
            Me.btnUbahPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnUbahPassword.ForeColor = System.Drawing.Color.White
            Me.btnUbahPassword.Location = New System.Drawing.Point(135, 455)
            Me.btnUbahPassword.Name = "btnUbahPassword"
            Me.btnUbahPassword.Size = New System.Drawing.Size(340, 52)
            Me.btnUbahPassword.TabIndex = 7
            Me.btnUbahPassword.Text = "Ubah Kata Sandi"
            Me.btnUbahPassword.UseVisualStyleBackColor = False
            '
            'lnkKembali
            '
            Me.lnkKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lnkKembali.LinkColor = System.Drawing.Color.Blue
            Me.lnkKembali.Location = New System.Drawing.Point(180, 525)
            Me.lnkKembali.Name = "lnkKembali"
            Me.lnkKembali.Size = New System.Drawing.Size(250, 22)
            Me.lnkKembali.TabIndex = 8
            Me.lnkKembali.TabStop = True
            Me.lnkKembali.Text = "Kembali ke Masuk Akun"
            Me.lnkKembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CadetBlue
            Me.ClientSize = New System.Drawing.Size(1250, 710)
            Me.Controls.Add(Me.pnlBrand)
            Me.Controls.Add(Me.pnlForgot)
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Form2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Lupa Kata Sandi"
            Me.pnlBrand.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlForgot.ResumeLayout(False)
            Me.pnlForgot.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblTagline As System.Windows.Forms.Label
    Friend WithEvents pnlForgot As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNoID As System.Windows.Forms.Label
    Friend WithEvents txtNoID As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUbahPassword As System.Windows.Forms.Button
        Friend WithEvents lnkKembali As System.Windows.Forms.LinkLabel
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace
