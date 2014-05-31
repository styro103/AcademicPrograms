Public Class NewCustomerForm
    Dim customerList As New clsCustomerListManager
    Dim objFileManager As New clsFileManager
    'Closes NewCustomerForm
    Private Sub btnNCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCBack.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Submits customer into database
    Private Sub btnNCSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCSubmit.Click
        Dim phoneCorrect As Boolean = False
        Dim nameCorrect As Boolean = False
        Dim fieldsFilled As Boolean = False
        Dim phoneNum As String = txtNCPhone.Text

        Dim objCheck As New clsCheck

        phoneNum = objCheck.editPhone(phoneNum)
        phoneCorrect = objCheck.checkPhone(phoneNum)
        nameCorrect = objCheck.checkName(txtNCName.Text)
        fieldsFilled = checkFieldsFilled()

        If phoneCorrect = True And nameCorrect = True And fieldsFilled = True Then
            customerList.addCustomer(txtNCName.Text, txtNCAddress.Text, phoneNum, txtNCEmail.Text)

            objFileManager.SaveCustomer(txtNCName.Text, txtNCAddress.Text, phoneNum, txtNCEmail.Text)

            MessageBox.Show("A new customer has been added to the database.", "Confirmation", MessageBoxButtons.OK)
            txtNCName.Clear()
            txtNCAddress.Clear()
            txtNCPhone.Clear()
            txtNCEmail.Clear()
        End If
    End Sub

  
    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtNCName.Text.Length = 0 Or txtNCAddress.Text.Length = 0 Or txtNCPhone.Text.Length = 0 Or txtNCEmail.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


End Class

'Function checkInfo() As Boolean
'    Dim phoneCorrect As Boolean = False
'    Dim nameCorrect As Boolean = False
'    Dim fieldsCorrect As Boolean = False

'    If txtNCPhone.TextLength >= 10 Then
'        ' phoneCorrect = checkPhoneFormat()
'    Else
'        MessageBox.Show("Please use ten numbers for the phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    End If

'    nameCorrect = checkName()
'    fieldsCorrect = checkFieldsFilled()

'    If phoneCorrect = False Or nameCorrect = False Or fieldsCorrect = False Then
'        Return False
'    End If

'    Return True
'End Function

'Checksto make sure that the name conists of only letters
'Function checkName() As Boolean
'    Dim x As String
'    Dim name As String
'    name = txtNCName.Text.Replace(" ", "") 'remove spaces when checking
'    name = LCase(name)
'    For iCnt = 1 To Len(name)
'        x = Mid(name, iCnt, 1)
'        If x < "a" Or x > "z" Then
'            MessageBox.Show("Please use letters only for your name", "Letters only", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Return False
'        End If
'    Next iCnt
'    Return True
'End Function


' Eric
'Function editPhoneFormat()
'    Dim areaCode As String = ""
'    Dim firstThree As String = ""
'    Dim lastFour As String = ""
'    Dim rest As String = ""
'    Dim x As String = ""
'    x = txtNCPhone.Text.Replace(" ", "") ' Remove any spaces. EX: If the user enters 123 456 7890, then just make it 1234567890

'    'If the phone nummber is entered is only digits then add in the correct formating
'    If IsNumeric(x) And x.Length = 10 Then
'        areaCode = Mid(x, 1, 3)
'        areaCode = "(" + areaCode + ")-"
'        firstThree = Mid(x, 4, 3)
'        firstThree = firstThree + "-"
'        lastFour = Mid(x, 7, 4)
'        x = areaCode + firstThree + lastFour
'        'MessageBox.Show("1)" + txtNCPhone.Text) 'Can be used to test

'        'If the user enters some formating then it needs to be handled differently
'    ElseIf x.Length > 10 Then
'        If Mid(x, 1, 1) <> "(" Then
'            x = "(" + x
'            'MessageBox.Show("2) " + txtNCPhone.Text) ' can be used to test
'        End If
'        If Mid(x, 5, 1) <> ")" Then
'            areaCode = Mid(x, 1, 4)
'            areaCode = areaCode + ")"
'            rest = Mid(x, 5, x.Length)
'            x = areaCode + rest
'            'MessageBox.Show("3) " + txtNCPhone.Text + " a) " + areaCode + " b) " + rest) 'can be used to test
'        Else
'            areaCode = Mid(x, 1, 5)
'        End If
'        If Mid(x, 6, 1) <> "-" Then
'            areaCode = areaCode + "-"
'            rest = Mid(x, 6, x.Length)
'            x = areaCode + rest
'            ' MessageBox.Show("4) " + txtNCPhone.Text + " a) " + areaCode + " b) " + rest) ' can be used to test
'        Else
'            areaCode = Mid(x, 1, 6)
'        End If
'        If Mid(x, 10, 1) <> "-" Then
'            firstThree = Mid(x, 7, 3)
'            firstThree = firstThree + "-"
'            lastFour = Mid(x, 10, x.Length)
'            x = areaCode + firstThree + lastFour
'            'MessageBox.Show("5) " + txtNCPhone.Text + " a) " + areaCode + " b) " + firstThree + " c) " + lastFour) ' can be used to test
'        End If

'        'MessageBox.Show("6)" + txtNCPhone.Text) ' can be used to test
'    End If
'    Return x
'End Function

'Eric
'Function checkPhoneFormat() As Boolean
'    Dim iCnt As Integer
'    Dim numCount As Integer
'    Dim x As String
'    Dim phoneNum As String

'    phoneNum = editPhoneFormat() ' Edit the phone number format first

'    'If the user did not enter 10 numbers
'    For iCnt = 1 To phoneNum.Length
'        If IsNumeric(Mid(phoneNum, iCnt, 1)) Then
'            numCount = numCount + 1
'        End If
'    Next
'    If numCount <> 10 Then
'        MessageBox.Show("You did not enter ten numbers for the phone number. Please enter ten numbes for the phone numer",
'                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Return False
'    End If

'    'Checks to make sure that the phone number only consists of only numbers and ( or ) or -
'    For iCnt = 1 To phoneNum.Length
'        x = Mid(phoneNum, iCnt, 1)
'        If Not IsNumeric(x) Then
'            If x <> "(" And x <> ")" And x <> "-" Then
'                MessageBox.Show("Please only use numbers and the following symbols for formating: '( ) -'",
'                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return False
'            End If
'            If x = "(" And iCnt <> 1 Then
'                MessageBox.Show("Please only use numbers and the following symbols for formating: '( ) -'",
'                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return False
'            End If
'            If x = ")" And iCnt <> 5 Then
'                MessageBox.Show("Please only use numbers and the following symbols for formating: '( ) -'",
'                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return False
'            End If
'            If x = "-" And iCnt <> 6 And iCnt <> 10 Then
'                MessageBox.Show("Please only use numbers and the following symbols for formating: '( ) -'",
'                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return False
'            End If

'        End If

'    Next
'    txtNCPhone.Text = phoneNum 'Change the text to the new edited phone number
'    Return True
'End Function