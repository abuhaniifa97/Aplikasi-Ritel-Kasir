<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDataPelanggan
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
        Me.rdoAktif = New System.Windows.Forms.RadioButton()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rdoTidak = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoTidakEdit = New System.Windows.Forms.RadioButton()
        Me.rdoAktifEdit = New System.Windows.Forms.RadioButton()
        Me.grpStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoAktif
        '
        Me.rdoAktif.AutoSize = True
        Me.rdoAktif.Location = New System.Drawing.Point(39, 39)
        Me.rdoAktif.Name = "rdoAktif"
        Me.rdoAktif.Size = New System.Drawing.Size(55, 17)
        Me.rdoAktif.TabIndex = 17
        Me.rdoAktif.TabStop = True
        Me.rdoAktif.Text = "AKTIF"
        Me.rdoAktif.UseVisualStyleBackColor = True
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(132, 240)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(171, 20)
        Me.txtKet.TabIndex = 30
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdoTidak)
        Me.grpStatus.Controls.Add(Me.rdoAktif)
        Me.grpStatus.Location = New System.Drawing.Point(117, 219)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(216, 24)
        Me.grpStatus.TabIndex = 34
        Me.grpStatus.TabStop = False
        '
        'rdoTidak
        '
        Me.rdoTidak.AutoSize = True
        Me.rdoTidak.Location = New System.Drawing.Point(120, 37)
        Me.rdoTidak.Name = "rdoTidak"
        Me.rdoTidak.Size = New System.Drawing.Size(90, 17)
        Me.rdoTidak.TabIndex = 18
        Me.rdoTidak.TabStop = True
        Me.rdoTidak.Text = "TIDAK AKTIF"
        Me.rdoTidak.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-1, -2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(324, 52)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Edit Data"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Keterangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Status"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(132, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(171, 20)
        Me.txtEmail.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "E-mail"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(132, 84)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(171, 20)
        Me.txtNama.TabIndex = 27
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(132, 170)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(171, 20)
        Me.txtTelp.TabIndex = 26
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(132, 110)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(171, 64)
        Me.txtAlamat.TabIndex = 25
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(132, 60)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(100, 20)
        Me.txtKode.TabIndex = 24
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(228, 298)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 42)
        Me.btnSimpan.TabIndex = 23
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kode Pelanggan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoTidakEdit)
        Me.GroupBox1.Controls.Add(Me.rdoAktifEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 24)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'rdoTidakEdit
        '
        Me.rdoTidakEdit.AutoSize = True
        Me.rdoTidakEdit.Location = New System.Drawing.Point(96, -1)
        Me.rdoTidakEdit.Name = "rdoTidakEdit"
        Me.rdoTidakEdit.Size = New System.Drawing.Size(90, 17)
        Me.rdoTidakEdit.TabIndex = 18
        Me.rdoTidakEdit.TabStop = True
        Me.rdoTidakEdit.Text = "TIDAK AKTIF"
        Me.rdoTidakEdit.UseVisualStyleBackColor = True
        '
        'rdoAktifEdit
        '
        Me.rdoAktifEdit.AutoSize = True
        Me.rdoAktifEdit.Location = New System.Drawing.Point(15, 1)
        Me.rdoAktifEdit.Name = "rdoAktifEdit"
        Me.rdoAktifEdit.Size = New System.Drawing.Size(55, 17)
        Me.rdoAktifEdit.TabIndex = 17
        Me.rdoAktifEdit.TabStop = True
        Me.rdoAktifEdit.Text = "AKTIF"
        Me.rdoAktifEdit.UseVisualStyleBackColor = True
        '
        'EditDataPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 354)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtKet)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditDataPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Data Pelanggan"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoAktif As RadioButton
    Friend WithEvents txtKet As TextBox
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents rdoTidak As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoTidakEdit As RadioButton
    Friend WithEvents rdoAktifEdit As RadioButton
End Class
