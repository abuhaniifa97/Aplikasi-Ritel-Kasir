Public Class FormUtama
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Dim BERGERAK As Integer
    Dim TEKS As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lomba1DataSet.data_pelanggan' table. You can move, or remove it, as needed.
        'Me.Data_pelangganTableAdapter.Fill(Me.Lomba1DataSet.data_pelanggan)
        Call bliKaton()
    End Sub

    Private Sub b_dtapelanggan_Click(sender As Object, e As EventArgs) Handles b_dtapelanggan.Click
        grpPembelian.Visible = False
        lblJudul.Text = "Data Pelanggan"
        b_tambah.Name = "btnTambahPelanggan"
        b_edit.Name = "btnEditPelanggan"
        tombolKaton()
        dataKaton()
        tampilDataPelanggan()
    End Sub

    Private Sub b_dtaprodusen_Click(sender As Object, e As EventArgs) Handles b_dtaproduk.Click
        grpPembelian.Visible = False
        lblJudul.Text = "Data Produk"
        b_tambah.Name = "btnTambahProduk"
        dataKaton()
        tombolKaton()
        tampilDataProduk()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
        Label6.Text = DateAndTime.Year(Today)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub b_dtaproduk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub b_pembelian_Click(sender As Object, e As EventArgs) Handles b_pembelian.Click
        kodePembelian()
        grpPembayaran.Visible = False
        grpPembelian.Visible = True
        lblJudul.Text = ""
        konekDb()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM Data_Produk ORDER BY Kode_Produk ASC", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Produk")
        dgvPembelian.DataSource = (ds.Tables("Data_Produk"))
        konek.Close()

        dgvKeranjang.Columns.Add("1", "Nama_Produk")
        dgvKeranjang.Columns.Add("2", "Harga")
        dgvKeranjang.Columns.Add("3", "Jumlah")
    End Sub

    Private Sub b_tmbhdata_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        dgv_data.Refresh()
    End Sub

    Private Sub b_tmbahdata_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_datapelanggan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data.CellContentClick

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnDataProdusen.Click
        grpPembelian.Visible = False
        lblJudul.Text = "Data Produsen"
        dataKaton()
        tampilDataProdusen()
        tombolKaton()
        b_tambah.Name = "btnTambahProdusen"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Sub aktif()


        Me.b_tambah.Enabled = True
        Me.b_import.Enabled = True
        Me.b_Refresh.Enabled = True
        Me.b_edit.Enabled = True
        Me.b_hapus.Enabled = True
    End Sub

    Sub tombolKaton()
        b_tambah.Visible = True
        b_import.Visible = True
        b_Refresh.Visible = True
        b_edit.Visible = True
        b_hapus.Visible = True
    End Sub

    Sub bliKaton()
        b_tambah.Visible = False
        b_import.Visible = False
        b_Refresh.Visible = False
        b_edit.Visible = False
        b_hapus.Visible = False
    End Sub

    Sub dataKaton()
        Me.dgv_data.Visible = True
    End Sub

    Sub tampilDataPelanggan()
        konekDb()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM data_pelanggan ORDER BY Kode_Pelanggan ASC", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "data_pelanggan")
        dgv_data.DataSource = (ds.Tables("data_pelanggan"))
        konek.Close()
    End Sub

    Sub tampilDataProdusen()
        konekDb()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM Data_Produsen ORDER BY Kode_Produsen ASC", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Produsen")
        dgv_data.DataSource = (ds.Tables("Data_Produsen"))
        konek.Close()
    End Sub

    Sub tampilDataProduk()
        konekDb()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM Data_Produk ORDER BY Kode_Produk ASC", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Produk")
        dgv_data.DataSource = (ds.Tables("Data_Produk"))
        konek.Close()
    End Sub

    Private Sub b_tambah_Click(sender As Object, e As EventArgs) Handles b_tambah.Click
        If b_tambah.Name = "btnTambahPelanggan" Then
            TambahDataPelanggan.Show()
        ElseIf b_tambah.Name = "btnTambahProdusen" Then
            TambahDataProdusen.Show()
        ElseIf b_tambah.name = "btnTambahProduk" Then
            TambahDataProduk.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub b_Refresh_Click(sender As Object, e As EventArgs) Handles b_Refresh.Click
        If b_tambah.Name = "btnTambahPelanggan" Then
            tampilDataPelanggan()
        ElseIf b_tambah.Name = "btnTambahProdusen" Then
            tampilDataProdusen()
        ElseIf b_tambah.Name = "btnTambahProduk" Then
            tampilDataProduk()
        End If
    End Sub

    Private Sub b_import_Click(sender As Object, e As EventArgs) Handles b_import.Click
        ImportDataPelanggan.Show()
    End Sub

    Private Sub b_hapus_Click(sender As Object, e As EventArgs) Handles b_hapus.Click
        konekDb()
        Dim hapusData As String
        Dim pesan As Integer
        Dim baris As Integer

        baris = dgv_data.CurrentRow.Index
        txtHiddenKode.Text = dgv_data.Item(0, baris).Value
        pesan = MsgBox("Anda yakin ingin menghapus data ini?", vbExclamation + vbYesNo, "Perhatian")
        If pesan = vbNo Then Exit Sub
        If b_tambah.Name = "btnTambahPelanggan" Then
            hapusData = "UPDATE data_pelanggan SET Status = 'TIDAK AKTIF' WHERE Kode_Pelanggan='" & txtHiddenKode.Text & "'"
            sqlOn(hapusData)
            dgv_data.Refresh()
            tampilDataPelanggan()
        ElseIf b_tambah.Name = "btnTambahProdusen" Then
            hapusData = "UPDATE Data_Produsen SET Status = 'TIDAK AKTIF' WHERE Kode_Produsen = '" & txtHiddenKode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(hapusData, konek)
            cmd.ExecuteNonQuery()
            konek.Close()
            MsgBox("Data dihapus", vbInformation)
            dgv_data.Refresh()
            tampilDataProdusen()
        End If

    End Sub

    Private Sub sqlOn(ByVal sQl As String)
        Dim sqlCmd As New SqlClient.SqlCommand
        konekDb()
        Try
            sqlCmd.Connection = konek
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandText = sQl
            sqlCmd.ExecuteNonQuery()
            konek.Close()
            MsgBox("Data Terhapus", vbInformation)
        Catch ex As Exception
            MessageBox.Show("Gagal Menghapus data " & ex.Message)
        End Try
    End Sub

    Private Sub b_edit_Click(sender As Object, e As EventArgs) Handles b_edit.Click
        Dim baris As Integer

        baris = dgv_data.CurrentRow.Index
        txtHiddenKode.Text = dgv_data.Item(0, baris).Value
        EditDataPelanggan.txtKode.Text = txtHiddenKode.Text
        If b_tambah.Name = "btnTambahPelanggan" Then
            EditDataPelanggan.Show()
        ElseIf b_tambah.Name = "btnTambahProdusen" Then
            EditDataProdusen.Show()
        End If
    End Sub

    Private Sub dgvPembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembelian.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgv As New System.Windows.Forms.DataGridViewRow
        For Each dgv In dgvPembelian.SelectedRows
            dgvKeranjang.Rows.Add(dgv.Cells(2).Value, dgv.Cells(3).Value)
            Dim totalHarga As Long
            totalHarga = 0
            For t As Integer = 0 To dgvKeranjang.RowCount - 2
                totalHarga = totalHarga + Val(dgvKeranjang.Rows(t).Cells(1).Value)
            Next
            lblTotHarga.Text = totalHarga
        Next
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        dgvKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index)
        Dim totalHarga As Long
        totalHarga = 0
        For t As Integer = 0 To dgvKeranjang.RowCount - 1
            totalHarga = totalHarga + Val(dgvKeranjang.Rows(t).Cells(1).Value)
        Next
        lblTotHarga.Text = totalHarga
    End Sub

    Private Sub lblTotHarga_Click(sender As Object, e As EventArgs) Handles lblTotHarga.Click

    End Sub

    Private Sub dgvKeranjang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeranjang.CellContentClick

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnProses.Click
        konekDb()
        Dim nama, jenisPembayaran, status As String
        Dim harga, jumlah As Integer

        If rdoKredit.Checked = True Then
            jenisPembayaran = "Kredit"
            status = "Belum Lunas"
        ElseIf rdoTunai.Checked = True Then
            jenisPembayaran = "Tunai"
            status = "Lunas"
        End If

        If rdoTunai.Checked = False And rdoKredit.Checked = False Then
            MsgBox("Anda belum memilih tipe pembayaran", vbCritical)
        Else
            Try
                '            For Each dgv In dgvKeranjang.SelectedCells
                For rows As Integer = 0 To dgvKeranjang.Rows.Count - 2
                    nama = dgvKeranjang.Rows(rows).Cells(0).Value.ToString
                    harga = dgvKeranjang.Rows(rows).Cells(1).Value.ToString
                    Dim jenis As New SqlClient.SqlCommand("Select Jenis_Produk, Jumlah_Stok FROM Data_Produk WHERE Nama_Produk = '" & nama & "'", konek)
                Dim er = jenis.ExecuteReader
                    er.Read()
                    Dim JumlahStok = Val(er.Item("Jumlah_Stok")) - Val(dgvKeranjang.Rows(rows).Cells(2).Value.ToString)
                    Dim jenisProduk = er.Item("Jenis_Produk")
                    er.Close()
                    Dim cmd As New SqlClient.SqlCommand("INSERT INTO Pembelian (" _
                                                            + "Kode_Pembelian," _
                                                            + "Discount," _
                                                            + "Pajak," _
                                                            + "Total_Harga," _
                                                            + "Status," _
                                                            + "Jenis_Pembayaran," _
                                                            + "Sisa_Pembayaran) VALUES (" _
                                                            + "'" & txtHiddenKode.Text & "'," _
                                                            + "''," _
                                                            + "''," _
                                                            + "'" & lblTotHarga.Text & "'," _
                                                            + "'" & status & "'," _
                                                            + "'" & jenisPembayaran & "'," _
                                                            + "'" & lblTotHarga.Text & "')", konek)
                    Dim simpanKeranjang As New SqlClient.SqlCommand("INSERT INTO Keranjang (" _
                                                            + "Kode_Pembelian," _
                                                            + "Jenis," _
                                                            + "Nama_Barang," _
                                                            + "Harga," _
                                                            + "Jumlah) VALUES (" _
                                                            + "'" & txtHiddenKode.Text & "'," _
                                                            + "'" & jenisProduk & "'," _
                                                            + "'" & nama & "'," _
                                                            + "'" & harga & "'," _
                                                            + "'')", konek)
                    cmd.ExecuteNonQuery()
                    simpanKeranjang.ExecuteNonQuery()
                    Dim stok As New SqlClient.SqlCommand("UPDATE Data_Produk SET Jumlah_Stok = '" & JumlahStok & "'WHERE Nama_Produk = '" & nama & "'", konek)
                    stok.ExecuteNonQuery()
                    konek.Close()
                Next
                '           Next
                MsgBox("Proses Berhasil ", vbInformation)
                konek.Close()
                dgvKeranjang.Rows.Clear()
                kodePembelian()
            Catch ex As Exception
                MsgBox("Proses Gagal " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Sub kodePembelian()
        konekDb()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Pembelian WHERE Kode_Pembelian in(SELECT MAX(Kode_Pembelian) FROM Pembelian)", konek)
        Dim er = cmd.ExecuteReader
        Dim itung As Long
        er.Read()
        Dim y, m, d As String
        y = Year(Now)
        m = Month(Now)
        d = Val(Today)
        If Not er.HasRows Then
            txtHiddenKode.Text = "PB" + y + m + d + "0001"
            er.Close()
        Else
            itung = Microsoft.VisualBasic.Right(er.GetString(0), 4) + 1
            txtHiddenKode.Text = "PB" + y + m + d + Microsoft.VisualBasic.Right("0000" & itung, 4)
            er.Close()
        End If
        txtHiddenKode.Visible = True
    End Sub

    Private Sub b_pembayaran_Click(sender As Object, e As EventArgs) Handles b_pembayaran.Click
        konekDb()
        grpPembayaran.Visible = True
        grpPembelian.Visible = True
        lblJudul.Text = ""
        keranjang()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        cari()
    End Sub

    Private Sub grpPembelian_Enter(sender As Object, e As EventArgs) Handles grpPembelian.Enter

    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        konekDb()
        Dim bayar As Integer = Val(lblSisa.Text) - Val(txtBayar.Text)
        Dim cmd As New SqlClient.SqlCommand("UPDATE Pembelian SET Sisa_Pembayaran = " & bayar & " WHERE Kode_Pembelian = '" & lblKodePembelian.Text & "'", konek)
        cmd.ExecuteNonQuery()
        If bayar = 0 Then
            Dim sisa As New SqlClient.SqlCommand("UPDATE Pembelian SET Status = 'Lunas'", konek)
            sisa.ExecuteNonQuery()
        End If
        cari()
        txtBayar.Text = ""
        konek.Close()
        MsgBox("Pembayaran berhasil", vbInformation)
    End Sub

    Sub tampilDataPembelian()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM Pembelian ORDER BY Kode_Pembelian ASC", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "Pembelian")
        dgvPembayaran.DataSource = (ds.Tables("Pembelian"))
        konek.Close()
    End Sub

    Sub dataPembelian()
        konekDb()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Pembelian WHERE Kode_Pembelian = '" & txtCari.Text & "' ORDER BY Kode_Pembelian", konek)
        Dim er = cmd.ExecuteReader
        er.Read()

        lblKodePembelian.Text = er.Item("Kode_Pembelian")
        lblDiscount.Text = er.Item("Discount")
        lblPajak.Text = er.Item("Pajak")
        lblTotal.Text = er.Item("Total_Harga")
        lblStatus.Text = er.Item("Status")
        lblTipePemb.Text = er.Item("Jenis_Pembayaran")
        lblSisa.Text = er.Item("Sisa_Pembayaran")
        er.Close()
    End Sub

    Sub keranjang()
        konekDb()
        Dim da As New SqlClient.SqlCommand("SELECT * FROM Keranjang WHERE Kode_Pembelian = '" & txtCari.Text & "' ORDER BY Kode_Pembelian", konek)
        Dim er = da.ExecuteReader
        er.Read()
    End Sub

    Sub cari()
        konekDb()
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM Keranjang WHERE Kode_Pembelian = '" & txtCari.Text & "'", konek)
        Dim ds As New DataSet
        If da.Fill(ds, "Keranjang") Then
            Dim view As DataView = (ds.Tables(0).DefaultView)
            dgvPembayaran.DataSource = view
        Else
            MsgBox("Data tidak ditemukan!", vbInformation)
        End If

        keranjang()
        dataPembelian()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub txtHiddenKode_TextChanged(sender As Object, e As EventArgs) Handles txtHiddenKode.TextChanged

    End Sub

    Private Sub b_penjualan_Click(sender As Object, e As EventArgs) Handles b_penjualan.Click

    End Sub
End Class
