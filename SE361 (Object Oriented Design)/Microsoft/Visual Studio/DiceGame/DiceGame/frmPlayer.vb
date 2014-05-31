Public Class frmPlayer
    Dim objDiceGame As New DiceGame
    Dim strPlayerName As String

    Private Sub btnPlayGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayGame.Click
        strPlayerName = txtName.Text
        objDiceGame.Play()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        MessageBox.Show("Thank you " & strPlayerName & _
                        " for playing the Dice Game.", "Dice Game")
        Application.Exit()
    End Sub

End Class
