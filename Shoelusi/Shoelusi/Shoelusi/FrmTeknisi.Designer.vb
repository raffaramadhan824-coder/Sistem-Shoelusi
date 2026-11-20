Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmTeknisi
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
            Me.tabMain = New System.Windows.Forms.TabControl()
            Me.tpCekPesanan = New System.Windows.Forms.TabPage()
            Me.lblTitleCekPesanan = New System.Windows.Forms.Label()
            Me.txtCariCekPesanan = New System.Windows.Forms.TextBox()
            Me.lblCariCekPesanan = New System.Windows.Forms.Label()
            Me.dgvCekPesanan = New System.Windows.Forms.DataGridView()
            Me.dgvCekPesananCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPesananCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPesananCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPesananCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPesananCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPesananCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpPengerjaan = New System.Windows.Forms.TabPage()
            Me.lblTitlePengerjaan = New System.Windows.Forms.Label()
            Me.pnlPengerjaan = New System.Windows.Forms.Panel()
            Me.lbltxtPengerjaanNo = New System.Windows.Forms.Label()
            Me.txtPengerjaanNo = New System.Windows.Forms.TextBox()
            Me.lbltxtPengerjaanPesanan = New System.Windows.Forms.Label()
            Me.txtPengerjaanPesanan = New System.Windows.Forms.TextBox()
            Me.lbltxtPengerjaanMulai = New System.Windows.Forms.Label()
            Me.dtpPengerjaanMulai = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPengerjaanSelesai = New System.Windows.Forms.Label()
            Me.dtpPengerjaanSelesai = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPengerjaanStatus = New System.Windows.Forms.Label()
            Me.txtPengerjaanStatus = New System.Windows.Forms.TextBox()
            Me.btnTambahPengerjaan = New System.Windows.Forms.Button()
            Me.btnUbahPengerjaan = New System.Windows.Forms.Button()
            Me.btnHapusPengerjaan = New System.Windows.Forms.Button()
            Me.btnBersihkanPengerjaan = New System.Windows.Forms.Button()
            Me.dgvPengerjaan = New System.Windows.Forms.DataGridView()
            Me.dgvPengerjaanCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengerjaanCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengerjaanCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengerjaanCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengerjaanCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpPenggunaanBB = New System.Windows.Forms.TabPage()
            Me.lblTitlePenggunaanBB = New System.Windows.Forms.Label()
            Me.pnlPenggunaanBB = New System.Windows.Forms.Panel()
            Me.lbltxtPenggunaanTanggal = New System.Windows.Forms.Label()
            Me.dtpPenggunaanTanggal = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPenggunaanPengerjaan = New System.Windows.Forms.Label()
            Me.txtPenggunaanPengerjaan = New System.Windows.Forms.TextBox()
            Me.lbltxtPenggunaanKode = New System.Windows.Forms.Label()
            Me.txtPenggunaanKode = New System.Windows.Forms.TextBox()
            Me.lbltxtPenggunaanNama = New System.Windows.Forms.Label()
            Me.txtPenggunaanNama = New System.Windows.Forms.TextBox()
            Me.lbltxtPenggunaanJumlah = New System.Windows.Forms.Label()
            Me.txtPenggunaanJumlah = New System.Windows.Forms.TextBox()
            Me.lbltxtPenggunaanSatuan = New System.Windows.Forms.Label()
            Me.txtPenggunaanSatuan = New System.Windows.Forms.TextBox()
            Me.btnTambahPenggunaanBB = New System.Windows.Forms.Button()
            Me.btnUbahPenggunaanBB = New System.Windows.Forms.Button()
            Me.btnHapusPenggunaanBB = New System.Windows.Forms.Button()
            Me.btnBersihkanPenggunaanBB = New System.Windows.Forms.Button()
            Me.lblKondisiPenggunaanBB = New System.Windows.Forms.Label()
            Me.cmbKondisiBB = New System.Windows.Forms.ComboBox()
            Me.btnLaporkanBB = New System.Windows.Forms.Button()
            Me.dgvPenggunaanBB = New System.Windows.Forms.DataGridView()
            Me.dgvPenggunaanBBCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPenggunaanBBCol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblBrand = New System.Windows.Forms.Label()
            Me.lblActor = New System.Windows.Forms.Label()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.tabMain.SuspendLayout()
            Me.tpCekPesanan.SuspendLayout()
            CType(Me.dgvCekPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpPengerjaan.SuspendLayout()
            Me.pnlPengerjaan.SuspendLayout()
            CType(Me.dgvPengerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpPenggunaanBB.SuspendLayout()
            Me.pnlPenggunaanBB.SuspendLayout()
            CType(Me.dgvPenggunaanBB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tabMain
            '
            Me.tabMain.Controls.Add(Me.tpCekPesanan)
            Me.tabMain.Controls.Add(Me.tpPengerjaan)
            Me.tabMain.Controls.Add(Me.tpPenggunaanBB)
            Me.tabMain.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.tabMain.Location = New System.Drawing.Point(20, 100)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(1210, 590)
            Me.tabMain.TabIndex = 3
            '
            'tpCekPesanan
            '
            Me.tpCekPesanan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekPesanan.Controls.Add(Me.lblTitleCekPesanan)
            Me.tpCekPesanan.Controls.Add(Me.txtCariCekPesanan)
            Me.tpCekPesanan.Controls.Add(Me.lblCariCekPesanan)
            Me.tpCekPesanan.Controls.Add(Me.dgvCekPesanan)
            Me.tpCekPesanan.Location = New System.Drawing.Point(4, 33)
            Me.tpCekPesanan.Name = "tpCekPesanan"
            Me.tpCekPesanan.Size = New System.Drawing.Size(1202, 553)
            Me.tpCekPesanan.TabIndex = 0
            Me.tpCekPesanan.Text = "Cek Pesanan"
            '
            'lblTitleCekPesanan
            '
            Me.lblTitleCekPesanan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekPesanan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekPesanan.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekPesanan.Location = New System.Drawing.Point(493, 12)
            Me.lblTitleCekPesanan.Name = "lblTitleCekPesanan"
            Me.lblTitleCekPesanan.Size = New System.Drawing.Size(1120, 35)
            Me.lblTitleCekPesanan.TabIndex = 0
            Me.lblTitleCekPesanan.Text = "CEK PESANAN"
            Me.lblTitleCekPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtCariCekPesanan
            '
            Me.txtCariCekPesanan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtCariCekPesanan.Location = New System.Drawing.Point(22, 62)
            Me.txtCariCekPesanan.Name = "txtCariCekPesanan"
            Me.txtCariCekPesanan.Size = New System.Drawing.Size(285, 30)
            Me.txtCariCekPesanan.TabIndex = 1
            '
            'lblCariCekPesanan
            '
            Me.lblCariCekPesanan.BackColor = System.Drawing.Color.Transparent
            Me.lblCariCekPesanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCariCekPesanan.ForeColor = System.Drawing.Color.Red
            Me.lblCariCekPesanan.Location = New System.Drawing.Point(22, 37)
            Me.lblCariCekPesanan.Name = "lblCariCekPesanan"
            Me.lblCariCekPesanan.Size = New System.Drawing.Size(250, 22)
            Me.lblCariCekPesanan.TabIndex = 2
            Me.lblCariCekPesanan.Text = "Cari data..."
            Me.lblCariCekPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            '
            'dgvCekPesanan
            '
            Me.dgvCekPesanan.AllowUserToAddRows = False
            Me.dgvCekPesanan.AllowUserToDeleteRows = False
            Me.dgvCekPesanan.AllowUserToResizeRows = False
            Me.dgvCekPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCekPesanan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCekPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCekPesananCol1, Me.dgvCekPesananCol2, Me.dgvCekPesananCol3, Me.dgvCekPesananCol4, Me.dgvCekPesananCol5, Me.dgvCekPesananCol6})
            Me.dgvCekPesanan.GridColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekPesanan.Location = New System.Drawing.Point(20, 115)
            Me.dgvCekPesanan.MultiSelect = False
            Me.dgvCekPesanan.Name = "dgvCekPesanan"
            Me.dgvCekPesanan.ReadOnly = True
            Me.dgvCekPesanan.RowHeadersVisible = False
            Me.dgvCekPesanan.RowHeadersWidth = 51
            Me.dgvCekPesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCekPesanan.Size = New System.Drawing.Size(1150, 440)
            Me.dgvCekPesanan.TabIndex = 4
            '
            'dgvCekPesananCol1
            '
            Me.dgvCekPesananCol1.HeaderText = "No. Pesanan"
            Me.dgvCekPesananCol1.MinimumWidth = 6
            Me.dgvCekPesananCol1.Name = "dgvCekPesananCol1"
            Me.dgvCekPesananCol1.ReadOnly = True
            Me.dgvCekPesananCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPesananCol2
            '
            Me.dgvCekPesananCol2.HeaderText = "Pelanggan"
            Me.dgvCekPesananCol2.MinimumWidth = 6
            Me.dgvCekPesananCol2.Name = "dgvCekPesananCol2"
            Me.dgvCekPesananCol2.ReadOnly = True
            Me.dgvCekPesananCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPesananCol3
            '
            Me.dgvCekPesananCol3.HeaderText = "Layanan"
            Me.dgvCekPesananCol3.MinimumWidth = 6
            Me.dgvCekPesananCol3.Name = "dgvCekPesananCol3"
            Me.dgvCekPesananCol3.ReadOnly = True
            Me.dgvCekPesananCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPesananCol4
            '
            Me.dgvCekPesananCol4.HeaderText = "Keluhan"
            Me.dgvCekPesananCol4.MinimumWidth = 6
            Me.dgvCekPesananCol4.Name = "dgvCekPesananCol4"
            Me.dgvCekPesananCol4.ReadOnly = True
            Me.dgvCekPesananCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPesananCol5
            '
            Me.dgvCekPesananCol5.HeaderText = "Tanggal"
            Me.dgvCekPesananCol5.MinimumWidth = 6
            Me.dgvCekPesananCol5.Name = "dgvCekPesananCol5"
            Me.dgvCekPesananCol5.ReadOnly = True
            Me.dgvCekPesananCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPesananCol6
            '
            Me.dgvCekPesananCol6.HeaderText = "Status"
            Me.dgvCekPesananCol6.MinimumWidth = 6
            Me.dgvCekPesananCol6.Name = "dgvCekPesananCol6"
            Me.dgvCekPesananCol6.ReadOnly = True
            Me.dgvCekPesananCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpPengerjaan
            '
            Me.tpPengerjaan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPengerjaan.Controls.Add(Me.lblTitlePengerjaan)
            Me.tpPengerjaan.Controls.Add(Me.pnlPengerjaan)
            Me.tpPengerjaan.Controls.Add(Me.dgvPengerjaan)
            Me.tpPengerjaan.Location = New System.Drawing.Point(4, 33)
            Me.tpPengerjaan.Name = "tpPengerjaan"
            Me.tpPengerjaan.Size = New System.Drawing.Size(1202, 553)
            Me.tpPengerjaan.TabIndex = 1
            Me.tpPengerjaan.Text = "Data Pengerjaan"
            '
            'lblTitlePengerjaan
            '
            Me.lblTitlePengerjaan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePengerjaan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitlePengerjaan.ForeColor = System.Drawing.Color.White
            Me.lblTitlePengerjaan.Location = New System.Drawing.Point(400, 8)
            Me.lblTitlePengerjaan.Name = "lblTitlePengerjaan"
            Me.lblTitlePengerjaan.Size = New System.Drawing.Size(379, 35)
            Me.lblTitlePengerjaan.TabIndex = 0
            Me.lblTitlePengerjaan.Text = "DATA PENGERJAAN"
            Me.lblTitlePengerjaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPengerjaan
            '
            Me.pnlPengerjaan.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlPengerjaan.Controls.Add(Me.lbltxtPengerjaanNo)
            Me.pnlPengerjaan.Controls.Add(Me.txtPengerjaanNo)
            Me.pnlPengerjaan.Controls.Add(Me.lbltxtPengerjaanPesanan)
            Me.pnlPengerjaan.Controls.Add(Me.txtPengerjaanPesanan)
            Me.pnlPengerjaan.Controls.Add(Me.lbltxtPengerjaanMulai)
            Me.pnlPengerjaan.Controls.Add(Me.dtpPengerjaanMulai)
            Me.pnlPengerjaan.Controls.Add(Me.lbltxtPengerjaanSelesai)
            Me.pnlPengerjaan.Controls.Add(Me.dtpPengerjaanSelesai)
            Me.pnlPengerjaan.Controls.Add(Me.lbltxtPengerjaanStatus)
            Me.pnlPengerjaan.Controls.Add(Me.txtPengerjaanStatus)
            Me.pnlPengerjaan.Controls.Add(Me.btnTambahPengerjaan)
            Me.pnlPengerjaan.Controls.Add(Me.btnUbahPengerjaan)
            Me.pnlPengerjaan.Controls.Add(Me.btnHapusPengerjaan)
            Me.pnlPengerjaan.Controls.Add(Me.btnBersihkanPengerjaan)
            Me.pnlPengerjaan.Location = New System.Drawing.Point(20, 55)
            Me.pnlPengerjaan.Name = "pnlPengerjaan"
            Me.pnlPengerjaan.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPengerjaan.TabIndex = 1
            '
            'lbltxtPengerjaanNo
            '
            Me.lbltxtPengerjaanNo.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengerjaanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengerjaanNo.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengerjaanNo.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtPengerjaanNo.Name = "lbltxtPengerjaanNo"
            Me.lbltxtPengerjaanNo.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPengerjaanNo.TabIndex = 0
            Me.lbltxtPengerjaanNo.Text = "No. Pengerjaan"
            Me.lbltxtPengerjaanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengerjaanNo
            '
            Me.txtPengerjaanNo.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengerjaanNo.Location = New System.Drawing.Point(15, 43)
            Me.txtPengerjaanNo.Name = "txtPengerjaanNo"
            Me.txtPengerjaanNo.Size = New System.Drawing.Size(190, 30)
            Me.txtPengerjaanNo.TabIndex = 1
            '
            'lbltxtPengerjaanPesanan
            '
            Me.lbltxtPengerjaanPesanan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengerjaanPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengerjaanPesanan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengerjaanPesanan.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtPengerjaanPesanan.Name = "lbltxtPengerjaanPesanan"
            Me.lbltxtPengerjaanPesanan.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPengerjaanPesanan.TabIndex = 2
            Me.lbltxtPengerjaanPesanan.Text = "No. Pesanan"
            Me.lbltxtPengerjaanPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengerjaanPesanan
            '
            Me.txtPengerjaanPesanan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengerjaanPesanan.Location = New System.Drawing.Point(217, 43)
            Me.txtPengerjaanPesanan.Name = "txtPengerjaanPesanan"
            Me.txtPengerjaanPesanan.Size = New System.Drawing.Size(190, 30)
            Me.txtPengerjaanPesanan.TabIndex = 3
            '
            'lbltxtPengerjaanMulai
            '
            Me.lbltxtPengerjaanMulai.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengerjaanMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengerjaanMulai.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengerjaanMulai.Location = New System.Drawing.Point(419, 16)
            Me.lbltxtPengerjaanMulai.Name = "lbltxtPengerjaanMulai"
            Me.lbltxtPengerjaanMulai.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPengerjaanMulai.TabIndex = 4
            Me.lbltxtPengerjaanMulai.Text = "Tanggal Mulai"
            Me.lbltxtPengerjaanMulai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPengerjaanMulai
            '
            Me.dtpPengerjaanMulai.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPengerjaanMulai.Location = New System.Drawing.Point(419, 43)
            Me.dtpPengerjaanMulai.Name = "dtpPengerjaanMulai"
            Me.dtpPengerjaanMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPengerjaanMulai.CustomFormat = "dd/MM/yyyy"
            Me.dtpPengerjaanMulai.Size = New System.Drawing.Size(190, 30)
            Me.dtpPengerjaanMulai.TabIndex = 5
            '
            'lbltxtPengerjaanSelesai
            '
            Me.lbltxtPengerjaanSelesai.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengerjaanSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengerjaanSelesai.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengerjaanSelesai.Location = New System.Drawing.Point(621, 16)
            Me.lbltxtPengerjaanSelesai.Name = "lbltxtPengerjaanSelesai"
            Me.lbltxtPengerjaanSelesai.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPengerjaanSelesai.TabIndex = 6
            Me.lbltxtPengerjaanSelesai.Text = "Tanggal Selesai"
            Me.lbltxtPengerjaanSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPengerjaanSelesai
            '
            Me.dtpPengerjaanSelesai.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPengerjaanSelesai.Location = New System.Drawing.Point(621, 43)
            Me.dtpPengerjaanSelesai.Name = "dtpPengerjaanSelesai"
            Me.dtpPengerjaanSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPengerjaanSelesai.CustomFormat = "dd/MM/yyyy"
            Me.dtpPengerjaanSelesai.ShowCheckBox = True
            Me.dtpPengerjaanSelesai.Checked = False
            Me.dtpPengerjaanSelesai.Size = New System.Drawing.Size(190, 30)
            Me.dtpPengerjaanSelesai.TabIndex = 7
            '
            'lbltxtPengerjaanStatus
            '
            Me.lbltxtPengerjaanStatus.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengerjaanStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengerjaanStatus.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengerjaanStatus.Location = New System.Drawing.Point(823, 16)
            Me.lbltxtPengerjaanStatus.Name = "lbltxtPengerjaanStatus"
            Me.lbltxtPengerjaanStatus.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtPengerjaanStatus.TabIndex = 8
            Me.lbltxtPengerjaanStatus.Text = "Status"
            Me.lbltxtPengerjaanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengerjaanStatus
            '
            Me.txtPengerjaanStatus.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengerjaanStatus.Location = New System.Drawing.Point(823, 43)
            Me.txtPengerjaanStatus.Name = "txtPengerjaanStatus"
            Me.txtPengerjaanStatus.Size = New System.Drawing.Size(190, 30)
            Me.txtPengerjaanStatus.TabIndex = 9
            '
            'btnTambahPengerjaan
            '
            Me.btnTambahPengerjaan.BackColor = System.Drawing.Color.Teal
            Me.btnTambahPengerjaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPengerjaan.ForeColor = System.Drawing.Color.White
            Me.btnTambahPengerjaan.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahPengerjaan.Name = "btnTambahPengerjaan"
            Me.btnTambahPengerjaan.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPengerjaan.TabIndex = 10
            Me.btnTambahPengerjaan.Text = "Tambah"
            Me.btnTambahPengerjaan.UseVisualStyleBackColor = False
            '
            'btnUbahPengerjaan
            '
            Me.btnUbahPengerjaan.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahPengerjaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPengerjaan.ForeColor = System.Drawing.Color.White
            Me.btnUbahPengerjaan.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPengerjaan.Name = "btnUbahPengerjaan"
            Me.btnUbahPengerjaan.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPengerjaan.TabIndex = 11
            Me.btnUbahPengerjaan.Text = "Ubah"
            Me.btnUbahPengerjaan.UseVisualStyleBackColor = False
            '
            'btnHapusPengerjaan
            '
            Me.btnHapusPengerjaan.BackColor = System.Drawing.Color.Brown
            Me.btnHapusPengerjaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusPengerjaan.ForeColor = System.Drawing.Color.White
            Me.btnHapusPengerjaan.Location = New System.Drawing.Point(913, 105)
            Me.btnHapusPengerjaan.Name = "btnHapusPengerjaan"
            Me.btnHapusPengerjaan.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPengerjaan.TabIndex = 12
            Me.btnHapusPengerjaan.Text = "Hapus"
            Me.btnHapusPengerjaan.UseVisualStyleBackColor = False
            '
            'btnBersihkanPengerjaan
            '
            Me.btnBersihkanPengerjaan.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanPengerjaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPengerjaan.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPengerjaan.Location = New System.Drawing.Point(1019, 105)
            Me.btnBersihkanPengerjaan.Name = "btnBersihkanPengerjaan"
            Me.btnBersihkanPengerjaan.Size = New System.Drawing.Size(119, 34)
            Me.btnBersihkanPengerjaan.TabIndex = 13
            Me.btnBersihkanPengerjaan.Text = "Bersihkan"
            Me.btnBersihkanPengerjaan.UseVisualStyleBackColor = False
            '
            'dgvPengerjaan
            '
            Me.dgvPengerjaan.AllowUserToAddRows = False
            Me.dgvPengerjaan.AllowUserToDeleteRows = False
            Me.dgvPengerjaan.AllowUserToResizeRows = False
            Me.dgvPengerjaan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPengerjaan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPengerjaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPengerjaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPengerjaanCol1, Me.dgvPengerjaanCol2, Me.dgvPengerjaanCol3, Me.dgvPengerjaanCol4, Me.dgvPengerjaanCol5})
            Me.dgvPengerjaan.Location = New System.Drawing.Point(20, 230)
            Me.dgvPengerjaan.MultiSelect = False
            Me.dgvPengerjaan.Name = "dgvPengerjaan"
            Me.dgvPengerjaan.ReadOnly = True
            Me.dgvPengerjaan.RowHeadersVisible = False
            Me.dgvPengerjaan.RowHeadersWidth = 51
            Me.dgvPengerjaan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPengerjaan.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPengerjaan.TabIndex = 2
            '
            'dgvPengerjaanCol1
            '
            Me.dgvPengerjaanCol1.HeaderText = "No. Pengerjaan"
            Me.dgvPengerjaanCol1.MinimumWidth = 6
            Me.dgvPengerjaanCol1.Name = "dgvPengerjaanCol1"
            Me.dgvPengerjaanCol1.ReadOnly = True
            Me.dgvPengerjaanCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengerjaanCol2
            '
            Me.dgvPengerjaanCol2.HeaderText = "No. Pesanan"
            Me.dgvPengerjaanCol2.MinimumWidth = 6
            Me.dgvPengerjaanCol2.Name = "dgvPengerjaanCol2"
            Me.dgvPengerjaanCol2.ReadOnly = True
            Me.dgvPengerjaanCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengerjaanCol3
            '
            Me.dgvPengerjaanCol3.HeaderText = "Mulai"
            Me.dgvPengerjaanCol3.MinimumWidth = 6
            Me.dgvPengerjaanCol3.Name = "dgvPengerjaanCol3"
            Me.dgvPengerjaanCol3.ReadOnly = True
            Me.dgvPengerjaanCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengerjaanCol4
            '
            Me.dgvPengerjaanCol4.HeaderText = "Selesai"
            Me.dgvPengerjaanCol4.MinimumWidth = 6
            Me.dgvPengerjaanCol4.Name = "dgvPengerjaanCol4"
            Me.dgvPengerjaanCol4.ReadOnly = True
            Me.dgvPengerjaanCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengerjaanCol5
            '
            Me.dgvPengerjaanCol5.HeaderText = "Status"
            Me.dgvPengerjaanCol5.MinimumWidth = 6
            Me.dgvPengerjaanCol5.Name = "dgvPengerjaanCol5"
            Me.dgvPengerjaanCol5.ReadOnly = True
            Me.dgvPengerjaanCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpPenggunaanBB
            '
            Me.tpPenggunaanBB.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPenggunaanBB.Controls.Add(Me.lblTitlePenggunaanBB)
            Me.tpPenggunaanBB.Controls.Add(Me.pnlPenggunaanBB)
            Me.tpPenggunaanBB.Controls.Add(Me.dgvPenggunaanBB)
            Me.tpPenggunaanBB.Location = New System.Drawing.Point(4, 33)
            Me.tpPenggunaanBB.Name = "tpPenggunaanBB"
            Me.tpPenggunaanBB.Size = New System.Drawing.Size(1202, 553)
            Me.tpPenggunaanBB.TabIndex = 2
            Me.tpPenggunaanBB.Text = "Penggunaan Bahan Baku"
            '
            'lblTitlePenggunaanBB
            '
            Me.lblTitlePenggunaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePenggunaanBB.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitlePenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.lblTitlePenggunaanBB.Location = New System.Drawing.Point(378, 6)
            Me.lblTitlePenggunaanBB.Name = "lblTitlePenggunaanBB"
            Me.lblTitlePenggunaanBB.Size = New System.Drawing.Size(517, 35)
            Me.lblTitlePenggunaanBB.TabIndex = 0
            Me.lblTitlePenggunaanBB.Text = "PENGGUNAAN BAHAN BAKU"
            Me.lblTitlePenggunaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPenggunaanBB
            '
            Me.pnlPenggunaanBB.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanTanggal)
            Me.pnlPenggunaanBB.Controls.Add(Me.dtpPenggunaanTanggal)
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanPengerjaan)
            Me.pnlPenggunaanBB.Controls.Add(Me.txtPenggunaanPengerjaan)
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanKode)
            Me.pnlPenggunaanBB.Controls.Add(Me.txtPenggunaanKode)
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanNama)
            Me.pnlPenggunaanBB.Controls.Add(Me.txtPenggunaanNama)
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanJumlah)
            Me.pnlPenggunaanBB.Controls.Add(Me.txtPenggunaanJumlah)
            Me.pnlPenggunaanBB.Controls.Add(Me.lbltxtPenggunaanSatuan)
            Me.pnlPenggunaanBB.Controls.Add(Me.txtPenggunaanSatuan)
            Me.pnlPenggunaanBB.Controls.Add(Me.btnTambahPenggunaanBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.btnUbahPenggunaanBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.btnHapusPenggunaanBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.btnBersihkanPenggunaanBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.lblKondisiPenggunaanBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.cmbKondisiBB)
            Me.pnlPenggunaanBB.Controls.Add(Me.btnLaporkanBB)
            Me.pnlPenggunaanBB.Location = New System.Drawing.Point(20, 55)
            Me.pnlPenggunaanBB.Name = "pnlPenggunaanBB"
            Me.pnlPenggunaanBB.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPenggunaanBB.TabIndex = 1
            '
            'lbltxtPenggunaanTanggal
            '
            Me.lbltxtPenggunaanTanggal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanTanggal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanTanggal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanTanggal.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtPenggunaanTanggal.Name = "lbltxtPenggunaanTanggal"
            Me.lbltxtPenggunaanTanggal.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanTanggal.TabIndex = 0
            Me.lbltxtPenggunaanTanggal.Text = "Tanggal"
            Me.lbltxtPenggunaanTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPenggunaanTanggal
            '
            Me.dtpPenggunaanTanggal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPenggunaanTanggal.Location = New System.Drawing.Point(15, 43)
            Me.dtpPenggunaanTanggal.Name = "dtpPenggunaanTanggal"
            Me.dtpPenggunaanTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPenggunaanTanggal.CustomFormat = "dd/MM/yyyy"
            Me.dtpPenggunaanTanggal.Size = New System.Drawing.Size(176, 30)
            Me.dtpPenggunaanTanggal.TabIndex = 1
            '
            'lbltxtPenggunaanPengerjaan
            '
            Me.lbltxtPenggunaanPengerjaan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanPengerjaan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanPengerjaan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanPengerjaan.Location = New System.Drawing.Point(203, 16)
            Me.lbltxtPenggunaanPengerjaan.Name = "lbltxtPenggunaanPengerjaan"
            Me.lbltxtPenggunaanPengerjaan.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanPengerjaan.TabIndex = 2
            Me.lbltxtPenggunaanPengerjaan.Text = "No. Pengerjaan"
            Me.lbltxtPenggunaanPengerjaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenggunaanPengerjaan
            '
            Me.txtPenggunaanPengerjaan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenggunaanPengerjaan.Location = New System.Drawing.Point(203, 43)
            Me.txtPenggunaanPengerjaan.Name = "txtPenggunaanPengerjaan"
            Me.txtPenggunaanPengerjaan.Size = New System.Drawing.Size(176, 30)
            Me.txtPenggunaanPengerjaan.TabIndex = 3
            '
            'lbltxtPenggunaanKode
            '
            Me.lbltxtPenggunaanKode.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanKode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanKode.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanKode.Location = New System.Drawing.Point(391, 16)
            Me.lbltxtPenggunaanKode.Name = "lbltxtPenggunaanKode"
            Me.lbltxtPenggunaanKode.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanKode.TabIndex = 4
            Me.lbltxtPenggunaanKode.Text = "Kode BB"
            Me.lbltxtPenggunaanKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenggunaanKode
            '
            Me.txtPenggunaanKode.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenggunaanKode.Location = New System.Drawing.Point(391, 43)
            Me.txtPenggunaanKode.Name = "txtPenggunaanKode"
            Me.txtPenggunaanKode.Size = New System.Drawing.Size(176, 30)
            Me.txtPenggunaanKode.TabIndex = 5
            '
            'lbltxtPenggunaanNama
            '
            Me.lbltxtPenggunaanNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanNama.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanNama.Location = New System.Drawing.Point(579, 16)
            Me.lbltxtPenggunaanNama.Name = "lbltxtPenggunaanNama"
            Me.lbltxtPenggunaanNama.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanNama.TabIndex = 6
            Me.lbltxtPenggunaanNama.Text = "Nama Bahan Baku"
            Me.lbltxtPenggunaanNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenggunaanNama
            '
            Me.txtPenggunaanNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenggunaanNama.Location = New System.Drawing.Point(579, 43)
            Me.txtPenggunaanNama.Name = "txtPenggunaanNama"
            Me.txtPenggunaanNama.Size = New System.Drawing.Size(176, 30)
            Me.txtPenggunaanNama.TabIndex = 7
            '
            'lbltxtPenggunaanJumlah
            '
            Me.lbltxtPenggunaanJumlah.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanJumlah.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanJumlah.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanJumlah.Location = New System.Drawing.Point(767, 16)
            Me.lbltxtPenggunaanJumlah.Name = "lbltxtPenggunaanJumlah"
            Me.lbltxtPenggunaanJumlah.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanJumlah.TabIndex = 8
            Me.lbltxtPenggunaanJumlah.Text = "Jumlah"
            Me.lbltxtPenggunaanJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenggunaanJumlah
            '
            Me.txtPenggunaanJumlah.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenggunaanJumlah.Location = New System.Drawing.Point(767, 43)
            Me.txtPenggunaanJumlah.Name = "txtPenggunaanJumlah"
            Me.txtPenggunaanJumlah.Size = New System.Drawing.Size(176, 30)
            Me.txtPenggunaanJumlah.TabIndex = 9
            '
            'lbltxtPenggunaanSatuan
            '
            Me.lbltxtPenggunaanSatuan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPenggunaanSatuan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPenggunaanSatuan.ForeColor = System.Drawing.Color.White
            Me.lbltxtPenggunaanSatuan.Location = New System.Drawing.Point(955, 16)
            Me.lbltxtPenggunaanSatuan.Name = "lbltxtPenggunaanSatuan"
            Me.lbltxtPenggunaanSatuan.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPenggunaanSatuan.TabIndex = 10
            Me.lbltxtPenggunaanSatuan.Text = "Satuan"
            Me.lbltxtPenggunaanSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPenggunaanSatuan
            '
            Me.txtPenggunaanSatuan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPenggunaanSatuan.Location = New System.Drawing.Point(955, 43)
            Me.txtPenggunaanSatuan.Name = "txtPenggunaanSatuan"
            Me.txtPenggunaanSatuan.Size = New System.Drawing.Size(176, 30)
            Me.txtPenggunaanSatuan.TabIndex = 11
            '
            'btnTambahPenggunaanBB
            '
            Me.btnTambahPenggunaanBB.BackColor = System.Drawing.Color.Teal
            Me.btnTambahPenggunaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.btnTambahPenggunaanBB.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahPenggunaanBB.Name = "btnTambahPenggunaanBB"
            Me.btnTambahPenggunaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPenggunaanBB.TabIndex = 12
            Me.btnTambahPenggunaanBB.Text = "Tambah"
            Me.btnTambahPenggunaanBB.UseVisualStyleBackColor = False
            '
            'btnUbahPenggunaanBB
            '
            Me.btnUbahPenggunaanBB.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahPenggunaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.btnUbahPenggunaanBB.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPenggunaanBB.Name = "btnUbahPenggunaanBB"
            Me.btnUbahPenggunaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPenggunaanBB.TabIndex = 13
            Me.btnUbahPenggunaanBB.Text = "Ubah"
            Me.btnUbahPenggunaanBB.UseVisualStyleBackColor = False
            '
            'btnHapusPenggunaanBB
            '
            Me.btnHapusPenggunaanBB.BackColor = System.Drawing.Color.Brown
            Me.btnHapusPenggunaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.btnHapusPenggunaanBB.Location = New System.Drawing.Point(239, 105)
            Me.btnHapusPenggunaanBB.Name = "btnHapusPenggunaanBB"
            Me.btnHapusPenggunaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPenggunaanBB.TabIndex = 14
            Me.btnHapusPenggunaanBB.Text = "Hapus"
            Me.btnHapusPenggunaanBB.UseVisualStyleBackColor = False
            '
            'btnBersihkanPenggunaanBB
            '
            Me.btnBersihkanPenggunaanBB.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanPenggunaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPenggunaanBB.Location = New System.Drawing.Point(351, 105)
            Me.btnBersihkanPenggunaanBB.Name = "btnBersihkanPenggunaanBB"
            Me.btnBersihkanPenggunaanBB.Size = New System.Drawing.Size(126, 34)
            Me.btnBersihkanPenggunaanBB.TabIndex = 15
            Me.btnBersihkanPenggunaanBB.Text = "Bersihkan"
            Me.btnBersihkanPenggunaanBB.UseVisualStyleBackColor = False
            '
            'lblKondisiPenggunaanBB
            '
            Me.lblKondisiPenggunaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblKondisiPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblKondisiPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.lblKondisiPenggunaanBB.Location = New System.Drawing.Point(520, 105)
            Me.lblKondisiPenggunaanBB.Name = "lblKondisiPenggunaanBB"
            Me.lblKondisiPenggunaanBB.Size = New System.Drawing.Size(110, 25)
            Me.lblKondisiPenggunaanBB.TabIndex = 16
            Me.lblKondisiPenggunaanBB.Text = "Kondisi Stok"
            Me.lblKondisiPenggunaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'cmbKondisiBB
            '
            Me.cmbKondisiBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKondisiBB.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.cmbKondisiBB.FormattingEnabled = True
            Me.cmbKondisiBB.Items.AddRange(New Object() {"Normal", "Hampir Habis", "Tidak Tersedia"})
            Me.cmbKondisiBB.Location = New System.Drawing.Point(625, 106)
            Me.cmbKondisiBB.Name = "cmbKondisiBB"
            Me.cmbKondisiBB.Size = New System.Drawing.Size(160, 29)
            Me.cmbKondisiBB.TabIndex = 17
            '
            'btnLaporkanBB
            '
            Me.btnLaporkanBB.BackColor = System.Drawing.Color.DarkSeaGreen
            Me.btnLaporkanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLaporkanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLaporkanBB.ForeColor = System.Drawing.Color.White
            Me.btnLaporkanBB.Location = New System.Drawing.Point(805, 102)
            Me.btnLaporkanBB.Name = "btnLaporkanBB"
            Me.btnLaporkanBB.Size = New System.Drawing.Size(160, 36)
            Me.btnLaporkanBB.TabIndex = 18
            Me.btnLaporkanBB.Text = "Laporkan Kondisi"
            Me.btnLaporkanBB.UseVisualStyleBackColor = False
            '
            'dgvPenggunaanBB
            '
            Me.dgvPenggunaanBB.AllowUserToAddRows = False
            Me.dgvPenggunaanBB.AllowUserToDeleteRows = False
            Me.dgvPenggunaanBB.AllowUserToResizeRows = False
            Me.dgvPenggunaanBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPenggunaanBB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPenggunaanBB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPenggunaanBB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPenggunaanBBCol1, Me.dgvPenggunaanBBCol2, Me.dgvPenggunaanBBCol3, Me.dgvPenggunaanBBCol4, Me.dgvPenggunaanBBCol5, Me.dgvPenggunaanBBCol6, Me.dgvPenggunaanBBCol7})
            Me.dgvPenggunaanBB.GridColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPenggunaanBB.Location = New System.Drawing.Point(20, 230)
            Me.dgvPenggunaanBB.MultiSelect = False
            Me.dgvPenggunaanBB.Name = "dgvPenggunaanBB"
            Me.dgvPenggunaanBB.ReadOnly = True
            Me.dgvPenggunaanBB.RowHeadersVisible = False
            Me.dgvPenggunaanBB.RowHeadersWidth = 51
            Me.dgvPenggunaanBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPenggunaanBB.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPenggunaanBB.TabIndex = 2
            '
            'dgvPenggunaanBBCol1
            '
            Me.dgvPenggunaanBBCol1.HeaderText = "Tanggal"
            Me.dgvPenggunaanBBCol1.MinimumWidth = 6
            Me.dgvPenggunaanBBCol1.Name = "dgvPenggunaanBBCol1"
            Me.dgvPenggunaanBBCol1.ReadOnly = True
            Me.dgvPenggunaanBBCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol2
            '
            Me.dgvPenggunaanBBCol2.HeaderText = "No. Pengerjaan"
            Me.dgvPenggunaanBBCol2.MinimumWidth = 6
            Me.dgvPenggunaanBBCol2.Name = "dgvPenggunaanBBCol2"
            Me.dgvPenggunaanBBCol2.ReadOnly = True
            Me.dgvPenggunaanBBCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol3
            '
            Me.dgvPenggunaanBBCol3.HeaderText = "Kode BB"
            Me.dgvPenggunaanBBCol3.MinimumWidth = 6
            Me.dgvPenggunaanBBCol3.Name = "dgvPenggunaanBBCol3"
            Me.dgvPenggunaanBBCol3.ReadOnly = True
            Me.dgvPenggunaanBBCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol4
            '
            Me.dgvPenggunaanBBCol4.HeaderText = "Nama Bahan Baku"
            Me.dgvPenggunaanBBCol4.MinimumWidth = 6
            Me.dgvPenggunaanBBCol4.Name = "dgvPenggunaanBBCol4"
            Me.dgvPenggunaanBBCol4.ReadOnly = True
            Me.dgvPenggunaanBBCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol5
            '
            Me.dgvPenggunaanBBCol5.HeaderText = "Jumlah"
            Me.dgvPenggunaanBBCol5.MinimumWidth = 6
            Me.dgvPenggunaanBBCol5.Name = "dgvPenggunaanBBCol5"
            Me.dgvPenggunaanBBCol5.ReadOnly = True
            Me.dgvPenggunaanBBCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol6
            '
            Me.dgvPenggunaanBBCol6.HeaderText = "Satuan"
            Me.dgvPenggunaanBBCol6.MinimumWidth = 6
            Me.dgvPenggunaanBBCol6.Name = "dgvPenggunaanBBCol6"
            Me.dgvPenggunaanBBCol6.ReadOnly = True
            Me.dgvPenggunaanBBCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPenggunaanBBCol7
            '
            Me.dgvPenggunaanBBCol7.HeaderText = "Kondisi/Laporan"
            Me.dgvPenggunaanBBCol7.MinimumWidth = 6
            Me.dgvPenggunaanBBCol7.Name = "dgvPenggunaanBBCol7"
            Me.dgvPenggunaanBBCol7.ReadOnly = True
            Me.dgvPenggunaanBBCol7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
            Me.Panel1.Controls.Add(Me.lblBrand)
            Me.Panel1.Controls.Add(Me.lblActor)
            Me.Panel1.Controls.Add(Me.btnLogout)
            Me.Panel1.Controls.Add(Me.PictureBox1)
            Me.Panel1.Location = New System.Drawing.Point(1, -6)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1254, 100)
            Me.Panel1.TabIndex = 18
            '
            'lblBrand
            '
            Me.lblBrand.BackColor = System.Drawing.Color.Transparent
            Me.lblBrand.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblBrand.ForeColor = System.Drawing.Color.White
            Me.lblBrand.Location = New System.Drawing.Point(104, 23)
            Me.lblBrand.Name = "lblBrand"
            Me.lblBrand.Size = New System.Drawing.Size(940, 45)
            Me.lblBrand.TabIndex = 9
            Me.lblBrand.Text = " SISTEM INFORMASI PENGELOLAAN SERVIS SEPATU Shoelusi"
            Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblActor
            '
            Me.lblActor.BackColor = System.Drawing.Color.Transparent
            Me.lblActor.Font = New System.Drawing.Font("Lucida Bright", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblActor.ForeColor = System.Drawing.Color.White
            Me.lblActor.Location = New System.Drawing.Point(1102, 8)
            Me.lblActor.Name = "lblActor"
            Me.lblActor.Size = New System.Drawing.Size(123, 45)
            Me.lblActor.TabIndex = 10
            Me.lblActor.Text = "Teknisi"
            Me.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.SteelBlue
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(1102, 56)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(135, 34)
            Me.btnLogout.TabIndex = 11
            Me.btnLogout.Text = "Keluar Akun"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.Resources.shoelusi_logo
            Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(86, 67)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 8
            Me.PictureBox1.TabStop = False
            '
            'FrmTeknisi
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CadetBlue
            Me.ClientSize = New System.Drawing.Size(1250, 710)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.tabMain)
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "FrmTeknisi"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Teknisi"
            Me.tabMain.ResumeLayout(False)
            Me.tpCekPesanan.ResumeLayout(False)
            Me.tpCekPesanan.PerformLayout()
            CType(Me.dgvCekPesanan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpPengerjaan.ResumeLayout(False)
            Me.pnlPengerjaan.ResumeLayout(False)
            Me.pnlPengerjaan.PerformLayout()
            CType(Me.dgvPengerjaan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpPenggunaanBB.ResumeLayout(False)
            Me.pnlPenggunaanBB.ResumeLayout(False)
            Me.pnlPenggunaanBB.PerformLayout()
            CType(Me.dgvPenggunaanBB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tpCekPesanan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleCekPesanan As System.Windows.Forms.Label
        Friend WithEvents txtCariCekPesanan As System.Windows.Forms.TextBox
        Friend WithEvents lblCariCekPesanan As System.Windows.Forms.Label
        Friend WithEvents dgvCekPesanan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCekPesananCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPesananCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPesananCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPesananCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPesananCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPesananCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpPengerjaan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePengerjaan As System.Windows.Forms.Label
        Friend WithEvents pnlPengerjaan As System.Windows.Forms.Panel
        Friend WithEvents lbltxtPengerjaanNo As System.Windows.Forms.Label
        Friend WithEvents txtPengerjaanNo As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPengerjaanPesanan As System.Windows.Forms.Label
        Friend WithEvents txtPengerjaanPesanan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPengerjaanMulai As System.Windows.Forms.Label
        Friend WithEvents dtpPengerjaanMulai As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPengerjaanSelesai As System.Windows.Forms.Label
        Friend WithEvents dtpPengerjaanSelesai As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPengerjaanStatus As System.Windows.Forms.Label
        Friend WithEvents txtPengerjaanStatus As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPengerjaan As System.Windows.Forms.Button
        Friend WithEvents btnUbahPengerjaan As System.Windows.Forms.Button
        Friend WithEvents btnHapusPengerjaan As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPengerjaan As System.Windows.Forms.Button
        Friend WithEvents dgvPengerjaan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPengerjaanCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengerjaanCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengerjaanCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengerjaanCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengerjaanCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpPenggunaanBB As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePenggunaanBB As System.Windows.Forms.Label
        Friend WithEvents pnlPenggunaanBB As System.Windows.Forms.Panel
        Friend WithEvents lbltxtPenggunaanTanggal As System.Windows.Forms.Label
        Friend WithEvents dtpPenggunaanTanggal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPenggunaanPengerjaan As System.Windows.Forms.Label
        Friend WithEvents txtPenggunaanPengerjaan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenggunaanKode As System.Windows.Forms.Label
        Friend WithEvents txtPenggunaanKode As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenggunaanNama As System.Windows.Forms.Label
        Friend WithEvents txtPenggunaanNama As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenggunaanJumlah As System.Windows.Forms.Label
        Friend WithEvents txtPenggunaanJumlah As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPenggunaanSatuan As System.Windows.Forms.Label
        Friend WithEvents txtPenggunaanSatuan As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPenggunaanBB As System.Windows.Forms.Button
        Friend WithEvents btnUbahPenggunaanBB As System.Windows.Forms.Button
        Friend WithEvents btnHapusPenggunaanBB As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPenggunaanBB As System.Windows.Forms.Button
        Friend WithEvents lblKondisiPenggunaanBB As System.Windows.Forms.Label
        Friend WithEvents cmbKondisiBB As System.Windows.Forms.ComboBox
        Friend WithEvents btnLaporkanBB As System.Windows.Forms.Button
        Friend WithEvents dgvPenggunaanBB As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPenggunaanBBCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPenggunaanBBCol7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents lblActor As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace
