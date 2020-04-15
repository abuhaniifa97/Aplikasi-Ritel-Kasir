Public Class EditDataProdusen
    Private Sub EditDataProdusen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditDataProdusen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtKode.Text = FormUtama.txtHiddenKode.Text
        konekDb()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Data_Produsen WHERE Kode_Produsen = '" & txtKode.Text & "'", konek)
        Dim er = cmd.ExecuteReader
        er.Read()

        Try
            If er.HasRows Then
                txtNama.Text = er.Item("Nama_Produsen")
                txtAlamat.Text = er.Item("Alamat")
                txtEmail.Text = er.Item("E_mail")
                If er.Item("Status") = "AKTIF" Then
                    rdoAktif.Checked = True
                ElseIf er.Item("Status") = "TIDAK AKTIF" Then
                    rdoTidak.Checked = True
                End If
                txtKet.Text = er.Item("Keterangan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kode As String
        Dim status As String

        If rdoAktif.Checked = True Then
            status = rdoAktif.Text
        ElseIf rdoTidak.Checked = True Then
            status = rdoTidak.Text
        End If
        Try
            Dim cmd As New SqlClient.SqlCommand("UPDATE Data_Produsen SET " _
                                                + "Nama_Produsen = '" & txtNama.Text & "'," _
                                                + "Alamat = '" & txtAlamat.Text & "'," _
                                                + "E_mail = '" & txtEmail.Text & "'," _
                                                + "Status = '" & status & "'," _
                                                + "Keterangan = '" & txtKet.Text & "' WHERE " _
                                                + "Kode_Produsen = '" & txtKode.Text & "'", konek)
            cmd.ExecuteNonQuery()
            konek.Close()
            MsgBox("Berhasil edit data", vbInformation)
            FormUtama.tampilDataProdusen()
            Close()
        Catch ex As Exception
            MsgBox("Gagal menyimpan data")
        End Try


    End Sub
End Class