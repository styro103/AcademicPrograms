Public Class DiceGame
    Dim Die1, Die2 As Die

    Public Sub New()
        Die1 = New Die
        Die2 = New Die
    End Sub

    Public Sub Play()
        Dim fv1, fv2, result As Integer

        Die1.Roll()
        fv1 = Die1.faceValue

        Die2.Roll()
        fv2 = Die2.faceValue

        result = fv1 + fv2

        If result = 7 Then
            MessageBox.Show("The Sum is: " & result & vbCrLf & _
                            "You Win!!", "Throw Dice Game")
        Else
            MessageBox.Show("The Sum is: " & result & vbCrLf & _
                            "You Lost. Try again.", "Throw Dice Game")
        End If
    End Sub

End Class
