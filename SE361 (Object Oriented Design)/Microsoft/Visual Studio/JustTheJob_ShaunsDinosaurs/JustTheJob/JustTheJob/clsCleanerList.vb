Public Class clsCleanerList

    Dim cleaners As New Collection

    Public Sub addNewCleaner(ByVal firstname As String, ByVal lastname As String, ByVal phone As String, ByVal city As String, ByVal cellphone As String, ByVal address As String, ByVal email As String)


        Dim objCleaner As New clsCleaner 'instantiate a new object

        objCleaner.firstname = firstname 'populate the object with related data
        objCleaner.lastname = lastname
        objCleaner.phone = phone
        objCleaner.email = email
        objCleaner.address = address
        objCleaner.city = city
        objCleaner.cellphone = cellphone

        cleaners.Add(objCleaner)  'add populated object in the collection

    End Sub

    Public Sub addNewCleaner(ByVal item As clsCleaner)
        cleaners.Add(item)
    End Sub


    Public Function retrieveCustomers() As String

        Dim data As String = ""
        Dim cleaner As New clsCleaner

        For Each cust In cleaners
            data &= cleaner.firstname & vbTab & cleaner.lastname & vbTab & cleaner.phone & vbTab & cleaner.email & vbTab & cleaner.address & vbTab & cleaner.city & vbTab & cleaner.cellphone & vbCrLf
        Next

        Return data

    End Function

End Class