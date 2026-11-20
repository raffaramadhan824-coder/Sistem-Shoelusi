Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
            Me.pnlLogin = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblNoID = New System.Windows.Forms.Label()
            Me.txtNoID = New System.Windows.Forms.TextBox()
            Me.lblNama = New System.Windows.Forms.Label()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.btnLihatPassword = New System.Windows.Forms.Button()
            Me.rbKasir = New System.Windows.Forms.RadioButton()
            Me.rbTeknisi = New System.Windows.Forms.RadioButton()
            Me.rbGudang = New System.Windows.Forms.RadioButton()
            Me.rbPemilik = New System.Windows.Forms.RadioButton()
            Me.btnMasuk = New System.Windows.Forms.Button()
            Me.lnkLupaPassword = New System.Windows.Forms.LinkLabel()
            Me.pnlBrand = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lblLogo = New System.Windows.Forms.Label()
            Me.lblTagline = New System.Windows.Forms.Label()
            Me.pnlLogin.SuspendLayout()
            Me.pnlBrand.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlLogin
            '
            Me.pnlLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlLogin.Controls.Add(Me.lblTitle)
            Me.pnlLogin.Controls.Add(Me.lblNoID)
            Me.pnlLogin.Controls.Add(Me.txtNoID)
            Me.pnlLogin.Controls.Add(Me.lblNama)
            Me.pnlLogin.Controls.Add(Me.txtNama)
            Me.pnlLogin.Controls.Add(Me.lblPassword)
            Me.pnlLogin.Controls.Add(Me.txtPassword)
            Me.pnlLogin.Controls.Add(Me.btnLihatPassword)
            Me.pnlLogin.Controls.Add(Me.rbKasir)
            Me.pnlLogin.Controls.Add(Me.rbTeknisi)
            Me.pnlLogin.Controls.Add(Me.rbGudang)
            Me.pnlLogin.Controls.Add(Me.rbPemilik)
            Me.pnlLogin.Controls.Add(Me.btnMasuk)
            Me.pnlLogin.Controls.Add(Me.lnkLupaPassword)
            Me.pnlLogin.Location = New System.Drawing.Point(590, 50)
            Me.pnlLogin.Name = "pnlLogin"
            Me.pnlLogin.Size = New System.Drawing.Size(610, 585)
            Me.pnlLogin.TabIndex = 1
            '
            'lblTitle
            '
            Me.lblTitle.BackColor = System.Drawing.Color.Transparent
            Me.lblTitle.Font = New System.Drawing.Font("Showcard Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(45, 22)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(520, 55)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Masuk Akun"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNoID
            '
            Me.lblNoID.BackColor = System.Drawing.Color.Transparent
            Me.lblNoID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNoID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblNoID.Location = New System.Drawing.Point(55, 110)
            Me.lblNoID.Name = "lblNoID"
            Me.lblNoID.Size = New System.Drawing.Size(480, 25)
            Me.lblNoID.TabIndex = 1
            Me.lblNoID.Text = "No ID"
            Me.lblNoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNoID
            '
            Me.txtNoID.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtNoID.Location = New System.Drawing.Point(55, 138)
            Me.txtNoID.Name = "txtNoID"
            Me.txtNoID.Size = New System.Drawing.Size(480, 30)
            Me.txtNoID.TabIndex = 2
            '
            'lblNama
            '
            Me.lblNama.BackColor = System.Drawing.Color.Transparent
            Me.lblNama.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblNama.Location = New System.Drawing.Point(55, 195)
            Me.lblNama.Name = "lblNama"
            Me.lblNama.Size = New System.Drawing.Size(480, 25)
            Me.lblNama.TabIndex = 3
            Me.lblNama.Text = "Nama"
            Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNama
            '
            Me.txtNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtNama.Location = New System.Drawing.Point(55, 223)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(480, 30)
            Me.txtNama.TabIndex = 4
            '
            'lblPassword
            '
            Me.lblPassword.BackColor = System.Drawing.Color.Transparent
            Me.lblPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.lblPassword.Location = New System.Drawing.Point(55, 280)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(480, 25)
            Me.lblPassword.TabIndex = 5
            Me.lblPassword.Text = "Kata Sandi"
            Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPassword
            '
            Me.txtPassword.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPassword.Location = New System.Drawing.Point(55, 308)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(440, 30)
            Me.txtPassword.TabIndex = 6
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'btnLihatPassword
            '
            Me.btnLihatPassword.AccessibleName = "Tampilkan kata sandi"
            Me.btnLihatPassword.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnLihatPassword.Location = New System.Drawing.Point(503, 306)
            Me.btnLihatPassword.Name = "btnLihatPassword"
            Me.btnLihatPassword.Size = New System.Drawing.Size(32, 26)
            Me.btnLihatPassword.TabIndex = 7
            Me.btnLihatPassword.UseVisualStyleBackColor = True
            '
            'rbKasir
            '
            Me.rbKasir.Checked = True
            Me.rbKasir.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.rbKasir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.rbKasir.Location = New System.Drawing.Point(65, 390)
            Me.rbKasir.Name = "rbKasir"
            Me.rbKasir.Size = New System.Drawing.Size(210, 28)
            Me.rbKasir.TabIndex = 8
            Me.rbKasir.TabStop = True
            Me.rbKasir.Text = "Kasir"
            Me.rbKasir.UseVisualStyleBackColor = True
            '
            'rbTeknisi
            '
            Me.rbTeknisi.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.rbTeknisi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.rbTeknisi.Location = New System.Drawing.Point(320, 390)
            Me.rbTeknisi.Name = "rbTeknisi"
            Me.rbTeknisi.Size = New System.Drawing.Size(210, 28)
            Me.rbTeknisi.TabIndex = 9
            Me.rbTeknisi.Text = "Teknisi"
            Me.rbTeknisi.UseVisualStyleBackColor = True
            '
            'rbGudang
            '
            Me.rbGudang.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.rbGudang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.rbGudang.Location = New System.Drawing.Point(65, 430)
            Me.rbGudang.Name = "rbGudang"
            Me.rbGudang.Size = New System.Drawing.Size(210, 28)
            Me.rbGudang.TabIndex = 10
            Me.rbGudang.Text = "Staf Gudang"
            Me.rbGudang.UseVisualStyleBackColor = True
            '
            'rbPemilik
            '
            Me.rbPemilik.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.rbPemilik.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
            Me.rbPemilik.Location = New System.Drawing.Point(320, 430)
            Me.rbPemilik.Name = "rbPemilik"
            Me.rbPemilik.Size = New System.Drawing.Size(210, 28)
            Me.rbPemilik.TabIndex = 11
            Me.rbPemilik.Text = "Pemilik"
            Me.rbPemilik.UseVisualStyleBackColor = True
            '
            'btnMasuk
            '
            Me.btnMasuk.BackColor = System.Drawing.SystemColors.HotTrack
            Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMasuk.ForeColor = System.Drawing.Color.White
            Me.btnMasuk.Location = New System.Drawing.Point(150, 485)
            Me.btnMasuk.Name = "btnMasuk"
            Me.btnMasuk.Size = New System.Drawing.Size(300, 52)
            Me.btnMasuk.TabIndex = 12
            Me.btnMasuk.Text = "Masuk"
            Me.btnMasuk.UseVisualStyleBackColor = False
            '
            'lnkLupaPassword
            '
            Me.lnkLupaPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lnkLupaPassword.LinkColor = System.Drawing.Color.Blue
            Me.lnkLupaPassword.Location = New System.Drawing.Point(190, 548)
            Me.lnkLupaPassword.Name = "lnkLupaPassword"
            Me.lnkLupaPassword.Size = New System.Drawing.Size(220, 22)
            Me.lnkLupaPassword.TabIndex = 13
            Me.lnkLupaPassword.TabStop = True
            Me.lnkLupaPassword.Text = "Ubah Kata Sandi"
            Me.lnkLupaPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlBrand
            '
            Me.pnlBrand.BackColor = System.Drawing.Color.LightSteelBlue
            Me.pnlBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
            Me.PictureBox1.Location = New System.Drawing.Point(194, 70)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'lblLogo
            '
            Me.lblLogo.BackColor = System.Drawing.Color.Transparent
            Me.lblLogo.Font = New System.Drawing.Font("Baskerville Old Face", 34.0!, System.Drawing.FontStyle.Bold)
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
            Me.lblTagline.Location = New System.Drawing.Point(43, 349)
            Me.lblTagline.Name = "lblTagline"
            Me.lblTagline.Size = New System.Drawing.Size(400, 108)
            Me.lblTagline.TabIndex = 1
            Me.lblTagline.Text = "Sistem Informasi Pengelolaan Servis Sepatu" & Global.Microsoft.VisualBasic.ChrW(10) & "dan Persediaan Bahan Baku"
            Me.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CadetBlue
            Me.ClientSize = New System.Drawing.Size(1250, 710)
            Me.Controls.Add(Me.pnlBrand)
            Me.Controls.Add(Me.pnlLogin)
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Masuk Akun"
            Me.pnlLogin.ResumeLayout(False)
            Me.pnlLogin.PerformLayout()
            Me.pnlBrand.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
        Friend WithEvents lblTagline As System.Windows.Forms.Label
        Friend WithEvents pnlLogin As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblNoID As System.Windows.Forms.Label
        Friend WithEvents txtNoID As System.Windows.Forms.TextBox
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnLihatPassword As System.Windows.Forms.Button
        Friend WithEvents rbKasir As System.Windows.Forms.RadioButton
        Friend WithEvents rbTeknisi As System.Windows.Forms.RadioButton
        Friend WithEvents rbGudang As System.Windows.Forms.RadioButton
        Friend WithEvents rbPemilik As System.Windows.Forms.RadioButton
        Friend WithEvents btnMasuk As System.Windows.Forms.Button
        Friend WithEvents lnkLupaPassword As System.Windows.Forms.LinkLabel
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblLogo As System.Windows.Forms.Label
    End Class
End Namespace
