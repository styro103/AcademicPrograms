Public Class clsContact

    Private strFirstName As String
    Private strLastName As String
    Private strPhoneNumber As String
    Private strEmail As String

    Public Sub New()
        strFirstName = String.Empty
        strLastName = String.Empty
        strPhoneNumber = String.Empty
        strEmail = String.Empty
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
    Public Property phonenumber As String
        Get
            Return strPhoneNumber
        End Get
        Set(ByVal value As String)
            strPhoneNumber = value
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

    Public Function fullName() As String
        Return strFirstName & vbTab & strLastName
    End Function

End Class
