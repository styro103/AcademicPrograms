Public Class JobForm
    'Opens add new Job Form
    Private Sub btnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJob.Click
        NewJobForm.Show()
        NewJobForm.txtNJName.Focus()
    End Sub
    'Opens form containing list of all jobs
    Private Sub btnJobAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobAll.Click
        JobListForm.Show()
        JobListForm.gbJLCompleted.Visible = True
        JobListForm.gbJLPending.Visible = True
    End Sub
    'Opens form containing list of completed Jobs
    Private Sub btnJobCompleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobCompleted.Click
        JobListForm.Show()
        JobListForm.gbJLCompleted.Visible = True
        JobListForm.gbJLPending.Visible = False
    End Sub
    'Opens form containing list of pending jobs
    Private Sub btnJobPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobPending.Click
        JobListForm.Show()
        JobListForm.gbJLCompleted.Visible = False
        JobListForm.gbJLPending.Visible = True
    End Sub
    'Opens dialog box to search a job. Opens form containing job information & gives option to delete that job if the user is 
    'a manager. Displays error message if job doesn't exist
    Private Sub btnJobEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobEdit.Click
        JobEditForm.Show()

    End Sub
    'Saves information
    Private Sub btnJobSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'sets txtbox & label to visible
    Private Sub btnJobStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobStatus.Click
        txtJobStatus.Visible = True
        lblJobStatus.Visible = True

    End Sub
    
    'Closes JobForm
    Private Sub btnJobBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobBack.Click
        Me.Close()
    End Sub

    'Saves Info
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Opens a message box containing status of the job. Displays error message if job doesn't exist
    Private Sub txtJobStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJobStatus.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            'check if job doesn't exist
            MessageBox.Show("Fill this in")
        End If
    End Sub

    Private Sub txtJobStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJobStatus.TextChanged

    End Sub
End Class