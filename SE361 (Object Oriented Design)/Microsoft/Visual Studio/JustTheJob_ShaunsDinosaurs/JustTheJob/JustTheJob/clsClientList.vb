Public Class clsClientList

    Dim clients As New Collection

    Public Sub addNewClient(ByVal firstname As String, ByVal lastname As String, ByVal phone As String, ByVal city As String, ByVal cellphone As String, ByVal address As String, ByVal email As String)


        Dim objClient As New clsClient 'instantiate a new object

        objClient.firstname = firstname 'populate the object with related data
        objClient.lastname = lastname
        objClient.phone = phone
        objClient.email = email
        objClient.address = address
        objClient.city = city
        objClient.cellphone = cellphone


        clients.Add(objClient)  'add populated object in the collection

        MessageBox.Show("Object Added to Collection:" &
                        objClient.firstname & " " & objClient.phone,
                        "User Feedback")
    End Sub


    'lets you add a core object
    Public Sub addNewClient(ByVal item As clsClient)
        clients.Add(item)
    End Sub



    Public Function retrieveClients() As String

        Dim data As String = ""
        Dim client As New clsClient 'new was added to stop a warning. 

        For Each cust In clients
            data &= client.firstname & vbTab & client.lastname & vbTab & client.phone & vbTab & client.email & vbTab & client.address & vbTab & client.city & vbTab & client.cellphone & vbCrLf
        Next

        Return data

    End Function

End Class