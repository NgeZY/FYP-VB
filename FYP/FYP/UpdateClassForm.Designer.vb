<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateClassForm
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
        Me.ClassIDLabel = New System.Windows.Forms.Label()
        Me.ClassNameLabel = New System.Windows.Forms.Label()
        Me.ClassIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClassIDLabel
        '
        Me.ClassIDLabel.AutoSize = True
        Me.ClassIDLabel.Location = New System.Drawing.Point(263, 168)
        Me.ClassIDLabel.Name = "ClassIDLabel"
        Me.ClassIDLabel.Size = New System.Drawing.Size(73, 20)
        Me.ClassIDLabel.TabIndex = 0
        Me.ClassIDLabel.Text = "Class ID:"
        '
        'ClassNameLabel
        '
        Me.ClassNameLabel.AutoSize = True
        Me.ClassNameLabel.Location = New System.Drawing.Point(263, 249)
        Me.ClassNameLabel.Name = "ClassNameLabel"
        Me.ClassNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.ClassNameLabel.TabIndex = 1
        Me.ClassNameLabel.Text = "Class Name:"
        '
        'ClassIDTextBox
        '
        Me.ClassIDTextBox.Location = New System.Drawing.Point(392, 162)
        Me.ClassIDTextBox.Name = "ClassIDTextBox"
        Me.ClassIDTextBox.Size = New System.Drawing.Size(237, 26)
        Me.ClassIDTextBox.TabIndex = 2
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.Location = New System.Drawing.Point(392, 246)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(237, 26)
        Me.ClassNameTextBox.TabIndex = 3
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(285, 342)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(111, 39)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(484, 342)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(111, 39)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'UpdateClassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 602)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClassNameTextBox)
        Me.Controls.Add(Me.ClassIDTextBox)
        Me.Controls.Add(Me.ClassNameLabel)
        Me.Controls.Add(Me.ClassIDLabel)
        Me.Name = "UpdateClassForm"
        Me.Text = "UpdateClassForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClassIDLabel As Label
    Friend WithEvents ClassNameLabel As Label
    Friend WithEvents ClassIDTextBox As TextBox
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents CloseButton As Button
End Class
