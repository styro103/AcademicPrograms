Public Class clsInvoice
    Public strDate As String
    Public strBalance As String
    Public intJobID As Integer

    Public Sub New()
        strDate = String.Empty
        strBalance = String.Empty
    End Sub

    Public Property thedate As String
        Get
            Return strDate
        End Get
        Set(ByVal value As String)
            strDate = value
        End Set
    End Property

    Public Property balance As String
        Get
            Return strBalance
        End Get
        Set(ByVal value As String)
            strBalance = value
        End Set
    End Property

    Public Property jobid As Integer
        Get
            Return intJobID
        End Get
        Set(ByVal value As Integer)
            intJobID = value
        End Set
    End Property

End Class
