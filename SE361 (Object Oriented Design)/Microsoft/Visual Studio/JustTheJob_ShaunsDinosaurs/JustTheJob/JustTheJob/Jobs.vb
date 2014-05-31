Public Class Jobs
    Dim joblist = New clsJobList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addjob.Click
        'create a new Cleaner object
        Dim objJob As New clsJob

        Try


            'populate the Contact object with the data from the GUI form
            objJob.strDate = CStr(txt_jobdate.Text)
            objJob.strTime = CStr(txt_jobtime.Text)
            objJob.strLength = CStr(txt_joblength.Text)
            objJob.strCleanerFirst = CStr(txt_cleanerfirst.Text)
            objJob.strCleanerLast = CStr(txt_cleanerlast.Text)
            objJob.strAddress = CStr(txt_jobaddress.Text)
            objJob.strCity = CStr(txt_jobcity.Text)
            objJob.strDeposit = CStr(txt_jobdeposit.Text)
            objJob.strBalance = CStr(txt_jobbalance.Text)

            'Add the object into the list
            joblist.addNewJob(objJob)

            'Add the object into the database 
            Dim entry As DataRow
            entry = JustTheJobDataSet.Tables("Jobs").NewRow

            entry.Item("jobCleanerFirst") = objJob.cleanerfirst
            entry.Item("jobCleanerLast") = objJob.cleanerlast
            entry.Item("jobTime") = objJob.time
            entry.Item("jobDate") = objJob.thedate
            entry.Item("jobLength") = objJob.length
            entry.Item("jobAddress") = objJob.address
            entry.Item("jobCity") = objJob.city
            entry.Item("jobDeposit") = objJob.deposit
            entry.Item("jobBalance") = objJob.balance


            JustTheJobDataSet.Tables("Jobs").Rows.Add(entry)
            JobsTableAdapter.Update(entry) 'displays it

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")

        End Try


    End Sub


    Private Sub Jobs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JustTheJobDataSet.Jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.JustTheJobDataSet.Jobs)
        btn_removejob.Enabled = MainMenu.adminuser

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_removejob.Click
        Try
            JobsBindingSource.RemoveCurrent()

            Me.JobsTableAdapter.Update(Me.JustTheJobDataSet.Tables("Jobs"))
            JustTheJobDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyTabControl.SelectedIndexChanged

        Dim indexOfSelectedTab As Integer = MyTabControl.SelectedIndex
        Dim selectedTab As System.Windows.Forms.TabPage = MyTabControl.SelectedTab

        Select Case indexOfSelectedTab
            Case 0
                Me.JobsTableAdapter.Fill(Me.JustTheJobDataSet.Jobs)
            Case 1
                Me.JobsTableAdapter.FillCompletedJobs(Me.JustTheJobDataSet.Jobs)
            Case 2
                Me.JobsTableAdapter.FillPending(Me.JustTheJobDataSet.Jobs)
            Case 3
                Me.JobsTableAdapter.FillBigJobs(Me.JustTheJobDataSet.Jobs)
        End Select


    End Sub


End Class