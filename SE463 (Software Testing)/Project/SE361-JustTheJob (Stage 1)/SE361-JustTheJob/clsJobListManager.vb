Public Class clsJobListManager
    Private colJobs As New Collection

    Public Sub addJob(ByVal projectName As String, ByVal client As String, ByVal location As String, ByVal startDate As String,
                    ByVal Deadline As String, ByVal Description As String, ByVal projectLead As String, ByVal employee1 As String,
                    ByVal employee2 As String, ByVal employee3 As String, ByVal leadTitle As String, ByVal title1 As String,
                    ByVal title2 As String, ByVal title3 As String)
        Dim objJob As New clsJob

        objJob.projectName = projectName
        objJob.client = client
        objJob.location = location
        objJob.startDate = startDate
        objJob.Deadline = Deadline
        objJob.Description = Description
        objJob.projectLead = projectLead
        objJob.employee1 = employee1
        objJob.employee2 = employee2
        objJob.employee3 = employee3
        objJob.leadTitle = leadTitle
        objJob.title1 = title1
        objJob.title2 = title2
        objJob.title3 = title3



        colJobs.Add(objJob)
    End Sub

    Public Sub viewProjectName(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.projectName)
        Next
    End Sub

    Public Sub viewClient(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.client)
        Next
    End Sub

    Public Sub viewLocation(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.location)
        Next
    End Sub

    Public Sub viewStartDate(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.startDate)
        Next
    End Sub
    Public Sub viewDeadline(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.Deadline)
        Next
    End Sub
    Public Sub viewDescription(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.Description)
        Next
    End Sub
    Public Sub viewProjectLead(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.projectLead)
        Next
    End Sub
    Public Sub viewEmployee1(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.employee1)
        Next
    End Sub
    Public Sub viewEmployee2(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.employee2)
        Next
    End Sub
    Public Sub viewEmployee3(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.employee3)
        Next
    End Sub
    Public Sub viewLeadTitle(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.leadTitle)
        Next
    End Sub
    Public Sub viewTitle1(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.title1)
        Next
    End Sub
    Public Sub viewTitle2(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.title2)
        Next
    End Sub
    Public Sub viewTitle3(ByRef guiDisplay As ListBox)
        Dim job As clsJob

        For Each job In colJobs
            guiDisplay.Items.Add(job.title3)
        Next
    End Sub
End Class
