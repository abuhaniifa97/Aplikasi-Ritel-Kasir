<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDataProdusen = New System.Windows.Forms.Button()
        Me.b_dtapelanggan = New System.Windows.Forms.Button()
        Me.b_dtaproduk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_pembayaran = New System.Windows.Forms.Button()
        Me.b_pembelian = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.b_pembelian2 = New System.Windows.Forms.Button()
        Me.b_penjualan = New System.Windows.Forms.Button()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.b_import = New System.Windows.Forms.Button()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_edit = New System.Windows.Forms.Button()
        Me.b_Refresh = New System.Windows.Forms.Button()
        Me.b_tambah = New System.Windows.Forms.Button()
        Me.DataprodukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lomba1DataSet = New lomba.lomba1DataSet()
        Me.DatapelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_pelangganTableAdapter = New lomba.lomba1DataSetTableAdapters.data_pelangganTableAdapter()
        Me.Data_produkTableAdapter = New lomba.lomba1DataSetTableAdapters.data_produkTableAdapter()
        Me.txtHiddenKode = New System.Windows.Forms.TextBox()
        Me.grpPembelian = New System.Windows.Forms.GroupBox()
        Me.grpPembayaran = New System.Windows.Forms.GroupBox()
        Me.lblSisa = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvPembayaran = New System.Windows.Forms.DataGridView()
        Me.lblTipePemb = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblPajak = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblKodePembelian = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotHarga = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpTipePembayaran = New System.Windows.Forms.GroupBox()
        Me.rdoKredit = New System.Windows.Forms.RadioButton()
        Me.rdoTunai = New System.Windows.Forms.RadioButton()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.dgvPembelian = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LatihanDataSet1 = New lomba.latihanDataSet()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataprodukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lomba1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatapelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPembelian.SuspendLayout()
        Me.grpPembayaran.SuspendLayout()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipePembayaran.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatihanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1353, 92)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOKO HANIIFA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "REKAYASA PERANGKAT LUNAK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(1263, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Red
        Me.lblJudul.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblJudul.Location = New System.Drawing.Point(1, 91)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(1353, 23)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "SMK NEGERI 1 CIKEDUNG"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(1263, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDataProdusen)
        Me.GroupBox1.Controls.Add(Me.b_dtapelanggan)
        Me.GroupBox1.Controls.Add(Me.b_dtaproduk)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 171)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'btnDataProdusen
        '
        Me.btnDataProdusen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataProdusen.Location = New System.Drawing.Point(0, 69)
        Me.btnDataProdusen.Name = "btnDataProdusen"
        Me.btnDataProdusen.Size = New System.Drawing.Size(187, 50)
        Me.btnDataProdusen.TabIndex = 1
        Me.btnDataProdusen.Text = "Data Produsen"
        Me.btnDataProdusen.UseVisualStyleBackColor = True
        '
        'b_dtapelanggan
        '
        Me.b_dtapelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_dtapelanggan.Location = New System.Drawing.Point(0, 19)
        Me.b_dtapelanggan.Name = "b_dtapelanggan"
        Me.b_dtapelanggan.Size = New System.Drawing.Size(187, 50)
        Me.b_dtapelanggan.TabIndex = 0
        Me.b_dtapelanggan.Text = "Data Pelanggan"
        Me.b_dtapelanggan.UseVisualStyleBackColor = True
        '
        'b_dtaproduk
        '
        Me.b_dtaproduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_dtaproduk.Location = New System.Drawing.Point(0, 119)
        Me.b_dtaproduk.Name = "b_dtaproduk"
        Me.b_dtaproduk.Size = New System.Drawing.Size(187, 50)
        Me.b_dtaproduk.TabIndex = 1
        Me.b_dtaproduk.Text = "Data Produk"
        Me.b_dtaproduk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_pembayaran)
        Me.GroupBox2.Controls.Add(Me.b_pembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 120)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pelanggan"
        '
        'b_pembayaran
        '
        Me.b_pembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_pembayaran.Location = New System.Drawing.Point(0, 69)
        Me.b_pembayaran.Name = "b_pembayaran"
        Me.b_pembayaran.Size = New System.Drawing.Size(186, 50)
        Me.b_pembayaran.TabIndex = 1
        Me.b_pembayaran.Text = "Pembayaran"
        Me.b_pembayaran.UseVisualStyleBackColor = True
        '
        'b_pembelian
        '
        Me.b_pembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_pembelian.Location = New System.Drawing.Point(0, 19)
        Me.b_pembelian.Name = "b_pembelian"
        Me.b_pembelian.Size = New System.Drawing.Size(186, 50)
        Me.b_pembelian.TabIndex = 0
        Me.b_pembelian.Text = "Pembelian"
        Me.b_pembelian.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.b_pembelian2)
        Me.GroupBox3.Controls.Add(Me.b_penjualan)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(188, 133)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan"
        '
        'b_pembelian2
        '
        Me.b_pembelian2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_pembelian2.Location = New System.Drawing.Point(0, 69)
        Me.b_pembelian2.Name = "b_pembelian2"
        Me.b_pembelian2.Size = New System.Drawing.Size(187, 50)
        Me.b_pembelian2.TabIndex = 10
        Me.b_pembelian2.Text = "Pembelian"
        Me.b_pembelian2.UseVisualStyleBackColor = True
        '
        'b_penjualan
        '
        Me.b_penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_penjualan.Location = New System.Drawing.Point(0, 19)
        Me.b_penjualan.Name = "b_penjualan"
        Me.b_penjualan.Size = New System.Drawing.Size(187, 50)
        Me.b_penjualan.TabIndex = 9
        Me.b_penjualan.Text = "Penjualan"
        Me.b_penjualan.UseVisualStyleBackColor = True
        '
        'dgv_data
        '
        Me.dgv_data.AllowUserToDeleteRows = False
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Location = New System.Drawing.Point(210, 117)
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.ReadOnly = True
        Me.dgv_data.Size = New System.Drawing.Size(1144, 366)
        Me.dgv_data.TabIndex = 10
        Me.dgv_data.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(203, 1045)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1352, 164)
        Me.Label7.TabIndex = 16
        '
        'b_import
        '
        Me.b_import.Location = New System.Drawing.Point(315, 499)
        Me.b_import.Name = "b_import"
        Me.b_import.Size = New System.Drawing.Size(77, 37)
        Me.b_import.TabIndex = 15
        Me.b_import.Text = "Import CSV"
        Me.b_import.UseVisualStyleBackColor = True
        Me.b_import.Visible = False
        '
        'b_hapus
        '
        Me.b_hapus.Location = New System.Drawing.Point(1236, 500)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(88, 37)
        Me.b_hapus.TabIndex = 14
        Me.b_hapus.Text = "Hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        Me.b_hapus.Visible = False
        '
        'b_edit
        '
        Me.b_edit.Location = New System.Drawing.Point(1142, 500)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(88, 37)
        Me.b_edit.TabIndex = 13
        Me.b_edit.Text = "Edit"
        Me.b_edit.UseVisualStyleBackColor = True
        Me.b_edit.Visible = False
        '
        'b_Refresh
        '
        Me.b_Refresh.Location = New System.Drawing.Point(1048, 500)
        Me.b_Refresh.Name = "b_Refresh"
        Me.b_Refresh.Size = New System.Drawing.Size(88, 37)
        Me.b_Refresh.TabIndex = 12
        Me.b_Refresh.Text = "Refresh"
        Me.b_Refresh.UseVisualStyleBackColor = True
        Me.b_Refresh.Visible = False
        '
        'b_tambah
        '
        Me.b_tambah.Location = New System.Drawing.Point(231, 498)
        Me.b_tambah.Name = "b_tambah"
        Me.b_tambah.Size = New System.Drawing.Size(77, 37)
        Me.b_tambah.TabIndex = 11
        Me.b_tambah.Text = "Tambah Data"
        Me.b_tambah.UseVisualStyleBackColor = True
        Me.b_tambah.Visible = False
        '
        'DataprodukBindingSource
        '
        Me.DataprodukBindingSource.DataMember = "data_produk"
        Me.DataprodukBindingSource.DataSource = Me.Lomba1DataSet
        '
        'Lomba1DataSet
        '
        Me.Lomba1DataSet.DataSetName = "lomba1DataSet"
        Me.Lomba1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatapelangganBindingSource
        '
        Me.DatapelangganBindingSource.DataMember = "data_pelanggan"
        Me.DatapelangganBindingSource.DataSource = Me.Lomba1DataSet
        '
        'Data_pelangganTableAdapter
        '
        Me.Data_pelangganTableAdapter.ClearBeforeFill = True
        '
        'Data_produkTableAdapter
        '
        Me.Data_produkTableAdapter.ClearBeforeFill = True
        '
        'txtHiddenKode
        '
        Me.txtHiddenKode.Location = New System.Drawing.Point(1254, 93)
        Me.txtHiddenKode.Name = "txtHiddenKode"
        Me.txtHiddenKode.Size = New System.Drawing.Size(100, 20)
        Me.txtHiddenKode.TabIndex = 17
        '
        'grpPembelian
        '
        Me.grpPembelian.Controls.Add(Me.grpPembayaran)
        Me.grpPembelian.Controls.Add(Me.btnProses)
        Me.grpPembelian.Controls.Add(Me.Button2)
        Me.grpPembelian.Controls.Add(Me.Button1)
        Me.grpPembelian.Controls.Add(Me.lblTotHarga)
        Me.grpPembelian.Controls.Add(Me.Label9)
        Me.grpPembelian.Controls.Add(Me.grpTipePembayaran)
        Me.grpPembelian.Controls.Add(Me.dgvKeranjang)
        Me.grpPembelian.Controls.Add(Me.dgvPembelian)
        Me.grpPembelian.Controls.Add(Me.Label8)
        Me.grpPembelian.Controls.Add(Me.Label5)
        Me.grpPembelian.Location = New System.Drawing.Point(210, 117)
        Me.grpPembelian.Name = "grpPembelian"
        Me.grpPembelian.Size = New System.Drawing.Size(1144, 431)
        Me.grpPembelian.TabIndex = 18
        Me.grpPembelian.TabStop = False
        Me.grpPembelian.Visible = False
        '
        'grpPembayaran
        '
        Me.grpPembayaran.Controls.Add(Me.lblSisa)
        Me.grpPembayaran.Controls.Add(Me.Label17)
        Me.grpPembayaran.Controls.Add(Me.btnBayar)
        Me.grpPembayaran.Controls.Add(Me.txtBayar)
        Me.grpPembayaran.Controls.Add(Me.Label13)
        Me.grpPembayaran.Controls.Add(Me.dgvPembayaran)
        Me.grpPembayaran.Controls.Add(Me.lblTipePemb)
        Me.grpPembayaran.Controls.Add(Me.Label15)
        Me.grpPembayaran.Controls.Add(Me.lblStatus)
        Me.grpPembayaran.Controls.Add(Me.Label20)
        Me.grpPembayaran.Controls.Add(Me.lblTotal)
        Me.grpPembayaran.Controls.Add(Me.Label18)
        Me.grpPembayaran.Controls.Add(Me.lblPajak)
        Me.grpPembayaran.Controls.Add(Me.Label16)
        Me.grpPembayaran.Controls.Add(Me.lblDiscount)
        Me.grpPembayaran.Controls.Add(Me.Label14)
        Me.grpPembayaran.Controls.Add(Me.lblKodePembelian)
        Me.grpPembayaran.Controls.Add(Me.Label12)
        Me.grpPembayaran.Controls.Add(Me.Label11)
        Me.grpPembayaran.Controls.Add(Me.btnCari)
        Me.grpPembayaran.Controls.Add(Me.txtCari)
        Me.grpPembayaran.Controls.Add(Me.Label10)
        Me.grpPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPembayaran.Location = New System.Drawing.Point(12, 16)
        Me.grpPembayaran.Name = "grpPembayaran"
        Me.grpPembayaran.Size = New System.Drawing.Size(1132, 402)
        Me.grpPembayaran.TabIndex = 20
        Me.grpPembayaran.TabStop = False
        Me.grpPembayaran.Text = "Pembayaran"
        Me.grpPembayaran.Visible = False
        '
        'lblSisa
        '
        Me.lblSisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSisa.Location = New System.Drawing.Point(283, 378)
        Me.lblSisa.Name = "lblSisa"
        Me.lblSisa.Size = New System.Drawing.Size(128, 13)
        Me.lblSisa.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(159, 378)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Sisa Pembayaran Rp."
        '
        'btnBayar
        '
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.Location = New System.Drawing.Point(323, 346)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 19
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(162, 347)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(146, 23)
        Me.txtBayar.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(159, 326)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Masukan Jumlah Pembayaran"
        '
        'dgvPembayaran
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPembayaran.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembayaran.Location = New System.Drawing.Point(162, 114)
        Me.dgvPembayaran.Name = "dgvPembayaran"
        Me.dgvPembayaran.Size = New System.Drawing.Size(743, 150)
        Me.dgvPembayaran.TabIndex = 16
        '
        'lblTipePemb
        '
        Me.lblTipePemb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipePemb.Location = New System.Drawing.Point(159, 299)
        Me.lblTipePemb.Name = "lblTipePemb"
        Me.lblTipePemb.Size = New System.Drawing.Size(98, 13)
        Me.lblTipePemb.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(158, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Tipe Pembayaran"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(10, 346)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(98, 13)
        Me.lblStatus.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 326)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Status"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(9, 299)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 13)
        Me.lblTotal.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 279)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Total Harga"
        '
        'lblPajak
        '
        Me.lblPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPajak.Location = New System.Drawing.Point(8, 248)
        Me.lblPajak.Name = "lblPajak"
        Me.lblPajak.Size = New System.Drawing.Size(98, 13)
        Me.lblPajak.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 228)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Pajak"
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(7, 200)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(135, 16)
        Me.lblDiscount.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Discount"
        '
        'lblKodePembelian
        '
        Me.lblKodePembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodePembelian.Location = New System.Drawing.Point(7, 151)
        Me.lblKodePembelian.Name = "lblKodePembelian"
        Me.lblKodePembelian.Size = New System.Drawing.Size(135, 19)
        Me.lblKodePembelian.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Kode Pembelian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Detail Pembelian"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(188, 46)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(9, 47)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(173, 22)
        Me.txtCari.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Masukan Kode Pembelian"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(1039, 373)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 32)
        Me.btnProses.TabIndex = 9
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1077, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(757, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTotHarga
        '
        Me.lblTotHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotHarga.Location = New System.Drawing.Point(110, 395)
        Me.lblTotHarga.Name = "lblTotHarga"
        Me.lblTotHarga.Size = New System.Drawing.Size(44, 23)
        Me.lblTotHarga.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total Harga : "
        '
        'grpTipePembayaran
        '
        Me.grpTipePembayaran.Controls.Add(Me.rdoKredit)
        Me.grpTipePembayaran.Controls.Add(Me.rdoTunai)
        Me.grpTipePembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipePembayaran.Location = New System.Drawing.Point(21, 331)
        Me.grpTipePembayaran.Name = "grpTipePembayaran"
        Me.grpTipePembayaran.Size = New System.Drawing.Size(200, 50)
        Me.grpTipePembayaran.TabIndex = 4
        Me.grpTipePembayaran.TabStop = False
        Me.grpTipePembayaran.Text = "Tipe Pembayaran"
        '
        'rdoKredit
        '
        Me.rdoKredit.AutoSize = True
        Me.rdoKredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKredit.Location = New System.Drawing.Point(102, 27)
        Me.rdoKredit.Name = "rdoKredit"
        Me.rdoKredit.Size = New System.Drawing.Size(52, 17)
        Me.rdoKredit.TabIndex = 1
        Me.rdoKredit.TabStop = True
        Me.rdoKredit.Text = "Kredit"
        Me.rdoKredit.UseVisualStyleBackColor = True
        '
        'rdoTunai
        '
        Me.rdoTunai.AutoSize = True
        Me.rdoTunai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTunai.Location = New System.Drawing.Point(6, 27)
        Me.rdoTunai.Name = "rdoTunai"
        Me.rdoTunai.Size = New System.Drawing.Size(52, 17)
        Me.rdoTunai.TabIndex = 0
        Me.rdoTunai.TabStop = True
        Me.rdoTunai.Text = "Tunai"
        Me.rdoTunai.UseVisualStyleBackColor = True
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(817, 82)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.Size = New System.Drawing.Size(297, 238)
        Me.dgvKeranjang.TabIndex = 3
        '
        'dgvPembelian
        '
        Me.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelian.Location = New System.Drawing.Point(21, 82)
        Me.dgvPembelian.Name = "dgvPembelian"
        Me.dgvPembelian.Size = New System.Drawing.Size(773, 238)
        Me.dgvPembelian.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Daftar Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pembelian"
        '
        'LatihanDataSet1
        '
        Me.LatihanDataSet1.DataSetName = "latihanDataSet"
        Me.LatihanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 546)
        Me.Controls.Add(Me.grpPembelian)
        Me.Controls.Add(Me.txtHiddenKode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.b_import)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_edit)
        Me.Controls.Add(Me.b_Refresh)
        Me.Controls.Add(Me.b_tambah)
        Me.Controls.Add(Me.dgv_data)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataprodukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lomba1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatapelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPembelian.ResumeLayout(False)
        Me.grpPembelian.PerformLayout()
        Me.grpPembayaran.ResumeLayout(False)
        Me.grpPembayaran.PerformLayout()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipePembayaran.ResumeLayout(False)
        Me.grpTipePembayaran.PerformLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatihanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents b_dtaproduk As Button
    Friend WithEvents b_dtapelanggan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents b_pembayaran As Button
    Friend WithEvents b_pembelian As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents b_pembelian2 As Button
    Friend WithEvents b_penjualan As Button
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lomba1DataSet As lomba1DataSet
    Friend WithEvents DatapelangganBindingSource As BindingSource
    Friend WithEvents Data_pelangganTableAdapter As lomba1DataSetTableAdapters.data_pelangganTableAdapter
    Friend WithEvents DataprodukBindingSource As BindingSource
    Friend WithEvents Data_produkTableAdapter As lomba1DataSetTableAdapters.data_produkTableAdapter
    Friend WithEvents btnDataProdusen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents b_import As Button
    Friend WithEvents b_hapus As Button
    Friend WithEvents b_edit As Button
    Friend WithEvents b_Refresh As Button
    Friend WithEvents b_tambah As Button
    Friend WithEvents txtHiddenKode As TextBox
    Friend WithEvents grpPembelian As GroupBox
    Friend WithEvents grpTipePembayaran As GroupBox
    Friend WithEvents rdoKredit As RadioButton
    Friend WithEvents rdoTunai As RadioButton
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents dgvPembelian As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotHarga As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnProses As Button
    Friend WithEvents grpPembayaran As GroupBox
    Friend WithEvents lblSisa As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents lblTipePemb As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblPajak As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblKodePembelian As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LatihanDataSet1 As latihanDataSet
End Class
