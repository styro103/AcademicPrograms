Public Class clsCoffee
    'This Class Handles the List of Coffees, the Quantities, and Prices'
    Private strCoffee As String 'Coffee Type'
    Private decPrice As Decimal 'Coffee Price'
    Private intQuantity As Integer 'Coffee Quantity'

    Sub New()
        strCoffee = ""
        decPrice = 0
        intQuantity = 0
    End Sub

    Public Property Coffee As String 'Coffee Type'
        Get
            Return strCoffee
        End Get
        Set(ByVal value As String)
            strCoffee = value
        End Set
    End Property

    Public Property Price As Decimal 'Coffee Price'
        Get
            Return decPrice
        End Get
        Set(ByVal value As Decimal)
            decPrice = value
        End Set
    End Property

    Public Property Quantity As Integer 'Coffee Quantity'
        Get
            Return intQuantity
        End Get
        Set(ByVal value As Integer)
            intQuantity = value
        End Set
    End Property

End Class
