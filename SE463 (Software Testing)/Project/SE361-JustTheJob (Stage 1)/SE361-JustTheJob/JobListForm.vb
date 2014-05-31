Public Class JobListForm
    'Prints list of jobs
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub
    'Closes JobListForm
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Toggle Completed Jobs Visibility
    Private Sub CompletedJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompletedJobsToolStripMenuItem.Click
        If gbJLCompleted.Visible = False Then
            gbJLCompleted.Visible = True
        ElseIf gbJLCompleted.Visible = True Then
            gbJLCompleted.Visible = False
        End If
    End Sub
    'Toggle Pending Jobs Visibility
    Private Sub PendingJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingJobsToolStripMenuItem.Click
        If gbJLPending.Visible = False Then
            gbJLPending.Visible = True
        ElseIf gbJLPending.Visible = True Then
            gbJLPending.Visible = False
        End If
    End Sub
    'Close Form
    Private Sub btnJLBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJLBack.Click
        Me.Close()
    End Sub
    'Prints list of Jobs
    Private Sub btnJLPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJLPrint.Click

    End Sub

    Private Sub BackToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lstCompletedName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCompletedName.SelectedIndexChanged

    End Sub
End Class