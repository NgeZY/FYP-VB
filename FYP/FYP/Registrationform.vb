Imports MySql.Data.MySqlClient
Public Class Registrationform

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Label3.Visible = True
        Dim connectionString As String = "server=localhost; user=root; password=; database = school_management"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO subject(StudentID, Subject_Code) VALUES (@id, @subject_code)"
        End Using

    End Sub

    Private Sub ButtonDisplaySubject_Click(sender As Object, e As EventArgs) Handles ButtonDisplaySubject.Click
        Label4.Visible = True
    End Sub
End Class