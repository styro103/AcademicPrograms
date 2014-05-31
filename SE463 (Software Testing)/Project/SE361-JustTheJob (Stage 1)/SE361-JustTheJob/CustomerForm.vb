Public Class CustomerForm

    'Display form containing list of Customers. Inside form give option to print list
    Private Sub btnCustList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustList.Click
        CustomerListForm.Show()
    End Sub

    'Open Add New Customer Form
    Private Sub btnCustAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustAdd.Click
        NewCustomerForm.Show()
        NewCustomerForm.txtNCName.Focus()
    End Sub
    
    'set txtBox & label to visible to enter name of customer
    Private Sub btnCustShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustShow.Click
        txtCustShow.Visible = True
        lblCustShow.Visible = True
    End Sub

    'Saves Info
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'displays CustomerInfoForm based on contents entered 
    Private Sub txtCustShow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustShow.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            CustomerInfoForm.Show()
            'search
        End If
    End Sub

    Private Sub btnCustBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustBack.Click
        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class