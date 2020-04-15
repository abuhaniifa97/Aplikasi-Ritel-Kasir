Public Class ImportDataPelanggan
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim dialog As New OpenFileDialog()
        dialog.DefaultExt = ".csv"
        dialog.Filter = "Comma Separated (*.csv)|*.csv"
        If DialogResult.OK = dialog.ShowDialog Then
            txtBrowse.Text = dialog.FileName
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        konekDb()
        'tabel database sql server
        Dim sSqlTable As String = "Data_Pelanggan"
        'nama sheet di file excel
        Dim myExcelDataQuery As String = "SELECT Nama FROM [Nama_Pelanggan]"
        Try

        Catch ex As Exception

        End Try
        'Dim ulang, objExcel, workBook, noWorkSheets
        'Dim objWorkSheets, hitungWorkSheets, hitung

        'hitung = 1
        'If (txtBrowse.Text = Nothing) Then
        '    MsgBox("Silahkan masukan file excel", vbInformation, "Informasi")
        'Else
        '    objExcel = CreateObject("Excel.Application")
        '    'buka file excelnya
        '    workBook = objExcel.workBook.open(txtBrowse.Text)
        '    noWorkSheets = workBook.workSheets.Count
        '    'menghitung
        '    For hitungWorkSheets = 1 To noWorkSheets
        '        objWorkSheets = workBook.worksheets(hitungWorkSheets)
        '        objWorkSheets.activate()

        '        ulang = 1

        '        Do While Not IsNothing(objExcel.cells(hitung, 1).value)
        '            Dim i 'forlooping through the columns on each row
        '        Loop
        '    Next
        'End If
    End Sub

    Private Sub ImportDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class