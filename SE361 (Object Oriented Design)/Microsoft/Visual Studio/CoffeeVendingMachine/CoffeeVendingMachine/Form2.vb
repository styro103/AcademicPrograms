Public Class Login

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtUsername.Text = "smbateng" And txtPassword.Text = "shaun" Then
            MessageBox.Show("Welcome Vendor!")
            MainForm.gbCustomer.Visible = False
            MainForm.gbVendor.Visible = True
            Me.Close()
        Else
            MessageBox.Show("Invalid Username and/or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class