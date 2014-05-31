'Control Class

Public Class clsCustomerList

    Dim customers As New Collection 'implements a one-to-many association between clsCustomerList and clsCustomer

    Public Sub addNewCustomer(ByVal name As String, ByVal phone As String)

        Dim objCustomer As New clsCustomer 'instantiate a new customer object

        objCustomer.name = name 'populate the customer object with related data
        objCustomer.phone = phone

        customers.Add(objCustomer)  'add populated object in the customers collection

        MessageBox.Show("Customer Object Added to Collection:" &
                        objCustomer.name & " " & objCustomer.phone,
                        "User Feedback")
    End Sub


    Public Function retreiveCustomers() As String

        Dim data As String = ""
        Dim cust As clsCustomer

        For Each cust In customers
            data &= cust.name & vbTab & cust.phone & vbCrLf
        Next

        Return data

    End Function

End Class
