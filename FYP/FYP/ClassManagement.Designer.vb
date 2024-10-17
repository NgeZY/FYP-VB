<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassManagementForm
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
        Me.DataGridViewClasses = New System.Windows.Forms.DataGridView()
        Me.IDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ClassIDLabel = New System.Windows.Forms.Label()
        Me.ClassNameLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusBox = New System.Windows.Forms.TextBox()
        Me.SearchClassButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteClassButton = New System.Windows.Forms.Button()
        Me.UpdateClassButton = New System.Windows.Forms.Button()
        Me.AddClassButton = New System.Windows.Forms.Button()
        CType(Me.DataGridViewClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewClasses
        '
        Me.DataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClasses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDColumn, Me.NameColumn})
        Me.DataGridViewClasses.Location = New System.Drawing.Point(187, 92)
        Me.DataGridViewClasses.Name = "DataGridViewClasses"
        Me.DataGridViewClasses.RowHeadersWidth = 62
        Me.DataGridViewClasses.RowTemplate.Height = 28
        Me.DataGridViewClasses.Size = New System.Drawing.Size(798, 259)
        Me.DataGridViewClasses.TabIndex = 0
        '
        'IDColumn
        '
        Me.IDColumn.HeaderText = "Class ID"
        Me.IDColumn.MinimumWidth = 8
        Me.IDColumn.Name = "IDColumn"
        Me.IDColumn.Width = 150
        '
        'NameColumn
        '
        Me.NameColumn.HeaderText = "Class Name"
        Me.NameColumn.MinimumWidth = 8
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(303, 433)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(412, 26)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(303, 496)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(412, 26)
        Me.TextBox2.TabIndex = 2
        '
        'ClassIDLabel
        '
        Me.ClassIDLabel.AutoSize = True
        Me.ClassIDLabel.Location = New System.Drawing.Point(192, 436)
        Me.ClassIDLabel.Name = "ClassIDLabel"
        Me.ClassIDLabel.Size = New System.Drawing.Size(73, 20)
        Me.ClassIDLabel.TabIndex = 3
        Me.ClassIDLabel.Text = "Class ID:"
        '
        'ClassNameLabel
        '
        Me.ClassNameLabel.AutoSize = True
        Me.ClassNameLabel.Location = New System.Drawing.Point(192, 499)
        Me.ClassNameLabel.Name = "ClassNameLabel"
        Me.ClassNameLabel.Size = New System.Drawing.Size(98, 20)
        Me.ClassNameLabel.TabIndex = 4
        Me.ClassNameLabel.Text = "Class Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 838)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Status Message:"
        '
        'StatusBox
        '
        Me.StatusBox.Location = New System.Drawing.Point(343, 838)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(273, 26)
        Me.StatusBox.TabIndex = 25
        '
        'SearchClassButton
        '
        Me.SearchClassButton.Location = New System.Drawing.Point(306, 704)
        Me.SearchClassButton.Name = "SearchClassButton"
        Me.SearchClassButton.Size = New System.Drawing.Size(175, 38)
        Me.SearchClassButton.TabIndex = 23
        Me.SearchClassButton.Text = "Search Class"
        Me.SearchClassButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(667, 704)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(155, 38)
        Me.ClearButton.TabIndex = 22
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteClassButton
        '
        Me.DeleteClassButton.Location = New System.Drawing.Point(786, 624)
        Me.DeleteClassButton.Name = "DeleteClassButton"
        Me.DeleteClassButton.Size = New System.Drawing.Size(135, 38)
        Me.DeleteClassButton.TabIndex = 21
        Me.DeleteClassButton.Text = "Delete Class"
        Me.DeleteClassButton.UseVisualStyleBackColor = True
        '
        'UpdateClassButton
        '
        Me.UpdateClassButton.Location = New System.Drawing.Point(510, 624)
        Me.UpdateClassButton.Name = "UpdateClassButton"
        Me.UpdateClassButton.Size = New System.Drawing.Size(143, 38)
        Me.UpdateClassButton.TabIndex = 20
        Me.UpdateClassButton.Text = "Update Class"
        Me.UpdateClassButton.UseVisualStyleBackColor = True
        '
        'AddClassButton
        '
        Me.AddClassButton.Location = New System.Drawing.Point(232, 624)
        Me.AddClassButton.Name = "AddClassButton"
        Me.AddClassButton.Size = New System.Drawing.Size(112, 38)
        Me.AddClassButton.TabIndex = 19
        Me.AddClassButton.Text = "Add Class"
        Me.AddClassButton.UseVisualStyleBackColor = True
        '
        'ClassManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 906)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.SearchClassButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DeleteClassButton)
        Me.Controls.Add(Me.UpdateClassButton)
        Me.Controls.Add(Me.AddClassButton)
        Me.Controls.Add(Me.ClassNameLabel)
        Me.Controls.Add(Me.ClassIDLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridViewClasses)
        Me.Name = "ClassManagementForm"
        Me.Text = "ClassManagement"
        CType(Me.DataGridViewClasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewClasses As DataGridView
    Friend WithEvents IDColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ClassIDLabel As Label
    Friend WithEvents ClassNameLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusBox As TextBox
    Friend WithEvents SearchClassButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DeleteClassButton As Button
    Friend WithEvents UpdateClassButton As Button
    Friend WithEvents AddClassButton As Button
End Class
