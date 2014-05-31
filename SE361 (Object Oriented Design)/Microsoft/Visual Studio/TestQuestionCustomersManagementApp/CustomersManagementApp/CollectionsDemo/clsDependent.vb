'Entity Class
Public Class clsDependent

    Private strName, strAddress As String
    Private intAge As Integer

    Sub New()
        strName = String.Empty
        intAge = 0
        strAddress = String.Empty
    End Sub
    Public Property Name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    Public Property Age As Integer
        Get
            Return intAge
        End Get
        Set(ByVal value As Integer)
            intAge = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
End Class
