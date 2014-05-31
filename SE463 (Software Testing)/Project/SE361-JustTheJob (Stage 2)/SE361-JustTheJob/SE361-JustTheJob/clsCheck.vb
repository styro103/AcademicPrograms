Public Class clsCheck
    Public Function editPhone(ByVal phoneNum As String)
        Dim areaCode As String = ""
        Dim firstThree As String = ""
        Dim lastFour As String = ""
        Dim rest As String = ""
        phoneNum = phoneNum.Replace(" ", "") ' Remove any spaces. EX: If the user enters 123 456 7890, then just make it 1234567890

        'If the phone nummber is entered is only digits then add in the correct formating
        If IsNumeric(phoneNum) And phoneNum.Length = 10 Then
            areaCode = Mid(phoneNum, 1, 3)
            areaCode = "(" + areaCode + ")-"
            firstThree = Mid(phoneNum, 4, 3)
            firstThree = firstThree + "-"
            lastFour = Mid(phoneNum, 7, 4)
            phoneNum = areaCode + firstThree + lastFour
            'MessageBox.Show("1)" + phoneNum) 'Can be used to test

            'If the user enters some formating then it needs to be handled differently
        ElseIf phoneNum.Length > 10 Then
            If Mid(phoneNum, 1, 1) <> "(" Then
                phoneNum = "(" + phoneNum
                'MessageBox.Show("2) " + phoneNum) ' can be used to test
            End If
            If Mid(phoneNum, 5, 1) <> ")" Then
                areaCode = Mid(phoneNum, 1, 4)
                areaCode = areaCode + ")"
                rest = Mid(phoneNum, 5, phoneNum.Length)
                phoneNum = areaCode + rest
                'MessageBox.Show("3) " + phoneNum + " a) " + areaCode + " b) " + rest) 'can be used to test
            Else
                areaCode = Mid(phoneNum, 1, 5)
            End If
            If Mid(phoneNum, 6, 1) <> "-" Then
                areaCode = areaCode + "-"
                rest = Mid(phoneNum, 6, phoneNum.Length)
                phoneNum = areaCode + rest
                ' MessageBox.Show("4) " + phoneNum + " a) " + areaCode + " b) " + rest) ' can be used to test
            Else
                areaCode = Mid(phoneNum, 1, 6)
            End If
            If Mid(phoneNum, 10, 1) <> "-" Then
                firstThree = Mid(phoneNum, 7, 3)
                firstThree = firstThree + "-"
                lastFour = Mid(phoneNum, 10, phoneNum.Length)
                phoneNum = areaCode + firstThree + lastFour
                'MessageBox.Show("5) " + phoneNum + " a) " + areaCode + " b) " + firstThree + " c) " + lastFour) ' can be used to test
            End If

            'MessageBox.Show("6)" + phoneNum) ' can be used to test
        End If
        Return phoneNum
    End Function
    Public Function checkPhone(ByVal phoneNum As String) As Boolean
        Dim iCnt As Integer
        Dim numCount As Integer
        Dim x As String
        phoneNum = phoneNum.Replace(" ", "") ' Remove any spaces. EX: If the user enters 123 456 7890, then just make it 1234567890

        'If the user did not enter 10 numbers
        For iCnt = 1 To phoneNum.Length
            If IsNumeric(Mid(phoneNum, iCnt, 1)) Then
                numCount = numCount + 1
            End If
        Next
        If numCount <> 10 Then
            MessageBox.Show("You did not enter ten numbers for the phone number. Please enter ten numbes for the phone numer",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        'Checks to make sure that the phone number only consists of only numbers and ( or ) or -
        For iCnt = 1 To phoneNum.Length
            x = Mid(phoneNum, iCnt, 1)
            If Not IsNumeric(x) Then
                If x <> "(" And x <> ")" And x <> "-" Then
                    MessageBox.Show("Please only use numbers and the following symbols for formating phone numbers: '( ) -'",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If x = "(" And iCnt <> 1 Then
                    MessageBox.Show("Please only use numbers and the following symbols for formating phone numbers: '( ) -'",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If x = ")" And iCnt <> 5 Then
                    MessageBox.Show("Please only use numbers and the following symbols for formating phone numbers: '( ) -'",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If x = "-" And iCnt <> 6 And iCnt <> 10 Then
                    MessageBox.Show("Please only use numbers and the following symbols for formating phone numbers: '( ) -'",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

            End If

        Next

        Return True
    End Function

    Public Function checkName(ByVal name As String)
        Dim x As String
        name = name.Replace(" ", "") 'remove spaces when checking
        name = LCase(name)
        For iCnt = 1 To Len(name)
            x = Mid(name, iCnt, 1)
            If x < "a" Or x > "z" Then
                MessageBox.Show("Please use letters only for your name", "Letters only", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next iCnt
        Return True
    End Function
End Class
