Public Class Form1

    Private Sub btnFillUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillUp.Click
        pbDemo.Maximum = 10
        pbDemo.Minimum = 0

        For i = 1 To 10
            pbDemo.Value = i
        Next

    End Sub

    Private Sub btnEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpty.Click
        Try
            pbDemo.Value -= 2
        Catch ex As Exception
            MessageBox.Show("Bar is empty!", "Warning")
        End Try


    End Sub
End Class
