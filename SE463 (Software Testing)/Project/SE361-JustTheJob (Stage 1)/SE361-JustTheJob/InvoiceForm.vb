Public Class InvoiceForm
    'Opens AddNew 1-Time Invoice Form
    Private Sub btnNew1TInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew1TInvoice.Click
        NewInvoiceForm.Show()
        NewInvoiceForm.radNIOneTime.Checked = True
    End Sub
    'search database based on info in textbox
    Private Sub btnInv1TShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv1TShow.Click
        'search first
        ShowInvoiceForm.Show()
    End Sub
   
    'search database based on info in textbox & return status in the label. Set label to visible
    Private Sub btnInv1TStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv1TStatus.Click
        lblStatus.Show()
        lblOTShow.Show()
    End Sub
    'Opens Add Regular Invoice Form
    Private Sub btnNewRInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRInvoice.Click
        NewInvoiceForm.Show()
        NewInvoiceForm.radNIRegular.Checked = True
    End Sub
    'search database based on info in textbox
    Private Sub btnInvRShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvRShow.Click
        'search first
        ShowInvoiceForm.Show()
    End Sub
   
    'search database based on info in textbox & return status in the label. set labels to visible
    Private Sub btnInvStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvStatus.Click
        lblStatus2.Show()
        lblRShow.Show()
    End Sub
    'Saves all changed information
    Private Sub btnInvSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes InvoiceForm
    Private Sub btnInvBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvBack.Click
        Me.Close()
    End Sub
    'Saves Info
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Toggles visibility of One-Time Invoice Groupbox
    Private Sub OneTimeInvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneTimeInvoicesToolStripMenuItem.Click

    End Sub
    'Toggles visibility of Regular Invoice Groupbox
    Private Sub RegularInvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularInvoicesToolStripMenuItem.Click

    End Sub
    'Opens Form containing info on that invoice. Will have option to edit & print info and option to delete invoice if user is a manager

End Class