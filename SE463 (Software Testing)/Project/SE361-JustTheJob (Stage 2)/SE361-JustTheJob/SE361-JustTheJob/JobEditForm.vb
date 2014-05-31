Public Class JobEditForm

    Dim objFileManager As New clsFileManager
    Dim jobPendingList As New Collection
    Dim jobCompletedList As New Collection
    'Prints Job information form
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub
    'Closes form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub btnJEBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJEBack.Click
        Me.Close()
    End Sub
    'Deletes the job from the database. Manager action only
    Private Sub btnJEDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
        counter = 1
        If (txtJEName.Text.Trim <> "" Or txtJEClient.Text.Trim <> "" Or txtJELocation.Text.Trim <> "" Or txtJEStart.Text.Trim <> "" Or txtDeadline.Text.Trim <> "" Or txtJEDescription.Text.Trim <> "" Or txtJELead.Text.Trim <> "" Or txtJETitleLead.Text.Trim <> "") Then
            objFileManager.LoadJob(jobPendingList, jobCompletedList)
            If JobViewForm.lblStatus.Text = "Pending" Then
                For Each job In jobPendingList
                    temp = job
                    temp = temp.Substring(6)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempName = JobViewForm.lblName.Text) Then
                        jobPendingList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                jobPendingList.Add("<name>" + txtJEName.Text.Trim + " <client>" + txtJEClient.Text.Trim + " <location>" + txtJELocation.Text.Trim + " <start>" + txtJEStart.Text.Trim + " <deadLine>" + txtDeadline.Text.Trim + " <description>" + txtJEDescription.Text.Trim + " <lead>" + txtJELead.Text.Trim +
                                   " <employee1>" + txtJEEmployee1.Text.Trim + " <employee2>" + txtJEEmployee2.Text.Trim + " <employee3>" + txtJEEmployee3.Text.Trim + "<leadTitle>" + txtJETitleLead.Text.Trim + " <title1>" + txtJETitle1.Text.Trim + " <title2>" + txtJETitle2.Text.Trim + " <title3>" + txtJETitle3.Text.Trim)

                objFileManager.deleteItem(jobPendingList, "PendingJobs.txt")

                MessageBox.Show("The Job has been edited successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                JobViewForm.Close()
                Me.Close()
            ElseIf JobViewForm.lblStatus.Text = "Completed" Then
                For Each job2 In jobCompletedList
                    temp = job2
                    temp = temp.Substring(6)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))

                    If (tempName = JobViewForm.lblName.Text) Then
                        jobCompletedList.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                jobCompletedList.Add("<name>" + txtJEName.Text.Trim + " <client>" + txtJEClient.Text.Trim + " <location>" + txtJELocation.Text.Trim + " <start>" + txtJEStart.Text.Trim + " <deadLine>" + txtDeadline.Text.Trim + " <description>" + txtJEDescription.Text.Trim + " <lead>" + txtJELead.Text.Trim +
                                   " <employee1>" + txtJEEmployee1.Text.Trim + " <employee2>" + txtJEEmployee2.Text.Trim + " <employee3>" + txtJEEmployee3.Text.Trim + "<leadTitle>" + txtJETitleLead.Text.Trim + " <title1>" + txtJETitle1.Text.Trim + " <title2>" + txtJETitle2.Text.Trim + " <title3>" + txtJETitle3.Text.Trim)

                objFileManager.deleteItem(jobCompletedList, "CompletedJobs.txt")

                MessageBox.Show("The Job has been edited successfully", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                JobViewForm.Close()
                Me.Close()
            End If

        Else
            MessageBox.Show("All text boxes must be filled in.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class