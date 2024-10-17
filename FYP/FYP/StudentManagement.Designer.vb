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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.SearchButton2 = New System.Windows.Forms.Button()
        Me.StatusBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(142, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(867, 194)
        Me.DataGridView1.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(163, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IC Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 427)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Class:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(280, 267)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(307, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(280, 321)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(307, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(280, 373)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(307, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(280, 427)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(307, 26)
        Me.TextBox4.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(280, 485)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 10
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(206, 594)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(112, 38)
        Me.AddButton.TabIndex = 11
        Me.AddButton.Text = "Add Student"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(392, 594)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(143, 38)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "Update Student"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(588, 594)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(135, 38)
        Me.DeleteButton.TabIndex = 13
        Me.DeleteButton.Text = "Delete Student"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(807, 594)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(112, 38)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(280, 674)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(175, 38)
        Me.SearchButton1.TabIndex = 15
        Me.SearchButton1.Text = "Search by IC Number"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'SearchButton2
        '
        Me.SearchButton2.Location = New System.Drawing.Point(659, 674)
        Me.SearchButton2.Name = "SearchButton2"
        Me.SearchButton2.Size = New System.Drawing.Size(150, 38)
        Me.SearchButton2.TabIndex = 16
        Me.SearchButton2.Text = "Search by Name"
        Me.SearchButton2.UseVisualStyleBackColor = True
        '
        'StatusBox
        '
        Me.StatusBox.Location = New System.Drawing.Point(314, 811)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(273, 26)
        Me.StatusBox.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 811)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Status Message:"
        '
        'StudentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 911)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.SearchButton2)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "StudentManagement"
        Me.Text = "StudentManagement"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
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
