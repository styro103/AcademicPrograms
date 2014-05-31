<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbAccount = New System.Windows.Forms.GroupBox()
        Me.lblTodays = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblBal = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.cmbAccount = New System.Windows.Forms.ComboBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.gbDeposit = New System.Windows.Forms.GroupBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.lblDS1 = New System.Windows.Forms.Label()
        Me.gbWithdrawal = New System.Windows.Forms.GroupBox()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.lblDS2 = New System.Windows.Forms.Label()
        Me.gbTransfer = New System.Windows.Forms.GroupBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDS3 = New System.Windows.Forms.Label()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.cmbTransfer = New System.Windows.Forms.ComboBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.gbCheck = New System.Windows.Forms.GroupBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtOrderOf = New System.Windows.Forms.TextBox()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.lblDS4 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.lblCAmount = New System.Windows.Forms.Label()
        Me.gbTransactions = New System.Windows.Forms.GroupBox()
        Me.lsbSavings = New System.Windows.Forms.ListBox()
        Me.lsbChecking = New System.Windows.Forms.ListBox()
        Me.gbAccount.SuspendLayout()
        Me.gbDeposit.SuspendLayout()
        Me.gbWithdrawal.SuspendLayout()
        Me.gbTransfer.SuspendLayout()
        Me.gbCheck.SuspendLayout()
        Me.gbTransactions.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAccount
        '
        Me.gbAccount.Controls.Add(Me.lblTodays)
        Me.gbAccount.Controls.Add(Me.lblDate)
        Me.gbAccount.Controls.Add(Me.btnSave)
        Me.gbAccount.Controls.Add(Me.lblBal)
        Me.gbAccount.Controls.Add(Me.lblBalance)
        Me.gbAccount.Controls.Add(Me.cmbAccount)
        Me.gbAccount.Controls.Add(Me.lblAccount)
        Me.gbAccount.Location = New System.Drawing.Point(12, 24)
        Me.gbAccount.Name = "gbAccount"
        Me.gbAccount.Size = New System.Drawing.Size(870, 100)
        Me.gbAccount.TabIndex = 0
        Me.gbAccount.TabStop = False
        '
        'lblTodays
        '
        Me.lblTodays.AutoSize = True
        Me.lblTodays.Location = New System.Drawing.Point(627, 45)
        Me.lblTodays.Name = "lblTodays"
        Me.lblTodays.Size = New System.Drawing.Size(73, 13)
        Me.lblTodays.TabIndex = 6
        Me.lblTodays.Text = "Today's Date:"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(731, 39)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 5
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(458, 39)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 27)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Accounts to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.Location = New System.Drawing.Point(239, 48)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(49, 13)
        Me.lblBal.TabIndex = 1
        Me.lblBal.Text = "Balance:"
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(319, 39)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(108, 27)
        Me.lblBalance.TabIndex = 3
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccount
        '
        Me.cmbAccount.FormattingEnabled = True
        Me.cmbAccount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cmbAccount.Location = New System.Drawing.Point(87, 45)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccount.TabIndex = 2
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(6, 48)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(50, 13)
        Me.lblAccount.TabIndex = 1
        Me.lblAccount.Text = "Account:"
        '
        'gbDeposit
        '
        Me.gbDeposit.Controls.Add(Me.btnDeposit)
        Me.gbDeposit.Controls.Add(Me.txtDeposit)
        Me.gbDeposit.Controls.Add(Me.lblDS1)
        Me.gbDeposit.Location = New System.Drawing.Point(12, 146)
        Me.gbDeposit.Name = "gbDeposit"
        Me.gbDeposit.Size = New System.Drawing.Size(288, 81)
        Me.gbDeposit.TabIndex = 1
        Me.gbDeposit.TabStop = False
        Me.gbDeposit.Text = "Deposit"
        '
        'btnDeposit
        '
        Me.btnDeposit.AutoSize = True
        Me.btnDeposit.Location = New System.Drawing.Point(169, 32)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(89, 32)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(41, 38)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 2
        '
        'lblDS1
        '
        Me.lblDS1.AutoSize = True
        Me.lblDS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDS1.Location = New System.Drawing.Point(14, 34)
        Me.lblDS1.Name = "lblDS1"
        Me.lblDS1.Size = New System.Drawing.Size(21, 24)
        Me.lblDS1.TabIndex = 2
        Me.lblDS1.Text = "$"
        '
        'gbWithdrawal
        '
        Me.gbWithdrawal.Controls.Add(Me.btnWithdrawal)
        Me.gbWithdrawal.Controls.Add(Me.txtWithdrawal)
        Me.gbWithdrawal.Controls.Add(Me.lblDS2)
        Me.gbWithdrawal.Location = New System.Drawing.Point(12, 251)
        Me.gbWithdrawal.Name = "gbWithdrawal"
        Me.gbWithdrawal.Size = New System.Drawing.Size(288, 81)
        Me.gbWithdrawal.TabIndex = 2
        Me.gbWithdrawal.TabStop = False
        Me.gbWithdrawal.Text = "Withdrawal"
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.AutoSize = True
        Me.btnWithdrawal.Location = New System.Drawing.Point(169, 32)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(89, 32)
        Me.btnWithdrawal.TabIndex = 2
        Me.btnWithdrawal.Text = "Withdraw"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(41, 38)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(100, 20)
        Me.txtWithdrawal.TabIndex = 2
        '
        'lblDS2
        '
        Me.lblDS2.AutoSize = True
        Me.lblDS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDS2.Location = New System.Drawing.Point(14, 34)
        Me.lblDS2.Name = "lblDS2"
        Me.lblDS2.Size = New System.Drawing.Size(21, 24)
        Me.lblDS2.TabIndex = 2
        Me.lblDS2.Text = "$"
        '
        'gbTransfer
        '
        Me.gbTransfer.Controls.Add(Me.btnTransfer)
        Me.gbTransfer.Controls.Add(Me.lblTo)
        Me.gbTransfer.Controls.Add(Me.lblDS3)
        Me.gbTransfer.Controls.Add(Me.txtTransfer)
        Me.gbTransfer.Controls.Add(Me.cmbTransfer)
        Me.gbTransfer.Controls.Add(Me.lblFrom)
        Me.gbTransfer.Location = New System.Drawing.Point(340, 146)
        Me.gbTransfer.Name = "gbTransfer"
        Me.gbTransfer.Size = New System.Drawing.Size(248, 186)
        Me.gbTransfer.TabIndex = 3
        Me.gbTransfer.TabStop = False
        Me.gbTransfer.Text = "Transfer"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(74, 134)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(89, 32)
        Me.btnTransfer.TabIndex = 5
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.Location = New System.Drawing.Point(8, 66)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(91, 48)
        Me.lblTo.TabIndex = 4
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDS3
        '
        Me.lblDS3.AutoSize = True
        Me.lblDS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDS3.Location = New System.Drawing.Point(103, 90)
        Me.lblDS3.Name = "lblDS3"
        Me.lblDS3.Size = New System.Drawing.Size(21, 24)
        Me.lblDS3.TabIndex = 3
        Me.lblDS3.Text = "$"
        '
        'txtTransfer
        '
        Me.txtTransfer.Location = New System.Drawing.Point(130, 95)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.Size = New System.Drawing.Size(100, 20)
        Me.txtTransfer.TabIndex = 2
        '
        'cmbTransfer
        '
        Me.cmbTransfer.FormattingEnabled = True
        Me.cmbTransfer.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cmbTransfer.Location = New System.Drawing.Point(109, 32)
        Me.cmbTransfer.Name = "cmbTransfer"
        Me.cmbTransfer.Size = New System.Drawing.Size(121, 21)
        Me.cmbTransfer.TabIndex = 1
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(35, 35)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'gbCheck
        '
        Me.gbCheck.Controls.Add(Me.lblOrder)
        Me.gbCheck.Controls.Add(Me.txtOrderOf)
        Me.gbCheck.Controls.Add(Me.btnSign)
        Me.gbCheck.Controls.Add(Me.lblDS4)
        Me.gbCheck.Controls.Add(Me.txtCheck)
        Me.gbCheck.Controls.Add(Me.lblCAmount)
        Me.gbCheck.Location = New System.Drawing.Point(622, 146)
        Me.gbCheck.Name = "gbCheck"
        Me.gbCheck.Size = New System.Drawing.Size(248, 186)
        Me.gbCheck.TabIndex = 4
        Me.gbCheck.TabStop = False
        Me.gbCheck.Text = "Check"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(26, 101)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(82, 13)
        Me.lblOrder.TabIndex = 5
        Me.lblOrder.Text = "To the Order of:"
        '
        'txtOrderOf
        '
        Me.txtOrderOf.Location = New System.Drawing.Point(121, 95)
        Me.txtOrderOf.Name = "txtOrderOf"
        Me.txtOrderOf.Size = New System.Drawing.Size(121, 20)
        Me.txtOrderOf.TabIndex = 5
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(87, 136)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(89, 32)
        Me.btnSign.TabIndex = 5
        Me.btnSign.Text = "Sign Check"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'lblDS4
        '
        Me.lblDS4.AutoSize = True
        Me.lblDS4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDS4.Location = New System.Drawing.Point(115, 32)
        Me.lblDS4.Name = "lblDS4"
        Me.lblDS4.Size = New System.Drawing.Size(21, 24)
        Me.lblDS4.TabIndex = 3
        Me.lblDS4.Text = "$"
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(142, 34)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(100, 20)
        Me.txtCheck.TabIndex = 2
        '
        'lblCAmount
        '
        Me.lblCAmount.AutoSize = True
        Me.lblCAmount.Location = New System.Drawing.Point(44, 40)
        Me.lblCAmount.Name = "lblCAmount"
        Me.lblCAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblCAmount.TabIndex = 0
        Me.lblCAmount.Text = "Amount:"
        '
        'gbTransactions
        '
        Me.gbTransactions.Controls.Add(Me.lsbSavings)
        Me.gbTransactions.Controls.Add(Me.lsbChecking)
        Me.gbTransactions.Location = New System.Drawing.Point(12, 361)
        Me.gbTransactions.Name = "gbTransactions"
        Me.gbTransactions.Size = New System.Drawing.Size(858, 220)
        Me.gbTransactions.TabIndex = 5
        Me.gbTransactions.TabStop = False
        Me.gbTransactions.Text = "Transactions"
        '
        'lsbSavings
        '
        Me.lsbSavings.FormattingEnabled = True
        Me.lsbSavings.Location = New System.Drawing.Point(9, 13)
        Me.lsbSavings.Name = "lsbSavings"
        Me.lsbSavings.Size = New System.Drawing.Size(843, 199)
        Me.lsbSavings.TabIndex = 1
        '
        'lsbChecking
        '
        Me.lsbChecking.FormattingEnabled = True
        Me.lsbChecking.Location = New System.Drawing.Point(9, 13)
        Me.lsbChecking.Name = "lsbChecking"
        Me.lsbChecking.Size = New System.Drawing.Size(843, 199)
        Me.lsbChecking.TabIndex = 0
        '
        'BankApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 593)
        Me.Controls.Add(Me.gbTransactions)
        Me.Controls.Add(Me.gbCheck)
        Me.Controls.Add(Me.gbTransfer)
        Me.Controls.Add(Me.gbWithdrawal)
        Me.Controls.Add(Me.gbDeposit)
        Me.Controls.Add(Me.gbAccount)
        Me.Name = "BankApp"
        Me.Text = "Bank Application"
        Me.gbAccount.ResumeLayout(False)
        Me.gbAccount.PerformLayout()
        Me.gbDeposit.ResumeLayout(False)
        Me.gbDeposit.PerformLayout()
        Me.gbWithdrawal.ResumeLayout(False)
        Me.gbWithdrawal.PerformLayout()
        Me.gbTransfer.ResumeLayout(False)
        Me.gbTransfer.PerformLayout()
        Me.gbCheck.ResumeLayout(False)
        Me.gbCheck.PerformLayout()
        Me.gbTransactions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAccount As System.Windows.Forms.GroupBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblTodays As System.Windows.Forms.Label
    Friend WithEvents gbDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents lblDS1 As System.Windows.Forms.Label
    Friend WithEvents gbWithdrawal As System.Windows.Forms.GroupBox
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents txtWithdrawal As System.Windows.Forms.TextBox
    Friend WithEvents lblDS2 As System.Windows.Forms.Label
    Friend WithEvents gbTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblDS3 As System.Windows.Forms.Label
    Friend WithEvents txtTransfer As System.Windows.Forms.TextBox
    Friend WithEvents cmbTransfer As System.Windows.Forms.ComboBox
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents gbCheck As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents txtOrderOf As System.Windows.Forms.TextBox
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents lblDS4 As System.Windows.Forms.Label
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents lblCAmount As System.Windows.Forms.Label
    Friend WithEvents gbTransactions As System.Windows.Forms.GroupBox
    Friend WithEvents lsbChecking As System.Windows.Forms.ListBox
    Friend WithEvents lsbSavings As System.Windows.Forms.ListBox
End Class
