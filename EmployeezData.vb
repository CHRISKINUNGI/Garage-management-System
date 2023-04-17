Imports MySql.Data.MySqlClient
Public Class EmployeezData
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnShowEmpData.Click

        Dim Myconnection As MySqlConnection
        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")
        Dim Table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(" SELECT * FROM employee ", Myconnection)
        Try
            Adapter.Fill(Table)

            employeeDataGrid.DataSource = Table
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub EmployeezData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdEmployeeBack_Click(sender As Object, e As EventArgs) Handles cmdEmployeeBack.Click
        Me.Close()
        myMenuu.Show()
    End Sub
End Class