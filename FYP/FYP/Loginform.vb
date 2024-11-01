Public Class Loginform
    Private Const validUsername As String = "admin"
    Private Const validPassword As String = "password123"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = validUsername And txtPassword.Text = validPassword Then
            ' Hide the login form and open the main menu
            Me.Hide()
            Dim mainMenu As New MainMenu()
            mainMenu.Show()
        Else
            ' Display an error message if the login fails
            lblMessage.Text = "Invalid Username or Password"
            lblMessage.ForeColor = Color.Red
        End If
    End Sub
End Class