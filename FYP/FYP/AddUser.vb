Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim connectionString As String = "server=localhost; user=root; password=; database = school_management"
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim role As String = ComboBox1.Text
        Using connection As New MySqlConnection(connectionString)
            query = "INSERT INTO user(Username, Password, Role) VALUES(@username, @password, @role)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@role", role)
                command.ExecuteNonQuery()
            End Using
        End Using
        MsgBox("New user added!")
    End Sub
End Class