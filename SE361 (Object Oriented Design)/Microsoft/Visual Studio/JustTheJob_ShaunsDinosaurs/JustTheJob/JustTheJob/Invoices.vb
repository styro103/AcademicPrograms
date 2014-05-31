Public Class Invoices
    Dim invoicelist As New clsInvoiceList
    Private Sub Invoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JustTheJobDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.JustTheJobDataSet.Invoices)
        btn_removeinvoice.Enabled = MainMenu.adminuser

    End Sub

    Private Sub btn_addinvoicet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addinvoice.Click
        Dim objInvoice As New clsInvoice

        Try
            'populate the Contact object with the data from the GUI form
            objInvoice.strDate = CStr(txt_invoicedate.Text)
            objInvoice.strBalance = CStr(txt_InvoiceBalance.Text)
            objInvoice.intJobID = CInt(txt_invoiceID.Text)
            

            'Add the object into the list
            invoicelist.addNewInvoice(objInvoice)

            'Add the object into the database 
            Dim entry As DataRow
            entry = JustTheJobDataSet.Tables(2).NewRow 'creates a new empty row in the database

            entry.Item("invoiceDate") = objInvoice.thedate
            entry.Item("invoiceToPay") = objInvoice.balance
            entry.Item("invoiceJobID") = objInvoice.jobid

            JustTheJobDataSet.Tables(2).Rows.Add(entry) 'adds to database
            InvoicesTableAdapter.Update(entry) 'displays it locally

            MessageBox.Show("Great Success! New invoice added to database.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub btn_removeinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_removeinvoice.Click
        Try
            InvoicesBindingSource.RemoveCurrent()

            Me.InvoicesTableAdapter.Update(Me.JustTheJobDataSet.Tables("Invoices"))
            JustTheJobDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Payments.Show()
        Payments.txt_paymentID.Text = txt_invoiceID.Text

    End Sub

    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyTabControl.SelectedIndexChanged

        Dim indexOfSelectedTab As Integer = MyTabControl.SelectedIndex
        Dim selectedTab As System.Windows.Forms.TabPage = MyTabControl.SelectedTab

        Select Case indexOfSelectedTab
            Case 0
                Me.InvoicesTableAdapter.Fill(Me.JustTheJobDataSet.Invoices)
            Case 1
                Me.InvoicesTableAdapter.FillPending(Me.JustTheJobDataSet.Invoices)
        End Select


    End Sub
End Class