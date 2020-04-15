Public Class TambahDataProduk
    Private Sub TambahDataProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbJenis.Items.Add("Normal")
        cmbJenis.Items.Add("Penting")
    End Sub

    Private Sub TambahDataProduk_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kodeProduk()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        konekDb()
        Dim status As String
        If rdoAktif.Checked = True Then
            status = "AKTIF"
        ElseIf rdoTidak.Checked = True Then
            status = "TIDAK AKTIF"
        End If
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO Data_Produk (Kode_Produk, Jenis_Produk, Nama_Produk, Harga, Jumlah_Stok, Status, Keterangan) VALUES (" _
                                    + "'" & txtKode.Text & "'," _
                                    + "'" & cmbJenis.Text & "'," _
                                    + "'" & txtNama.Text & "'," _
                                    + "'" & txtHarga.Text & "'," _
                                    + "'" & txtStok.Text & "'," _
                                    + "'" & status & "'," _
                                    + "'" & txtKet.Text & "')", konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data tersimpan", vbInformation)
            kodeProduk()
            bersih()
        Catch ex As Exception
            MsgBox("Gagal menyimpan data " & ex.Message, vbCritical)
        End Try
    End Sub

    Sub kodeProduk()
        konekDb()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Data_Produk WHERE Kode_Produk in(SELECT MAX(Kode_Produk) FROM Data_Produk)", konek)
        Dim er = cmd.ExecuteReader
        Dim itung As Long
        er.Read()

        If Not er.HasRows Then
            txtKode.Text = "PRD" + "0001"
            er.Close()
        Else
            itung = Microsoft.VisualBasic.Right(er.GetString(0), 4) + 1
            txtKode.Text = "PRD" + Microsoft.VisualBasic.Right("0000" & itung, 4)
            er.Close()
        End If
    End Sub

    Sub bersih()
        cmbJenis.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
        rdoAktif.Checked = False
        rdoTidak.Checked = False
        txtKet.Text = ""
    End Sub
End Class