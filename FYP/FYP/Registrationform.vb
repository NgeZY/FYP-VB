Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Registrationform
    Dim connectionString As String = "server=localhost; user=root; password=; database = school_management"

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If Not DataGridView1.Columns.Contains("StudentID") Then
            DataGridView1.Columns.Add("StudentID", "Student ID")
            DataGridView1.Columns.Add("subject_code", "Subject Code")
        End If
        Label3.Visible = True
        Dim id As Integer = TextBoxID.Text.Trim()
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
        Dim id As Integer = TextBoxID.Text.Trim()
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
        Dim id As Integer = TextBoxID.Text.Trim()
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
        Dim pdfFilePath As String = "../../../../Slip/Slip.pdf"
        CreatePdf(pdfFilePath)

        Dim email As String = InputBox("Enter student email: ")
        Dim smtpClient As New SmtpClient("smtp.gmail.com")
        smtpClient.Port = 587
        smtpClient.Credentials = New NetworkCredential("zheyunge041225@gmail.com", "dokr kpme kmaz wtnr") ' Use App Password if 2FA is enabled
        smtpClient.EnableSsl = True

        Dim mailMessage As New MailMessage()
        mailMessage.From = New MailAddress("zheyunge041225@gmail.com") ' Use the same email as the credentials
        mailMessage.To.Add(email)
        mailMessage.Subject = "Registration Slip"
        mailMessage.Body = "This is your registration slip."
        mailMessage.IsBodyHtml = False

        If File.Exists(pdfFilePath) Then
            mailMessage.Attachments.Add(New Attachment(pdfFilePath))
        Else
            MessageBox.Show("The specified PDF file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            smtpClient.Send(mailMessage)
            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SmtpException
            MessageBox.Show("SMTP Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CreatePdf(filePath As String)
        Dim id As Integer
        If Not Integer.TryParse(TextBoxID.Text.Trim(), id) Then
            MessageBox.Show("Please enter a valid Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim document As New Document()
        Using connection As New MySqlConnection(connectionString)
            connection.Open() ' Open the connection before executing the command
            Dim query As String = "SELECT st.Subject_code, s.Name, st.Fee, st.Credit, s.Class
                            FROM students s
                            INNER JOIN subject_registered sr ON s.StudentID = sr.StudentID
                            INNER JOIN subject st ON st.Subject_code = sr.subject_code
                            WHERE s.StudentID = @id"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id) ' Ensure 'id' is defined in your context
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        Try
                            ' Create a PdfWriter instance
                            PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
                            document.Open() ' Open the document

                            ' Add a title or header
                            document.Add(New Paragraph("Registration Slip"))
                            document.Add(New Paragraph(New String("-"c, 40))) ' Separator line

                            ' Read the first record to get student details
                            reader.Read() ' Read the first record
                            Dim name As String = reader("Name").ToString()
                            Dim studentClass As String = reader("Class").ToString()

                            ' Add student details
                            document.Add(New Paragraph("Student ID: " & id))
                            document.Add(New Paragraph("Student Name: " & name))
                            document.Add(New Paragraph("Student Class: " & studentClass))
                            document.Add(New Paragraph(New String("-"c, 40))) ' Separator line

                            ' Create a table with 3 columns
                            Dim table As New PdfPTable(3)
                            table.WidthPercentage = 100 ' Set the table width to 100%

                            ' Set column widths (optional)
                            Dim widths() As Single = {1.5F, 1.0F, 1.5F} ' Adjust the ratios as needed
                            table.SetWidths(widths)

                            ' Set table border
                            table.DefaultCell.Border = Rectangle.NO_BORDER

                            ' Add table headers
                            table.AddCell(New Phrase("Subject Code"))
                            table.AddCell(New Phrase("Credit"))
                            table.AddCell(New Phrase("Fee"))

                            Dim totalFee As Decimal = 0
                            Dim totalCredit As Integer = 0

                            ' Add the first subject's details to the table
                            table.AddCell(New Phrase(reader("Subject_code").ToString()))
                            table.AddCell(New Phrase(reader.GetInt32("Credit").ToString()))
                            table.AddCell(New Phrase(reader.GetDecimal("Fee").ToString("C"))) ' Format as currency

                            ' Accumulate totals
                            totalFee += reader.GetDecimal("Fee")
                            totalCredit += reader.GetInt32("Credit")

                            ' Loop through the remaining records
                            While reader.Read()
                                ' Add each subject's details to the PDF
                                table.AddCell(New Phrase(reader("Subject_code").ToString()))
                                table.AddCell(New Phrase(reader.GetInt32("Credit").ToString()))
                                table.AddCell(New Phrase(reader.GetDecimal("Fee").ToString("C"))) ' Format as currency

                                ' Accumulate totals
                                totalFee += reader.GetDecimal("Fee")
                                totalCredit += reader.GetInt32("Credit")
                            End While

                            ' Add the table to the document
                            document.Add(table)

                            ' Add total fee and total credit
                            document.Add(New Paragraph(New String("-"c, 40))) ' Separator line
                            document.Add(New Paragraph("Total Credit: " & totalCredit.ToString()))
                            document.Add(New Paragraph("Total Fee: " & totalFee.ToString("C"))) ' Format as currency

                        Catch ex As Exception
                            Console.WriteLine("Error creating PDF: " & ex.Message)
                        Finally
                            document.Close() ' Ensure the document is closed
                        End Try
                    Else
                        MessageBox.Show("No records found for the given Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class