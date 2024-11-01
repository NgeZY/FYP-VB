<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBoxIcNumber = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIcNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIcNumber = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblIc = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(650, 255)
        Me.DataGridView1.TabIndex = 2
        '
        'txtBoxIcNumber
        '
        Me.txtBoxIcNumber.Location = New System.Drawing.Point(368, 155)
        Me.txtBoxIcNumber.Name = "txtBoxIcNumber"
        Me.txtBoxIcNumber.Size = New System.Drawing.Size(427, 28)
        Me.txtBoxIcNumber.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(854, 447)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(237, 28)
        Me.txtSubject.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(854, 334)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 28)
        Me.txtName.TabIndex = 5
        '
        'txtIcNumber
        '
        Me.txtIcNumber.Location = New System.Drawing.Point(854, 388)
        Me.txtIcNumber.Name = "txtIcNumber"
        Me.txtIcNumber.Size = New System.Drawing.Size(237, 28)
        Me.txtIcNumber.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(659, 75)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Teacher Information"
        '
        'lblIcNumber
        '
        Me.lblIcNumber.AutoSize = True
        Me.lblIcNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIcNumber.Location = New System.Drawing.Point(146, 154)
        Me.lblIcNumber.Name = "lblIcNumber"
        Me.lblIcNumber.Size = New System.Drawing.Size(122, 25)
        Me.lblIcNumber.TabIndex = 8
        Me.lblIcNumber.Text = " IC Number :"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(888, 141)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 41)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(712, 334)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 22)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = " Name :"
        '
        'lblIc
        '
        Me.lblIc.AutoSize = True
        Me.lblIc.Location = New System.Drawing.Point(715, 388)
        Me.lblIc.Name = "lblIc"
        Me.lblIc.Size = New System.Drawing.Size(105, 22)
        Me.lblIc.TabIndex = 11
        Me.lblIc.Text = "IC Number :"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(713, 447)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(80, 22)
        Me.lblSubject.TabIndex = 12
        Me.lblSubject.Text = "Subject :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(722, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(347, 37)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Add / Delete Teacher "
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(1138, 447)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 31)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1134, 563)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 31)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1134, 504)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 31)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 37)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Teacher's List"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(700, 504)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(140, 22)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(725, 563)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(86, 22)
        Me.lblAddress.TabIndex = 19
        Me.lblAddress.Text = "Address :"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(725, 617)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(71, 22)
        Me.lblSalary.TabIndex = 20
        Me.lblSalary.Text = "Salary :"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(854, 504)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(237, 28)
        Me.txtPhoneNumber.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(854, 560)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(237, 28)
        Me.txtAddress.TabIndex = 22
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(854, 614)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(237, 28)
        Me.txtSalary.TabIndex = 23
        '
        'TeacherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 699)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblIc)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblIcNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIcNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtBoxIcNumber)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TeacherInfo"
        Me.Text = "TeacherInfo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBoxIcNumber As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIcNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIcNumber As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblIc As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSalary As TextBox
End Class
