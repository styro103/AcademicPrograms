Public Class MainForm
    Dim Calculator As New Stack 'Stack for Program'

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Exits Application'
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'Clears TextBox, Label, and Stack'
        txtEquation.Clear()
        lblOutput.Text = ""
        Calculator.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'Variables to Help Calculate
        Dim Match As Boolean = True 'Check for Equation Correctness
        Dim Result As Double = 0 'Hold Result of Equation
        Dim n As Double 'Hold Number
        Dim i As Integer = 0 'For Loop
        Dim j As Integer 'For Loop
        Dim k As Integer 'For Loop
        Dim l As Integer 'For Loop
        Dim lp As Integer = 0 'For ( Count
        Dim rp As Integer = 0 'For ) Count

        Try
            'Next Lines Check if Proper Equation
            While i < txtEquation.Text.Length
                If txtEquation.Text(i) = "(" Then
                    lp += 1
                ElseIf txtEquation.Text(i) = ")" Then
                    rp += 1
                End If

                If txtEquation.Text(i) = "+" Or txtEquation.Text(i) = "-" Or txtEquation.Text(i) = "*" Or txtEquation.Text(i) = "/" Then
                    If i = 0 Then
                        Match = False
                    ElseIf i = txtEquation.Text.Length - 1 Then
                        Match = False
                    Else
                        If txtEquation.Text(i + 1) = "+" Or txtEquation.Text(i + 1) = "-" Or txtEquation.Text(i + 1) = "*" Or txtEquation.Text(i + 1) = "/" Then
                            Match = False
                        End If
                        If txtEquation.Text(i - 1) = "+" Or txtEquation.Text(i - 1) = "-" Or txtEquation.Text(i - 1) = "*" Or txtEquation.Text(i - 1) = "/" Then
                            Match = False
                        End If
                    End If
                End If
                i += 1
            End While

            If lp <> rp Then
                Match = False
            End If

            i = 0

            'Solve Equation
            While (i < txtEquation.Text.Length())

                lblEquation2.Text = ""

                'Pop Element if )
                If (txtEquation.Text(i) = ")") Then
                    While (Calculator.Peek <> "(")
                        lblEquation2.Text += Calculator.Pop()
                        j -= 1
                    End While

                    j = 0
                    k = 0
                    lblEquation2.Text = StrReverse(lblEquation2.Text)

                    While lblEquation2.Text(k) <> "+" And lblEquation2.Text(k) <> "-" And lblEquation2.Text(k) <> "*" And lblEquation2.Text(k) <> "/"
                        k += 1
                    End While

                    'Initialize Result
                    While j < k
                        Result += CDbl(Val(lblEquation2.Text(j))) * 10 ^ (k - j - 1)
                        j += 1
                    End While

                    j = k
                    l = j

                    While j < lblEquation2.Text.Length
                        'When Element is Operation, Get Numbers Around and Do Operation With Numbers
                        If lblEquation2.Text(j) = "+" Or lblEquation2.Text(j) = "-" Or lblEquation2.Text(j) = "*" Or lblEquation2.Text(j) = "/" Then
                            k = j + 1

                            While lblEquation2.Text(k) <> "+" And lblEquation2.Text(k) <> "-" And lblEquation2.Text(k) <> "*" And lblEquation2.Text(k) <> "/" And lblEquation2.Text(k) <> vbNullChar
                                k += 1
                                If k >= lblEquation2.Text.Length Then
                                    Exit While
                                End If
                            End While

                            n = 0
                            j += 1

                            While j < k
                                n += CDbl(Val(lblEquation2.Text(j))) * 10 ^ (k - j - 1)
                                j += 1
                            End While

                            If lblEquation2.Text(l) = "+" Then
                                Result += n
                            ElseIf lblEquation2.Text(l) = "-" Then
                                Result -= n
                            ElseIf lblEquation2.Text(l) = "*" Then
                                Result *= n
                            ElseIf lblEquation2.Text(l) = "/" Then
                                Result /= n
                            End If
                        End If

                        l = j
                        'j += 1
                    End While
                Else
                    'Push Element
                    Calculator.Push(txtEquation.Text(i))
                End If

                i += 1
            End While
        Catch ex As Exception
            Match = False
        End Try
        

        'If Match is False Display Error, Else Display Result
        If Match = False Then
            lblOutput.Text = "Error"
            MessageBox.Show("Invalid Equation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            lblOutput.Text = Result.ToString
        End If

        Calculator.Clear()
    End Sub
End Class
