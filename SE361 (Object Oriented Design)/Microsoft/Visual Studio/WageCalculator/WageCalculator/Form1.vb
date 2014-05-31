Public Class WageCalculator

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnCGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCGP.Click
        Dim decGP As Decimal
        decGP = CDec(txtHW.Text) * CDec(txtHPR.Text)
        lblGP.Text = CStr(decGP)
    End Sub

End Class
