Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class myMenuu
    Public Property RegesteredVehicleDataGrid As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles cmdCars.Click
        homePage.SetPage("Cars")
    End Sub

    Private Sub cmdSpareParts_Click(sender As Object, e As EventArgs) Handles cmdRecords.Click
        homePage.SetPage("Records")
    End Sub

    Private Sub cmdBilling_Click(sender As Object, e As EventArgs) Handles cmdBilling.Click
        homePage.SetPage("Billing")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
        Login.Show()

    End Sub


    Private Sub cmdRegesterVehicle_Click(sender As Object, e As EventArgs) Handles cmdRegesterVehicle.Click
        Dim Myconnection As MySqlConnection


        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")

        Try
            Myconnection.Open()
            MsgBox(" Connected To Database ")
            Dim comand As New MySqlCommand("INSERT INTO `regesteredvehicles`(`CarBrand`, `NumberPlate`, `Model`,`Phone_Numer`, `Owner_Name`, `Color`) VALUES ('" & txtVehicleBrand.Text & "','" & txtNumberPlate.Text & "','" & txtVehicleModel.Text & "','" & txtPhoneNumber.Text & "','" & txtOwnerName.Text & "','" & txtColor.Text & "')", Myconnection)
            comand.ExecuteNonQuery()
            Myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub cmdEmployees_Click_1(sender As Object, e As EventArgs) Handles cmdEmployees.Click
        homePage.SetPage("Employees")
    End Sub

    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeName.TextChanged

    End Sub



    Private Sub cmdVehicleData_Click(sender As Object, e As EventArgs) Handles cmdVehicleData.Click
        Me.Close()
        Vehicle_records.Show()
    End Sub

    Private Sub cmdRegesterEmployee_Click(sender As Object, e As EventArgs) Handles cmdRegesterEmployee.Click
        Dim Myconnection As MySqlConnection


        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")

        Try
            Myconnection.Open()
            MsgBox(" Connected To Database ")
            Dim comand As New MySqlCommand(" INSERT INTO `employee`(`Employee_ID`, `Name`, `Phone_Number`, `Email`) VALUES ('" & txtEmployeeId.Text & "','" & txtEmployeeName.Text & "','" & txtEmployeePhoneNumber.Text & "','" & txtEmail.Text & "') ", Myconnection)
            comand.ExecuteNonQuery()
            Myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub cmdcmdEmployeeesData_Click(sender As Object, e As EventArgs) Handles cmdcmdEmployeeesData.Click
        Me.Close()
        EmployeezData.Show()

    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles cmdRecordSpare.Click
        Dim Myconnection As MySqlConnection


        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")

        Try
            Myconnection.Open()
            MsgBox(" Connected To Database ")
            Dim comand As New MySqlCommand(" INSERT INTO `spareparts`(`Spare_ID`, `Name`, `Brand`, `Quantity`) VALUES ('" & txtSpareID.Text & "','" & txtSpareName.Text & "','" & txtSpareBrand.Text & "','" & txtSparequantity.Text & "') ", Myconnection)
            comand.ExecuteNonQuery()
            Myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
        SpareData.Show()

    End Sub

    Private Sub txtOwnerName_TextChanged(sender As Object, e As EventArgs) Handles txtOwnerName.TextChanged

    End Sub

    Private Sub txtOwnerName_keypress(sender As Object, e As KeyPressEventArgs) Handles txtOwnerName.KeyPress
        'restricting the name text box to take characters only

        If Not Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtVehicleBrand_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleBrand.TextChanged

    End Sub

    Private Sub txtVehicleBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVehicleBrand.KeyPress

        If Not Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged

    End Sub

    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress

        If Not Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub

    Private Sub txtPhoneNumber_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtPhoneNumber.MouseDoubleClick

    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress


    End Sub

    Private Sub cmdSpareParts_Click_1(sender As Object, e As EventArgs) Handles cmdSpareParts.Click
        homePage.SetPage("spareparts")
    End Sub

    Private Sub BunifuButton1_Click_2(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim Myconnection As MySqlConnection


        Myconnection = New MySqlConnection("server=localhost; user id= root; password=Mypassword.;database=garage management system;")

        Try
            Myconnection.Open()
            MsgBox(" Connected To Database ")
            Dim comand As New MySqlCommand(" INSERT INTO `finance`(`vehicleID`, `EmployeeName`, `Charges`, `JobDone`) VALUES ('" & txtBillID.Text & "','" & txtMyName.Text & "','" & txtCharges.Text & "','" & txtJobDone.Text & "')", Myconnection)
            comand.ExecuteNonQuery()
            Myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub cmdFinances_Click(sender As Object, e As EventArgs) Handles cmdFinances.Click
        Me.Close()
        Finance.Show()
    End Sub

    Private Sub txtSpareID_TextChanged(sender As Object, e As EventArgs) Handles txtSpareID.TextChanged

    End Sub
End Class