Public Class EmployeeInfo
    'Opens The Modify Employee Form
    Private Sub btnEIEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEIEdit.Click
        'need a form here or something.
    End Sub
    'Close Form
    Private Sub btnEIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEIBack.Click
        Me.Close()
    End Sub
    'Close Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Deletes the Employee from database. Manager action only
    Private Sub btnEIRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEIRemove.Click

    End Sub
End Class