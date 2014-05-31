Public Class clsCircle
    Private dblRadius As Double
    Const pi As Double = 3.14

    Public Sub New()
        dblRadius = 0
    End Sub

    Public Property Radius As Double
        Get
            Return dblRadius
        End Get
        Set(ByVal value As Double)
            dblRadius = value
        End Set
    End Property

    Public Function CalcArea() As Double
        Return pi * dblRadius ^ 2
    End Function

    Public Function CalcCircumference() As Double
        Return 2 * pi * dblRadius
    End Function
End Class
