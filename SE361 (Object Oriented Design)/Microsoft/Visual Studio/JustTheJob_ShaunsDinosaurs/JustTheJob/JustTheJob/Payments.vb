Public Class Payments

    Private Sub Payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JustTheJobDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.JustTheJobDataSet.Payments)
        btn_removepayment.Enabled = MainMenu.adminuser

    End Sub

    Private Sub btn_addinvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addpayment.Click
        Dim objPayment As New clsPayment

        Try
            'populate the Contact object with the data from the GUI form
            objPayment.datDate = CDate(PaymentDatePicker.Value)
            objPayment.strAmount = CStr(txt_paymentAmount.Text)
            objPayment.invoiceID = CInt(txt_paymentID.Text)
            objPayment.strFirstName = CStr(txt_paymentFirstname.Text)
            objPayment.strLastName = CStr(txt_paymentLastname.Text)

            'Add the object into the database 
            Dim entry As DataRow
            entry = JustTheJobDataSet.Tables("Payments").NewRow 'creates a new empty row in the database

            entry.Item("paymentDate") = objPayment.thedate
            entry.Item("paymentAmount") = objPayment.amount
            entry.Item("paymentInvoiceID") = objPayment.invoiceID
            entry.Item("paymentFirstname") = objPayment.firstname
            entry.Item("paymentLastname") = objPayment.lastname

            JustTheJobDataSet.Tables("Payments").Rows.Add(entry) 'adds to database
            PaymentsTableAdapter.Update(entry) 'displays it locally

            MessageBox.Show("Great Success! New payment added to database.")

            'As an added effect, let's try changing the related invoice ID when you add the payment
            Invoices.Show()





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub

    Private Sub btn_removepayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_removepayment.Click
        Try
            PaymentsBindingSource.RemoveCurrent()

            Me.PaymentsTableAdapter.Update(Me.JustTheJobDataSet.Tables("Payments"))
            JustTheJobDataSet.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub
End Class