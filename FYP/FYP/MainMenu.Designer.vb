<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(88, 555)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(194, 74)
        Me.btnUser.TabIndex = 5
        Me.btnUser.Text = "Manage User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(88, 122)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(194, 74)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Manage Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClass
        '
        Me.btnClass.Location = New System.Drawing.Point(88, 18)
        Me.btnClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(194, 74)
        Me.btnClass.TabIndex = 7
        Me.btnClass.Text = "Manage Class"
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(88, 231)
        Me.btnStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(194, 74)
        Me.btnStudent.TabIndex = 8
        Me.btnStudent.Text = "Manage Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(88, 334)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(194, 74)
        Me.btnTeacher.TabIndex = 9
        Me.btnTeacher.Text = "Manage Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'btnSubject
        '
        Me.btnSubject.Location = New System.Drawing.Point(88, 438)
        Me.btnSubject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(194, 74)
        Me.btnSubject.TabIndex = 10
        Me.btnSubject.Text = "Manage Subject"
        Me.btnSubject.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnSubject)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnClass)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnUser)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUser As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents btnRegister As Button
End Class
