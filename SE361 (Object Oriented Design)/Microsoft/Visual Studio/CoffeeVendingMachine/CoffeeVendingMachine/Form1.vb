Public Class MainForm
    Dim objCoffee As New clsCoffee 'General Coffee Object'
    Dim objBrazilian As New clsCoffee 'Brazilian Coffee Object'
    Dim objColumbian As New clsCoffee 'Columbian Coffee Object'
    Dim objFrench As New clsCoffee 'French Coffee Object'
    Dim objJavan As New clsCoffee 'Javan Coffee Objet'
    Dim objCoins As New clsCoinSlot 'Coins Object'

    Private Sub btnBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'If There Are No More Coffee, Error Message is Displayed'
            If objCoffee.Quantity = 0 Then
                MessageBox.Show("No More Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'If There Are No More of the Selected Coffee Type, Error Message is Displayed'
            ElseIf lsbCoffee.SelectedIndex = 0 And objBrazilian.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 1 And objColumbian.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 2 And objFrench.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 3 And objJavan.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 'Commence Coffee Purchase'
                If CDec(lblPrice.Text) > objCoins.Credit Then 'If Price is More Than Inputted Change, Than Error Message'
                    MessageBox.Show("Not Enough Money Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else 'Continue Coffee Purchase'
                    'Reduce Quantity of Selected Coffee By One and Display New Quantity Value on Progress Bar'
                    If lsbCoffee.SelectedIndex = 0 Then
                        objBrazilian.Quantity -= 1
                        pgbQuantity.Value = CInt(objBrazilian.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 1 Then
                        objColumbian.Quantity -= 1
                        pgbQuantity.Value = CInt(objColumbian.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 2 Then
                        objFrench.Quantity -= 1
                        pgbQuantity.Value = CInt(objFrench.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 3 Then
                        objJavan.Quantity -= 1
                        pgbQuantity.Value = CInt(objJavan.Quantity)
                    End If
                    'Coffee Details Become Selected Type and Its Price'
                    objCoffee.Coffee = lsbCoffee.SelectedItem.ToString
                    objCoffee.Price = CDec(lblPrice.Text)
                    'Edit Credit (Change) Amount and Display on MainForm'
                    objCoins.Credit -= objCoffee.Price
                    lblCredit.Text = objCoins.Credit.ToString("c")
                    'Reduce Total Coffee Amount By One and Show on Progress Bar'
                    objCoffee.Quantity -= 1
                    pgbTotalQuantity.Value = CInt(objCoffee.Quantity)
                    'Show Message Indicating Succeeded Purchase'
                    MessageBox.Show("Enjoy Your " + lsbCoffee.SelectedItem.ToString + " Coffee")
                End If
            End If
        Catch ex As Exception
            'Display Error Message Box'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsbCoffee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Depending on Which Item is Selected, Value of First Progress Bar Changes and So Does the Price That is Displayed'
        lblCoffee.Text = lsbCoffee.SelectedItem.ToString
        If lsbCoffee.SelectedIndex = 0 Then
            lblPrice.Text = "$1.00"
            pgbQuantity.Value = CInt(objBrazilian.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 1 Then
            lblPrice.Text = "$2.00"
            pgbQuantity.Value = CInt(objColumbian.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 2 Then
            lblPrice.Text = "$3.00"
            pgbQuantity.Value = CInt(objFrench.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 3 Then
            lblPrice.Text = "$4.00"
            pgbQuantity.Value = CInt(objJavan.Quantity)
        End If

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'If There is No Change in Machine, Error Message is Displayed and Nothing is Given'
            If objCoins.Credit = 0 Then
                MessageBox.Show("No Change to Give", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Change is Given'
                objCoins.Credit = 0
                lblCredit.Text = objCoins.Credit.ToString("c")
                MessageBox.Show("Please Take Your Change")
            End If
        Catch ex As Exception
            'Error MessageBox Displayed'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Coin Details Become Selected Coin Type and Its Value'
            objCoins.Coin = lsbCoin.SelectedItem.ToString
            'Credit Gets Updated and Increases, and is Displayed on MainForm'
            objCoins.Credit += CDec(lblValue.Text)
            lblCredit.Text = objCoins.Credit.ToString("c")
            'Displays Warning Message Stating That Even Though the Money Was Inputted, There is No More Coffee in the Machine
            'So It is Actually Pointless'
            If objCoffee.Quantity = 0 Then
                MessageBox.Show("No More Coffee in the Machine", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            'Error MessageBox Displayed'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Displayes Credit on Load (Which Should be Zero)'
        lblCredit.Text = objCoins.Credit.ToString("c")
        'Sets Quantity of Each Coffee to 5, and Total Quantity to 20'
        objBrazilian.Quantity = 5
        objColumbian.Quantity = 5
        objFrench.Quantity = 5
        objJavan.Quantity = 5
        objCoffee.Quantity = 20
        'Set Mode Automatically to Customer'
        gbCustomer.Visible = True
        gbVendor.Visible = False
    End Sub

    Private Sub lsbCoin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Depending on Which Item is Selected, Displayed Coin Value Changes'
        If lsbCoin.SelectedIndex = 0 Then
            lblValue.Text = "$0.01"
        ElseIf lsbCoin.SelectedIndex = 1 Then
            lblValue.Text = "$0.05"
        ElseIf lsbCoin.SelectedIndex = 2 Then
            lblValue.Text = "$0.10"
        ElseIf lsbCoin.SelectedIndex = 3 Then
            lblValue.Text = "$0.25"
        ElseIf lsbCoin.SelectedIndex = 4 Then
            lblValue.Text = "$0.50"
        ElseIf lsbCoin.SelectedIndex = 5 Then
            lblValue.Text = "$1.00"
        End If
    End Sub

    Private Sub btnInsert_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            'Coin Details Become Selected Coin Type and Its Value'
            objCoins.Coin = lsbCoin.SelectedItem.ToString
            'Credit Gets Updated and Increases, and is Displayed on MainForm'
            objCoins.Credit += CDec(lblValue.Text)
            lblCredit.Text = objCoins.Credit.ToString("c")
            'Displays Warning Message Stating That Even Though the Money Was Inputted, There is No More Coffee in the Machine
            'So It is Actually Pointless'
            If objCoffee.Quantity = 0 Then
                MessageBox.Show("No More Coffee in the Machine", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            'Error MessageBox Displayed'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy.Click
        Try
            'If There Are No More Coffee, Error Message is Displayed'
            If objCoffee.Quantity = 0 Then
                MessageBox.Show("No More Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'If There Are No More of the Selected Coffee Type, Error Message is Displayed'
            ElseIf lsbCoffee.SelectedIndex = 0 And objBrazilian.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 1 And objColumbian.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 2 And objFrench.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lsbCoffee.SelectedIndex = 3 And objJavan.Quantity = 0 Then
                MessageBox.Show("No More " + lsbCoffee.SelectedItem + " Coffee in the Machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else 'Commence Coffee Purchase'
                If CDec(lblPrice.Text) > objCoins.Credit Then 'If Price is More Than Inputted Change, Than Error Message'
                    MessageBox.Show("Not Enough Money Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else 'Continue Coffee Purchase'
                    'Reduce Quantity of Selected Coffee By One and Display New Quantity Value on Progress Bar'
                    If lsbCoffee.SelectedIndex = 0 Then
                        objBrazilian.Quantity -= 1
                        pgbQuantity.Value = CInt(objBrazilian.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 1 Then
                        objColumbian.Quantity -= 1
                        pgbQuantity.Value = CInt(objColumbian.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 2 Then
                        objFrench.Quantity -= 1
                        pgbQuantity.Value = CInt(objFrench.Quantity)
                    ElseIf lsbCoffee.SelectedIndex = 3 Then
                        objJavan.Quantity -= 1
                        pgbQuantity.Value = CInt(objJavan.Quantity)
                    End If
                    'Coffee Details Become Selected Type and Its Price'
                    objCoffee.Coffee = lsbCoffee.SelectedItem.ToString
                    objCoffee.Price = CDec(lblPrice.Text)
                    'Edit Credit (Change) Amount and Display on MainForm'
                    objCoins.Credit -= objCoffee.Price
                    lblCredit.Text = objCoins.Credit.ToString("c")
                    'Reduce Total Coffee Amount By One and Show on Progress Bar'
                    objCoffee.Quantity -= 1
                    pgbTotalQuantity.Value = CInt(objCoffee.Quantity)
                    'Show Message Indicating Succeeded Purchase'
                    MessageBox.Show("Enjoy Your " + lsbCoffee.SelectedItem.ToString + " Coffee")
                End If
            End If
        Catch ex As Exception
            'Display Error Message Box'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnChange_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Try
            'If There is No Change in Machine, Error Message is Displayed and Nothing is Given'
            If objCoins.Credit = 0 Then
                MessageBox.Show("No Change to Give", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Change is Given'
                objCoins.Credit = 0
                lblCredit.Text = objCoins.Credit.ToString("c")
                MessageBox.Show("Please Take Your Change")
            End If
        Catch ex As Exception
            'Error MessageBox Displayed'
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsbCoffee_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbCoffee.SelectedIndexChanged
        'Depending on Which Item is Selected, Value of First Progress Bar Changes and So Does the Price That is Displayed'
        lblCoffee.Text = lsbCoffee.SelectedItem.ToString
        If lsbCoffee.SelectedIndex = 0 Then
            lblPrice.Text = "$1.00"
            pgbQuantity.Value = CInt(objBrazilian.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 1 Then
            lblPrice.Text = "$2.00"
            pgbQuantity.Value = CInt(objColumbian.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 2 Then
            lblPrice.Text = "$3.00"
            pgbQuantity.Value = CInt(objFrench.Quantity)
        ElseIf lsbCoffee.SelectedIndex = 3 Then
            lblPrice.Text = "$4.00"
            pgbQuantity.Value = CInt(objJavan.Quantity)
        End If
    End Sub

    Private Sub lsbCoin_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbCoin.SelectedIndexChanged
        'Depending on Which Item is Selected, Displayed Coin Value Changes'
        If lsbCoin.SelectedIndex = 0 Then
            lblValue.Text = "$0.01"
        ElseIf lsbCoin.SelectedIndex = 1 Then
            lblValue.Text = "$0.05"
        ElseIf lsbCoin.SelectedIndex = 2 Then
            lblValue.Text = "$0.10"
        ElseIf lsbCoin.SelectedIndex = 3 Then
            lblValue.Text = "$0.25"
        ElseIf lsbCoin.SelectedIndex = 4 Then
            lblValue.Text = "$0.50"
        ElseIf lsbCoin.SelectedIndex = 5 Then
            lblValue.Text = "$1.00"
        End If
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        gbCustomer.Visible = True
        gbVendor.Visible = False
    End Sub

    Private Sub VendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub btnRefill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefill.Click
        Try
            If lsbBrands.SelectedIndex = 0 Then
                If objBrazilian.Quantity = 5 Then
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Already Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objBrazilian.Quantity = 5
                    pgbQuantity.Value = CInt(objBrazilian.Quantity)
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Refilled")
                End If
            ElseIf lsbBrands.SelectedIndex = 1 Then
                If objColumbian.Quantity = 5 Then
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Already Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objColumbian.Quantity = 5
                    pgbQuantity.Value = CInt(objColumbian.Quantity)
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Refilled")
                End If
            ElseIf lsbBrands.SelectedIndex = 2 Then
                If objFrench.Quantity = 5 Then
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Already Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objFrench.Quantity = 5
                    pgbQuantity.Value = CInt(objFrench.Quantity)
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Refilled")
                End If
            ElseIf lsbBrands.SelectedIndex = 3 Then
                If objJavan.Quantity = 5 Then
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Already Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objJavan.Quantity = 5
                    pgbQuantity.Value = CInt(objJavan.Quantity)
                    MessageBox.Show(lsbBrands.SelectedItem + " Coffee Refilled")
                End If
            Else
                MessageBox.Show("Select A Coffee Type to Refill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            pgbTotalQuantity.Value = CInt(objBrazilian.Quantity + objColumbian.Quantity + objFrench.Quantity + objJavan.Quantity)

        Catch ex As Exception
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
