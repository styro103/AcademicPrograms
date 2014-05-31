Public Class clsCircle

    Private dblRadius As Double

    Public Sub New()
        dblRadius = 0
    End Sub

    Public Property radius As Double
        Get
            Return dblRadius
        End Get
        Set(ByVal value As Double)
            dblRadius = value
        End Set
    End Property

    Public Function calcArea() As Double
        Return 3.14 * dblRadius ^ 2
    End Function

    Public Function calcCircumference() As Double
        Return 2 * dblRadius * 3.14
    End Function

End Class
