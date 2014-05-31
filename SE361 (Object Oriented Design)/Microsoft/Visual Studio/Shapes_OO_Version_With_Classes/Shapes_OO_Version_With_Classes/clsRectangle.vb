Public Class clsRectangle

    Private dblSide1, dblSide2 As Double

    Public Sub New()
        dblSide1 = dblSide2 = 0
    End Sub

    Public Property side1 As Double
        Get
            Return dblSide1
        End Get
        Set(ByVal value As Double)
            dblSide1 = value
        End Set
    End Property

    Public Property side2 As Double
        Get
            Return dblSide2
        End Get
        Set(ByVal value As Double)
            dblSide2 = value
        End Set
    End Property

    Public Function calcArea() As Double
        Return dblSide1 * dblSide2
    End Function

    Public Function calcPerimeter() As Double
        Return (2 * dblSide1) + (2 * dblSide2)
    End Function

End Class
