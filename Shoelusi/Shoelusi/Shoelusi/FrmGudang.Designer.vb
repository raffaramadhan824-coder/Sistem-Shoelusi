Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmGudang
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
            Me.components = New System.ComponentModel.Container()
            Me.tabMain = New System.Windows.Forms.TabControl()
            Me.tpPersediaanBB = New System.Windows.Forms.TabPage()
            Me.lblTitlePersediaanBB = New System.Windows.Forms.Label()
            Me.pnlPersediaanBB = New System.Windows.Forms.Panel()
            Me.lbltxtStokKode = New System.Windows.Forms.Label()
            Me.txtStokKode = New System.Windows.Forms.TextBox()
            Me.lbltxtStokNama = New System.Windows.Forms.Label()
            Me.txtStokNama = New System.Windows.Forms.TextBox()
            Me.lbltxtStokJumlah = New System.Windows.Forms.Label()
            Me.txtStokJumlah = New System.Windows.Forms.TextBox()
            Me.lbltxtStokSatuan = New System.Windows.Forms.Label()
            Me.txtStokSatuan = New System.Windows.Forms.TextBox()
            Me.lbltxtStokMinimum = New System.Windows.Forms.Label()
            Me.lbltxtStokJenis = New System.Windows.Forms.Label()
            Me.lbltxtStokHarga = New System.Windows.Forms.Label()
            Me.txtStokMinimum = New System.Windows.Forms.TextBox()
            Me.txtStokJenis = New System.Windows.Forms.TextBox()
            Me.txtStokHarga = New System.Windows.Forms.TextBox()
            Me.btnTambahPersediaanBB = New System.Windows.Forms.Button()
            Me.btnUbahPersediaanBB = New System.Windows.Forms.Button()
            Me.btnHapusPersediaanBB = New System.Windows.Forms.Button()
            Me.btnBersihkanPersediaanBB = New System.Windows.Forms.Button()
            Me.dgvPersediaanBB = New System.Windows.Forms.DataGridView()
            Me.dgvPersediaanBBCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersediaanBBCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersediaanBBCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersediaanBBCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersediaanBBCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpPengadaanBB = New System.Windows.Forms.TabPage()
            Me.lblTitlePengadaanBB = New System.Windows.Forms.Label()
            Me.pnlPengadaanBB = New System.Windows.Forms.Panel()
            Me.lbltxtPengadaanNo = New System.Windows.Forms.Label()
            Me.txtPengadaanNo = New System.Windows.Forms.TextBox()
            Me.lbltxtPengadaanTanggal = New System.Windows.Forms.Label()
            Me.dtpPengadaanTanggal = New System.Windows.Forms.DateTimePicker()
            Me.lbltxtPengadaanNama = New System.Windows.Forms.Label()
            Me.txtPengadaanNama = New System.Windows.Forms.TextBox()
            Me.lbltxtPengadaanJumlah = New System.Windows.Forms.Label()
            Me.txtPengadaanJumlah = New System.Windows.Forms.TextBox()
            Me.lbltxtPengadaanStatus = New System.Windows.Forms.Label()
            Me.lbltxtPengadaanHarga = New System.Windows.Forms.Label()
            Me.lbltxtPengadaanTotal = New System.Windows.Forms.Label()
            Me.txtPengadaanStatus = New System.Windows.Forms.TextBox()
            Me.txtPengadaanHarga = New System.Windows.Forms.TextBox()
            Me.txtPengadaanTotal = New System.Windows.Forms.TextBox()
            Me.btnTambahPengadaanBB = New System.Windows.Forms.Button()
            Me.btnUbahPengadaanBB = New System.Windows.Forms.Button()
            Me.btnHapusPengadaanBB = New System.Windows.Forms.Button()
            Me.btnBersihkanPengadaanBB = New System.Windows.Forms.Button()
            Me.dgvPengadaanBB = New System.Windows.Forms.DataGridView()
            Me.tpCekPenggunaanBB = New System.Windows.Forms.TabPage()
            Me.lblTitleCekPenggunaanBB = New System.Windows.Forms.Label()
            Me.txtCariCekPenggunaanBB = New System.Windows.Forms.TextBox()
            Me.lblCariCekPenggunaanBB = New System.Windows.Forms.Label()
            Me.dgvCekPenggunaanBB = New System.Windows.Forms.DataGridView()
            Me.dgvCekPenggunaanBBCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenggunaanBBCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenggunaanBBCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenggunaanBBCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenggunaanBBCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenggunaanBBCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpCekPenjualan = New System.Windows.Forms.TabPage()
            Me.lblTitleCekPenjualan = New System.Windows.Forms.Label()
            Me.txtCariCekPenjualan = New System.Windows.Forms.TextBox()
            Me.lblCariCekPenjualan = New System.Windows.Forms.Label()
            Me.dgvCekPenjualan = New System.Windows.Forms.DataGridView()
            Me.dgvCekPenjualanCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenjualanCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenjualanCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenjualanCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvCekPenjualanCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpHitungEOQ = New System.Windows.Forms.TabPage()
            Me.lblTitleHitungEOQ = New System.Windows.Forms.Label()
            Me.pnlHitungEOQ = New System.Windows.Forms.Panel()
            Me.txthasileoq = New System.Windows.Forms.TextBox()
            Me.lbltxtEOQD = New System.Windows.Forms.Label()
            Me.txtEOQD = New System.Windows.Forms.TextBox()
            Me.lbltxtEOQS = New System.Windows.Forms.Label()
            Me.txtEOQS = New System.Windows.Forms.TextBox()
            Me.lbltxtEOQH = New System.Windows.Forms.Label()
            Me.txtEOQH = New System.Windows.Forms.TextBox()
            Me.lbltxtEOQNama = New System.Windows.Forms.Label()
            Me.txtEOQNama = New System.Windows.Forms.TextBox()
            Me.btnHitungEOQ = New System.Windows.Forms.Button()
            Me.btnResetEOQ = New System.Windows.Forms.Button()
            Me.lblHasilEOQ = New System.Windows.Forms.Label()
            Me.dgvHitungEOQ = New System.Windows.Forms.DataGridView()
            Me.dgvHitungEOQCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungEOQCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungEOQCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungEOQCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungEOQCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpHitungROP = New System.Windows.Forms.TabPage()
            Me.lblTitleHitungROP = New System.Windows.Forms.Label()
            Me.pnlHitungROP = New System.Windows.Forms.Panel()
            Me.txtreoderpoint = New System.Windows.Forms.TextBox()
            Me.txtsafetystock = New System.Windows.Forms.TextBox()
            Me.lbltxtROPAvg = New System.Windows.Forms.Label()
            Me.txtROPAvg = New System.Windows.Forms.TextBox()
            Me.lbltxtROPMax = New System.Windows.Forms.Label()
            Me.txtROPMax = New System.Windows.Forms.TextBox()
            Me.lbltxtROPLTAvg = New System.Windows.Forms.Label()
            Me.txtROPLTAvg = New System.Windows.Forms.TextBox()
            Me.lbltxtROPLTMax = New System.Windows.Forms.Label()
            Me.txtROPLTMax = New System.Windows.Forms.TextBox()
            Me.btnHitungROP = New System.Windows.Forms.Button()
            Me.btnResetROP = New System.Windows.Forms.Button()
            Me.lblHasilSS = New System.Windows.Forms.Label()
            Me.lblHasilROP = New System.Windows.Forms.Label()
            Me.dgvHitungROP = New System.Windows.Forms.DataGridView()
            Me.dgvHitungROPCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvHitungROPCol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.lblBrand = New System.Windows.Forms.Label()
            Me.lblActor = New System.Windows.Forms.Label()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.dgvPengadaanBBCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengadaanBBCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengadaanBBCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengadaanBBCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPengadaanBBCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tabMain.SuspendLayout()
            Me.tpPersediaanBB.SuspendLayout()
            Me.pnlPersediaanBB.SuspendLayout()
            CType(Me.dgvPersediaanBB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpPengadaanBB.SuspendLayout()
            Me.pnlPengadaanBB.SuspendLayout()
            CType(Me.dgvPengadaanBB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCekPenggunaanBB.SuspendLayout()
            CType(Me.dgvCekPenggunaanBB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCekPenjualan.SuspendLayout()
            CType(Me.dgvCekPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpHitungEOQ.SuspendLayout()
            Me.pnlHitungEOQ.SuspendLayout()
            CType(Me.dgvHitungEOQ, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpHitungROP.SuspendLayout()
            Me.pnlHitungROP.SuspendLayout()
            CType(Me.dgvHitungROP, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tabMain
            '
            Me.tabMain.Controls.Add(Me.tpPersediaanBB)
            Me.tabMain.Controls.Add(Me.tpPengadaanBB)
            Me.tabMain.Controls.Add(Me.tpCekPenggunaanBB)
            Me.tabMain.Controls.Add(Me.tpCekPenjualan)
            Me.tabMain.Controls.Add(Me.tpHitungEOQ)
            Me.tabMain.Controls.Add(Me.tpHitungROP)
            Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabMain.Location = New System.Drawing.Point(20, 100)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(1210, 590)
            Me.tabMain.TabIndex = 3
            '
            'tpPersediaanBB
            '
            Me.tpPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(181, Byte), Integer))
            Me.tpPersediaanBB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tpPersediaanBB.Controls.Add(Me.lblTitlePersediaanBB)
            Me.tpPersediaanBB.Controls.Add(Me.pnlPersediaanBB)
            Me.tpPersediaanBB.Controls.Add(Me.dgvPersediaanBB)
            Me.tpPersediaanBB.Location = New System.Drawing.Point(4, 33)
            Me.tpPersediaanBB.Name = "tpPersediaanBB"
            Me.tpPersediaanBB.Size = New System.Drawing.Size(1202, 553)
            Me.tpPersediaanBB.TabIndex = 0
            Me.tpPersediaanBB.Text = "Persediaan Bahan Baku"
            '
            'lblTitlePersediaanBB
            '
            Me.lblTitlePersediaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePersediaanBB.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitlePersediaanBB.ForeColor = System.Drawing.Color.White
            Me.lblTitlePersediaanBB.Location = New System.Drawing.Point(22, 12)
            Me.lblTitlePersediaanBB.Name = "lblTitlePersediaanBB"
            Me.lblTitlePersediaanBB.Size = New System.Drawing.Size(1120, 35)
            Me.lblTitlePersediaanBB.TabIndex = 0
            Me.lblTitlePersediaanBB.Text = "PERSEDIAAN BAHAN BAKU"
            Me.lblTitlePersediaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPersediaanBB
            '
            Me.pnlPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokKode)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokKode)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokNama)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokNama)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokJumlah)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokJumlah)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokSatuan)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokSatuan)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokMinimum)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokJenis)
            Me.pnlPersediaanBB.Controls.Add(Me.lbltxtStokHarga)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokMinimum)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokJenis)
            Me.pnlPersediaanBB.Controls.Add(Me.txtStokHarga)
            Me.pnlPersediaanBB.Controls.Add(Me.btnTambahPersediaanBB)
            Me.pnlPersediaanBB.Controls.Add(Me.btnUbahPersediaanBB)
            Me.pnlPersediaanBB.Controls.Add(Me.btnHapusPersediaanBB)
            Me.pnlPersediaanBB.Controls.Add(Me.btnBersihkanPersediaanBB)
            Me.pnlPersediaanBB.Location = New System.Drawing.Point(20, 55)
            Me.pnlPersediaanBB.Name = "pnlPersediaanBB"
            Me.pnlPersediaanBB.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPersediaanBB.TabIndex = 1
            '
            'lbltxtStokKode
            '
            Me.lbltxtStokKode.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokKode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokKode.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokKode.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtStokKode.Name = "lbltxtStokKode"
            Me.lbltxtStokKode.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtStokKode.TabIndex = 0
            Me.lbltxtStokKode.Text = "Kode BB"
            Me.lbltxtStokKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokKode
            '
            Me.txtStokKode.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokKode.Location = New System.Drawing.Point(15, 43)
            Me.txtStokKode.Name = "txtStokKode"
            Me.txtStokKode.Size = New System.Drawing.Size(190, 30)
            Me.txtStokKode.TabIndex = 1
            '
            'lbltxtStokNama
            '
            Me.lbltxtStokNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokNama.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokNama.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtStokNama.Name = "lbltxtStokNama"
            Me.lbltxtStokNama.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtStokNama.TabIndex = 2
            Me.lbltxtStokNama.Text = "Nama Bahan Baku"
            Me.lbltxtStokNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokNama
            '
            Me.txtStokNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokNama.Location = New System.Drawing.Point(217, 43)
            Me.txtStokNama.Name = "txtStokNama"
            Me.txtStokNama.Size = New System.Drawing.Size(190, 30)
            Me.txtStokNama.TabIndex = 3
            '
            'lbltxtStokJumlah
            '
            Me.lbltxtStokJumlah.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokJumlah.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokJumlah.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokJumlah.Location = New System.Drawing.Point(419, 16)
            Me.lbltxtStokJumlah.Name = "lbltxtStokJumlah"
            Me.lbltxtStokJumlah.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtStokJumlah.TabIndex = 4
            Me.lbltxtStokJumlah.Text = "Jumlah Stok"
            Me.lbltxtStokJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokJumlah
            '
            Me.txtStokJumlah.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokJumlah.Location = New System.Drawing.Point(419, 43)
            Me.txtStokJumlah.Name = "txtStokJumlah"
            Me.txtStokJumlah.Size = New System.Drawing.Size(190, 30)
            Me.txtStokJumlah.TabIndex = 5
            '
            'lbltxtStokSatuan
            '
            Me.lbltxtStokSatuan.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokSatuan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokSatuan.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokSatuan.Location = New System.Drawing.Point(621, 16)
            Me.lbltxtStokSatuan.Name = "lbltxtStokSatuan"
            Me.lbltxtStokSatuan.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtStokSatuan.TabIndex = 6
            Me.lbltxtStokSatuan.Text = "Satuan"
            Me.lbltxtStokSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokSatuan
            '
            Me.txtStokSatuan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokSatuan.Location = New System.Drawing.Point(621, 43)
            Me.txtStokSatuan.Name = "txtStokSatuan"
            Me.txtStokSatuan.Size = New System.Drawing.Size(190, 30)
            Me.txtStokSatuan.TabIndex = 7
            '
            'lbltxtStokMinimum
            '
            Me.lbltxtStokMinimum.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokMinimum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokMinimum.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokMinimum.Location = New System.Drawing.Point(823, 16)
            Me.lbltxtStokMinimum.Name = "lbltxtStokMinimum"
            Me.lbltxtStokMinimum.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtStokMinimum.TabIndex = 8
            Me.lbltxtStokMinimum.Text = "Stok Minimum"
            Me.lbltxtStokMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokMinimum
            '
            Me.txtStokMinimum.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokMinimum.Location = New System.Drawing.Point(823, 43)
            Me.txtStokMinimum.Name = "txtStokMinimum"
            Me.txtStokMinimum.Size = New System.Drawing.Size(190, 30)
            Me.txtStokMinimum.TabIndex = 9
            '
            'lbltxtStokJenis
            '
            Me.lbltxtStokJenis.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokJenis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokJenis.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokJenis.Location = New System.Drawing.Point(1018, 16)
            Me.lbltxtStokJenis.Name = "lbltxtStokJenis"
            Me.lbltxtStokJenis.Size = New System.Drawing.Size(120, 23)
            Me.lbltxtStokJenis.TabIndex = 10
            Me.lbltxtStokJenis.Text = "Jenis Bahan"
            Me.lbltxtStokJenis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokJenis
            '
            Me.txtStokJenis.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokJenis.Location = New System.Drawing.Point(1018, 43)
            Me.txtStokJenis.Name = "txtStokJenis"
            Me.txtStokJenis.Size = New System.Drawing.Size(120, 30)
            Me.txtStokJenis.TabIndex = 11
            '
            'lbltxtStokHarga
            '
            Me.lbltxtStokHarga.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtStokHarga.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtStokHarga.ForeColor = System.Drawing.Color.White
            Me.lbltxtStokHarga.Location = New System.Drawing.Point(258, 79)
            Me.lbltxtStokHarga.Name = "lbltxtStokHarga"
            Me.lbltxtStokHarga.Size = New System.Drawing.Size(180, 23)
            Me.lbltxtStokHarga.TabIndex = 20
            Me.lbltxtStokHarga.Text = "Harga Acuan (Rp)"
            Me.lbltxtStokHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStokHarga
            '
            Me.txtStokHarga.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtStokHarga.Location = New System.Drawing.Point(258, 106)
            Me.txtStokHarga.Name = "txtStokHarga"
            Me.txtStokHarga.Size = New System.Drawing.Size(180, 30)
            Me.txtStokHarga.TabIndex = 21
            '
            'btnTambahPersediaanBB
            '
            Me.btnTambahPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.btnTambahPersediaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPersediaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPersediaanBB.ForeColor = System.Drawing.Color.White
            Me.btnTambahPersediaanBB.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahPersediaanBB.Name = "btnTambahPersediaanBB"
            Me.btnTambahPersediaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPersediaanBB.TabIndex = 10
            Me.btnTambahPersediaanBB.Text = "Tambah"
            Me.btnTambahPersediaanBB.UseVisualStyleBackColor = False
            '
            'btnUbahPersediaanBB
            '
            Me.btnUbahPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnUbahPersediaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPersediaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPersediaanBB.ForeColor = System.Drawing.Color.White
            Me.btnUbahPersediaanBB.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPersediaanBB.Name = "btnUbahPersediaanBB"
            Me.btnUbahPersediaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPersediaanBB.TabIndex = 11
            Me.btnUbahPersediaanBB.Text = "Ubah"
            Me.btnUbahPersediaanBB.UseVisualStyleBackColor = False
            '
            'btnHapusPersediaanBB
            '
            Me.btnHapusPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnHapusPersediaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPersediaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusPersediaanBB.ForeColor = System.Drawing.Color.White
            Me.btnHapusPersediaanBB.Location = New System.Drawing.Point(239, 105)
            Me.btnHapusPersediaanBB.Name = "btnHapusPersediaanBB"
            Me.btnHapusPersediaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPersediaanBB.TabIndex = 12
            Me.btnHapusPersediaanBB.Text = "Hapus"
            Me.btnHapusPersediaanBB.UseVisualStyleBackColor = False
            '
            'btnBersihkanPersediaanBB
            '
            Me.btnBersihkanPersediaanBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnBersihkanPersediaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPersediaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPersediaanBB.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPersediaanBB.Location = New System.Drawing.Point(351, 105)
            Me.btnBersihkanPersediaanBB.Name = "btnBersihkanPersediaanBB"
            Me.btnBersihkanPersediaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnBersihkanPersediaanBB.TabIndex = 13
            Me.btnBersihkanPersediaanBB.Text = "Bersihkan"
            Me.btnBersihkanPersediaanBB.UseVisualStyleBackColor = False
            '
            'dgvPersediaanBB
            '
            Me.dgvPersediaanBB.AllowUserToAddRows = False
            Me.dgvPersediaanBB.AllowUserToDeleteRows = False
            Me.dgvPersediaanBB.AllowUserToResizeRows = False
            Me.dgvPersediaanBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPersediaanBB.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.dgvPersediaanBB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPersediaanBB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPersediaanBBCol1, Me.dgvPersediaanBBCol2, Me.dgvPersediaanBBCol3, Me.dgvPersediaanBBCol4, Me.dgvPersediaanBBCol5})
            Me.dgvPersediaanBB.Location = New System.Drawing.Point(20, 230)
            Me.dgvPersediaanBB.MultiSelect = False
            Me.dgvPersediaanBB.Name = "dgvPersediaanBB"
            Me.dgvPersediaanBB.ReadOnly = True
            Me.dgvPersediaanBB.RowHeadersVisible = False
            Me.dgvPersediaanBB.RowHeadersWidth = 51
            Me.dgvPersediaanBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersediaanBB.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPersediaanBB.TabIndex = 2
            '
            'dgvPersediaanBBCol1
            '
            Me.dgvPersediaanBBCol1.HeaderText = "Kode BB"
            Me.dgvPersediaanBBCol1.MinimumWidth = 6
            Me.dgvPersediaanBBCol1.Name = "dgvPersediaanBBCol1"
            Me.dgvPersediaanBBCol1.ReadOnly = True
            Me.dgvPersediaanBBCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersediaanBBCol2
            '
            Me.dgvPersediaanBBCol2.HeaderText = "Nama Bahan Baku"
            Me.dgvPersediaanBBCol2.MinimumWidth = 6
            Me.dgvPersediaanBBCol2.Name = "dgvPersediaanBBCol2"
            Me.dgvPersediaanBBCol2.ReadOnly = True
            Me.dgvPersediaanBBCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersediaanBBCol3
            '
            Me.dgvPersediaanBBCol3.HeaderText = "Stok"
            Me.dgvPersediaanBBCol3.MinimumWidth = 6
            Me.dgvPersediaanBBCol3.Name = "dgvPersediaanBBCol3"
            Me.dgvPersediaanBBCol3.ReadOnly = True
            Me.dgvPersediaanBBCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersediaanBBCol4
            '
            Me.dgvPersediaanBBCol4.HeaderText = "Satuan"
            Me.dgvPersediaanBBCol4.MinimumWidth = 6
            Me.dgvPersediaanBBCol4.Name = "dgvPersediaanBBCol4"
            Me.dgvPersediaanBBCol4.ReadOnly = True
            Me.dgvPersediaanBBCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersediaanBBCol5
            '
            Me.dgvPersediaanBBCol5.HeaderText = "Stok Minimum"
            Me.dgvPersediaanBBCol5.MinimumWidth = 6
            Me.dgvPersediaanBBCol5.Name = "dgvPersediaanBBCol5"
            Me.dgvPersediaanBBCol5.ReadOnly = True
            Me.dgvPersediaanBBCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpPengadaanBB
            '
            Me.tpPengadaanBB.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPengadaanBB.Controls.Add(Me.lblTitlePengadaanBB)
            Me.tpPengadaanBB.Controls.Add(Me.pnlPengadaanBB)
            Me.tpPengadaanBB.Controls.Add(Me.dgvPengadaanBB)
            Me.tpPengadaanBB.Location = New System.Drawing.Point(4, 31)
            Me.tpPengadaanBB.Name = "tpPengadaanBB"
            Me.tpPengadaanBB.Size = New System.Drawing.Size(1202, 555)
            Me.tpPengadaanBB.TabIndex = 1
            Me.tpPengadaanBB.Text = "Pengadaan Bahan Baku"
            '
            'lblTitlePengadaanBB
            '
            Me.lblTitlePengadaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePengadaanBB.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitlePengadaanBB.ForeColor = System.Drawing.Color.White
            Me.lblTitlePengadaanBB.Location = New System.Drawing.Point(392, 12)
            Me.lblTitlePengadaanBB.Name = "lblTitlePengadaanBB"
            Me.lblTitlePengadaanBB.Size = New System.Drawing.Size(497, 35)
            Me.lblTitlePengadaanBB.TabIndex = 0
            Me.lblTitlePengadaanBB.Text = "PENGADAAN BAHAN BAKU"
            Me.lblTitlePengadaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlPengadaanBB
            '
            Me.pnlPengadaanBB.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanNo)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanNo)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanTanggal)
            Me.pnlPengadaanBB.Controls.Add(Me.dtpPengadaanTanggal)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanNama)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanNama)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanJumlah)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanJumlah)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanStatus)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanHarga)
            Me.pnlPengadaanBB.Controls.Add(Me.lbltxtPengadaanTotal)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanStatus)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanHarga)
            Me.pnlPengadaanBB.Controls.Add(Me.txtPengadaanTotal)
            Me.pnlPengadaanBB.Controls.Add(Me.btnTambahPengadaanBB)
            Me.pnlPengadaanBB.Controls.Add(Me.btnUbahPengadaanBB)
            Me.pnlPengadaanBB.Controls.Add(Me.btnHapusPengadaanBB)
            Me.pnlPengadaanBB.Controls.Add(Me.btnBersihkanPengadaanBB)
            Me.pnlPengadaanBB.Location = New System.Drawing.Point(20, 55)
            Me.pnlPengadaanBB.Name = "pnlPengadaanBB"
            Me.pnlPengadaanBB.Size = New System.Drawing.Size(1150, 160)
            Me.pnlPengadaanBB.TabIndex = 1
            '
            'lbltxtPengadaanNo
            '
            Me.lbltxtPengadaanNo.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanNo.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanNo.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtPengadaanNo.Name = "lbltxtPengadaanNo"
            Me.lbltxtPengadaanNo.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPengadaanNo.TabIndex = 0
            Me.lbltxtPengadaanNo.Text = "No. Pengadaan"
            Me.lbltxtPengadaanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanNo
            '
            Me.txtPengadaanNo.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanNo.Location = New System.Drawing.Point(15, 43)
            Me.txtPengadaanNo.Name = "txtPengadaanNo"
            Me.txtPengadaanNo.Size = New System.Drawing.Size(176, 30)
            Me.txtPengadaanNo.TabIndex = 1
            '
            'lbltxtPengadaanTanggal
            '
            Me.lbltxtPengadaanTanggal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanTanggal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanTanggal.Location = New System.Drawing.Point(203, 16)
            Me.lbltxtPengadaanTanggal.Name = "lbltxtPengadaanTanggal"
            Me.lbltxtPengadaanTanggal.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPengadaanTanggal.TabIndex = 2
            Me.lbltxtPengadaanTanggal.Text = "Tanggal"
            Me.lbltxtPengadaanTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpPengadaanTanggal
            '
            Me.dtpPengadaanTanggal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.dtpPengadaanTanggal.Location = New System.Drawing.Point(203, 43)
            Me.dtpPengadaanTanggal.Name = "dtpPengadaanTanggal"
            Me.dtpPengadaanTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpPengadaanTanggal.CustomFormat = "dd/MM/yyyy"
            Me.dtpPengadaanTanggal.Size = New System.Drawing.Size(176, 30)
            Me.dtpPengadaanTanggal.TabIndex = 3
            '
            'lbltxtPengadaanNama
            '
            Me.lbltxtPengadaanNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanNama.Location = New System.Drawing.Point(417, 16)
            Me.lbltxtPengadaanNama.Name = "lbltxtPengadaanNama"
            Me.lbltxtPengadaanNama.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPengadaanNama.TabIndex = 6
            Me.lbltxtPengadaanNama.Text = "Kode Bahan"
            Me.lbltxtPengadaanNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanNama
            '
            Me.txtPengadaanNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanNama.Location = New System.Drawing.Point(417, 43)
            Me.txtPengadaanNama.Name = "txtPengadaanNama"
            Me.txtPengadaanNama.Size = New System.Drawing.Size(176, 30)
            Me.txtPengadaanNama.TabIndex = 7
            '
            'lbltxtPengadaanJumlah
            '
            Me.lbltxtPengadaanJumlah.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanJumlah.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanJumlah.Location = New System.Drawing.Point(624, 16)
            Me.lbltxtPengadaanJumlah.Name = "lbltxtPengadaanJumlah"
            Me.lbltxtPengadaanJumlah.Size = New System.Drawing.Size(176, 23)
            Me.lbltxtPengadaanJumlah.TabIndex = 8
            Me.lbltxtPengadaanJumlah.Text = "Jumlah"
            Me.lbltxtPengadaanJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanJumlah
            '
            Me.txtPengadaanJumlah.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanJumlah.Location = New System.Drawing.Point(624, 42)
            Me.txtPengadaanJumlah.Name = "txtPengadaanJumlah"
            Me.txtPengadaanJumlah.Size = New System.Drawing.Size(176, 30)
            Me.txtPengadaanJumlah.TabIndex = 9
            '
            'lbltxtPengadaanStatus
            '
            Me.lbltxtPengadaanStatus.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanStatus.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanStatus.Location = New System.Drawing.Point(824, 16)
            Me.lbltxtPengadaanStatus.Name = "lbltxtPengadaanStatus"
            Me.lbltxtPengadaanStatus.Size = New System.Drawing.Size(163, 23)
            Me.lbltxtPengadaanStatus.TabIndex = 10
            Me.lbltxtPengadaanStatus.Text = "Status"
            Me.lbltxtPengadaanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanStatus
            '
            Me.txtPengadaanStatus.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanStatus.Location = New System.Drawing.Point(828, 42)
            Me.txtPengadaanStatus.Name = "txtPengadaanStatus"
            Me.txtPengadaanStatus.Size = New System.Drawing.Size(163, 30)
            Me.txtPengadaanStatus.TabIndex = 11
            '
            'lbltxtPengadaanHarga
            '
            Me.lbltxtPengadaanHarga.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanHarga.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanHarga.Location = New System.Drawing.Point(1007, 16)
            Me.lbltxtPengadaanHarga.Name = "lbltxtPengadaanHarga"
            Me.lbltxtPengadaanHarga.Size = New System.Drawing.Size(130, 23)
            Me.lbltxtPengadaanHarga.TabIndex = 12
            Me.lbltxtPengadaanHarga.Text = "Harga Satuan"
            Me.lbltxtPengadaanHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanHarga
            '
            Me.txtPengadaanHarga.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanHarga.Location = New System.Drawing.Point(1007, 42)
            Me.txtPengadaanHarga.Name = "txtPengadaanHarga"
            Me.txtPengadaanHarga.Size = New System.Drawing.Size(130, 30)
            Me.txtPengadaanHarga.TabIndex = 13
            Me.txtPengadaanHarga.ReadOnly = True
            '
            'lbltxtPengadaanTotal
            '
            Me.lbltxtPengadaanTotal.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtPengadaanTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtPengadaanTotal.ForeColor = System.Drawing.Color.White
            Me.lbltxtPengadaanTotal.Location = New System.Drawing.Point(250, 79)
            Me.lbltxtPengadaanTotal.Name = "lbltxtPengadaanTotal"
            Me.lbltxtPengadaanTotal.Size = New System.Drawing.Size(180, 23)
            Me.lbltxtPengadaanTotal.TabIndex = 20
            Me.lbltxtPengadaanTotal.Text = "Total Biaya (Rp)"
            Me.lbltxtPengadaanTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPengadaanTotal
            '
            Me.txtPengadaanTotal.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtPengadaanTotal.Location = New System.Drawing.Point(250, 106)
            Me.txtPengadaanTotal.Name = "txtPengadaanTotal"
            Me.txtPengadaanTotal.Size = New System.Drawing.Size(180, 30)
            Me.txtPengadaanTotal.TabIndex = 21
            Me.txtPengadaanTotal.ReadOnly = True
            '
            'btnTambahPengadaanBB
            '
            Me.btnTambahPengadaanBB.BackColor = System.Drawing.Color.Teal
            Me.btnTambahPengadaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahPengadaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahPengadaanBB.ForeColor = System.Drawing.Color.White
            Me.btnTambahPengadaanBB.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahPengadaanBB.Name = "btnTambahPengadaanBB"
            Me.btnTambahPengadaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahPengadaanBB.TabIndex = 12
            Me.btnTambahPengadaanBB.Text = "Tambah"
            Me.btnTambahPengadaanBB.UseVisualStyleBackColor = False
            '
            'btnUbahPengadaanBB
            '
            Me.btnUbahPengadaanBB.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahPengadaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahPengadaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahPengadaanBB.ForeColor = System.Drawing.Color.White
            Me.btnUbahPengadaanBB.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahPengadaanBB.Name = "btnUbahPengadaanBB"
            Me.btnUbahPengadaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahPengadaanBB.TabIndex = 13
            Me.btnUbahPengadaanBB.Text = "Ubah"
            Me.btnUbahPengadaanBB.UseVisualStyleBackColor = False
            '
            'btnHapusPengadaanBB
            '
            Me.btnHapusPengadaanBB.BackColor = System.Drawing.Color.Brown
            Me.btnHapusPengadaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusPengadaanBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnHapusPengadaanBB.ForeColor = System.Drawing.Color.White
            Me.btnHapusPengadaanBB.Location = New System.Drawing.Point(928, 105)
            Me.btnHapusPengadaanBB.Name = "btnHapusPengadaanBB"
            Me.btnHapusPengadaanBB.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusPengadaanBB.TabIndex = 14
            Me.btnHapusPengadaanBB.Text = "Hapus"
            Me.btnHapusPengadaanBB.UseVisualStyleBackColor = False
            '
            'btnBersihkanPengadaanBB
            '
            Me.btnBersihkanPengadaanBB.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanPengadaanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanPengadaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanPengadaanBB.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanPengadaanBB.Location = New System.Drawing.Point(1034, 105)
            Me.btnBersihkanPengadaanBB.Name = "btnBersihkanPengadaanBB"
            Me.btnBersihkanPengadaanBB.Size = New System.Drawing.Size(113, 34)
            Me.btnBersihkanPengadaanBB.TabIndex = 15
            Me.btnBersihkanPengadaanBB.Text = "Bersihkan"
            Me.btnBersihkanPengadaanBB.UseVisualStyleBackColor = False
            '
            'dgvPengadaanBB
            '
            Me.dgvPengadaanBB.AllowUserToAddRows = False
            Me.dgvPengadaanBB.AllowUserToDeleteRows = False
            Me.dgvPengadaanBB.AllowUserToResizeRows = False
            Me.dgvPengadaanBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPengadaanBB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPengadaanBB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPengadaanBB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPengadaanBBCol1, Me.dgvPengadaanBBCol2, Me.dgvPengadaanBBCol4, Me.dgvPengadaanBBCol5, Me.dgvPengadaanBBCol6})
            Me.dgvPengadaanBB.Location = New System.Drawing.Point(20, 230)
            Me.dgvPengadaanBB.MultiSelect = False
            Me.dgvPengadaanBB.Name = "dgvPengadaanBB"
            Me.dgvPengadaanBB.ReadOnly = True
            Me.dgvPengadaanBB.RowHeadersVisible = False
            Me.dgvPengadaanBB.RowHeadersWidth = 51
            Me.dgvPengadaanBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPengadaanBB.Size = New System.Drawing.Size(1150, 325)
            Me.dgvPengadaanBB.TabIndex = 2
            '
            'tpCekPenggunaanBB
            '
            Me.tpCekPenggunaanBB.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekPenggunaanBB.Controls.Add(Me.lblTitleCekPenggunaanBB)
            Me.tpCekPenggunaanBB.Controls.Add(Me.txtCariCekPenggunaanBB)
            Me.tpCekPenggunaanBB.Controls.Add(Me.lblCariCekPenggunaanBB)
            Me.tpCekPenggunaanBB.Controls.Add(Me.dgvCekPenggunaanBB)
            Me.tpCekPenggunaanBB.ForeColor = System.Drawing.Color.Azure
            Me.tpCekPenggunaanBB.Location = New System.Drawing.Point(4, 31)
            Me.tpCekPenggunaanBB.Name = "tpCekPenggunaanBB"
            Me.tpCekPenggunaanBB.Size = New System.Drawing.Size(1202, 555)
            Me.tpCekPenggunaanBB.TabIndex = 2
            Me.tpCekPenggunaanBB.Text = "Cek Penggunaan BB"
            '
            'lblTitleCekPenggunaanBB
            '
            Me.lblTitleCekPenggunaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekPenggunaanBB.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekPenggunaanBB.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekPenggunaanBB.Location = New System.Drawing.Point(423, 10)
            Me.lblTitleCekPenggunaanBB.Name = "lblTitleCekPenggunaanBB"
            Me.lblTitleCekPenggunaanBB.Size = New System.Drawing.Size(403, 35)
            Me.lblTitleCekPenggunaanBB.TabIndex = 0
            Me.lblTitleCekPenggunaanBB.Text = "CEK PENGGUNAAN BB"
            Me.lblTitleCekPenggunaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtCariCekPenggunaanBB
            '
            Me.txtCariCekPenggunaanBB.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtCariCekPenggunaanBB.Location = New System.Drawing.Point(22, 62)
            Me.txtCariCekPenggunaanBB.Name = "txtCariCekPenggunaanBB"
            Me.txtCariCekPenggunaanBB.Size = New System.Drawing.Size(285, 30)
            Me.txtCariCekPenggunaanBB.TabIndex = 1
            '
            'lblCariCekPenggunaanBB
            '
            Me.lblCariCekPenggunaanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblCariCekPenggunaanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCariCekPenggunaanBB.ForeColor = System.Drawing.Color.Red
            Me.lblCariCekPenggunaanBB.Location = New System.Drawing.Point(22, 37)
            Me.lblCariCekPenggunaanBB.Name = "lblCariCekPenggunaanBB"
            Me.lblCariCekPenggunaanBB.Size = New System.Drawing.Size(250, 22)
            Me.lblCariCekPenggunaanBB.TabIndex = 2
            Me.lblCariCekPenggunaanBB.Text = "Cari data..."
            Me.lblCariCekPenggunaanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            '
            'dgvCekPenggunaanBB
            '
            Me.dgvCekPenggunaanBB.AllowUserToAddRows = False
            Me.dgvCekPenggunaanBB.AllowUserToDeleteRows = False
            Me.dgvCekPenggunaanBB.AllowUserToResizeRows = False
            Me.dgvCekPenggunaanBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCekPenggunaanBB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekPenggunaanBB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCekPenggunaanBB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCekPenggunaanBBCol1, Me.dgvCekPenggunaanBBCol2, Me.dgvCekPenggunaanBBCol3, Me.dgvCekPenggunaanBBCol4, Me.dgvCekPenggunaanBBCol5, Me.dgvCekPenggunaanBBCol6})
            Me.dgvCekPenggunaanBB.Location = New System.Drawing.Point(26, 99)
            Me.dgvCekPenggunaanBB.MultiSelect = False
            Me.dgvCekPenggunaanBB.Name = "dgvCekPenggunaanBB"
            Me.dgvCekPenggunaanBB.ReadOnly = True
            Me.dgvCekPenggunaanBB.RowHeadersVisible = False
            Me.dgvCekPenggunaanBB.RowHeadersWidth = 51
            Me.dgvCekPenggunaanBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCekPenggunaanBB.Size = New System.Drawing.Size(1150, 440)
            Me.dgvCekPenggunaanBB.TabIndex = 4
            '
            'dgvCekPenggunaanBBCol1
            '
            Me.dgvCekPenggunaanBBCol1.HeaderText = "Tanggal"
            Me.dgvCekPenggunaanBBCol1.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol1.Name = "dgvCekPenggunaanBBCol1"
            Me.dgvCekPenggunaanBBCol1.ReadOnly = True
            Me.dgvCekPenggunaanBBCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenggunaanBBCol2
            '
            Me.dgvCekPenggunaanBBCol2.HeaderText = "No. Pengerjaan"
            Me.dgvCekPenggunaanBBCol2.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol2.Name = "dgvCekPenggunaanBBCol2"
            Me.dgvCekPenggunaanBBCol2.ReadOnly = True
            Me.dgvCekPenggunaanBBCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenggunaanBBCol3
            '
            Me.dgvCekPenggunaanBBCol3.HeaderText = "Bahan Baku"
            Me.dgvCekPenggunaanBBCol3.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol3.Name = "dgvCekPenggunaanBBCol3"
            Me.dgvCekPenggunaanBBCol3.ReadOnly = True
            Me.dgvCekPenggunaanBBCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenggunaanBBCol4
            '
            Me.dgvCekPenggunaanBBCol4.HeaderText = "Jumlah"
            Me.dgvCekPenggunaanBBCol4.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol4.Name = "dgvCekPenggunaanBBCol4"
            Me.dgvCekPenggunaanBBCol4.ReadOnly = True
            Me.dgvCekPenggunaanBBCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenggunaanBBCol5
            '
            Me.dgvCekPenggunaanBBCol5.HeaderText = "Satuan"
            Me.dgvCekPenggunaanBBCol5.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol5.Name = "dgvCekPenggunaanBBCol5"
            Me.dgvCekPenggunaanBBCol5.ReadOnly = True
            Me.dgvCekPenggunaanBBCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenggunaanBBCol6
            '
            Me.dgvCekPenggunaanBBCol6.HeaderText = "Kondisi/Laporan"
            Me.dgvCekPenggunaanBBCol6.MinimumWidth = 6
            Me.dgvCekPenggunaanBBCol6.Name = "dgvCekPenggunaanBBCol6"
            Me.dgvCekPenggunaanBBCol6.ReadOnly = True
            Me.dgvCekPenggunaanBBCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpCekPenjualan
            '
            Me.tpCekPenjualan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekPenjualan.Controls.Add(Me.lblTitleCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.txtCariCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.lblCariCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.dgvCekPenjualan)
            Me.tpCekPenjualan.Location = New System.Drawing.Point(4, 31)
            Me.tpCekPenjualan.Name = "tpCekPenjualan"
            Me.tpCekPenjualan.Size = New System.Drawing.Size(1202, 555)
            Me.tpCekPenjualan.TabIndex = 3
            Me.tpCekPenjualan.Text = "Cek Penjualan"
            '
            'lblTitleCekPenjualan
            '
            Me.lblTitleCekPenjualan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekPenjualan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekPenjualan.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekPenjualan.Location = New System.Drawing.Point(461, 13)
            Me.lblTitleCekPenjualan.Name = "lblTitleCekPenjualan"
            Me.lblTitleCekPenjualan.Size = New System.Drawing.Size(1120, 35)
            Me.lblTitleCekPenjualan.TabIndex = 0
            Me.lblTitleCekPenjualan.Text = "CEK PENJUALAN"
            Me.lblTitleCekPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtCariCekPenjualan
            '
            Me.txtCariCekPenjualan.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtCariCekPenjualan.Location = New System.Drawing.Point(22, 62)
            Me.txtCariCekPenjualan.Name = "txtCariCekPenjualan"
            Me.txtCariCekPenjualan.Size = New System.Drawing.Size(285, 30)
            Me.txtCariCekPenjualan.TabIndex = 1
            '
            'lblCariCekPenjualan
            '
            Me.lblCariCekPenjualan.BackColor = System.Drawing.Color.Transparent
            Me.lblCariCekPenjualan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCariCekPenjualan.ForeColor = System.Drawing.Color.Red
            Me.lblCariCekPenjualan.Location = New System.Drawing.Point(22, 37)
            Me.lblCariCekPenjualan.Name = "lblCariCekPenjualan"
            Me.lblCariCekPenjualan.Size = New System.Drawing.Size(250, 22)
            Me.lblCariCekPenjualan.TabIndex = 2
            Me.lblCariCekPenjualan.Text = "Cari data..."
            Me.lblCariCekPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            '
            'dgvCekPenjualan
            '
            Me.dgvCekPenjualan.AllowUserToAddRows = False
            Me.dgvCekPenjualan.AllowUserToDeleteRows = False
            Me.dgvCekPenjualan.AllowUserToResizeRows = False
            Me.dgvCekPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCekPenjualan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvCekPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCekPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCekPenjualanCol1, Me.dgvCekPenjualanCol2, Me.dgvCekPenjualanCol3, Me.dgvCekPenjualanCol4, Me.dgvCekPenjualanCol5})
            Me.dgvCekPenjualan.Location = New System.Drawing.Point(22, 99)
            Me.dgvCekPenjualan.MultiSelect = False
            Me.dgvCekPenjualan.Name = "dgvCekPenjualan"
            Me.dgvCekPenjualan.ReadOnly = True
            Me.dgvCekPenjualan.RowHeadersVisible = False
            Me.dgvCekPenjualan.RowHeadersWidth = 51
            Me.dgvCekPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCekPenjualan.Size = New System.Drawing.Size(1150, 440)
            Me.dgvCekPenjualan.TabIndex = 4
            '
            'dgvCekPenjualanCol1
            '
            Me.dgvCekPenjualanCol1.HeaderText = "Kode Penjualan"
            Me.dgvCekPenjualanCol1.MinimumWidth = 6
            Me.dgvCekPenjualanCol1.Name = "dgvCekPenjualanCol1"
            Me.dgvCekPenjualanCol1.ReadOnly = True
            Me.dgvCekPenjualanCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenjualanCol2
            '
            Me.dgvCekPenjualanCol2.HeaderText = "Tanggal Pengambilan"
            Me.dgvCekPenjualanCol2.MinimumWidth = 6
            Me.dgvCekPenjualanCol2.Name = "dgvCekPenjualanCol2"
            Me.dgvCekPenjualanCol2.ReadOnly = True
            Me.dgvCekPenjualanCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenjualanCol3
            '
            Me.dgvCekPenjualanCol3.HeaderText = "No. Pesanan"
            Me.dgvCekPenjualanCol3.MinimumWidth = 6
            Me.dgvCekPenjualanCol3.Name = "dgvCekPenjualanCol3"
            Me.dgvCekPenjualanCol3.ReadOnly = True
            Me.dgvCekPenjualanCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenjualanCol4
            '
            Me.dgvCekPenjualanCol4.HeaderText = "Total (Rp)"
            Me.dgvCekPenjualanCol4.MinimumWidth = 6
            Me.dgvCekPenjualanCol4.Name = "dgvCekPenjualanCol4"
            Me.dgvCekPenjualanCol4.ReadOnly = True
            Me.dgvCekPenjualanCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvCekPenjualanCol5
            '
            Me.dgvCekPenjualanCol5.HeaderText = "Status Pembayaran"
            Me.dgvCekPenjualanCol5.MinimumWidth = 6
            Me.dgvCekPenjualanCol5.Name = "dgvCekPenjualanCol5"
            Me.dgvCekPenjualanCol5.ReadOnly = True
            Me.dgvCekPenjualanCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpHitungEOQ
            '
            Me.tpHitungEOQ.BackColor = System.Drawing.Color.CadetBlue
            Me.tpHitungEOQ.Controls.Add(Me.lblTitleHitungEOQ)
            Me.tpHitungEOQ.Controls.Add(Me.pnlHitungEOQ)
            Me.tpHitungEOQ.Controls.Add(Me.dgvHitungEOQ)
            Me.tpHitungEOQ.Location = New System.Drawing.Point(4, 31)
            Me.tpHitungEOQ.Name = "tpHitungEOQ"
            Me.tpHitungEOQ.Size = New System.Drawing.Size(1202, 555)
            Me.tpHitungEOQ.TabIndex = 4
            Me.tpHitungEOQ.Text = "Perhitungan EOQ"
            '
            'lblTitleHitungEOQ
            '
            Me.lblTitleHitungEOQ.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleHitungEOQ.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleHitungEOQ.ForeColor = System.Drawing.Color.White
            Me.lblTitleHitungEOQ.Location = New System.Drawing.Point(441, 14)
            Me.lblTitleHitungEOQ.Name = "lblTitleHitungEOQ"
            Me.lblTitleHitungEOQ.Size = New System.Drawing.Size(399, 35)
            Me.lblTitleHitungEOQ.TabIndex = 0
            Me.lblTitleHitungEOQ.Text = "PERHITUNGAN EOQ"
            Me.lblTitleHitungEOQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHitungEOQ
            '
            Me.pnlHitungEOQ.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlHitungEOQ.Controls.Add(Me.txthasileoq)
            Me.pnlHitungEOQ.Controls.Add(Me.lbltxtEOQD)
            Me.pnlHitungEOQ.Controls.Add(Me.txtEOQD)
            Me.pnlHitungEOQ.Controls.Add(Me.lbltxtEOQS)
            Me.pnlHitungEOQ.Controls.Add(Me.txtEOQS)
            Me.pnlHitungEOQ.Controls.Add(Me.lbltxtEOQH)
            Me.pnlHitungEOQ.Controls.Add(Me.txtEOQH)
            Me.pnlHitungEOQ.Controls.Add(Me.lbltxtEOQNama)
            Me.pnlHitungEOQ.Controls.Add(Me.txtEOQNama)
            Me.pnlHitungEOQ.Controls.Add(Me.btnHitungEOQ)
            Me.pnlHitungEOQ.Controls.Add(Me.btnResetEOQ)
            Me.pnlHitungEOQ.Controls.Add(Me.lblHasilEOQ)
            Me.pnlHitungEOQ.Location = New System.Drawing.Point(20, 65)
            Me.pnlHitungEOQ.Name = "pnlHitungEOQ"
            Me.pnlHitungEOQ.Size = New System.Drawing.Size(1150, 235)
            Me.pnlHitungEOQ.TabIndex = 1
            '
            'txthasileoq
            '
            Me.txthasileoq.Location = New System.Drawing.Point(941, 150)
            Me.txthasileoq.Name = "txthasileoq"
            Me.txthasileoq.Size = New System.Drawing.Size(154, 28)
            Me.txthasileoq.ReadOnly = True
            Me.txthasileoq.TabIndex = 11
            '
            'lbltxtEOQD
            '
            Me.lbltxtEOQD.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtEOQD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtEOQD.ForeColor = System.Drawing.Color.White
            Me.lbltxtEOQD.Location = New System.Drawing.Point(25, 32)
            Me.lbltxtEOQD.Name = "lbltxtEOQD"
            Me.lbltxtEOQD.Size = New System.Drawing.Size(245, 25)
            Me.lbltxtEOQD.TabIndex = 0
            Me.lbltxtEOQD.Text = "Kebutuhan Tahunan (D)"
            Me.lbltxtEOQD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtEOQD
            '
            Me.txtEOQD.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtEOQD.Location = New System.Drawing.Point(25, 65)
            Me.txtEOQD.Name = "txtEOQD"
            Me.txtEOQD.Size = New System.Drawing.Size(245, 30)
            Me.txtEOQD.TabIndex = 1
            '
            'lbltxtEOQS
            '
            Me.lbltxtEOQS.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtEOQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtEOQS.ForeColor = System.Drawing.Color.White
            Me.lbltxtEOQS.Location = New System.Drawing.Point(300, 32)
            Me.lbltxtEOQS.Name = "lbltxtEOQS"
            Me.lbltxtEOQS.Size = New System.Drawing.Size(245, 25)
            Me.lbltxtEOQS.TabIndex = 2
            Me.lbltxtEOQS.Text = "Biaya Pemesanan (S)"
            Me.lbltxtEOQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtEOQS
            '
            Me.txtEOQS.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtEOQS.Location = New System.Drawing.Point(300, 65)
            Me.txtEOQS.Name = "txtEOQS"
            Me.txtEOQS.Size = New System.Drawing.Size(245, 30)
            Me.txtEOQS.TabIndex = 3
            '
            'lbltxtEOQH
            '
            Me.lbltxtEOQH.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtEOQH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtEOQH.ForeColor = System.Drawing.Color.White
            Me.lbltxtEOQH.Location = New System.Drawing.Point(575, 32)
            Me.lbltxtEOQH.Name = "lbltxtEOQH"
            Me.lbltxtEOQH.Size = New System.Drawing.Size(245, 25)
            Me.lbltxtEOQH.TabIndex = 4
            Me.lbltxtEOQH.Text = "Biaya Penyimpanan (H)"
            Me.lbltxtEOQH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtEOQH
            '
            Me.txtEOQH.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtEOQH.Location = New System.Drawing.Point(575, 65)
            Me.txtEOQH.Name = "txtEOQH"
            Me.txtEOQH.Size = New System.Drawing.Size(245, 30)
            Me.txtEOQH.TabIndex = 5
            '
            'lbltxtEOQNama
            '
            Me.lbltxtEOQNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtEOQNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtEOQNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtEOQNama.Location = New System.Drawing.Point(850, 32)
            Me.lbltxtEOQNama.Name = "lbltxtEOQNama"
            Me.lbltxtEOQNama.Size = New System.Drawing.Size(245, 25)
            Me.lbltxtEOQNama.TabIndex = 6
            Me.lbltxtEOQNama.Text = "Nama Bahan Baku"
            Me.lbltxtEOQNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtEOQNama
            '
            Me.txtEOQNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtEOQNama.Location = New System.Drawing.Point(850, 65)
            Me.txtEOQNama.Name = "txtEOQNama"
            Me.txtEOQNama.Size = New System.Drawing.Size(245, 30)
            Me.txtEOQNama.ReadOnly = True
            Me.txtEOQNama.TabIndex = 7
            '
            'btnHitungEOQ
            '
            Me.btnHitungEOQ.BackColor = System.Drawing.Color.Teal
            Me.btnHitungEOQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHitungEOQ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHitungEOQ.ForeColor = System.Drawing.Color.White
            Me.btnHitungEOQ.Location = New System.Drawing.Point(25, 135)
            Me.btnHitungEOQ.Name = "btnHitungEOQ"
            Me.btnHitungEOQ.Size = New System.Drawing.Size(190, 43)
            Me.btnHitungEOQ.TabIndex = 8
            Me.btnHitungEOQ.Text = "Simpan EOQ"
            Me.btnHitungEOQ.UseVisualStyleBackColor = False
            '
            'btnResetEOQ
            '
            Me.btnResetEOQ.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnResetEOQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnResetEOQ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnResetEOQ.ForeColor = System.Drawing.Color.White
            Me.btnResetEOQ.Location = New System.Drawing.Point(230, 135)
            Me.btnResetEOQ.Name = "btnResetEOQ"
            Me.btnResetEOQ.Size = New System.Drawing.Size(120, 43)
            Me.btnResetEOQ.TabIndex = 9
            Me.btnResetEOQ.Text = "Reset"
            Me.btnResetEOQ.UseVisualStyleBackColor = False
            '
            'lblHasilEOQ
            '
            Me.lblHasilEOQ.BackColor = System.Drawing.Color.Transparent
            Me.lblHasilEOQ.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasilEOQ.ForeColor = System.Drawing.Color.IndianRed
            Me.lblHasilEOQ.Location = New System.Drawing.Point(776, 131)
            Me.lblHasilEOQ.Name = "lblHasilEOQ"
            Me.lblHasilEOQ.Size = New System.Drawing.Size(174, 60)
            Me.lblHasilEOQ.TabIndex = 10
            Me.lblHasilEOQ.Text = "Hasil EOQ: "
            Me.lblHasilEOQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvHitungEOQ
            '
            Me.dgvHitungEOQ.AllowUserToAddRows = False
            Me.dgvHitungEOQ.AllowUserToDeleteRows = False
            Me.dgvHitungEOQ.AllowUserToResizeRows = False
            Me.dgvHitungEOQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvHitungEOQ.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvHitungEOQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvHitungEOQ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvHitungEOQCol1, Me.dgvHitungEOQCol2, Me.dgvHitungEOQCol3, Me.dgvHitungEOQCol4, Me.dgvHitungEOQCol5})
            Me.dgvHitungEOQ.Location = New System.Drawing.Point(20, 316)
            Me.dgvHitungEOQ.MultiSelect = False
            Me.dgvHitungEOQ.Name = "dgvHitungEOQ"
            Me.dgvHitungEOQ.ReadOnly = True
            Me.dgvHitungEOQ.RowHeadersVisible = False
            Me.dgvHitungEOQ.RowHeadersWidth = 51
            Me.dgvHitungEOQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHitungEOQ.Size = New System.Drawing.Size(1150, 222)
            Me.dgvHitungEOQ.TabIndex = 3
            '
            'dgvHitungEOQCol1
            '
            Me.dgvHitungEOQCol1.HeaderText = "Bahan Baku"
            Me.dgvHitungEOQCol1.MinimumWidth = 6
            Me.dgvHitungEOQCol1.Name = "dgvHitungEOQCol1"
            Me.dgvHitungEOQCol1.ReadOnly = True
            Me.dgvHitungEOQCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungEOQCol2
            '
            Me.dgvHitungEOQCol2.HeaderText = "D"
            Me.dgvHitungEOQCol2.MinimumWidth = 6
            Me.dgvHitungEOQCol2.Name = "dgvHitungEOQCol2"
            Me.dgvHitungEOQCol2.ReadOnly = True
            Me.dgvHitungEOQCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungEOQCol3
            '
            Me.dgvHitungEOQCol3.HeaderText = "S"
            Me.dgvHitungEOQCol3.MinimumWidth = 6
            Me.dgvHitungEOQCol3.Name = "dgvHitungEOQCol3"
            Me.dgvHitungEOQCol3.ReadOnly = True
            Me.dgvHitungEOQCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungEOQCol4
            '
            Me.dgvHitungEOQCol4.HeaderText = "H"
            Me.dgvHitungEOQCol4.MinimumWidth = 6
            Me.dgvHitungEOQCol4.Name = "dgvHitungEOQCol4"
            Me.dgvHitungEOQCol4.ReadOnly = True
            Me.dgvHitungEOQCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungEOQCol5
            '
            Me.dgvHitungEOQCol5.HeaderText = "EOQ"
            Me.dgvHitungEOQCol5.MinimumWidth = 6
            Me.dgvHitungEOQCol5.Name = "dgvHitungEOQCol5"
            Me.dgvHitungEOQCol5.ReadOnly = True
            Me.dgvHitungEOQCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpHitungROP
            '
            Me.tpHitungROP.BackColor = System.Drawing.Color.CadetBlue
            Me.tpHitungROP.Controls.Add(Me.lblTitleHitungROP)
            Me.tpHitungROP.Controls.Add(Me.pnlHitungROP)
            Me.tpHitungROP.Controls.Add(Me.dgvHitungROP)
            Me.tpHitungROP.Location = New System.Drawing.Point(4, 31)
            Me.tpHitungROP.Name = "tpHitungROP"
            Me.tpHitungROP.Size = New System.Drawing.Size(1202, 555)
            Me.tpHitungROP.TabIndex = 5
            Me.tpHitungROP.Text = "Perhitungan ROP & Safety Stock"
            '
            'lblTitleHitungROP
            '
            Me.lblTitleHitungROP.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleHitungROP.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleHitungROP.ForeColor = System.Drawing.Color.White
            Me.lblTitleHitungROP.Location = New System.Drawing.Point(259, 6)
            Me.lblTitleHitungROP.Name = "lblTitleHitungROP"
            Me.lblTitleHitungROP.Size = New System.Drawing.Size(744, 35)
            Me.lblTitleHitungROP.TabIndex = 0
            Me.lblTitleHitungROP.Text = "PERHITUNGAN ROP dan SAFETY STOCK"
            Me.lblTitleHitungROP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlHitungROP
            '
            Me.pnlHitungROP.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlHitungROP.Controls.Add(Me.txtreoderpoint)
            Me.pnlHitungROP.Controls.Add(Me.txtsafetystock)
            Me.pnlHitungROP.Controls.Add(Me.lbltxtROPAvg)
            Me.pnlHitungROP.Controls.Add(Me.txtROPAvg)
            Me.pnlHitungROP.Controls.Add(Me.lbltxtROPMax)
            Me.pnlHitungROP.Controls.Add(Me.txtROPMax)
            Me.pnlHitungROP.Controls.Add(Me.lbltxtROPLTAvg)
            Me.pnlHitungROP.Controls.Add(Me.txtROPLTAvg)
            Me.pnlHitungROP.Controls.Add(Me.lbltxtROPLTMax)
            Me.pnlHitungROP.Controls.Add(Me.txtROPLTMax)
            Me.pnlHitungROP.Controls.Add(Me.btnHitungROP)
            Me.pnlHitungROP.Controls.Add(Me.btnResetROP)
            Me.pnlHitungROP.Controls.Add(Me.lblHasilSS)
            Me.pnlHitungROP.Controls.Add(Me.lblHasilROP)
            Me.pnlHitungROP.Location = New System.Drawing.Point(20, 55)
            Me.pnlHitungROP.Name = "pnlHitungROP"
            Me.pnlHitungROP.Size = New System.Drawing.Size(1150, 300)
            Me.pnlHitungROP.TabIndex = 1
            '
            'txtreoderpoint
            '
            Me.txtreoderpoint.Location = New System.Drawing.Point(1034, 225)
            Me.txtreoderpoint.Name = "txtreoderpoint"
            Me.txtreoderpoint.Size = New System.Drawing.Size(100, 28)
            Me.txtreoderpoint.ReadOnly = True
            Me.txtreoderpoint.TabIndex = 13
            '
            'txtsafetystock
            '
            Me.txtsafetystock.Location = New System.Drawing.Point(774, 227)
            Me.txtsafetystock.Name = "txtsafetystock"
            Me.txtsafetystock.Size = New System.Drawing.Size(100, 28)
            Me.txtsafetystock.ReadOnly = True
            Me.txtsafetystock.TabIndex = 12
            '
            'lbltxtROPAvg
            '
            Me.lbltxtROPAvg.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtROPAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtROPAvg.ForeColor = System.Drawing.Color.White
            Me.lbltxtROPAvg.Location = New System.Drawing.Point(28, 25)
            Me.lbltxtROPAvg.Name = "lbltxtROPAvg"
            Me.lbltxtROPAvg.Size = New System.Drawing.Size(350, 24)
            Me.lbltxtROPAvg.TabIndex = 0
            Me.lbltxtROPAvg.Text = "Pemakaian Rata-rata / hari"
            Me.lbltxtROPAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtROPAvg
            '
            Me.txtROPAvg.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtROPAvg.Location = New System.Drawing.Point(32, 52)
            Me.txtROPAvg.Name = "txtROPAvg"
            Me.txtROPAvg.Size = New System.Drawing.Size(350, 30)
            Me.txtROPAvg.TabIndex = 1
            '
            'lbltxtROPMax
            '
            Me.lbltxtROPMax.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtROPMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtROPMax.ForeColor = System.Drawing.Color.White
            Me.lbltxtROPMax.Location = New System.Drawing.Point(500, 25)
            Me.lbltxtROPMax.Name = "lbltxtROPMax"
            Me.lbltxtROPMax.Size = New System.Drawing.Size(350, 24)
            Me.lbltxtROPMax.TabIndex = 2
            Me.lbltxtROPMax.Text = "Pemakaian Maksimum / hari"
            Me.lbltxtROPMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtROPMax
            '
            Me.txtROPMax.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtROPMax.Location = New System.Drawing.Point(500, 52)
            Me.txtROPMax.Name = "txtROPMax"
            Me.txtROPMax.Size = New System.Drawing.Size(350, 30)
            Me.txtROPMax.TabIndex = 3
            '
            'lbltxtROPLTAvg
            '
            Me.lbltxtROPLTAvg.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtROPLTAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtROPLTAvg.ForeColor = System.Drawing.Color.White
            Me.lbltxtROPLTAvg.Location = New System.Drawing.Point(32, 105)
            Me.lbltxtROPLTAvg.Name = "lbltxtROPLTAvg"
            Me.lbltxtROPLTAvg.Size = New System.Drawing.Size(350, 24)
            Me.lbltxtROPLTAvg.TabIndex = 4
            Me.lbltxtROPLTAvg.Text = "Lead Time Rata-rata (hari)"
            Me.lbltxtROPLTAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtROPLTAvg
            '
            Me.txtROPLTAvg.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtROPLTAvg.Location = New System.Drawing.Point(32, 144)
            Me.txtROPLTAvg.Name = "txtROPLTAvg"
            Me.txtROPLTAvg.Size = New System.Drawing.Size(350, 30)
            Me.txtROPLTAvg.TabIndex = 5
            '
            'lbltxtROPLTMax
            '
            Me.lbltxtROPLTMax.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtROPLTMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtROPLTMax.ForeColor = System.Drawing.Color.White
            Me.lbltxtROPLTMax.Location = New System.Drawing.Point(496, 109)
            Me.lbltxtROPLTMax.Name = "lbltxtROPLTMax"
            Me.lbltxtROPLTMax.Size = New System.Drawing.Size(350, 24)
            Me.lbltxtROPLTMax.TabIndex = 6
            Me.lbltxtROPLTMax.Text = "Lead Time Maksimum (hari)"
            Me.lbltxtROPLTMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtROPLTMax
            '
            Me.txtROPLTMax.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtROPLTMax.Location = New System.Drawing.Point(500, 144)
            Me.txtROPLTMax.Name = "txtROPLTMax"
            Me.txtROPLTMax.Size = New System.Drawing.Size(350, 30)
            Me.txtROPLTMax.TabIndex = 7
            '
            'btnHitungROP
            '
            Me.btnHitungROP.BackColor = System.Drawing.Color.Teal
            Me.btnHitungROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHitungROP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHitungROP.ForeColor = System.Drawing.Color.MintCream
            Me.btnHitungROP.Location = New System.Drawing.Point(32, 227)
            Me.btnHitungROP.Name = "btnHitungROP"
            Me.btnHitungROP.Size = New System.Drawing.Size(213, 45)
            Me.btnHitungROP.TabIndex = 8
            Me.btnHitungROP.Text = "Simpan SS dan ROP"
            Me.btnHitungROP.UseVisualStyleBackColor = False
            '
            'btnResetROP
            '
            Me.btnResetROP.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnResetROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnResetROP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnResetROP.ForeColor = System.Drawing.Color.White
            Me.btnResetROP.Location = New System.Drawing.Point(267, 228)
            Me.btnResetROP.Name = "btnResetROP"
            Me.btnResetROP.Size = New System.Drawing.Size(130, 42)
            Me.btnResetROP.TabIndex = 9
            Me.btnResetROP.Text = "Reset"
            Me.btnResetROP.UseVisualStyleBackColor = False
            '
            'lblHasilSS
            '
            Me.lblHasilSS.BackColor = System.Drawing.Color.Transparent
            Me.lblHasilSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasilSS.ForeColor = System.Drawing.Color.White
            Me.lblHasilSS.Location = New System.Drawing.Point(642, 223)
            Me.lblHasilSS.Name = "lblHasilSS"
            Me.lblHasilSS.Size = New System.Drawing.Size(143, 36)
            Me.lblHasilSS.TabIndex = 10
            Me.lblHasilSS.Text = "Safety Stock: "
            Me.lblHasilSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblHasilROP
            '
            Me.lblHasilROP.BackColor = System.Drawing.Color.Transparent
            Me.lblHasilROP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasilROP.ForeColor = System.Drawing.Color.White
            Me.lblHasilROP.Location = New System.Drawing.Point(895, 221)
            Me.lblHasilROP.Name = "lblHasilROP"
            Me.lblHasilROP.Size = New System.Drawing.Size(142, 36)
            Me.lblHasilROP.TabIndex = 11
            Me.lblHasilROP.Text = "Reorder Point: "
            Me.lblHasilROP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvHitungROP
            '
            Me.dgvHitungROP.AllowUserToAddRows = False
            Me.dgvHitungROP.AllowUserToDeleteRows = False
            Me.dgvHitungROP.AllowUserToResizeRows = False
            Me.dgvHitungROP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvHitungROP.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvHitungROP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvHitungROP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvHitungROPCol1, Me.dgvHitungROPCol2, Me.dgvHitungROPCol3, Me.dgvHitungROPCol4, Me.dgvHitungROPCol5, Me.dgvHitungROPCol6, Me.dgvHitungROPCol7})
            Me.dgvHitungROP.Location = New System.Drawing.Point(20, 361)
            Me.dgvHitungROP.MultiSelect = False
            Me.dgvHitungROP.Name = "dgvHitungROP"
            Me.dgvHitungROP.ReadOnly = True
            Me.dgvHitungROP.RowHeadersVisible = False
            Me.dgvHitungROP.RowHeadersWidth = 51
            Me.dgvHitungROP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHitungROP.Size = New System.Drawing.Size(1150, 189)
            Me.dgvHitungROP.TabIndex = 3
            '
            'dgvHitungROPCol1
            '
            Me.dgvHitungROPCol1.HeaderText = "Bahan Baku"
            Me.dgvHitungROPCol1.MinimumWidth = 6
            Me.dgvHitungROPCol1.Name = "dgvHitungROPCol1"
            Me.dgvHitungROPCol1.ReadOnly = True
            Me.dgvHitungROPCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol2
            '
            Me.dgvHitungROPCol2.HeaderText = "Pemakaian Rata-rata"
            Me.dgvHitungROPCol2.MinimumWidth = 6
            Me.dgvHitungROPCol2.Name = "dgvHitungROPCol2"
            Me.dgvHitungROPCol2.ReadOnly = True
            Me.dgvHitungROPCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol3
            '
            Me.dgvHitungROPCol3.HeaderText = "Pemakaian Maksimum"
            Me.dgvHitungROPCol3.MinimumWidth = 6
            Me.dgvHitungROPCol3.Name = "dgvHitungROPCol3"
            Me.dgvHitungROPCol3.ReadOnly = True
            Me.dgvHitungROPCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol4
            '
            Me.dgvHitungROPCol4.HeaderText = "LT Rata-rata"
            Me.dgvHitungROPCol4.MinimumWidth = 6
            Me.dgvHitungROPCol4.Name = "dgvHitungROPCol4"
            Me.dgvHitungROPCol4.ReadOnly = True
            Me.dgvHitungROPCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol5
            '
            Me.dgvHitungROPCol5.HeaderText = "LT Maksimum"
            Me.dgvHitungROPCol5.MinimumWidth = 6
            Me.dgvHitungROPCol5.Name = "dgvHitungROPCol5"
            Me.dgvHitungROPCol5.ReadOnly = True
            Me.dgvHitungROPCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol6
            '
            Me.dgvHitungROPCol6.HeaderText = "Safety Stock"
            Me.dgvHitungROPCol6.MinimumWidth = 6
            Me.dgvHitungROPCol6.Name = "dgvHitungROPCol6"
            Me.dgvHitungROPCol6.ReadOnly = True
            Me.dgvHitungROPCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvHitungROPCol7
            '
            Me.dgvHitungROPCol7.HeaderText = "ROP"
            Me.dgvHitungROPCol7.MinimumWidth = 6
            Me.dgvHitungROPCol7.Name = "dgvHitungROPCol7"
            Me.dgvHitungROPCol7.ReadOnly = True
            Me.dgvHitungROPCol7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
            '
            'ContextMenuStrip2
            '
            Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
            Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
            Me.Panel1.Controls.Add(Me.PictureBox1)
            Me.Panel1.Controls.Add(Me.lblBrand)
            Me.Panel1.Controls.Add(Me.lblActor)
            Me.Panel1.Controls.Add(Me.btnLogout)
            Me.Panel1.ForeColor = System.Drawing.Color.CadetBlue
            Me.Panel1.Location = New System.Drawing.Point(0, -6)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1254, 100)
            Me.Panel1.TabIndex = 15
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
            'lblBrand
            '
            Me.lblBrand.BackColor = System.Drawing.Color.Transparent
            Me.lblBrand.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblBrand.ForeColor = System.Drawing.Color.White
            Me.lblBrand.Location = New System.Drawing.Point(117, 32)
            Me.lblBrand.Name = "lblBrand"
            Me.lblBrand.Size = New System.Drawing.Size(940, 45)
            Me.lblBrand.TabIndex = 5
            Me.lblBrand.Text = " SISTEM INFORMASI PENGELOLAAN SERVIS SEPATU Shoelusi"
            Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblActor
            '
            Me.lblActor.BackColor = System.Drawing.Color.Transparent
            Me.lblActor.Font = New System.Drawing.Font("Lucida Bright", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblActor.ForeColor = System.Drawing.Color.White
            Me.lblActor.Location = New System.Drawing.Point(1026, 11)
            Me.lblActor.Name = "lblActor"
            Me.lblActor.Size = New System.Drawing.Size(210, 45)
            Me.lblActor.TabIndex = 6
            Me.lblActor.Text = "Staf Gudang"
            Me.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.SteelBlue
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(1097, 56)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(135, 34)
            Me.btnLogout.TabIndex = 7
            Me.btnLogout.Text = "Keluar Akun"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'dgvPengadaanBBCol1
            '
            Me.dgvPengadaanBBCol1.HeaderText = "No. Pengadaan"
            Me.dgvPengadaanBBCol1.MinimumWidth = 6
            Me.dgvPengadaanBBCol1.Name = "dgvPengadaanBBCol1"
            Me.dgvPengadaanBBCol1.ReadOnly = True
            Me.dgvPengadaanBBCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengadaanBBCol2
            '
            Me.dgvPengadaanBBCol2.HeaderText = "Tanggal"
            Me.dgvPengadaanBBCol2.MinimumWidth = 6
            Me.dgvPengadaanBBCol2.Name = "dgvPengadaanBBCol2"
            Me.dgvPengadaanBBCol2.ReadOnly = True
            Me.dgvPengadaanBBCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengadaanBBCol4
            '
            Me.dgvPengadaanBBCol4.HeaderText = "Kode Bahan"
            Me.dgvPengadaanBBCol4.MinimumWidth = 6
            Me.dgvPengadaanBBCol4.Name = "dgvPengadaanBBCol4"
            Me.dgvPengadaanBBCol4.ReadOnly = True
            Me.dgvPengadaanBBCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengadaanBBCol5
            '
            Me.dgvPengadaanBBCol5.HeaderText = "Jumlah"
            Me.dgvPengadaanBBCol5.MinimumWidth = 6
            Me.dgvPengadaanBBCol5.Name = "dgvPengadaanBBCol5"
            Me.dgvPengadaanBBCol5.ReadOnly = True
            Me.dgvPengadaanBBCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPengadaanBBCol6
            '
            Me.dgvPengadaanBBCol6.HeaderText = "Status"
            Me.dgvPengadaanBBCol6.MinimumWidth = 6
            Me.dgvPengadaanBBCol6.Name = "dgvPengadaanBBCol6"
            Me.dgvPengadaanBBCol6.ReadOnly = True
            Me.dgvPengadaanBBCol6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'FrmGudang
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.CadetBlue
            Me.ClientSize = New System.Drawing.Size(1250, 710)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.tabMain)
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ForeColor = System.Drawing.Color.CadetBlue
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "FrmGudang"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Staf Gudang"
            Me.tabMain.ResumeLayout(False)
            Me.tpPersediaanBB.ResumeLayout(False)
            Me.pnlPersediaanBB.ResumeLayout(False)
            Me.pnlPersediaanBB.PerformLayout()
            CType(Me.dgvPersediaanBB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpPengadaanBB.ResumeLayout(False)
            Me.pnlPengadaanBB.ResumeLayout(False)
            Me.pnlPengadaanBB.PerformLayout()
            CType(Me.dgvPengadaanBB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCekPenggunaanBB.ResumeLayout(False)
            Me.tpCekPenggunaanBB.PerformLayout()
            CType(Me.dgvCekPenggunaanBB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCekPenjualan.ResumeLayout(False)
            Me.tpCekPenjualan.PerformLayout()
            CType(Me.dgvCekPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpHitungEOQ.ResumeLayout(False)
            Me.pnlHitungEOQ.ResumeLayout(False)
            Me.pnlHitungEOQ.PerformLayout()
            CType(Me.dgvHitungEOQ, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpHitungROP.ResumeLayout(False)
            Me.pnlHitungROP.ResumeLayout(False)
            Me.pnlHitungROP.PerformLayout()
            CType(Me.dgvHitungROP, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tpPersediaanBB As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePersediaanBB As System.Windows.Forms.Label
        Friend WithEvents pnlPersediaanBB As System.Windows.Forms.Panel
        Friend WithEvents lbltxtStokKode As System.Windows.Forms.Label
        Friend WithEvents txtStokKode As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtStokNama As System.Windows.Forms.Label
        Friend WithEvents txtStokNama As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtStokJumlah As System.Windows.Forms.Label
        Friend WithEvents txtStokJumlah As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtStokSatuan As System.Windows.Forms.Label
        Friend WithEvents txtStokSatuan As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtStokMinimum As System.Windows.Forms.Label
        Friend WithEvents lbltxtStokJenis As System.Windows.Forms.Label
        Friend WithEvents lbltxtStokHarga As System.Windows.Forms.Label
        Friend WithEvents txtStokMinimum As System.Windows.Forms.TextBox
        Friend WithEvents txtStokJenis As System.Windows.Forms.TextBox
        Friend WithEvents txtStokHarga As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPersediaanBB As System.Windows.Forms.Button
        Friend WithEvents btnUbahPersediaanBB As System.Windows.Forms.Button
        Friend WithEvents btnHapusPersediaanBB As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPersediaanBB As System.Windows.Forms.Button
        Friend WithEvents dgvPersediaanBB As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPersediaanBBCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersediaanBBCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersediaanBBCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersediaanBBCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersediaanBBCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpPengadaanBB As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePengadaanBB As System.Windows.Forms.Label
        Friend WithEvents pnlPengadaanBB As System.Windows.Forms.Panel
        Friend WithEvents lbltxtPengadaanNo As System.Windows.Forms.Label
        Friend WithEvents txtPengadaanNo As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPengadaanTanggal As System.Windows.Forms.Label
        Friend WithEvents dtpPengadaanTanggal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lbltxtPengadaanNama As System.Windows.Forms.Label
        Friend WithEvents txtPengadaanNama As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPengadaanJumlah As System.Windows.Forms.Label
        Friend WithEvents txtPengadaanJumlah As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtPengadaanStatus As System.Windows.Forms.Label
        Friend WithEvents lbltxtPengadaanHarga As System.Windows.Forms.Label
        Friend WithEvents lbltxtPengadaanTotal As System.Windows.Forms.Label
        Friend WithEvents txtPengadaanStatus As System.Windows.Forms.TextBox
        Friend WithEvents txtPengadaanHarga As System.Windows.Forms.TextBox
        Friend WithEvents txtPengadaanTotal As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahPengadaanBB As System.Windows.Forms.Button
        Friend WithEvents btnUbahPengadaanBB As System.Windows.Forms.Button
        Friend WithEvents btnHapusPengadaanBB As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanPengadaanBB As System.Windows.Forms.Button
        Friend WithEvents dgvPengadaanBB As System.Windows.Forms.DataGridView
        Friend WithEvents tpCekPenggunaanBB As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleCekPenggunaanBB As System.Windows.Forms.Label
        Friend WithEvents txtCariCekPenggunaanBB As System.Windows.Forms.TextBox
        Friend WithEvents lblCariCekPenggunaanBB As System.Windows.Forms.Label
        Friend WithEvents dgvCekPenggunaanBB As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCekPenggunaanBBCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenggunaanBBCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenggunaanBBCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenggunaanBBCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenggunaanBBCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenggunaanBBCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpCekPenjualan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleCekPenjualan As System.Windows.Forms.Label
        Friend WithEvents txtCariCekPenjualan As System.Windows.Forms.TextBox
        Friend WithEvents lblCariCekPenjualan As System.Windows.Forms.Label
        Friend WithEvents dgvCekPenjualan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCekPenjualanCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenjualanCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenjualanCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenjualanCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvCekPenjualanCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpHitungEOQ As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleHitungEOQ As System.Windows.Forms.Label
        Friend WithEvents pnlHitungEOQ As System.Windows.Forms.Panel
        Friend WithEvents lbltxtEOQD As System.Windows.Forms.Label
        Friend WithEvents txtEOQD As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtEOQS As System.Windows.Forms.Label
        Friend WithEvents txtEOQS As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtEOQH As System.Windows.Forms.Label
        Friend WithEvents txtEOQH As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtEOQNama As System.Windows.Forms.Label
        Friend WithEvents txtEOQNama As System.Windows.Forms.TextBox
        Friend WithEvents btnHitungEOQ As System.Windows.Forms.Button
        Friend WithEvents btnResetEOQ As System.Windows.Forms.Button
        Friend WithEvents lblHasilEOQ As System.Windows.Forms.Label
        Friend WithEvents dgvHitungEOQ As System.Windows.Forms.DataGridView
        Friend WithEvents dgvHitungEOQCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungEOQCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungEOQCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungEOQCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungEOQCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tpHitungROP As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleHitungROP As System.Windows.Forms.Label
        Friend WithEvents pnlHitungROP As System.Windows.Forms.Panel
        Friend WithEvents lbltxtROPAvg As System.Windows.Forms.Label
        Friend WithEvents txtROPAvg As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtROPMax As System.Windows.Forms.Label
        Friend WithEvents txtROPMax As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtROPLTAvg As System.Windows.Forms.Label
        Friend WithEvents txtROPLTAvg As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtROPLTMax As System.Windows.Forms.Label
        Friend WithEvents txtROPLTMax As System.Windows.Forms.TextBox
        Friend WithEvents btnHitungROP As System.Windows.Forms.Button
        Friend WithEvents btnResetROP As System.Windows.Forms.Button
        Friend WithEvents lblHasilSS As System.Windows.Forms.Label
        Friend WithEvents lblHasilROP As System.Windows.Forms.Label
        Friend WithEvents dgvHitungROP As System.Windows.Forms.DataGridView
        Friend WithEvents dgvHitungROPCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvHitungROPCol7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txthasileoq As System.Windows.Forms.TextBox
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents txtreoderpoint As System.Windows.Forms.TextBox
        Friend WithEvents txtsafetystock As System.Windows.Forms.TextBox
        Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents lblActor As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents dgvPengadaanBBCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengadaanBBCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengadaanBBCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengadaanBBCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPengadaanBBCol6 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
