Public Class NewInvoiceForm
    Private strType As String
    Dim invoiceList As New clsInvoiceListManager
    Dim objFileManager As New clsFileManager
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
        Dim fieldsFilled As Boolean = False
        Dim cNameCorrect As Boolean = False 'Customer Name
        Dim eNameCorrect As Boolean = False 'Employee Name

        Dim objCheck As New clsCheck

        If radNIRegular.Checked = True Then
            strType = "Regular"
        Else
            strType = "One" 'one time
            txtNIWeek.Text = "N/A"
        End If
        cNameCorrect = objCheck.checkName(txtNIName.Text)
        eNameCorrect = objCheck.checkName(txtNIEmployee.Text)
        fieldsFilled = checkFieldsFilled()

        If cNameCorrect = True And eNameCorrect = True And fieldsFilled = True Then
            invoiceList.addInvoice(txtID.Text, strType, txtNIName.Text, txtNIEmployee.Text, CDbl(txtNIPay.Text),
                                   cmbPaymentMethod.Text, txtNIComplete.Text, CDbl(txtNIPaid.Text), txtNIWeek.Text)
            objFileManager.SaveInvoice(txtID.Text, strType, txtNIName.Text, txtNIEmployee.Text, txtNIPay.Text,
                                   cmbPaymentMethod.Text, txtNIComplete.Text, txtNIPaid.Text, txtNIWeek.Text)

            MessageBox.Show("Invoice Added", "Invoice Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub radNIRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radNIRegular.CheckedChanged
        If radNIRegular.Checked = True Then
            lblNIWeek.Visible = True
            txtNIWeek.Visible = True
        End If
    End Sub

    Private Sub radNIOneTime_CheckedChanged(sender As Object, e As EventArgs) Handles radNIOneTime.CheckedChanged
        If radNIOneTime.Checked = True Then
            lblNIWeek.Visible = False
            txtNIWeek.Visible = False
        End If
    End Sub
    Private Function checkFieldsFilled() As Boolean
        If txtNIWeek.Text.Length = 0 Or txtNIComplete.Text.Length = 0 Or txtNIEmployee.Text.Length = 0 Or
            txtNIName.Text.Length = 0 Or txtNIPaid.Text.Length = 0 Or txtNIPay.Text.Length = 0 Or
            cmbPaymentMethod.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class