Public Class Login
    Dim username As String
    Dim password As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            username = TextBox2.Text.ToString
            password = TextBox1.Text.ToString
            If username = "smbateng" And password = "shaun" Then
                MainMenu.adminuser = True
                Jobs.btn_removejob.Enabled = True
                Cleaners.btn_removecleaner.Enabled = True
                Clients.btn_removeclient.Enabled = True
                Invoices.btn_removeinvoice.Enabled = True
                Payments.btn_removepayment.Enabled = True
                Me.Close()
                MessageBox.Show("Welcome Shaun!", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf username = "dfilippini" And password = "dino" Then
                MainMenu.adminuser = True
                Jobs.btn_removejob.Enabled = True
                Cleaners.btn_removecleaner.Enabled = True
                Clients.btn_removeclient.Enabled = True
                Invoices.btn_removeinvoice.Enabled = True
                Payments.btn_removepayment.Enabled = True
                Me.Close()
                MessageBox.Show("Welcome Dino!", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainMenu.adminuser = False
    End Sub
End Class