Public Class clsCleaner

    Public strFirstName As String
    Public strLastName As String
    Public strPhone As String
    Public strEmail As String
    Public strAddress As String
    Public strCity As String
    Public strCellphone As String

    Public Sub New()
        strFirstName = String.Empty
        strLastName = String.Empty
        strPhone = String.Empty
        strEmail = String.Empty
        strAddress = String.Empty
        strCity = String.Empty
        strCellphone = String.Empty
    End Sub

    Public Property firstname As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property

    Public Property lastname As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
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

    Public Property phone As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property

    Public Property email As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
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

    Public Property cellphone As String
        Get
            Return strCellphone
        End Get
        Set(ByVal value As String)
            strCellphone = value
        End Set
    End Property

End Class