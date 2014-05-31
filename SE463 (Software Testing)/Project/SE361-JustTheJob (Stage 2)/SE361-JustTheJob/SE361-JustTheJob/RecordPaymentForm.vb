Public Class RecordPaymentForm
    Dim strType As String
    Dim colOneTimeInvoice As New Collection
    Dim colRegularInvoice As New Collection
    Dim objFileManager As New clsFileManager

    'Opens dialog box to allow searching database for invoice. If entered invoice doesn't exist, it returns an error message. Otherwise, it 
    'sets all attribute Labels to visible and pulls in the information needed
    'Closes the form
    Private Sub btnRPBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    'Submit payment into invoice
    Private Sub btnRPSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim counter As Integer
        Dim temp As String
        Dim tempName As String
        Dim firstHalf As String
        Dim secondHalf As String

        firstHalf = ""
        secondHalf = ""

        objFileManager.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

        counter = 0
        If (strType.Trim = "One") Then
            For Each inv In colOneTimeInvoice
                temp = inv
                temp = temp.Substring(15)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))
                MessageBox.Show(tempName)
                If (tempName.Trim = lblCustomer.Text) Then
                    temp = inv
                    firstHalf = temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    secondHalf = temp.Substring(temp.IndexOf("<"))
                    MessageBox.Show(firstHalf & txtPaid.Text & secondHalf)
                    colOneTimeInvoice.Remove(counter)
                End If
                counter = counter + 1
            Next
            colOneTimeInvoice.Add(firstHalf + txtPaid.Text + " " + secondHalf)

            objFileManager.deleteItem(colOneTimeInvoice, "OneTimeInvoices.txt")
        Else '(strType = "Regular") Then
            For Each inv In colRegularInvoice
                temp = inv
                temp = temp.Substring(15)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))
                If (tempName.Trim = lblCustomer.Text) Then
                    temp = inv
                    firstHalf = temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                    temp = temp.Substring(temp.IndexOf(">") + 1)
                    secondHalf = temp.Substring(temp.IndexOf("<"))
                    MessageBox.Show(firstHalf + txtPaid.Text + secondHalf)
                    colOneTimeInvoice.Remove(counter)
                End If
                counter = counter + 1
            Next
            colRegularInvoice.Add(firstHalf + txtPaid.Text + " " + secondHalf)

            objFileManager.deleteItem(colRegularInvoice, "RegularInvoices.txt")
        End If
        Me.Close()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strId As String
        Dim strInvoiceId As String

        objFileManager.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

        strInvoiceId = InputBox("Enter the Invoice ID you want to search for.", "Invoice ID")
        For Each inv In colOneTimeInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblCustomer.Text = inv.substring(0, inv.indexof("<")).Trim
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(6)
                strType = inv.substring(0, inv.indexof("<"))
                MessageBox.Show("strType: " + strType)
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(10)
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(9)
                lblAmount.Text = inv.subString(0, inv.indexof("<"))
                lblInvoice.Text = strId
            End If
        Next
        For Each inv In colRegularInvoice
            inv = inv.subString(4)
            strId = inv.subString(0, inv.indexOf("<")).Trim
            inv = inv.subString(inv.indexof("<"))
            inv = inv.substring(6)
            If (strInvoiceId.Trim = strId.Trim) Then
                lblCustomer.Text = inv.substring(0, inv.indexof("<")).Trim
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(6)
                strType = inv.substring(0, inv.indexof("<"))
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(10)
                inv = inv.subString(inv.indexof("<"))
                inv = inv.substring(9)
                lblAmount.Text = inv.subString(0, inv.indexof("<"))
                lblInvoice.Text = strId
            End If
        Next
    End Sub

    Private Sub txtPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaid.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim counter As Integer
            Dim temp As String
            Dim tempName As String
            Dim firstHalf As String
            Dim secondHalf As String

            firstHalf = ""
            secondHalf = ""

            objFileManager.LoadInvoice(colOneTimeInvoice, colRegularInvoice)

            counter = 0
            If (strType.Trim = "One") Then
                For Each inv In colOneTimeInvoice
                    temp = inv
                    temp = temp.Substring(15)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))
                    MessageBox.Show(tempName)
                    If (tempName.Trim = lblCustomer.Text) Then
                        temp = inv
                        firstHalf = temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        secondHalf = temp.Substring(temp.IndexOf("<"))
                        MessageBox.Show(firstHalf & txtPaid.Text & secondHalf)
                        colOneTimeInvoice.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                colOneTimeInvoice.Add(firstHalf + txtPaid.Text + " " + secondHalf)

                objFileManager.deleteItem(colOneTimeInvoice, "OneTimeInvoices.txt")
            Else '(strType = "Regular") Then
                For Each inv In colRegularInvoice
                    temp = inv
                    temp = temp.Substring(15)                    'Removes beginning <name> tags
                    tempName = temp.Substring(0, temp.IndexOf("<"))
                    If (tempName.Trim = lblCustomer.Text) Then
                        temp = inv
                        firstHalf = temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        firstHalf = firstHalf & temp.Substring(0, temp.IndexOf(">") + 1)
                        temp = temp.Substring(temp.IndexOf(">") + 1)
                        secondHalf = temp.Substring(temp.IndexOf("<"))
                        MessageBox.Show(firstHalf + txtPaid.Text + secondHalf)
                        colOneTimeInvoice.Remove(counter)
                    End If
                    counter = counter + 1
                Next
                colRegularInvoice.Add(firstHalf + txtPaid.Text + " " + secondHalf)

                objFileManager.deleteItem(colRegularInvoice, "RegularInvoices.txt")
            End If
            Me.Close()
        End If
    End Sub
End Class