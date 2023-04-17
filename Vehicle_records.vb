
Imports MySql.Data.MySqlClient
Public Class Vehicle_records
    Private Sub VehicleRegestrationDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub cmdShowVehicleData_Click(sender As Object, e As EventArgs) Handles cmdShowVehicleData.Click

        Dim Myconnection As MySqlConnection
        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")
        Dim Table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" SELECT * FROM regesteredvehicles ", Myconnection)
        Try
            Adapter.Fill(Table)

            RegesteredVehicleDataGrid.DataSource = Table
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        myMenuu.Show()
    End Sub
End Class