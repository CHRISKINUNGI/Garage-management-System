Imports MySql.Data.MySqlClient
Public Class SpareData
    Private Sub cmdShowSpareData_Click(sender As Object, e As EventArgs) Handles cmdShowSpareData.Click
        Dim Myconnection As MySqlConnection
        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")
        Dim Table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" SELECT * FROM spareparts ", Myconnection)
        Try
            Adapter.Fill(Table)

            spareDataGrid.DataSource = Table
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        myMenuu.Show()


    End Sub
End Class