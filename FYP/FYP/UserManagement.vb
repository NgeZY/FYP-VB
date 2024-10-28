Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class UserManagement
    Private connectionString As String = "server=localhost; user=root; password=; database=school_management"
    Dim query As String

    Private Sub LoadData()

        If ComboBox1.SelectedIndex = 0 Then
            query = "SELECT * FROM students"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            query = "SELECT * FROM teachers"
        End If

        If Not String.IsNullOrEmpty(query) Then
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()

                    Try
                        connection.Open()
                        adapter.Fill(table)
                        DataGridView1.DataSource = table
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub DeleteUser(tableName As String, columnName As String, userID As String)
        query = $"DELETE FROM {tableName} WHERE {columnName} = @UserID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully.")
                        LoadData() ' Refresh the DataGridView
                    Else
                        MessageBox.Show("User not found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub resetPassword(tableName As String, columnName As String, userID As String)
        query = $"UPDATE {tableName} SET Password = 0000 WHERE {columnName} = @UserID"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User password reset successfully.")
                        LoadData() ' Refresh the DataGridView
                    Else
                        MessageBox.Show("User not found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim userID As String = ""

            If ComboBox1.SelectedIndex = 0 Then
                userID = selectedRow.Cells("StudentID").Value.ToString()
                DeleteUser("students", "StudentID", userID)
            ElseIf ComboBox1.SelectedIndex = 1 Then
                userID = selectedRow.Cells("TeacherID").Value.ToString()
                DeleteUser("teachers", "TeacherID", userID)
            End If
        Else
            MessageBox.Show("Please select a user to delete.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim userID As String = ""
            If ComboBox1.SelectedIndex = 0 Then
                userID = selectedRow.Cells("StudentID").Value.ToString()
                resetPassword("students", "StudentID", userID)
            ElseIf ComboBox1.SelectedIndex = 1 Then
                userID = selectedRow.Cells("TeacherID").Value.ToString()
                resetPassword("teachers", "TeacherID", userID)
            End If
        Else
            MessageBox.Show("Please select a user to reset the password.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class