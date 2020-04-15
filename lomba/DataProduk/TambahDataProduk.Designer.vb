<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahDataProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rdoTidak = New System.Windows.Forms.RadioButton()
        Me.rdoAktif = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdoTidak)
        Me.grpStatus.Controls.Add(Me.rdoAktif)
        Me.grpStatus.Location = New System.Drawing.Point(117, 178)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(222, 24)
        Me.grpStatus.TabIndex = 62
        Me.grpStatus.TabStop = False
        '
        'rdoTidak
        '
        Me.rdoTidak.AutoSize = True
        Me.rdoTidak.Location = New System.Drawing.Point(96, -1)
        Me.rdoTidak.Name = "rdoTidak"
        Me.rdoTidak.Size = New System.Drawing.Size(90, 17)
        Me.rdoTidak.TabIndex = 18
        Me.rdoTidak.TabStop = True
        Me.rdoTidak.Text = "TIDAK AKTIF"
        Me.rdoTidak.UseVisualStyleBackColor = True
        '
        'rdoAktif
        '
        Me.rdoAktif.AutoSize = True
        Me.rdoAktif.Location = New System.Drawing.Point(15, 1)
        Me.rdoAktif.Name = "rdoAktif"
        Me.rdoAktif.Size = New System.Drawing.Size(55, 17)
        Me.rdoAktif.TabIndex = 17
        Me.rdoAktif.TabStop = True
        Me.rdoAktif.Text = "AKTIF"
        Me.rdoAktif.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-1, -2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 52)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Tambah Data"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Keterangan"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(228, 285)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 42)
        Me.btnSimpan.TabIndex = 52
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Jumlah Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Kode Produk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nama Produk"
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(132, 57)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(100, 20)
        Me.txtKode.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Jenis Produk"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(132, 80)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(171, 21)
        Me.cmbJenis.TabIndex = 65
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(132, 107)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(171, 20)
        Me.txtNama.TabIndex = 66
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(159, 130)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(144, 20)
        Me.txtHarga.TabIndex = 67
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(132, 152)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(171, 20)
        Me.txtStok.TabIndex = 68
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(132, 200)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(171, 20)
        Me.txtKet.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Rp."
        '
        'TambahDataProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 348)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtKet)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Name = "TambahDataProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Produk"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents rdoTidak As RadioButton
    Friend WithEvents rdoAktif As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtKet As TextBox
    Friend WithEvents Label9 As Label
End Class
