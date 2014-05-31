Public Class clsRectangle
    Private dblSide1 As Double
    Private dblSide2 As Double

    Public Sub New()
        dblSide1 = 0
        dblSide2 = 0
    End Sub

    Public Property Side1 As Double
        Get
            Return dblSide1
        End Get
        Set(ByVal value As Double)
            dblSide1 = value
        End Set
    End Property

    Public Property Side2 As Double
        Get
            Return dblSide2
        End Get
        Set(ByVal value As Double)
            dblSide2 = value
        End Set
    End Property

    Public Function CalcArea() As Double
        Return dblSide1 * dblSide2
    End Function

    Public Function CalcPerimeter() As Double
        Return (2 * dblSide1) + (2 * dblSide2)
    End Function
End Class
