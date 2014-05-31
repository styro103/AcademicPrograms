Public Class clsTransaction
    'This Class Handles the Transaction'
    Private strName As String
    Private decAmount As Decimal
    Private daDate As Date
    Private strType As String

    Sub New()
        decAmount = 0
        daDate = Today
        strName = ""
        strType = ""
    End Sub

    Public Property Amount As Decimal
        'Get and Return Amount'
        Get
            Return decAmount
        End Get
        Set(ByVal value As Decimal)
            decAmount = value
        End Set
    End Property

    Public Property dDate As Date
        'Get and Return Date'
        Get
            Return daDate
        End Get
        Set(ByVal value As Date)
            daDate = Today
        End Set
    End Property

    Public Property Name As String
        'Get and Return Name'
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property Type As String
        'Get and Return Type'
        Get
            Return strType
        End Get
        Set(ByVal value As String)
            strType = value
        End Set
    End Property

End Class
