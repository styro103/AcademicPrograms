Public Class clsTransactionList
    'This Class Holds the Transaction Lists'
    Dim Transactions As New Collection

    Public Sub addTransaction(ByVal name As String, ByVal amount As Decimal, ByVal datetoday As Date, ByVal type As String)
        Dim objTransaction As New clsTransaction

        'Declaring What is the Name, Amount, Date, and Type'
        objTransaction.Name = name
        objTransaction.Amount = amount
        objTransaction.dDate = datetoday
        objTransaction.Type = type

        Transactions.Add(objTransaction)
    End Sub
End Class
