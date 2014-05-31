Public Class clsPayment
    Public strFirstName As String
    Public strLastName As String
    Public intInvoiceID As Integer
    Public strAmount As String
    Public datDate As Date

    Public Sub New()
        strFirstName = String.Empty
        strLastName = String.Empty
        intInvoiceID = 0
        strAmount = String.Empty
        datDate = Today
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

    Public Property invoiceID As Integer
        Get
            Return intInvoiceID
        End Get
        Set(ByVal value As Integer)
            intInvoiceID = value
        End Set
    End Property

    Public Property amount As String
        Get
            Return strAmount
        End Get
        Set(ByVal value As String)
            strAmount = value
        End Set
    End Property


    Public Property thedate As Date
        Get
            Return datDate
        End Get
        Set(ByVal value As Date)
            datDate = value
        End Set
    End Property


End Class
