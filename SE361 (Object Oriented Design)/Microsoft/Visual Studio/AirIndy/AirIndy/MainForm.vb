Public Class MainForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridView.Click
        Dim frmGridView As New GridForm
        frmGridView.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailView.Click
        Dim frmDetailView As New DetailForm
        frmDetailView.ShowDialog()
    End Sub
End Class