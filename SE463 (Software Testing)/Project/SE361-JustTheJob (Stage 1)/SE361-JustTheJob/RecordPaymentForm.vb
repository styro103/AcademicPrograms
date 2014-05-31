Public Class RecordPaymentForm
    'Opens dialog box to allow searching database for invoice. If entered invoice doesn't exist, it returns an error message. Otherwise, it 
    'sets all attribute Labels to visible and pulls in the information needed
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
    'Closes the form
    Private Sub btnRPBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRPBack.Click
        Me.Close()
    End Sub
    'Submit payment into invoice
    Private Sub btnRPSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRPSubmit.Click
        Me.Close()
    End Sub
End Class