Public Class Die

    Private intFaceValue As Integer

    Public Sub New()
        intFaceValue = 0
    End Sub

    Public Property faceValue() As Integer
        Get
            Return intFaceValue
        End Get
        Set(ByVal value As Integer)
            intFaceValue = value
        End Set
    End Property

    Public Sub Roll()
        Dim R As New Random()

        faceValue = R.Next(1, 6)

        MessageBox.Show("Die Face Value = " & _
                        faceValue, "After Throwing The Die")
    End Sub

End Class
