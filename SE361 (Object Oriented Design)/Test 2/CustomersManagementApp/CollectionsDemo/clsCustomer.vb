
'Entity Class

Public Class clsCustomer

    Private strName As String
    Private strPhone As String

    Sub New()
        strName = String.Empty
        strPhone = String.Empty
    End Sub

    Public Property name As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
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
End Class
