Public Class clsSquare
    'This is My Private Data Member'
    Private dblSide As Double

    'This is the Basic Constructior That Initializes the dblSide'
    Public Sub New()
        dblSide = 0
    End Sub

    'This is the Property Definition That Allows the External World to Have Access to my Private Data Member(s)'
    'Data Member dblSide'
    Public Property Side As Double
        Get
            Return dblSide
        End Get
        Set(ByVal value As Double)
            dblSide = value
        End Set
    End Property

    Public Function CalcArea() As Double
        Return dblSide * dblSide
    End Function

    Public Function CalcPerimeter() As Double
        Return 4 * dblSide
    End Function
End Class
