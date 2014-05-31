Public Class clsCoinSlot
    'This Class Handles The Amount of Change the User Has Inputted
    Private strCoin As String 'Coin Type'
    Private decCredit As Decimal 'Coin Value'

    Sub New()
        strCoin = ""
        decCredit = 0
    End Sub

    Public Property Coin As String 'Coin Type'
        Get
            Return strCoin
        End Get
        Set(ByVal value As String)
            strCoin = value
        End Set
    End Property

    Public Property Credit As Decimal 'Coin Value'
        Get
            Return decCredit
        End Get
        Set(ByVal value As Decimal)
            decCredit = value
        End Set
    End Property
End Class
