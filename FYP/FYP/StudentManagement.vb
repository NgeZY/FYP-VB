Imports System.Data.SqlClient

Public Class StudentManagement
    ' Define the connection string (adjust as needed)
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=YourDatabase;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    ' Load students when the form opens
    Private Sub StudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    ' Method to load data into DataGridView
    Private Sub LoadStudents()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Students"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            StudentDataGridView.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Add a new student to the database
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Students (StudentID, Name, ICNumber, Age, Class) VALUES (@StudentID, @Name, @ICNumber, @Age, @Class)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@StudentID", StudentTextBox.Text)
            command.Parameters.AddWithValue("@Name", NameTextBox.Text)
            command.Parameters.AddWithValue("@ICNumber", ICTextBox.Text)
            command.Parameters.AddWithValue("@Age", AgeTextBox.Text)
            command.Parameters.AddWithValue("@Class", ComboBox1.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Student added successfully.")
            LoadStudents()
        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update an existing student's information
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Students SET Name=@Name, ICNumber=@ICNumber, Age=@Age, Class=@Class WHERE StudentID=@StudentID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@StudentID", StudentTextBox.Text)
            command.Parameters.AddWithValue("@Name", NameTextBox.Text)
            command.Parameters.AddWithValue("@ICNumber", ICTextBox.Text)
            command.Parameters.AddWithValue("@Age", AgeTextBox.Text)
            command.Parameters.AddWithValue("@Class", ComboBox1.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully.")
            LoadStudents()
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete a student from the database
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Students WHERE StudentID=@StudentID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@StudentID", StudentTextBox.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Student deleted successfully.")
            LoadStudents()
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Clear input fields
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StudentTextBox.Clear()
        NameTextBox.Clear()
        ICTextBox.Clear()
        AgeTextBox.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    ' Populate input fields when a row is clicked in DataGridView
    Private Sub StudentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)
            StudentTextBox.Text = row.Cells("StudentID").Value.ToString()
            NameTextBox.Text = row.Cells("Name").Value.ToString()
            ICTextBox.Text = row.Cells("ICNumber").Value.ToString()
            AgeTextBox.Text = row.Cells("Age").Value.ToString()
            ComboBox1.Text = row.Cells("Class").Value.ToString()
        End If
    End Sub

    Private Sub ClassDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick

    End Sub

    Private Sub StudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentTextBox.TextChanged

    End Sub
End Class
