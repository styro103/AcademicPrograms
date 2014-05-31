'Boundary class
'Responsible for retrieving GUI data about customers and send it to other control classes for processing
'Responsbile for receiving processed data from other control classes and display it onto related GUI forms

Public Class frmMain

    Dim customerList As New clsCustomerList 'implemements a one-to-one association between frmMain and clsCustomerList

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        customerList.addNewCustomer(txtName.Text, txtPhone.Text)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblDisplay.Text = String.Empty
        lblDisplay.Text = customerList.retrieveCustomers()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblDisplay.Text = String.Empty
        txtName.Clear()
        txtPhone.Clear()
    End Sub
End Class
