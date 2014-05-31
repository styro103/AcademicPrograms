Public Class NewInvoiceForm
    'Closes the form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes the form
    Private Sub btnNIBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNIBack.Click
        Me.Close()
    End Sub
    'Add the invoice to the appropriate database depending on the radio button selection
    Private Sub btnNISubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNISubmit.Click
        Me.Close()
    End Sub
End Class