Public Class clsJobList

    Dim jobs As New Collection

    'Public Sub addNewJob(ByVal name As String, ByVal phone As String, ByVal city As String, ByVal cellphone As String, ByVal address As String, ByVal email As String, ByVal deposit As String, ByVal balance As String)
    '
    '    Dim objJob As New clsJob 'instantiate a new object
    '
    '        objJob.thedate = name 'populate the object with related data
    '        objJob.time = phone
    '        objJob.length = cellphone
    '        objJob.cleaner = email
    '        objJob.address = address
    '        objJob.city = city
    '        objJob.deposit = deposit
    '        objJob.balance = balance
    '
    '
    '        jobs.Add(objJob)  'add populated object in the collection
    '
    '        MessageBox.Show("Object Added to Collection")
    'End Sub

    Public Sub addNewJob(ByVal item As clsJob)
        jobs.Add(item)
    End Sub


    Public Function retrieveJobs() As String

        Dim data As String = ""
        Dim job As New clsJob 'new was added to stop a warning. 

        'NEEDS MORE WORK HERE.

        Return data

    End Function

End Class