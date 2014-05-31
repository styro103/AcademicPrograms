Public Class Mainform
    'Closes Program
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    'Opens CustomerForm
    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        CustomerForm.Show()

    End Sub
    'Opens ScheduleForm
    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click
        ScheduleForm.Show()
    End Sub
    'Opens EmployeeForm
    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        EmployeesForm.Show()
    End Sub
    'Opens InvoiceForm
    Private Sub btnInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoices.Click
        InvoiceForm.Show()
    End Sub
    'Opens JobForm
    Private Sub btnJobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJobs.Click
        JobForm.Show()
    End Sub
    'Opens PaymentForm
    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        PaymentForm.Show()
    End Sub
    'Closes Program
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
