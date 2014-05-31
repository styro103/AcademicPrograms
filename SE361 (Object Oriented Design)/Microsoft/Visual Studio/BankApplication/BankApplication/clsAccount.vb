Public Class clsAccount
    'This Class Handles the Creation of the Transactions'
    Private strName As String
    Private decBalance As Decimal
    Dim objTransactions As New clsTransactionList
    Sub New()
        strName = ""
        decBalance = 0
    End Sub
    Public Property Name As String
        'This Property Gets and Returns the Name'
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    Public Property Balance As Decimal
        'This Property Gets and Returns the Name'
        Get
            Return decBalance
        End Get
        Set(ByVal value As Decimal)
            decBalance = value
        End Set
    End Property
    Public Sub createTransaction(ByVal name As String, ByVal amount As Decimal, ByVal datetoday As Date, ByVal type As String)
        objTransactions.addTransaction(name, amount, datetoday, type)
        'In Order for a Transaction to be Made, There Needs to be a Name, Amount, Date, and Type'
    End Sub
End Class
