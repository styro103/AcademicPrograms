Public Class NewJobForm
    Dim jobList As New clsJobListManager
    'Closes Form
    Private Sub btnNJBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNJBack.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Add the information to the database
    Private Sub btnNJSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNJSubmit.Click
        jobList.addJob(txtNJName.Text, txtNJClient.Text, txtNJLocation.Text, txtNJStart.Text, txtNJDeadline.Text, txtNJDescription.Text,
                       txtNJLead.Text, txtNJEmployee1.Text, txtNJEmployee2.Text, txtNJEmployee3.Text, txtNJLeadTitle.Text, txtNJTitle1.Text,
                       txtNJTitle2.Text, txtNJTitle3.Text)

        'insert into listboxes
        'These will be added to the pending jobs because a new job will never be a completed job - Eric
        jobList.viewProjectName(JobListForm.lstPendingName)
        jobList.viewClient(JobListForm.lstPendingClient)
        jobList.viewStartDate(JobListForm.lstPendingStart)
        jobList.viewDeadline(JobListForm.lstPendingDeadline)
        JobListForm.lstPendingStatus.Items.Add("Not Completed") 'Automatically put "not completed" in the pending status - Eric


        Me.Close()
    End Sub

    Private Sub NewJobForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class