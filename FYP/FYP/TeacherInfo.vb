Imports MySql.Data.MySqlClient

Public Class TeacherInfo
    ' Define the database connection string
    Dim connectionString As String = "server=localhost; user=root; password=; database=school_management"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)

    ' Load event to populate the DataGridView with the list of teachers on form load
    Private Sub TeacherInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacherList()
    End Sub

    ' Method to load all teachers into the DataGridView
    Private Sub LoadTeacherList()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM teachers"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading teacher list: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Search for a teacher by IC number
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM teachers WHERE IC = @IC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@IC", txtIcNumber.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtName.Text = reader("Name").ToString()
                txtSubject.Text = reader("Subject").ToString()
                txtPhoneNumber.Text = reader("PhoneNumber").ToString()
                txtAddress.Text = reader("Address").ToString()
                txtSalary.Text = reader("Salary").ToString()
                MessageBox.Show("Teacher found!")
            Else
                MessageBox.Show("Teacher not found.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Add a new teacher to the database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO teachers (Name, IC, Subject, PhoneNumber, Address, Salary) VALUES (@Name, @IC, @Subject, @PhoneNumber, @Address, @Salary)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", txtName.Text)
            command.Parameters.AddWithValue("@IC", txtIcNumber.Text)
            command.Parameters.AddWithValue("@Subject", txtSubject.Text)
            command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Salary", txtSalary.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Teacher added successfully.")
                LoadTeacherList() ' Refresh the DataGridView
            Else
                MessageBox.Show("Failed to add teacher.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update an existing teacher's details
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE teachers SET Name = @Name, Subject = @Subject, PhoneNumber = @PhoneNumber, Address = @Address, Salary = @Salary WHERE IC = @IC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", txtName.Text)
            command.Parameters.AddWithValue("@Subject", txtSubject.Text)
            command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Salary", txtSalary.Text)
            command.Parameters.AddWithValue("@IC", txtIcNumber.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Teacher updated successfully.")
                LoadTeacherList() ' Refresh the DataGridView
            Else
                MessageBox.Show("Failed to update teacher.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete a teacher from the database
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM teachers WHERE IC = @IC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@IC", txtIcNumber.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Teacher deleted successfully.")
                LoadTeacherList() ' Refresh the DataGridView
            Else
                MessageBox.Show("Failed to delete teacher.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class