Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Define connection string (update with your own server, username, password if necessary)
    Private connectionString As String = "Server=127.0.0.1;Database=school_management;Uid=root;Pwd=;"

    ' Method to open a connection to the database
    Private Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Method to save subject information to the database
    Private Sub SaveSubject()
        ' Validate inputs
        If String.IsNullOrEmpty(txtSubjectCode.Text) OrElse String.IsNullOrEmpty(txtSubjectName.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' SQL Insert Command
        Dim query As String = "INSERT INTO subjects (subject_code, subject_name) VALUES (@subject, @subject_registered)"


        ' Connect to the database
        Using connection As MySqlConnection = GetConnection()
            Using command As New MySqlCommand(query, connection)
                ' Define parameters and their values
                command.Parameters.AddWithValue("@subjects", txtSubjectCode.Text)
                command.Parameters.AddWithValue("@subject_registered", txtSubjectName.Text)

                ' Open connection and execute command
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Subject information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As MySqlException
                    MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Event handler for the Save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSubject()
    End Sub
End Class