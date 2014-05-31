Public Class clsInvoiceList
    Dim invoices As New Collection

    Public Sub addNewInvoice(ByVal dateof As String, ByVal jobid As Integer, ByVal balance As String)


        Dim objInvoice As New clsInvoice 'instantiate a new object

        objInvoice.thedate = dateof 'populate the object with related data
        objInvoice.balance = balance
        objInvoice.intJobID = jobid

        invoices.Add(objInvoice)  'add populated object in the collection

        MessageBox.Show("Object Added to Collection")
    End Sub

    'lets you add a core object
    Public Sub addNewInvoice(ByVal item As clsInvoice)
        invoices.Add(item)
    End Sub

    Public Function retrieveInvoices() As String

        Dim data As String = ""
        Dim invoice As New clsJob 'new was added to stop a warning. 

        'NEEDS MORE WORK HERE.

        Return data

    End Function
End Class
