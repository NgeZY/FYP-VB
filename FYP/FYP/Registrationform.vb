Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Net
Imports System.Net.Mail
Public Class Registrationform
    Dim connectionString As String = "server=localhost; user=root; password=; database = school_management"

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If Not DataGridView1.Columns.Contains("StudentID") Then
            DataGridView1.Columns.Add("StudentID", "Student ID")
            DataGridView1.Columns.Add("subject_code", "Subject Code")
        End If
        Label3.Visible = True
        Dim id As Integer = TextBoxID.Text
        Dim code As String = TextBoxCode.Text
        Dim subject_registered As Boolean = False
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

    Private Sub ButtonDisplayCredit_Click(sender As Object, e As EventArgs) Handles ButtonDisplayCredit.Click

        Dim id As String = TextBoxID.Text.Trim()
        If String.IsNullOrEmpty(id) Then
            MsgBox("Please enter a student ID!")
            Return
        End If
        Dim credit As Integer = 0
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT SUM(s.Credit) FROM subject s INNER JOIN subject_registered sr ON sr.Subject_code
                                    = s.Subject_code WHERE sr.StudentID = @studentID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", id)
                Using reader As MySqlDataReader = command.ExecuteReader
                    If reader.Read() Then
                        If Not reader.IsDBNull(0) Then
                            credit = reader.GetInt32(0)
                        End If
                    End If
                End Using
            End Using
        End Using
        MsgBox("The total credit of this student is " + credit.ToString())
    End Sub

    Private Sub ButtonDisplayFee_Click(sender As Object, e As EventArgs) Handles ButtonDisplayFee.Click
        Dim id As String = TextBoxID.Text.Trim()
        If String.IsNullOrEmpty(id) Then
            MsgBox("Please enter a student ID!")
            Return
        End If
        Dim fee As Integer = 0
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT SUM(s.Fee) FROM subject s INNER JOIN subject_registered sr ON sr.Subject_code
                                    = s.Subject_code WHERE sr.StudentID = @studentID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", id)
                Using reader As MySqlDataReader = command.ExecuteReader
                    If reader.Read() Then
                        If Not reader.IsDBNull(0) Then
                            fee = reader.GetInt32(0)
                        End If
                    End If
                End Using
            End Using
        End Using
        MsgBox("The total fee needed to pay by this student is " + fee.ToString())
    End Sub

    Private Sub ButtonEmail_Click(sender As Object, e As EventArgs) Handles ButtonEmail.Click
        Dim email As String = InputBox("Enter student email: ")
        Dim smtpClient As New SmtpClient("smtp.gmail.com") ' Replace with your SMTP server
        smtpClient.Port = 587 ' Common port for TLS
        smtpClient.Credentials = New NetworkCredential("zheyunge0412@gmail.com", "nge041225") ' Replace with your email and password
        smtpClient.EnableSsl = True ' Enable SSL for secure connection

        Dim mailMessage As New MailMessage()
        mailMessage.From = New MailAddress("zheyunge0412@gmail.com") ' Replace with your email
        mailMessage.To.Add(email) ' Replace with recipient's email
        mailMessage.Subject = "Test Email"
        mailMessage.Body = "This is a test email sent from VB.NET application."
        mailMessage.IsBodyHtml = False ' Set to True if the body contains HTML

        Try
            smtpClient.Send(mailMessage)
            Console.WriteLine("Email sent successfully!")
        Catch ex As Exception
            Console.WriteLine("Error sending email: " & ex.Message)
        End Try
    End Sub
End Class