Imports System.Data.SqlClient
Module MdlKoneksi
    Public konek As SqlConnection
    Sub konekDb()
        Try
            konek = New SqlConnection("Data Source=LAPTOP-O5CDB914;Initial Catalog=latihan;Integrated Security=True")
            konek.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi bermasalah, periksa koneksi kembali")
        End Try
    End Sub

    Public Sub sqlJalan(ByVal sQl As String)
        Dim sqlCmd As New SqlClient.SqlCommand
        konekDb()
        Try
            sqlCmd.Connection = konek
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandText = sQl
            sqlCmd.ExecuteNonQuery()
            konek.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal " & ex.Message)
        End Try
    End Sub

    Public Sub sqlOn(ByVal sQl As String)
        Dim sqlCmd As New SqlClient.SqlCommand
        konekDb()
        Try
            sqlCmd.Connection = konek
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandText = sQl
            sqlCmd.ExecuteNonQuery()
            konek.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal " & ex.Message)
        End Try
    End Sub

End Module
