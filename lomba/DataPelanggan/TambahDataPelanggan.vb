
Public Class TambahDataPelanggan
    Private Sub sqlOn(ByVal sQl As String)
        Dim sqlCmd As New SqlClient.SqlCommand
        konekDb()
        Try
            sqlCmd.Connection = konek
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandText = sQl
            sqlCmd.ExecuteNonQuery()
            konek.Close()
            MsgBox("Data Tersimpan", vbInformation)
        Catch ex As Exception
            MessageBox.Show("Gagal Menyimpan data " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Or txtEmail.Text = "" Or txtKet.Text = "" Then
            MsgBox("Data pelanggan tidak lengkap", vbCritical)
        Else
            If rdoAktif.Checked = False And rdoTidak.Checked = False Then
                MsgBox("Status pelanggan belum dipilih", vbCritical)
            Else
                Dim status As String
                If rdoAktif.Checked = True Then
                    status = rdoAktif.Text
                ElseIf rdoTidak.Checked = True Then
                    status = rdoTidak.Text
                End If
                Dim simpan As String
                simpan = "INSERT INTO data_pelanggan(Kode_Pelanggan, Nama_Pelanggan, Alamat, No_Telp, E_mail, " _
                         + "Status, Keterangan) VALUES(" _
                         + "'" & txtKode.Text & "'," _
                         + "'" & txtNama.Text & "'," _
                         + "'" & txtAlamat.Text & "'," _
                         + "'" & txtTelp.Text & "'," _
                         + "'" & txtEmail.Text & "'," _
                         + "'" & status & "'," _
                         + "'" & txtKet.Text & "')"
                sqlOn(simpan)
                bersih()
                kodePelanggan()
            End If
        End If
    End Sub

    Sub bersih()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtEmail.Text = ""
        rdoAktif.Checked = False
        rdoTidak.Checked = False
        txtKet.Text = ""
    End Sub

    Private Sub TambahDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TambahDataPelanggan_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub TambahDataPelanggan_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtKode.Enabled = False
        kodePelanggan()
        Return
    End Sub

    Sub kodePelanggan()
        konekDb()
        Dim sqlCmd As New SqlClient.SqlCommand("SELECT * FROM data_pelanggan WHERE Kode_Pelanggan in(SELECT MAX(Kode_Pelanggan) FROM data_pelanggan)", konek)
        Dim dr = sqlCmd.ExecuteReader
        Dim itung As Long
        dr.Read()
        If Not dr.HasRows Then
            txtKode.Text = "PEL" + "0001"
            dr.Close()
        Else
            itung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            txtKode.Text = "PEL" + Microsoft.VisualBasic.Right("0000" & itung, 4)
            dr.Close()
        End If
    End Sub

    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs) Handles txtKode.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub

    Private Sub txtTelp_TextChanged(sender As Object, e As EventArgs) Handles txtTelp.TextChanged

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtKet_TextChanged(sender As Object, e As EventArgs) Handles txtKet.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub grpStatus_Enter(sender As Object, e As EventArgs) Handles grpStatus.Enter

    End Sub

    Private Sub rdoTidak_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTidak.CheckedChanged

    End Sub

    Private Sub rdoAktif_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAktif.CheckedChanged

    End Sub
End Class