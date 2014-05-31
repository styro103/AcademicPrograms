Public Class clsJob

    Public strDate As String
    Public strTime As String
    Public strLength As String
    Public strCleanerFirst As String
    Public strCleanerLast As String
    Public strAddress As String
    Public strCity As String
    Public strDeposit As String
    Public strBalance As String


    Public Sub New()
        strDate = String.Empty
        strTime = String.Empty
        strLength = String.Empty
        strCleanerFirst = String.Empty
        strCleanerLast = String.Empty
        strAddress = String.Empty
        strCity = String.Empty
        strDeposit = String.Empty
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

    Public Property time As String
        Get
            Return strTime
        End Get
        Set(ByVal value As String)
            strTime = value
        End Set
    End Property

    Public Property length As String
        Get
            Return strLength
        End Get
        Set(ByVal value As String)
            strLength = value
        End Set
    End Property

    Public Property cleanerfirst As String
        Get
            Return strCleanerFirst
        End Get
        Set(ByVal value As String)
            strCleanerFirst = value
        End Set
    End Property

    Public Property cleanerlast As String
        Get
            Return strCleanerLast
        End Get
        Set(ByVal value As String)
            strCleanerLast = value
        End Set
    End Property

    Public Property address As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property

    Public Property city As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property

    Public Property deposit As String
        Get
            Return strDeposit
        End Get
        Set(ByVal value As String)
            strDeposit = value
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
End Class
