Public Class EditDataPelanggan
    Private rd As Object

    Private Sub EditDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kode As String
        Dim edit As String
        Dim status As String

        If rdoAktifEdit.Checked = True Then
            status = rdoAktifEdit.Text
        ElseIf rdoTidakEdit.Checked = True Then
            status = rdoTidakEdit.Text
        End If

        kode = FormUtama.txtHiddenKode.Text
        edit = "UPDATE data_pelanggan SET " _
             + "Nama_Pelanggan = '" & txtNama.Text & "', " _
             + "Alamat = '" & txtAlamat.Text & "', " _
             + "No_Telp = '" & txtTelp.Text & "', " _
             + "E_mail = '" & txtEmail.Text & "', " _
             + "Status = '" & status & "', " _
             + "Keterangan = '" & txtKet.Text & "' " _
             + "WHERE Kode_Pelanggan = '" & kode & "'"
        sqlJalan(edit)
        MsgBox("Berhasil edit data", vbInformation)
        FormUtama.tampilDataPelanggan()
        Close()
    End Sub

    Private Sub EditDataPelanggan_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            konekDb()
            Dim tampil As String

            tampil = "SELECT * FROM data_pelanggan WHERE Kode_Pelanggan = '" & txtKode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(tampil, konek)
            Dim er = cmd.ExecuteReader()
            er.Read()

            If er.HasRows Then
                txtNama.Text = er.Item("Nama_Pelanggan")
                txtAlamat.Text = er.Item("Alamat")
                txtTelp.Text = er.Item("No_Telp")
                txtEmail.Text = er.Item("E_mail")
                If er.Item("Status") = "AKTIF" Then
                    rdoAktifEdit.Checked = True
                ElseIf er.Item("Status") = "TIDAK AKTIF" Then
                    rdoTidakEdit.Checked = True
                End If
                txtKet.Text = er.Item("Keterangan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class