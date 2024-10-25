Public Class Loginform
    Dim correctUsername As String = "user123"
    Dim correctPassword As String = "pass123"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Fetch input from textboxes
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Check if the username and password are correct
        If username = correctUsername And password = correctPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class