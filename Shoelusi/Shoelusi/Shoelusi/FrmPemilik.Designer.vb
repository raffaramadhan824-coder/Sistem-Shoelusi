Imports System.Drawing

Namespace Shoelusi

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmPemilik
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
            Me.tpAkun = New System.Windows.Forms.TabPage()
            Me.lblTitleAkun = New System.Windows.Forms.Label()
            Me.pnlAkun = New System.Windows.Forms.Panel()
            Me.lbltxtAkunID = New System.Windows.Forms.Label()
            Me.txtAkunID = New System.Windows.Forms.TextBox()
            Me.lbltxtAkunNama = New System.Windows.Forms.Label()
            Me.txtAkunNama = New System.Windows.Forms.TextBox()
            Me.lbltxtAkunRole = New System.Windows.Forms.Label()
            Me.txtAkunRole = New System.Windows.Forms.TextBox()
            Me.lbltxtAkunStatus = New System.Windows.Forms.Label()
            Me.txtAkunStatus = New System.Windows.Forms.TextBox()
            Me.btnTambahAkun = New System.Windows.Forms.Button()
            Me.btnUbahAkun = New System.Windows.Forms.Button()
            Me.btnHapusAkun = New System.Windows.Forms.Button()
            Me.btnBersihkanAkun = New System.Windows.Forms.Button()
            Me.dgvAkun = New System.Windows.Forms.DataGridView()
            Me.tpPersetujuanBB = New System.Windows.Forms.TabPage()
            Me.lblTitlePersetujuanBB = New System.Windows.Forms.Label()
            Me.lblPetunjukPersetujuanBB = New System.Windows.Forms.Label()
            Me.dgvPersetujuanBB = New System.Windows.Forms.DataGridView()
            Me.dgvPersetujuanBBCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersetujuanBBCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersetujuanBBCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersetujuanBBCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvPersetujuanBBCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnSetujuiPersetujuanBB = New System.Windows.Forms.Button()
            Me.btnTolakPersetujuanBB = New System.Windows.Forms.Button()
            Me.tpDataLayanan = New System.Windows.Forms.TabPage()
            Me.lblTitleDataLayanan = New System.Windows.Forms.Label()
            Me.pnlDataLayanan = New System.Windows.Forms.Panel()
            Me.lbltxtLayananKode = New System.Windows.Forms.Label()
            Me.txtLayananKode = New System.Windows.Forms.TextBox()
            Me.lbltxtLayananNama = New System.Windows.Forms.Label()
            Me.txtLayananNama = New System.Windows.Forms.TextBox()
            Me.lbltxtLayananDeskripsi = New System.Windows.Forms.Label()
            Me.txtLayananDeskripsi = New System.Windows.Forms.TextBox()
            Me.lbltxtLayananHarga = New System.Windows.Forms.Label()
            Me.txtLayananHarga = New System.Windows.Forms.TextBox()
            Me.lbltxtLayananEstimasi = New System.Windows.Forms.Label()
            Me.txtLayananEstimasi = New System.Windows.Forms.TextBox()
            Me.btnTambahDataLayanan = New System.Windows.Forms.Button()
            Me.btnUbahDataLayanan = New System.Windows.Forms.Button()
            Me.btnHapusDataLayanan = New System.Windows.Forms.Button()
            Me.btnBersihkanDataLayanan = New System.Windows.Forms.Button()
            Me.dgvDataLayanan = New System.Windows.Forms.DataGridView()
            Me.dgvDataLayananCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDataLayananCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDataLayananCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDataLayananCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDataLayananCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblBrand = New System.Windows.Forms.Label()
            Me.lblActor = New System.Windows.Forms.Label()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.dgvAkunCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvAkunCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvAkunCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvAkunCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tabMain.SuspendLayout()
            Me.tpAkun.SuspendLayout()
            Me.pnlAkun.SuspendLayout()
            CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpPersetujuanBB.SuspendLayout()
            CType(Me.dgvPersetujuanBB, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpDataLayanan.SuspendLayout()
            Me.pnlDataLayanan.SuspendLayout()
            CType(Me.dgvDataLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCekPenjualan.SuspendLayout()
            CType(Me.dgvCekPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tabMain
            '
            Me.tabMain.Controls.Add(Me.tpAkun)
            Me.tabMain.Controls.Add(Me.tpPersetujuanBB)
            Me.tabMain.Controls.Add(Me.tpDataLayanan)
            Me.tabMain.Controls.Add(Me.tpCekPenjualan)
            Me.tabMain.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.tabMain.Location = New System.Drawing.Point(20, 100)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(1210, 590)
            Me.tabMain.TabIndex = 3
            '
            'tpAkun
            '
            Me.tpAkun.BackColor = System.Drawing.Color.CadetBlue
            Me.tpAkun.Controls.Add(Me.lblTitleAkun)
            Me.tpAkun.Controls.Add(Me.pnlAkun)
            Me.tpAkun.Controls.Add(Me.dgvAkun)
            Me.tpAkun.Location = New System.Drawing.Point(4, 33)
            Me.tpAkun.Name = "tpAkun"
            Me.tpAkun.Size = New System.Drawing.Size(1202, 553)
            Me.tpAkun.TabIndex = 0
            Me.tpAkun.Text = "Data Akun"
            '
            'lblTitleAkun
            '
            Me.lblTitleAkun.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleAkun.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleAkun.ForeColor = System.Drawing.Color.White
            Me.lblTitleAkun.Location = New System.Drawing.Point(486, 5)
            Me.lblTitleAkun.Name = "lblTitleAkun"
            Me.lblTitleAkun.Size = New System.Drawing.Size(230, 35)
            Me.lblTitleAkun.TabIndex = 0
            Me.lblTitleAkun.Text = "DATA AKUN"
            Me.lblTitleAkun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlAkun
            '
            Me.pnlAkun.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlAkun.Controls.Add(Me.lbltxtAkunID)
            Me.pnlAkun.Controls.Add(Me.txtAkunID)
            Me.pnlAkun.Controls.Add(Me.lbltxtAkunNama)
            Me.pnlAkun.Controls.Add(Me.txtAkunNama)
            Me.pnlAkun.Controls.Add(Me.lbltxtAkunRole)
            Me.pnlAkun.Controls.Add(Me.txtAkunRole)
            Me.pnlAkun.Controls.Add(Me.lbltxtAkunStatus)
            Me.pnlAkun.Controls.Add(Me.txtAkunStatus)
            Me.pnlAkun.Controls.Add(Me.btnTambahAkun)
            Me.pnlAkun.Controls.Add(Me.btnUbahAkun)
            Me.pnlAkun.Controls.Add(Me.btnHapusAkun)
            Me.pnlAkun.Controls.Add(Me.btnBersihkanAkun)
            Me.pnlAkun.Location = New System.Drawing.Point(20, 55)
            Me.pnlAkun.Name = "pnlAkun"
            Me.pnlAkun.Size = New System.Drawing.Size(1150, 160)
            Me.pnlAkun.TabIndex = 1
            '
            'lbltxtAkunID
            '
            Me.lbltxtAkunID.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtAkunID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtAkunID.ForeColor = System.Drawing.Color.White
            Me.lbltxtAkunID.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtAkunID.Name = "lbltxtAkunID"
            Me.lbltxtAkunID.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtAkunID.TabIndex = 0
            Me.lbltxtAkunID.Text = "No. ID"
            Me.lbltxtAkunID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAkunID
            '
            Me.txtAkunID.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtAkunID.Location = New System.Drawing.Point(15, 43)
            Me.txtAkunID.Name = "txtAkunID"
            Me.txtAkunID.Size = New System.Drawing.Size(190, 30)
            Me.txtAkunID.TabIndex = 1
            '
            'lbltxtAkunNama
            '
            Me.lbltxtAkunNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtAkunNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtAkunNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtAkunNama.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtAkunNama.Name = "lbltxtAkunNama"
            Me.lbltxtAkunNama.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtAkunNama.TabIndex = 2
            Me.lbltxtAkunNama.Text = "Nama"
            Me.lbltxtAkunNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAkunNama
            '
            Me.txtAkunNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtAkunNama.Location = New System.Drawing.Point(217, 43)
            Me.txtAkunNama.Name = "txtAkunNama"
            Me.txtAkunNama.Size = New System.Drawing.Size(190, 30)
            Me.txtAkunNama.TabIndex = 3
            '
            'lbltxtAkunRole
            '
            Me.lbltxtAkunRole.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtAkunRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtAkunRole.ForeColor = System.Drawing.Color.White
            Me.lbltxtAkunRole.Location = New System.Drawing.Point(439, 16)
            Me.lbltxtAkunRole.Name = "lbltxtAkunRole"
            Me.lbltxtAkunRole.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtAkunRole.TabIndex = 6
            Me.lbltxtAkunRole.Text = "Divisi"
            Me.lbltxtAkunRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAkunRole
            '
            Me.txtAkunRole.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtAkunRole.Location = New System.Drawing.Point(439, 43)
            Me.txtAkunRole.Name = "txtAkunRole"
            Me.txtAkunRole.Size = New System.Drawing.Size(190, 30)
            Me.txtAkunRole.TabIndex = 7
            '
            'lbltxtAkunStatus
            '
            Me.lbltxtAkunStatus.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtAkunStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtAkunStatus.ForeColor = System.Drawing.Color.White
            Me.lbltxtAkunStatus.Location = New System.Drawing.Point(667, 16)
            Me.lbltxtAkunStatus.Name = "lbltxtAkunStatus"
            Me.lbltxtAkunStatus.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtAkunStatus.TabIndex = 8
            Me.lbltxtAkunStatus.Text = "Kata Sandi"
            Me.lbltxtAkunStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAkunStatus
            '
            Me.txtAkunStatus.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtAkunStatus.Location = New System.Drawing.Point(667, 43)
            Me.txtAkunStatus.Name = "txtAkunStatus"
            Me.txtAkunStatus.Size = New System.Drawing.Size(190, 30)
            Me.txtAkunStatus.TabIndex = 9
            '
            'btnTambahAkun
            '
            Me.btnTambahAkun.BackColor = System.Drawing.Color.Teal
            Me.btnTambahAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahAkun.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahAkun.ForeColor = System.Drawing.Color.White
            Me.btnTambahAkun.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahAkun.Name = "btnTambahAkun"
            Me.btnTambahAkun.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahAkun.TabIndex = 10
            Me.btnTambahAkun.Text = "Tambah"
            Me.btnTambahAkun.UseVisualStyleBackColor = False
            '
            'btnUbahAkun
            '
            Me.btnUbahAkun.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahAkun.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahAkun.ForeColor = System.Drawing.Color.White
            Me.btnUbahAkun.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahAkun.Name = "btnUbahAkun"
            Me.btnUbahAkun.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahAkun.TabIndex = 11
            Me.btnUbahAkun.Text = "Ubah"
            Me.btnUbahAkun.UseVisualStyleBackColor = False
            '
            'btnHapusAkun
            '
            Me.btnHapusAkun.BackColor = System.Drawing.Color.Brown
            Me.btnHapusAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusAkun.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusAkun.ForeColor = System.Drawing.Color.White
            Me.btnHapusAkun.Location = New System.Drawing.Point(881, 105)
            Me.btnHapusAkun.Name = "btnHapusAkun"
            Me.btnHapusAkun.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusAkun.TabIndex = 12
            Me.btnHapusAkun.Text = "Hapus"
            Me.btnHapusAkun.UseVisualStyleBackColor = False
            '
            'btnBersihkanAkun
            '
            Me.btnBersihkanAkun.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanAkun.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanAkun.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanAkun.Location = New System.Drawing.Point(1001, 105)
            Me.btnBersihkanAkun.Name = "btnBersihkanAkun"
            Me.btnBersihkanAkun.Size = New System.Drawing.Size(137, 34)
            Me.btnBersihkanAkun.TabIndex = 13
            Me.btnBersihkanAkun.Text = "Bersihkan"
            Me.btnBersihkanAkun.UseVisualStyleBackColor = False
            '
            'dgvAkun
            '
            Me.dgvAkun.AllowUserToAddRows = False
            Me.dgvAkun.AllowUserToDeleteRows = False
            Me.dgvAkun.AllowUserToResizeRows = False
            Me.dgvAkun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvAkun.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAkun.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvAkunCol1, Me.dgvAkunCol2, Me.dgvAkunCol4, Me.dgvAkunCol5})
            Me.dgvAkun.Location = New System.Drawing.Point(20, 230)
            Me.dgvAkun.MultiSelect = False
            Me.dgvAkun.Name = "dgvAkun"
            Me.dgvAkun.ReadOnly = True
            Me.dgvAkun.RowHeadersVisible = False
            Me.dgvAkun.RowHeadersWidth = 51
            Me.dgvAkun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAkun.Size = New System.Drawing.Size(1150, 325)
            Me.dgvAkun.TabIndex = 2
            '
            'tpPersetujuanBB
            '
            Me.tpPersetujuanBB.BackColor = System.Drawing.Color.CadetBlue
            Me.tpPersetujuanBB.Controls.Add(Me.lblTitlePersetujuanBB)
            Me.tpPersetujuanBB.Controls.Add(Me.lblPetunjukPersetujuanBB)
            Me.tpPersetujuanBB.Controls.Add(Me.dgvPersetujuanBB)
            Me.tpPersetujuanBB.Controls.Add(Me.btnSetujuiPersetujuanBB)
            Me.tpPersetujuanBB.Controls.Add(Me.btnTolakPersetujuanBB)
            Me.tpPersetujuanBB.Location = New System.Drawing.Point(4, 33)
            Me.tpPersetujuanBB.Name = "tpPersetujuanBB"
            Me.tpPersetujuanBB.Size = New System.Drawing.Size(1202, 553)
            Me.tpPersetujuanBB.TabIndex = 1
            Me.tpPersetujuanBB.Text = "Persetujuan Pengadaan"
            '
            'lblTitlePersetujuanBB
            '
            Me.lblTitlePersetujuanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblTitlePersetujuanBB.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitlePersetujuanBB.ForeColor = System.Drawing.Color.White
            Me.lblTitlePersetujuanBB.Location = New System.Drawing.Point(398, 9)
            Me.lblTitlePersetujuanBB.Name = "lblTitlePersetujuanBB"
            Me.lblTitlePersetujuanBB.Size = New System.Drawing.Size(565, 35)
            Me.lblTitlePersetujuanBB.TabIndex = 0
            Me.lblTitlePersetujuanBB.Text = "PERSETUJUAN PENGADAAN"
            Me.lblTitlePersetujuanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblPetunjukPersetujuanBB
            '
            Me.lblPetunjukPersetujuanBB.BackColor = System.Drawing.Color.Transparent
            Me.lblPetunjukPersetujuanBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPetunjukPersetujuanBB.ForeColor = System.Drawing.Color.Red
            Me.lblPetunjukPersetujuanBB.Location = New System.Drawing.Point(22, 55)
            Me.lblPetunjukPersetujuanBB.Name = "lblPetunjukPersetujuanBB"
            Me.lblPetunjukPersetujuanBB.Size = New System.Drawing.Size(1120, 28)
            Me.lblPetunjukPersetujuanBB.TabIndex = 1
            Me.lblPetunjukPersetujuanBB.Text = "Pilih pengadaan pada tabel, lalu tentukan persetujuan."
            Me.lblPetunjukPersetujuanBB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvPersetujuanBB
            '
            Me.dgvPersetujuanBB.AllowUserToAddRows = False
            Me.dgvPersetujuanBB.AllowUserToDeleteRows = False
            Me.dgvPersetujuanBB.AllowUserToResizeRows = False
            Me.dgvPersetujuanBB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPersetujuanBB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvPersetujuanBB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPersetujuanBB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPersetujuanBBCol1, Me.dgvPersetujuanBBCol2, Me.dgvPersetujuanBBCol3, Me.dgvPersetujuanBBCol4, Me.dgvPersetujuanBBCol5})
            Me.dgvPersetujuanBB.Location = New System.Drawing.Point(20, 95)
            Me.dgvPersetujuanBB.MultiSelect = False
            Me.dgvPersetujuanBB.Name = "dgvPersetujuanBB"
            Me.dgvPersetujuanBB.ReadOnly = True
            Me.dgvPersetujuanBB.RowHeadersVisible = False
            Me.dgvPersetujuanBB.RowHeadersWidth = 51
            Me.dgvPersetujuanBB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersetujuanBB.Size = New System.Drawing.Size(1150, 365)
            Me.dgvPersetujuanBB.TabIndex = 2
            '
            'dgvPersetujuanBBCol1
            '
            Me.dgvPersetujuanBBCol1.HeaderText = "No. Pengadaan"
            Me.dgvPersetujuanBBCol1.MinimumWidth = 6
            Me.dgvPersetujuanBBCol1.Name = "dgvPersetujuanBBCol1"
            Me.dgvPersetujuanBBCol1.ReadOnly = True
            Me.dgvPersetujuanBBCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersetujuanBBCol2
            '
            Me.dgvPersetujuanBBCol2.HeaderText = "Tanggal"
            Me.dgvPersetujuanBBCol2.MinimumWidth = 6
            Me.dgvPersetujuanBBCol2.Name = "dgvPersetujuanBBCol2"
            Me.dgvPersetujuanBBCol2.ReadOnly = True
            Me.dgvPersetujuanBBCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersetujuanBBCol3
            '
            Me.dgvPersetujuanBBCol3.HeaderText = "Bahan Baku"
            Me.dgvPersetujuanBBCol3.MinimumWidth = 6
            Me.dgvPersetujuanBBCol3.Name = "dgvPersetujuanBBCol3"
            Me.dgvPersetujuanBBCol3.ReadOnly = True
            Me.dgvPersetujuanBBCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersetujuanBBCol4
            '
            Me.dgvPersetujuanBBCol4.HeaderText = "Total (Rp)"
            Me.dgvPersetujuanBBCol4.MinimumWidth = 6
            Me.dgvPersetujuanBBCol4.Name = "dgvPersetujuanBBCol4"
            Me.dgvPersetujuanBBCol4.ReadOnly = True
            Me.dgvPersetujuanBBCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvPersetujuanBBCol5
            '
            Me.dgvPersetujuanBBCol5.HeaderText = "Status"
            Me.dgvPersetujuanBBCol5.MinimumWidth = 6
            Me.dgvPersetujuanBBCol5.Name = "dgvPersetujuanBBCol5"
            Me.dgvPersetujuanBBCol5.ReadOnly = True
            Me.dgvPersetujuanBBCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'btnSetujuiPersetujuanBB
            '
            Me.btnSetujuiPersetujuanBB.BackColor = System.Drawing.Color.Teal
            Me.btnSetujuiPersetujuanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSetujuiPersetujuanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSetujuiPersetujuanBB.ForeColor = System.Drawing.Color.White
            Me.btnSetujuiPersetujuanBB.Location = New System.Drawing.Point(760, 480)
            Me.btnSetujuiPersetujuanBB.Name = "btnSetujuiPersetujuanBB"
            Me.btnSetujuiPersetujuanBB.Size = New System.Drawing.Size(150, 42)
            Me.btnSetujuiPersetujuanBB.TabIndex = 3
            Me.btnSetujuiPersetujuanBB.Text = "Setujui"
            Me.btnSetujuiPersetujuanBB.UseVisualStyleBackColor = False
            '
            'btnTolakPersetujuanBB
            '
            Me.btnTolakPersetujuanBB.BackColor = System.Drawing.Color.Brown
            Me.btnTolakPersetujuanBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTolakPersetujuanBB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTolakPersetujuanBB.ForeColor = System.Drawing.Color.White
            Me.btnTolakPersetujuanBB.Location = New System.Drawing.Point(930, 480)
            Me.btnTolakPersetujuanBB.Name = "btnTolakPersetujuanBB"
            Me.btnTolakPersetujuanBB.Size = New System.Drawing.Size(150, 42)
            Me.btnTolakPersetujuanBB.TabIndex = 4
            Me.btnTolakPersetujuanBB.Text = "Tolak"
            Me.btnTolakPersetujuanBB.UseVisualStyleBackColor = False
            '
            'tpDataLayanan
            '
            Me.tpDataLayanan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpDataLayanan.Controls.Add(Me.lblTitleDataLayanan)
            Me.tpDataLayanan.Controls.Add(Me.pnlDataLayanan)
            Me.tpDataLayanan.Controls.Add(Me.dgvDataLayanan)
            Me.tpDataLayanan.Location = New System.Drawing.Point(4, 33)
            Me.tpDataLayanan.Name = "tpDataLayanan"
            Me.tpDataLayanan.Size = New System.Drawing.Size(1202, 553)
            Me.tpDataLayanan.TabIndex = 2
            Me.tpDataLayanan.Text = "Data Layanan"
            '
            'lblTitleDataLayanan
            '
            Me.lblTitleDataLayanan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleDataLayanan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleDataLayanan.ForeColor = System.Drawing.Color.White
            Me.lblTitleDataLayanan.Location = New System.Drawing.Point(507, 8)
            Me.lblTitleDataLayanan.Name = "lblTitleDataLayanan"
            Me.lblTitleDataLayanan.Size = New System.Drawing.Size(334, 35)
            Me.lblTitleDataLayanan.TabIndex = 0
            Me.lblTitleDataLayanan.Text = "DATA LAYANAN"
            Me.lblTitleDataLayanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlDataLayanan
            '
            Me.pnlDataLayanan.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.pnlDataLayanan.Controls.Add(Me.lbltxtLayananKode)
            Me.pnlDataLayanan.Controls.Add(Me.txtLayananKode)
            Me.pnlDataLayanan.Controls.Add(Me.lbltxtLayananNama)
            Me.pnlDataLayanan.Controls.Add(Me.txtLayananNama)
            Me.pnlDataLayanan.Controls.Add(Me.lbltxtLayananDeskripsi)
            Me.pnlDataLayanan.Controls.Add(Me.txtLayananDeskripsi)
            Me.pnlDataLayanan.Controls.Add(Me.lbltxtLayananHarga)
            Me.pnlDataLayanan.Controls.Add(Me.txtLayananHarga)
            Me.pnlDataLayanan.Controls.Add(Me.lbltxtLayananEstimasi)
            Me.pnlDataLayanan.Controls.Add(Me.txtLayananEstimasi)
            Me.pnlDataLayanan.Controls.Add(Me.btnTambahDataLayanan)
            Me.pnlDataLayanan.Controls.Add(Me.btnUbahDataLayanan)
            Me.pnlDataLayanan.Controls.Add(Me.btnHapusDataLayanan)
            Me.pnlDataLayanan.Controls.Add(Me.btnBersihkanDataLayanan)
            Me.pnlDataLayanan.Location = New System.Drawing.Point(20, 55)
            Me.pnlDataLayanan.Name = "pnlDataLayanan"
            Me.pnlDataLayanan.Size = New System.Drawing.Size(1150, 160)
            Me.pnlDataLayanan.TabIndex = 1
            '
            'lbltxtLayananKode
            '
            Me.lbltxtLayananKode.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtLayananKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtLayananKode.ForeColor = System.Drawing.Color.White
            Me.lbltxtLayananKode.Location = New System.Drawing.Point(15, 16)
            Me.lbltxtLayananKode.Name = "lbltxtLayananKode"
            Me.lbltxtLayananKode.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtLayananKode.TabIndex = 0
            Me.lbltxtLayananKode.Text = "Kode Layanan"
            Me.lbltxtLayananKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtLayananKode
            '
            Me.txtLayananKode.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtLayananKode.Location = New System.Drawing.Point(15, 43)
            Me.txtLayananKode.Name = "txtLayananKode"
            Me.txtLayananKode.Size = New System.Drawing.Size(190, 30)
            Me.txtLayananKode.TabIndex = 1
            '
            'lbltxtLayananNama
            '
            Me.lbltxtLayananNama.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtLayananNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtLayananNama.ForeColor = System.Drawing.Color.White
            Me.lbltxtLayananNama.Location = New System.Drawing.Point(217, 16)
            Me.lbltxtLayananNama.Name = "lbltxtLayananNama"
            Me.lbltxtLayananNama.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtLayananNama.TabIndex = 2
            Me.lbltxtLayananNama.Text = "Nama Layanan"
            Me.lbltxtLayananNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtLayananNama
            '
            Me.txtLayananNama.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtLayananNama.Location = New System.Drawing.Point(217, 43)
            Me.txtLayananNama.Name = "txtLayananNama"
            Me.txtLayananNama.Size = New System.Drawing.Size(190, 30)
            Me.txtLayananNama.TabIndex = 3
            '
            'lbltxtLayananDeskripsi
            '
            Me.lbltxtLayananDeskripsi.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtLayananDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtLayananDeskripsi.ForeColor = System.Drawing.Color.White
            Me.lbltxtLayananDeskripsi.Location = New System.Drawing.Point(419, 16)
            Me.lbltxtLayananDeskripsi.Name = "lbltxtLayananDeskripsi"
            Me.lbltxtLayananDeskripsi.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtLayananDeskripsi.TabIndex = 4
            Me.lbltxtLayananDeskripsi.Text = "Jenis Layanan"
            Me.lbltxtLayananDeskripsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtLayananDeskripsi
            '
            Me.txtLayananDeskripsi.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtLayananDeskripsi.Location = New System.Drawing.Point(419, 43)
            Me.txtLayananDeskripsi.Name = "txtLayananDeskripsi"
            Me.txtLayananDeskripsi.Size = New System.Drawing.Size(190, 30)
            Me.txtLayananDeskripsi.TabIndex = 5
            '
            'lbltxtLayananHarga
            '
            Me.lbltxtLayananHarga.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtLayananHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtLayananHarga.ForeColor = System.Drawing.Color.White
            Me.lbltxtLayananHarga.Location = New System.Drawing.Point(621, 16)
            Me.lbltxtLayananHarga.Name = "lbltxtLayananHarga"
            Me.lbltxtLayananHarga.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtLayananHarga.TabIndex = 6
            Me.lbltxtLayananHarga.Text = "Harga (Rp)"
            Me.lbltxtLayananHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtLayananHarga
            '
            Me.txtLayananHarga.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtLayananHarga.Location = New System.Drawing.Point(621, 43)
            Me.txtLayananHarga.Name = "txtLayananHarga"
            Me.txtLayananHarga.Size = New System.Drawing.Size(190, 30)
            Me.txtLayananHarga.TabIndex = 7
            '
            'lbltxtLayananEstimasi
            '
            Me.lbltxtLayananEstimasi.BackColor = System.Drawing.Color.Transparent
            Me.lbltxtLayananEstimasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltxtLayananEstimasi.ForeColor = System.Drawing.Color.White
            Me.lbltxtLayananEstimasi.Location = New System.Drawing.Point(823, 16)
            Me.lbltxtLayananEstimasi.Name = "lbltxtLayananEstimasi"
            Me.lbltxtLayananEstimasi.Size = New System.Drawing.Size(190, 23)
            Me.lbltxtLayananEstimasi.TabIndex = 8
            Me.lbltxtLayananEstimasi.Text = "Estimasi Hari"
            Me.lbltxtLayananEstimasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtLayananEstimasi
            '
            Me.txtLayananEstimasi.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.txtLayananEstimasi.Location = New System.Drawing.Point(823, 43)
            Me.txtLayananEstimasi.Name = "txtLayananEstimasi"
            Me.txtLayananEstimasi.Size = New System.Drawing.Size(190, 30)
            Me.txtLayananEstimasi.TabIndex = 9
            '
            'btnTambahDataLayanan
            '
            Me.btnTambahDataLayanan.BackColor = System.Drawing.Color.Teal
            Me.btnTambahDataLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTambahDataLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnTambahDataLayanan.ForeColor = System.Drawing.Color.White
            Me.btnTambahDataLayanan.Location = New System.Drawing.Point(15, 105)
            Me.btnTambahDataLayanan.Name = "btnTambahDataLayanan"
            Me.btnTambahDataLayanan.Size = New System.Drawing.Size(100, 34)
            Me.btnTambahDataLayanan.TabIndex = 10
            Me.btnTambahDataLayanan.Text = "Tambah"
            Me.btnTambahDataLayanan.UseVisualStyleBackColor = False
            '
            'btnUbahDataLayanan
            '
            Me.btnUbahDataLayanan.BackColor = System.Drawing.Color.LightSeaGreen
            Me.btnUbahDataLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUbahDataLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUbahDataLayanan.ForeColor = System.Drawing.Color.White
            Me.btnUbahDataLayanan.Location = New System.Drawing.Point(127, 105)
            Me.btnUbahDataLayanan.Name = "btnUbahDataLayanan"
            Me.btnUbahDataLayanan.Size = New System.Drawing.Size(100, 34)
            Me.btnUbahDataLayanan.TabIndex = 11
            Me.btnUbahDataLayanan.Text = "Ubah"
            Me.btnUbahDataLayanan.UseVisualStyleBackColor = False
            '
            'btnHapusDataLayanan
            '
            Me.btnHapusDataLayanan.BackColor = System.Drawing.Color.Brown
            Me.btnHapusDataLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnHapusDataLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnHapusDataLayanan.ForeColor = System.Drawing.Color.White
            Me.btnHapusDataLayanan.Location = New System.Drawing.Point(913, 105)
            Me.btnHapusDataLayanan.Name = "btnHapusDataLayanan"
            Me.btnHapusDataLayanan.Size = New System.Drawing.Size(100, 34)
            Me.btnHapusDataLayanan.TabIndex = 12
            Me.btnHapusDataLayanan.Text = "Hapus"
            Me.btnHapusDataLayanan.UseVisualStyleBackColor = False
            '
            'btnBersihkanDataLayanan
            '
            Me.btnBersihkanDataLayanan.BackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.btnBersihkanDataLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBersihkanDataLayanan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnBersihkanDataLayanan.ForeColor = System.Drawing.Color.White
            Me.btnBersihkanDataLayanan.Location = New System.Drawing.Point(1014, 105)
            Me.btnBersihkanDataLayanan.Name = "btnBersihkanDataLayanan"
            Me.btnBersihkanDataLayanan.Size = New System.Drawing.Size(122, 34)
            Me.btnBersihkanDataLayanan.TabIndex = 13
            Me.btnBersihkanDataLayanan.Text = "Bersihkan"
            Me.btnBersihkanDataLayanan.UseVisualStyleBackColor = False
            '
            'dgvDataLayanan
            '
            Me.dgvDataLayanan.AllowUserToAddRows = False
            Me.dgvDataLayanan.AllowUserToDeleteRows = False
            Me.dgvDataLayanan.AllowUserToResizeRows = False
            Me.dgvDataLayanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDataLayanan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.dgvDataLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDataLayanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDataLayananCol1, Me.dgvDataLayananCol2, Me.dgvDataLayananCol3, Me.dgvDataLayananCol4, Me.dgvDataLayananCol5})
            Me.dgvDataLayanan.Location = New System.Drawing.Point(20, 230)
            Me.dgvDataLayanan.MultiSelect = False
            Me.dgvDataLayanan.Name = "dgvDataLayanan"
            Me.dgvDataLayanan.ReadOnly = True
            Me.dgvDataLayanan.RowHeadersVisible = False
            Me.dgvDataLayanan.RowHeadersWidth = 51
            Me.dgvDataLayanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDataLayanan.Size = New System.Drawing.Size(1150, 325)
            Me.dgvDataLayanan.TabIndex = 2
            '
            'dgvDataLayananCol1
            '
            Me.dgvDataLayananCol1.HeaderText = "Kode Layanan"
            Me.dgvDataLayananCol1.MinimumWidth = 6
            Me.dgvDataLayananCol1.Name = "dgvDataLayananCol1"
            Me.dgvDataLayananCol1.ReadOnly = True
            Me.dgvDataLayananCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvDataLayananCol2
            '
            Me.dgvDataLayananCol2.HeaderText = "Nama Layanan"
            Me.dgvDataLayananCol2.MinimumWidth = 6
            Me.dgvDataLayananCol2.Name = "dgvDataLayananCol2"
            Me.dgvDataLayananCol2.ReadOnly = True
            Me.dgvDataLayananCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvDataLayananCol3
            '
            Me.dgvDataLayananCol3.HeaderText = "Jenis Layanan"
            Me.dgvDataLayananCol3.MinimumWidth = 6
            Me.dgvDataLayananCol3.Name = "dgvDataLayananCol3"
            Me.dgvDataLayananCol3.ReadOnly = True
            Me.dgvDataLayananCol3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvDataLayananCol4
            '
            Me.dgvDataLayananCol4.HeaderText = "Harga"
            Me.dgvDataLayananCol4.MinimumWidth = 6
            Me.dgvDataLayananCol4.Name = "dgvDataLayananCol4"
            Me.dgvDataLayananCol4.ReadOnly = True
            Me.dgvDataLayananCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvDataLayananCol5
            '
            Me.dgvDataLayananCol5.HeaderText = "Estimasi"
            Me.dgvDataLayananCol5.MinimumWidth = 6
            Me.dgvDataLayananCol5.Name = "dgvDataLayananCol5"
            Me.dgvDataLayananCol5.ReadOnly = True
            Me.dgvDataLayananCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'tpCekPenjualan
            '
            Me.tpCekPenjualan.BackColor = System.Drawing.Color.CadetBlue
            Me.tpCekPenjualan.Controls.Add(Me.lblTitleCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.txtCariCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.lblCariCekPenjualan)
            Me.tpCekPenjualan.Controls.Add(Me.dgvCekPenjualan)
            Me.tpCekPenjualan.Location = New System.Drawing.Point(4, 33)
            Me.tpCekPenjualan.Name = "tpCekPenjualan"
            Me.tpCekPenjualan.Size = New System.Drawing.Size(1202, 553)
            Me.tpCekPenjualan.TabIndex = 3
            Me.tpCekPenjualan.Text = "Cek Penjualan"
            '
            'lblTitleCekPenjualan
            '
            Me.lblTitleCekPenjualan.BackColor = System.Drawing.Color.Transparent
            Me.lblTitleCekPenjualan.Font = New System.Drawing.Font("Bookman Old Style", 17.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitleCekPenjualan.ForeColor = System.Drawing.Color.White
            Me.lblTitleCekPenjualan.Location = New System.Drawing.Point(490, 12)
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
            Me.dgvCekPenjualan.Location = New System.Drawing.Point(20, 115)
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
            Me.Panel1.TabIndex = 17
            '
            'lblBrand
            '
            Me.lblBrand.BackColor = System.Drawing.Color.Transparent
            Me.lblBrand.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblBrand.ForeColor = System.Drawing.Color.White
            Me.lblBrand.Location = New System.Drawing.Point(104, 33)
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
            Me.lblActor.Location = New System.Drawing.Point(1102, 15)
            Me.lblActor.Name = "lblActor"
            Me.lblActor.Size = New System.Drawing.Size(127, 45)
            Me.lblActor.TabIndex = 10
            Me.lblActor.Text = "Pemilik"
            Me.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.SteelBlue
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(1102, 63)
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
            'dgvAkunCol1
            '
            Me.dgvAkunCol1.HeaderText = "No. ID"
            Me.dgvAkunCol1.MinimumWidth = 6
            Me.dgvAkunCol1.Name = "dgvAkunCol1"
            Me.dgvAkunCol1.ReadOnly = True
            Me.dgvAkunCol1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvAkunCol2
            '
            Me.dgvAkunCol2.HeaderText = "Nama"
            Me.dgvAkunCol2.MinimumWidth = 6
            Me.dgvAkunCol2.Name = "dgvAkunCol2"
            Me.dgvAkunCol2.ReadOnly = True
            Me.dgvAkunCol2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvAkunCol4
            '
            Me.dgvAkunCol4.HeaderText = "Divisi"
            Me.dgvAkunCol4.MinimumWidth = 6
            Me.dgvAkunCol4.Name = "dgvAkunCol4"
            Me.dgvAkunCol4.ReadOnly = True
            Me.dgvAkunCol4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'dgvAkunCol5
            '
            Me.dgvAkunCol5.HeaderText = "Kata Sandi"
            Me.dgvAkunCol5.MinimumWidth = 6
            Me.dgvAkunCol5.Name = "dgvAkunCol5"
            Me.dgvAkunCol5.ReadOnly = True
            Me.dgvAkunCol5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'FrmPemilik
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
            Me.Name = "FrmPemilik"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shoelusi - Pemilik"
            Me.tabMain.ResumeLayout(False)
            Me.tpAkun.ResumeLayout(False)
            Me.pnlAkun.ResumeLayout(False)
            Me.pnlAkun.PerformLayout()
            CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpPersetujuanBB.ResumeLayout(False)
            CType(Me.dgvPersetujuanBB, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpDataLayanan.ResumeLayout(False)
            Me.pnlDataLayanan.ResumeLayout(False)
            Me.pnlDataLayanan.PerformLayout()
            CType(Me.dgvDataLayanan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCekPenjualan.ResumeLayout(False)
            Me.tpCekPenjualan.PerformLayout()
            CType(Me.dgvCekPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private components As System.ComponentModel.IContainer
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tpAkun As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleAkun As System.Windows.Forms.Label
        Friend WithEvents pnlAkun As System.Windows.Forms.Panel
        Friend WithEvents lbltxtAkunID As System.Windows.Forms.Label
        Friend WithEvents txtAkunID As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtAkunNama As System.Windows.Forms.Label
        Friend WithEvents txtAkunNama As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtAkunRole As System.Windows.Forms.Label
        Friend WithEvents txtAkunRole As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtAkunStatus As System.Windows.Forms.Label
        Friend WithEvents txtAkunStatus As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahAkun As System.Windows.Forms.Button
        Friend WithEvents btnUbahAkun As System.Windows.Forms.Button
        Friend WithEvents btnHapusAkun As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanAkun As System.Windows.Forms.Button
        Friend WithEvents dgvAkun As System.Windows.Forms.DataGridView
        Friend WithEvents tpPersetujuanBB As System.Windows.Forms.TabPage
        Friend WithEvents lblTitlePersetujuanBB As System.Windows.Forms.Label
        Friend WithEvents lblPetunjukPersetujuanBB As System.Windows.Forms.Label
        Friend WithEvents dgvPersetujuanBB As System.Windows.Forms.DataGridView
        Friend WithEvents dgvPersetujuanBBCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersetujuanBBCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersetujuanBBCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersetujuanBBCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvPersetujuanBBCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnSetujuiPersetujuanBB As System.Windows.Forms.Button
        Friend WithEvents btnTolakPersetujuanBB As System.Windows.Forms.Button
        Friend WithEvents tpDataLayanan As System.Windows.Forms.TabPage
        Friend WithEvents lblTitleDataLayanan As System.Windows.Forms.Label
        Friend WithEvents pnlDataLayanan As System.Windows.Forms.Panel
        Friend WithEvents lbltxtLayananKode As System.Windows.Forms.Label
        Friend WithEvents txtLayananKode As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtLayananNama As System.Windows.Forms.Label
        Friend WithEvents txtLayananNama As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtLayananDeskripsi As System.Windows.Forms.Label
        Friend WithEvents txtLayananDeskripsi As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtLayananHarga As System.Windows.Forms.Label
        Friend WithEvents txtLayananHarga As System.Windows.Forms.TextBox
        Friend WithEvents lbltxtLayananEstimasi As System.Windows.Forms.Label
        Friend WithEvents txtLayananEstimasi As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahDataLayanan As System.Windows.Forms.Button
        Friend WithEvents btnUbahDataLayanan As System.Windows.Forms.Button
        Friend WithEvents btnHapusDataLayanan As System.Windows.Forms.Button
        Friend WithEvents btnBersihkanDataLayanan As System.Windows.Forms.Button
        Friend WithEvents dgvDataLayanan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDataLayananCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDataLayananCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDataLayananCol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDataLayananCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDataLayananCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
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
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents lblActor As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dgvAkunCol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvAkunCol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvAkunCol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvAkunCol5 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
