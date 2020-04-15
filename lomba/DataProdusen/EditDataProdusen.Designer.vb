<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDataProdusen
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
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdoTidak = New System.Windows.Forms.RadioButton()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.rdoAktif = New System.Windows.Forms.RadioButton()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(133, 62)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(106, 20)
        Me.txtKode.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Kode Produsen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Alamat"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(229, 287)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 42)
        Me.btnSimpan.TabIndex = 38
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(133, 86)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(177, 20)
        Me.txtNama.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Keterangan"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 52)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Edit Data"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdoTidak)
        Me.grpStatus.Controls.Add(Me.rdoAktif)
        Me.grpStatus.Location = New System.Drawing.Point(118, 208)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(222, 24)
        Me.grpStatus.TabIndex = 48
        Me.grpStatus.TabStop = False
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(133, 229)
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(177, 20)
        Me.txtKet.TabIndex = 44
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
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(133, 112)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(177, 64)
        Me.txtAlamat.TabIndex = 40
        '
        'EditDataProdusen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 348)
        Me.Controls.Add(Me.txtKet)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKode)
        Me.Name = "EditDataProdusen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Data Produsen"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rdoTidak As RadioButton
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents rdoAktif As RadioButton
    Friend WithEvents txtKet As TextBox
    Friend WithEvents txtAlamat As TextBox
End Class
