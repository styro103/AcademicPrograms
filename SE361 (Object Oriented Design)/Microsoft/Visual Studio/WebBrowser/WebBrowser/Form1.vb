Public Class Form1

    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        wbrDisplay.Navigate(txtURL.Text)
    End Sub

    Private Sub txtEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEXIT.Click
        Application.Exit()
    End Sub

    Private Sub txtCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCLEAR.Click
        txtURL.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
