Public Class ScheduleChangeForm
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub btnSCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCBack.Click
        Me.Close()
    End Sub
    'Submits the changes made to the appointment to the database
    Private Sub btnSCEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCEdit.Click
        Me.Close()
    End Sub
    'Removes appointment from Manager's Schedule
    Private Sub btnSCCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCCancel.Click

    End Sub

    Private Sub txtNAHead_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNAHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblNAHead.visible = False
        End If
    End Sub
End Class