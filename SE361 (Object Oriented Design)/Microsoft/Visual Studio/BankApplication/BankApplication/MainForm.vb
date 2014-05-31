'Shaun Mbateng'
'Assignment 3'
'SE-361: Spring Semester'

Public Class BankApp
    Dim objAccount As clsAccount
    Dim objSavings As New clsAccount
    Dim objChecking As New clsAccount

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Today
        'Makes the Text of Date Label Today's Date'
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Try
            'Depending on What is Selected in Combo Box, Deposit Will be Made into That Account and Listed onto That ListBox'
            If cmbAccount.SelectedItem.ToString = "Checking" Then
                objChecking.createTransaction("Checking", CDec(txtDeposit.Text), Today, "Deposit") 'Calls Class Account to Create Transaction'
                objChecking.Balance += CDec(txtDeposit.Text) 'Balance is Updated for That Account'
                lblBalance.Text = objChecking.Balance.ToString("c")
                lsbChecking.Items.Add(lblDate.Text & vbTab &
                                      vbTab & "Deposit" & vbTab &
                                      vbTab & CDec(txtDeposit.Text).ToString("c") & vbTab &
                                      vbTab & "Prev. Bal." & vbTab &
                                      vbTab & (CDec(lblBalance.Text) - CDec(txtDeposit.Text)).ToString("c") & vbTab &
                                      vbTab & "New Bal." & vbTab &
                                      vbTab & lblBalance.Text)
            ElseIf cmbAccount.SelectedItem.ToString = "Savings" Then
                objSavings.createTransaction("Savings", CDec(txtDeposit.Text), Today, "Deposit")
                objSavings.Balance += CDec(txtDeposit.Text)
                lblBalance.Text = objSavings.Balance.ToString("c")
                lsbSavings.Items.Add(lblDate.Text & vbTab &
                                      vbTab & "Deposit" & vbTab &
                                      vbTab & CDec(txtDeposit.Text).ToString("c") & vbTab &
                                      vbTab & "Prev. Bal." & vbTab &
                                      vbTab & (CDec(lblBalance.Text) - CDec(txtDeposit.Text)).ToString("c") & vbTab &
                                      vbTab & "New Bal." & vbTab &
                                      vbTab & lblBalance.Text)
            End If
        Catch ex As Exception
            'Happens if Nothing is Inputted in Deposit Textbox, or Nothing is Seleced in Account ComboBox'
            MessageBox.Show("Invalid Input Data", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnWithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdrawal.Click
        Try
            If CDec(txtWithdrawal.Text) > CDec(lblBalance.Text) Then
                MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Happens if Withdrawal Amount is More Than Balance. If Not, Transaction is Made'
            Else
                'Works Same Way as Deposit Button, Except Money is Withdrawn, and Properties are For Withdraw'
                If cmbAccount.SelectedItem.ToString = "Checking" Then
                    objChecking.createTransaction("Checking", CDec(txtWithdrawal.Text), Today, "Withdraw")
                    objChecking.Balance -= CDec(txtWithdrawal.Text)
                    lblBalance.Text = objChecking.Balance.ToString("c")
                    lsbChecking.Items.Add(lblDate.Text & vbTab &
                                          vbTab & "Withdrawal" & vbTab &
                                          vbTab & CDec(txtWithdrawal.Text).ToString("c") & vbTab &
                                          vbTab & "Prev. Bal." & vbTab &
                                          vbTab & (CDec(txtWithdrawal.Text) + CDec(lblBalance.Text)).ToString("c") & vbTab &
                                          vbTab & "New Bal." & vbTab &
                                          vbTab & lblBalance.Text)
                ElseIf cmbAccount.SelectedItem.ToString = "Savings" Then
                    objSavings.createTransaction("Savings", CDec(txtWithdrawal.Text), Today, "Withdraw")
                    objSavings.Balance -= CDec(txtWithdrawal.Text)
                    lblBalance.Text = objSavings.Balance.ToString("c")
                    lsbSavings.Items.Add(lblDate.Text & vbTab &
                                         vbTab & "Withdrawal" & vbTab &
                                         vbTab & CDec(txtWithdrawal.Text).ToString("c") & vbTab &
                                         vbTab & "Prev. Bal." & vbTab &
                                         vbTab & (CDec(txtWithdrawal.Text) + CDec(lblBalance.Text)).ToString("c") & vbTab &
                                         vbTab & "New Bal." & vbTab &
                                         vbTab & lblBalance.Text)
                End If
            End If
        Catch ex As Exception
            'Happens if Nothing is Inputted in Withdrawal Textbox, or Nothing is Seleced in Account ComboBox'
            MessageBox.Show("Invalid Input Data", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbTransfer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransfer.SelectedIndexChanged
        'Edits Text of Transfer Label Depending on What is Selected in Transfer ComboBox'
        If cmbTransfer.Text = "Checking" Then
            lblTo.Text = "to Savings"
        ElseIf cmbTransfer.Text = "Savings" Then
            lblTo.Text = "to Checking"
        End If
    End Sub

    Private Sub cmbAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccount.SelectedIndexChanged
        'Depending on What is Selected in ComboBox, Check Box is Visible or Hidden,the Text of Save Button Changes,
        'and Certains ListBoxs are Shown or Hidden'
        If cmbAccount.Text = "Savings" Then
            btnSave.Text = "Save Savings Account to File"
            gbCheck.Visible = False
            lblBalance.Text = objSavings.Balance.ToString("c")
            lsbSavings.Visible = True
            lsbChecking.Visible = False
        ElseIf cmbAccount.Text = "Checking" Then
            btnSave.Text = "Save Checking Account to File"
            gbCheck.Visible = True
            lblBalance.Text = objChecking.Balance.ToString("c")
            lsbSavings.Visible = False
            lsbChecking.Visible = True
        Else
            gbCheck.Visible = True
        End If
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Try
            If cmbTransfer.SelectedItem.ToString = "Checking" Then
                If CDec(txtTransfer.Text) > objChecking.Balance Then
                    MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Happens if Transfer Amount is More Than Balance. If Not, Transaction is Made'
                Else
                    'Works Similar as Deposit and Withdrawal, With A Few Differences'
                    objChecking.createTransaction("Checking", CDec(txtTransfer.Text), Today, "Transfer")
                    objChecking.Balance -= CDec(txtTransfer.Text) 'One Balance Decreases'
                    objSavings.createTransaction("Savings", CDec(txtTransfer.Text), Today, "Transfer")
                    objSavings.Balance += CDec(txtTransfer.Text) 'While the Other Decreases;
                    'Balance is Updated Depending on What is Selected in Account ComboBox'
                    If cmbAccount.SelectedItem.ToString = "Savings" Then
                        lblBalance.Text = objSavings.Balance.ToString("c")
                    ElseIf cmbAccount.SelectedItem.ToString = "Checking" Then
                        lblBalance.Text = objChecking.Balance.ToString("c")
                    End If
                    'What is Added to the Listbox Depends on What is in the Account ComboBox'
                    If cmbTransfer.Text = "Checking" Then
                        lsbChecking.Items.Add(lblDate.Text & vbTab &
                                              vbTab & "Transfer to Savings" & vbTab &
                                              vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                              vbTab & "Prev. Bal." & vbTab &
                                              vbTab & (CDec(txtTransfer.Text) + objChecking.Balance).ToString("c") & vbTab &
                                              vbTab & "New Bal." & vbTab &
                                              vbTab & objChecking.Balance.ToString("c"))
                        lsbSavings.Items.Add(lblDate.Text & vbTab &
                                             vbTab & "Transfer from Checking" & vbTab &
                                             vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                             vbTab & "Prev. Bal." & vbTab &
                                             vbTab & (objSavings.Balance - CDec(txtTransfer.Text)).ToString("c") & vbTab &
                                             vbTab & "New Bal." & vbTab &
                                             vbTab & objSavings.Balance.ToString("c"))
                    ElseIf cmbTransfer.Text = "Savings" Then
                        lsbSavings.Items.Add(lblDate.Text & vbTab &
                                             vbTab & "Transfer to Checking" & vbTab &
                                             vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                             vbTab & "Prev. Bal." & vbTab &
                                             vbTab & (CDec(txtTransfer.Text) + objSavings.Balance).ToString("c") & vbTab &
                                             vbTab & "New Bal." & vbTab &
                                             vbTab & objSavings.Balance.ToString("c"))
                        lsbChecking.Items.Add(lblDate.Text & vbTab &
                                              vbTab & "Transfer from Savings" & vbTab &
                                              vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                              vbTab & "Prev. Bal." & vbTab &
                                              vbTab & (objChecking.Balance - CDec(txtTransfer.Text)).ToString("c") & vbTab &
                                              vbTab & "New Bal." & vbTab &
                                              vbTab & objChecking.Balance.ToString("c"))
                    End If
                End If
            ElseIf cmbTransfer.SelectedItem.ToString = "Savings" Then
                If CDec(txtTransfer.Text) > objSavings.Balance Then
                    MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Happens if Transfer Amount is More Than Balance. If Not, Transaction is Made'
                Else
                    objChecking.createTransaction("Checking", CDec(txtTransfer.Text), Today, "Transfer")
                    objChecking.Balance += CDec(txtTransfer.Text)
                    objSavings.createTransaction("Savings", CDec(txtTransfer.Text), Today, "Transfer")
                    objSavings.Balance -= CDec(txtTransfer.Text)

                    If cmbAccount.SelectedItem.ToString = "Checking" Then
                        lblBalance.Text = objChecking.Balance.ToString("c")
                    ElseIf cmbAccount.SelectedItem.ToString = "Savings" Then
                        lblBalance.Text = objSavings.Balance.ToString("c")
                    End If

                    If cmbTransfer.Text = "Checking" Then
                        lsbChecking.Items.Add(lblDate.Text & vbTab &
                                              vbTab & "Transfer to Savings" & vbTab &
                                              vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                              vbTab & "Prev. Bal." & vbTab &
                                              vbTab & (CDec(txtTransfer.Text) + objChecking.Balance).ToString("c") & vbTab &
                                              vbTab & "New Bal." & vbTab &
                                              vbTab & objChecking.Balance.ToString("c"))
                        lsbSavings.Items.Add(lblDate.Text & vbTab &
                                             vbTab & "Transfer from Checking" & vbTab &
                                             vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                             vbTab & "Prev. Bal." & vbTab &
                                             vbTab & (objSavings.Balance - CDec(txtTransfer.Text)).ToString("c") & vbTab &
                                             vbTab & "New Bal." & vbTab &
                                             vbTab & objSavings.Balance.ToString("c"))
                    ElseIf cmbTransfer.Text = "Savings" Then
                        lsbSavings.Items.Add(lblDate.Text & vbTab &
                                             vbTab & "Transfer to Checking" & vbTab &
                                             vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                             vbTab & "Prev. Bal." & vbTab &
                                             vbTab & (CDec(txtTransfer.Text) + objSavings.Balance).ToString("c") & vbTab &
                                             vbTab & "New Bal." & vbTab &
                                             vbTab & objSavings.Balance.ToString("c"))
                        lsbChecking.Items.Add(lblDate.Text & vbTab &
                                              vbTab & "Transfer from Savings" & vbTab &
                                              vbTab & CDec(txtTransfer.Text).ToString("c") & vbTab &
                                              vbTab & "Prev. Bal." & vbTab &
                                              vbTab & (objChecking.Balance - CDec(txtTransfer.Text)).ToString("c") & vbTab &
                                              vbTab & "New Bal." & vbTab &
                                              vbTab & objChecking.Balance.ToString("c"))
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input Data", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Happens if Nothing is Inputted in Transfer Textbox, or Nothing is Seleced in Account ComboBox'
        End Try
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        Try
            If CDec(txtCheck.Text) > CDec(lblBalance.Text) Then
                MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Happens if Transfer Amount is More Than Balance. If Not, Transaction is Made'
            Else
                'Works Similar to Withdrawal, Except This Can Only Be Done to Checking Account'
                objChecking.createTransaction(txtOrderOf.Text, CDec(txtCheck.Text), Today, "Check")
                objChecking.Balance -= CDec(txtCheck.Text)
                lblBalance.Text = objChecking.Balance.ToString("c")
                lsbChecking.Items.Add(lblDate.Text & vbTab &
                                       vbTab & "Check to" & vbTab & txtOrderOf.Text & vbTab &
                                       vbTab & CDec(txtCheck.Text).ToString("c") & vbTab &
                                       vbTab & "Prev. Bal." & vbTab &
                                       vbTab & (CDec(txtCheck.Text) + objChecking.Balance).ToString("c") & vbTab &
                                       vbTab & "New Bal." & vbTab &
                                       vbTab & objChecking.Balance.ToString("c"))
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input Data", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Happens if Nothing is Inputted in Check Textbox, or Nothing is Seleced in Account ComboBox'
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Saves Account to File Depending on Which Account is Selected'
        'Calls TransactionDirectory'
        Try
            Dim objFileManager As New clsTransactionsDirectory
            Dim fileChooser As New OpenFileDialog
            Dim result As DialogResult = fileChooser.ShowDialog
            objFileManager.name = fileChooser.FileName
            If cmbAccount.Text = "Checking" Then
                objFileManager.saveToFile(lsbChecking)
            ElseIf cmbAccount.Text = "Savings" Then
                objFileManager.saveToFile(lsbSavings)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input Data", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class