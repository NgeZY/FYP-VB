Public Class UpdateClassForm

    Private Sub ClassUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the "PUSATTUITIONFANADataset._class" table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.PUSATTUITIONFANADataset._class)
        showSelectedClass(ClassInformationForm.mselectedIdString)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Me.Validate()
        Me.ClassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PUSATTUITIONFANADataset)
        MessageBox.Show("Successfully updated!")
    End Sub

    Friend Sub showSelectedClass(id As String)
        ClassBindingSource.Filter = "(convert(ID, 'System.String') = '" & id & "')"
        If ClassBindingSource.Count <> 0 Then
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class
