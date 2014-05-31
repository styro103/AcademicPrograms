
'Boundary Class
Public Class frmCustomer

    Dim customerList As New clsCustomerList 'implemements a one-to-one association between frmCustomer and clsCustomerList
    Dim lineCharReader



    Private Sub btnAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomer.Click
        Try
            customerList.addNewCustomer(txtCustName.Text, txtCustPhone.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Private Sub btnShow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            lblDisplayCustomers.Text = String.Empty
            lblDisplayCustomers.Text = customerList.retrieveCustomers()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblDisplayCustomers.Text = String.Empty
        txtCustName.Clear()
        txtCustPhone.Clear()
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
