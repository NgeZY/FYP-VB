<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrationform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonEmail = New System.Windows.Forms.Button()
        Me.ButtonDisplayCredit = New System.Windows.Forms.Button()
        Me.ButtonDisplayFee = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDisplaySubject = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Code"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(392, 262)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 2
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Location = New System.Drawing.Point(392, 297)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCode.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(185, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Registered Subject"
        Me.Label3.Visible = False
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(252, 357)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegister.TabIndex = 6
        Me.ButtonRegister.Text = "Register Subject"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(362, 357)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrint.TabIndex = 7
        Me.ButtonPrint.Text = "Print Slip"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonEmail
        '
        Me.ButtonEmail.Location = New System.Drawing.Point(476, 357)
        Me.ButtonEmail.Name = "ButtonEmail"
        Me.ButtonEmail.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEmail.TabIndex = 8
        Me.ButtonEmail.Text = "Email Slip"
        Me.ButtonEmail.UseVisualStyleBackColor = True
        '
        'ButtonDisplayCredit
        '
        Me.ButtonDisplayCredit.Location = New System.Drawing.Point(252, 399)
        Me.ButtonDisplayCredit.Name = "ButtonDisplayCredit"
        Me.ButtonDisplayCredit.Size = New System.Drawing.Size(75, 45)
        Me.ButtonDisplayCredit.TabIndex = 9
        Me.ButtonDisplayCredit.Text = "Display Total Credit"
        Me.ButtonDisplayCredit.UseVisualStyleBackColor = True
        '
        'ButtonDisplayFee
        '
        Me.ButtonDisplayFee.Location = New System.Drawing.Point(362, 399)
        Me.ButtonDisplayFee.Name = "ButtonDisplayFee"
        Me.ButtonDisplayFee.Size = New System.Drawing.Size(75, 45)
        Me.ButtonDisplayFee.TabIndex = 10
        Me.ButtonDisplayFee.Text = "Display Fee"
        Me.ButtonDisplayFee.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Student List by Subject"
        Me.Label4.Visible = False
        '
        'ButtonDisplaySubject
        '
        Me.ButtonDisplaySubject.Location = New System.Drawing.Point(476, 399)
        Me.ButtonDisplaySubject.Name = "ButtonDisplaySubject"
        Me.ButtonDisplaySubject.Size = New System.Drawing.Size(75, 45)
        Me.ButtonDisplaySubject.TabIndex = 12
        Me.ButtonDisplaySubject.Text = "Display by Subject"
        Me.ButtonDisplaySubject.UseVisualStyleBackColor = True
        '
        'Registrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 501)
        Me.Controls.Add(Me.ButtonDisplaySubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonDisplayFee)
        Me.Controls.Add(Me.ButtonDisplayCredit)
        Me.Controls.Add(Me.ButtonEmail)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxCode)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrationform"
        Me.Text = "Registrationform"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonEmail As Button
    Friend WithEvents ButtonDisplayCredit As Button
    Friend WithEvents ButtonDisplayFee As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDisplaySubject As Button
End Class
