Imports MySql.Data.MySqlClient
Public Class Finance
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        myMenuu.Show()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim Myconnection As MySqlConnection
        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")
        Dim Table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" SELECT * FROM finance ", Myconnection)



        Try

            Adapter.Fill(Table)

            FinanceDataGrid.DataSource = Table
            txtTotal.Text = 1500
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

End Class