'Control Class

Public Class clsCustomerList

    Dim customers As New Collection 'implements a one-to-many association between clsCustomerList and clsCustomer

    Public Sub addNewCustomer(ByVal custName As String, ByVal custPhone As String)

        Try
            Dim objCustomer As New clsCustomer 'instantiate a new customer object

            objCustomer.name = custName 'populate customer object with data from the GUI form
            objCustomer.phone = custPhone

            customers.Add(objCustomer)  'add populated object in the customers collection   

            MessageBox.Show("Customer Object Added to Collection:" & vbTab &
                                        objCustomer.name & vbTab & objCustomer.phone,
                                        "User Feedback")

            objCustomer.getDependentData(objCustomer) 'ask for any data about dependents for this customer
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Public Function retrieveCustomers() As String

        Dim dataCustomer As String = String.Empty

        Try
            Dim cust As clsCustomer
            'traverse the customers collection and append all information about customers into the dataCustomer variable
            For Each cust In customers
                dataCustomer &= cust.name & vbTab & cust.phone & vbCrLf
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

        Return dataCustomer

    End Function

End Class
