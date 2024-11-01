Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ClassManagementForm
    ' Set your connection string (replace with your own)
    Private connectionString As String = "Server=localhost;Database=school_management;Uid=root;Pwd=your_password;"
    Private connection As New MySqlConnection(connectionString)

    ' Load class data into DataGridView on form load
    Private Sub DataGridViewClasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClasses()
    End Sub

    ' Method to load classes into the DataGridView
    Private Sub LoadClasses()
        Try
            Dim query As String = "SELECT * FROM Classes"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridViewClasses.DataSource = table
        Catch ex As Exception
            StatusBox.Text = "Error loading classes: " & ex.Message
        End Try
    End Sub

    ' Add a new class
    Private Sub AddClassButton_Click(sender As Object, e As EventArgs) Handles AddClassButton.Click
        Try
            Dim query As String = "INSERT INTO Classes (ClassID, ClassName) VALUES (@ClassID, @ClassName)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClassID", TextBoxClassID.Text)
            command.Parameters.AddWithValue("@ClassName", TextBoxClassName.Text)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            StatusBox.Text = "Class added successfully!"
            LoadClasses()
        Catch ex As Exception
            StatusBox.Text = "Error adding class: " & ex.Message
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update class information
    Private Sub UpdateClassButton_Click(sender As Object, e As EventArgs) Handles UpdateClassButton.Click
        Try
            Dim query As String = "UPDATE Classes SET ClassName = @ClassName WHERE ClassID = @ClassID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClassID", TextBoxClassID.Text)
            command.Parameters.AddWithValue("@ClassName", TextBoxClassName.Text)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            StatusBox.Text = "Class updated successfully!"
            LoadClasses()
        Catch ex As Exception
            StatusBox.Text = "Error updating class: " & ex.Message
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete a class
    Private Sub DeleteClassButton_Click(sender As Object, e As EventArgs) Handles DeleteClassButton.Click
        Try
            Dim query As String = "DELETE FROM Classes WHERE ClassID = @ClassID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClassID", TextBoxClassID.Text)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            StatusBox.Text = "Class deleted successfully!"
            LoadClasses()
        Catch ex As Exception
            StatusBox.Text = "Error deleting class: " & ex.Message
        Finally
            connection.Close()
        End Try
    End Sub

    ' Search for a class by ID or Name
    Private Sub SearchClassButton_Click(sender As Object, e As EventArgs) Handles SearchClassButton.Click
        Dim query As String
        If Not String.IsNullOrEmpty(TextBoxClassID.Text) Then
            query = "SELECT * FROM Classes WHERE ClassID = @ClassID"
        ElseIf Not String.IsNullOrEmpty(TextBoxClassName.Text) Then
            query = "SELECT * FROM Classes WHERE ClassName LIKE @ClassName"
        Else
            StatusBox.Text = "Please enter a Class ID or Name to search."
            Exit Sub
        End If

        Dim adapter As New MySqlDataAdapter(query, connection)
        If Not String.IsNullOrEmpty(TextBoxClassID.Text) Then
            adapter.SelectCommand.Parameters.AddWithValue("@ClassID", TextBoxClassID.Text)
        Else
            adapter.SelectCommand.Parameters.AddWithValue("@ClassName", "%" & TextBoxClassName.Text & "%")
        End If

        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewClasses.DataSource = table
    End Sub

    ' Clear all input fields
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBoxClassID.Clear()
        TextBoxClassName.Clear()
        StatusBox.Clear()
    End Sub
End Class
