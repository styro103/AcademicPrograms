Public Class clsOrder
    Private strItem As String
    Private decUPrice As Decimal
    Private decTotPrice As Decimal
    Private intQuantity As Integer
    Private strAddress As String

    Sub New()
        strItem = String.Empty
        decUPrice = 0
        decTotPrice = 0
        intQuantity = 0
        strAddress = String.Empty
    End Sub

    Public Property Item As String
        Get
            Return strItem
        End Get
        Set(ByVal value As String)
            strItem = value
        End Set
    End Property

    Public Property UnitPrice As Decimal
        Get
            Return decUPrice
        End Get
        Set(ByVal value As Decimal)
            decUPrice = value
        End Set
    End Property

    Public Property TotPrice As Decimal
        Get
            Return decTotPrice
        End Get
        Set(ByVal value As Decimal)
            decTotPrice = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return intQuantity
        End Get
        Set(ByVal value As Integer)
            intQuantity = value
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
