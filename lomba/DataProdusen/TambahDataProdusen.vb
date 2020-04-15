Public Class TambahDataProdusen
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtAlamat.Text = "" Or txtEmail.Text = "" Or txtKet.Text = "" Then
            MsgBox("Data produsen tidak lengkap", vbCritical)
        Else
            If rdoAktif.Checked = False And rdoTidak.Checked = False Then
                MessageBox.Show("Anda belum memilih status produsen")
            Else
                Dim status As String
                If rdoAktif.Checked = True Then
                    status = "AKTIF"
                ElseIf rdoTidak.Checked = True Then
                    status = "TIDAK AKTIF"
                End If
                konekDb()
                Dim cmd As New SqlClient.SqlCommand("INSERT INTO Data_Produsen(Kode_Produsen, Nama_Produsen, Alamat, E_mail, Status, Keterangan) VALUES" _
                                                    + "('" & txtKode.Text & "'," _
                                                    + "'" & txtNama.Text & "'," _
                                                    + "'" & txtAlamat.Text & "'," _
                                                    + "'" & txtEmail.Text & "'," _
                                                    + "'" & status & "'," _
                                                    + "'" & txtKet.Text & "')", konek)
                cmd.ExecuteNonQuery()
                konek.Close()
                MsgBox("Berhasil menyimpan data", vbInformation)
                bersih()
                kodeProdusen()
            End If
        End If
    End Sub

    Private Sub TambahDataProdusen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TambahDataProdusen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kodeProdusen()
        txtKode.Enabled = False
    End Sub

    Sub kodeProdusen()
        konekDb()
        Dim sqlCmd As New SqlClient.SqlCommand("SELECT * FROM Data_Produsen WHERE Kode_Produsen in(SELECT MAX(Kode_Produsen) FROM Data_Produsen)", konek)
        Dim dr = sqlCmd.ExecuteReader
        Dim itung As Long
        dr.Read()
        If Not dr.HasRows Then
            txtKode.Text = "PROD" + "0001"
            dr.Close()
        Else
            itung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            txtKode.Text = "PROD" + Microsoft.VisualBasic.Right("0000" & itung, 4)
            dr.Close()
        End If
    End Sub

    Sub bersih()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtEmail.Text = ""
        rdoAktif.Checked = False
        rdoTidak.Checked = False
        txtKet.Text = ""
    End Sub
End Class