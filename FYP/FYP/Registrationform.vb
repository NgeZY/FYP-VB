Imports MySql.Data.MySqlClient
Public Class Registrationform

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If Not DataGridView1.Columns.Contains("StudentID") Then
            DataGridView1.Columns.Add("StudentID", "Student ID")
            DataGridView1.Columns.Add("subject_code", "Subject Code")
        End If
        Label3.Visible = True
        Dim id As Integer = TextBoxID.Text
        Dim code As String = TextBoxCode.Text
        Dim subject_registered As Boolean = False
        Dim connectionString As String = "server=localhost; user=root; password=; database = school_management"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query_check As String = "SELECT COUNT(*) FROM subject_registered WHERE StudentID = @id AND Subject_code = @code"
            Using command_check As New MySqlCommand(query_check, connection)
                command_check.Parameters.AddWithValue("@id", id)
                command_check.Parameters.AddWithValue("@code", code)
                Using reader As MySqlDataReader = command_check.ExecuteReader
                    If reader.Read() Then
                        Dim subjectcount As Integer = reader.GetInt32(0)
                        If subjectcount > 0 Then
                            subject_registered = True
                        End If
                    End If
                End Using
            End Using

            If subject_registered Then
                MsgBox("This student has already registered this subject")
            Else
                Dim query As String = "INSERT INTO subject_registered(StudentID, Subject_code) VALUES (@id, @subject_code)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@subject_code", code)

                    command.ExecuteNonQuery()
                End Using
            End If

            DataGridView1.Rows.Clear()
            Dim query2 As String = "SELECT * FROM subject_registered WHERE StudentID = @id"
            Using command2 As New MySqlCommand(query2, connection)
                command2.Parameters.AddWithValue("@id", id)
                Using reader As MySqlDataReader = command2.ExecuteReader
                    While reader.Read()
                        DataGridView1.Rows.Add(reader("StudentID").ToString(), reader("Subject_code").ToString())
                    End While
                End Using
            End Using
        End Using
        TextBoxCode.Clear()
        TextBoxID.Clear()
    End Sub

    Private Sub ButtonDisplaySubject_Click(sender As Object, e As EventArgs) Handles ButtonDisplaySubject.Click
        Label4.Visible = True
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click

    End Sub
End Class