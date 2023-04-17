Public Class Login
    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()

    End Sub



    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If txtPassword.Text.Contains("password") And txtuserName.Text.Contains("Admin") Then
            Me.Hide()
            myMenuu.Show()

        Else
            MsgBox("Incorect Login Details")
        End If

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class
