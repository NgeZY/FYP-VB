<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentManagement
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
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StudentTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ICTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.SearchButton2 = New System.Windows.Forms.Button()
        Me.StatusBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.StudentDataGridView.Location = New System.Drawing.Point(95, 32)
        Me.StudentDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 62
        Me.StudentDataGridView.RowTemplate.Height = 28
        Me.StudentDataGridView.Size = New System.Drawing.Size(591, 126)
        Me.StudentDataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "IC Number"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Age "
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Class"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IC Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 315)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Class:"
        '
        'StudentTextBox
        '
        Me.StudentTextBox.Location = New System.Drawing.Point(187, 174)
        Me.StudentTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentTextBox.Name = "StudentTextBox"
        Me.StudentTextBox.Size = New System.Drawing.Size(206, 20)
        Me.StudentTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(187, 209)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(206, 20)
        Me.NameTextBox.TabIndex = 7
        '
        'ICTextBox
        '
        Me.ICTextBox.Location = New System.Drawing.Point(187, 242)
        Me.ICTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(206, 20)
        Me.ICTextBox.TabIndex = 8
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(187, 278)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(206, 20)
        Me.AgeTextBox.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(187, 315)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(137, 386)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 25)
        Me.AddButton.TabIndex = 11
        Me.AddButton.Text = "Add Student"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(261, 386)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(95, 25)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update Student"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(392, 386)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(90, 25)
        Me.DeleteButton.TabIndex = 13
        Me.DeleteButton.Text = "Delete Student"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(538, 386)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 25)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(187, 438)
        Me.SearchButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(117, 25)
        Me.SearchButton1.TabIndex = 15
        Me.SearchButton1.Text = "Search by IC Number"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'SearchButton2
        '
        Me.SearchButton2.Location = New System.Drawing.Point(439, 438)
        Me.SearchButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchButton2.Name = "SearchButton2"
        Me.SearchButton2.Size = New System.Drawing.Size(100, 25)
        Me.SearchButton2.TabIndex = 16
        Me.SearchButton2.Text = "Search by Name"
        Me.SearchButton2.UseVisualStyleBackColor = True
        '
        'StatusBox
        '
        Me.StatusBox.Location = New System.Drawing.Point(209, 527)
        Me.StatusBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(183, 20)
        Me.StatusBox.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 527)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Status Message:"
        '
        'StudentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 592)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.SearchButton2)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.ICTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.StudentTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "StudentManagement"
        Me.Text = "StudentManagement"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StudentTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ICTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SearchButton1 As Button
    Friend WithEvents SearchButton2 As Button
    Friend WithEvents StatusBox As TextBox
    Friend WithEvents Label6 As Label
End Class
