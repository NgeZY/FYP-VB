Public Class MainMenu
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        ' Open the Class Management Form
        Dim classForm As New ClassManagementForm()
        classForm.Show()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        ' Open the Student Information Form
        Dim studentForm As New StudentManagement()
        studentForm.Show()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        ' Open the Teacher Information Form
        Dim teacherForm As New TeacherInfo()
        teacherForm.Show()
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        ' Open the Subject Information Form
        Dim subjectForm As New SubjectInfo()
        subjectForm.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Open the Registration Form
        Dim registrationForm As New Registrationform()
        registrationForm.Show()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ' Open the User Management Form
        Dim userForm As New UserManagement()
        userForm.Show()
    End Sub
End Class
