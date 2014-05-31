Public Class clsSquare

    Private dblSide As Double

    Public Sub New()
        dblSide = 0
    End Sub

    Public Property side As Double
        Get
            Return dblSide
        End Get
        Set(ByVal value As Double)
            dblSide = value
        End Set
    End Property

    Public Function calcArea() As Double
        Return dblSide * dblSide
    End Function

    Public Function calcPerimeter() As Double
        Return 4 * dblSide
    End Function

End Class
