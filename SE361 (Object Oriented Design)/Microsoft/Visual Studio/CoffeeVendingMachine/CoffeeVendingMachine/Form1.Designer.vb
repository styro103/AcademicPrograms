<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.gbCustomer = New System.Windows.Forms.GroupBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblYC = New System.Windows.Forms.Label()
        Me.gbQuantities = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblZero = New System.Windows.Forms.Label()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.pgbTotalQuantity = New System.Windows.Forms.ProgressBar()
        Me.pgbQuantity = New System.Windows.Forms.ProgressBar()
        Me.gbCoins = New System.Windows.Forms.GroupBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lsbCoin = New System.Windows.Forms.ListBox()
        Me.gbCoffee = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.lsbCoffee = New System.Windows.Forms.ListBox()
        Me.msMode = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbVendor = New System.Windows.Forms.GroupBox()
        Me.gbBrands = New System.Windows.Forms.GroupBox()
        Me.lsbBrands = New System.Windows.Forms.ListBox()
        Me.btnRefill = New System.Windows.Forms.Button()
        Me.gbCustomer.SuspendLayout()
        Me.gbQuantities.SuspendLayout()
        Me.gbCoins.SuspendLayout()
        Me.gbCoffee.SuspendLayout()
        Me.msMode.SuspendLayout()
        Me.gbVendor.SuspendLayout()
        Me.gbBrands.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCustomer
        '
        Me.gbCustomer.Controls.Add(Me.btnChange)
        Me.gbCustomer.Controls.Add(Me.lblCredit)
        Me.gbCustomer.Controls.Add(Me.lblYC)
        Me.gbCustomer.Controls.Add(Me.gbQuantities)
        Me.gbCustomer.Controls.Add(Me.gbCoins)
        Me.gbCustomer.Controls.Add(Me.gbCoffee)
        Me.gbCustomer.Location = New System.Drawing.Point(12, 33)
        Me.gbCustomer.Name = "gbCustomer"
        Me.gbCustomer.Size = New System.Drawing.Size(400, 474)
        Me.gbCustomer.TabIndex = 0
        Me.gbCustomer.TabStop = False
        Me.gbCustomer.Text = "Customer"
        '
        'btnChange
        '
        Me.btnChange.AutoSize = True
        Me.btnChange.Location = New System.Drawing.Point(139, 423)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 12
        Me.btnChange.Text = "Get Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lblCredit
        '
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Location = New System.Drawing.Point(161, 386)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(100, 23)
        Me.lblCredit.TabIndex = 11
        '
        'lblYC
        '
        Me.lblYC.AutoSize = True
        Me.lblYC.Location = New System.Drawing.Point(93, 387)
        Me.lblYC.Name = "lblYC"
        Me.lblYC.Size = New System.Drawing.Size(62, 13)
        Me.lblYC.TabIndex = 10
        Me.lblYC.Text = "Your Credit:"
        '
        'gbQuantities
        '
        Me.gbQuantities.Controls.Add(Me.lblTotal)
        Me.gbQuantities.Controls.Add(Me.lblFull)
        Me.gbQuantities.Controls.Add(Me.lblEmpty)
        Me.gbQuantities.Controls.Add(Me.lblFive)
        Me.gbQuantities.Controls.Add(Me.lblZero)
        Me.gbQuantities.Controls.Add(Me.lblCoffee)
        Me.gbQuantities.Controls.Add(Me.pgbTotalQuantity)
        Me.gbQuantities.Controls.Add(Me.pgbQuantity)
        Me.gbQuantities.Location = New System.Drawing.Point(0, 205)
        Me.gbQuantities.Name = "gbQuantities"
        Me.gbQuantities.Size = New System.Drawing.Size(387, 163)
        Me.gbQuantities.TabIndex = 9
        Me.gbQuantities.TabStop = False
        Me.gbQuantities.Text = "Quantities"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(24, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'lblFull
        '
        Me.lblFull.AutoSize = True
        Me.lblFull.Location = New System.Drawing.Point(340, 138)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(23, 13)
        Me.lblFull.TabIndex = 7
        Me.lblFull.Text = "Full"
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Location = New System.Drawing.Point(24, 138)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(36, 13)
        Me.lblEmpty.TabIndex = 7
        Me.lblEmpty.Text = "Empty"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(340, 66)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(13, 13)
        Me.lblFive.TabIndex = 6
        Me.lblFive.Text = "5"
        '
        'lblZero
        '
        Me.lblZero.AutoSize = True
        Me.lblZero.Location = New System.Drawing.Point(24, 66)
        Me.lblZero.Name = "lblZero"
        Me.lblZero.Size = New System.Drawing.Size(13, 13)
        Me.lblZero.TabIndex = 5
        Me.lblZero.Text = "0"
        '
        'lblCoffee
        '
        Me.lblCoffee.Location = New System.Drawing.Point(19, 24)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(93, 13)
        Me.lblCoffee.TabIndex = 4
        '
        'pgbTotalQuantity
        '
        Me.pgbTotalQuantity.Location = New System.Drawing.Point(37, 112)
        Me.pgbTotalQuantity.Maximum = 20
        Me.pgbTotalQuantity.Name = "pgbTotalQuantity"
        Me.pgbTotalQuantity.Size = New System.Drawing.Size(316, 23)
        Me.pgbTotalQuantity.TabIndex = 3
        Me.pgbTotalQuantity.Value = 20
        '
        'pgbQuantity
        '
        Me.pgbQuantity.Location = New System.Drawing.Point(37, 40)
        Me.pgbQuantity.Maximum = 5
        Me.pgbQuantity.Name = "pgbQuantity"
        Me.pgbQuantity.Size = New System.Drawing.Size(316, 23)
        Me.pgbQuantity.TabIndex = 2
        Me.pgbQuantity.Value = 5
        '
        'gbCoins
        '
        Me.gbCoins.Controls.Add(Me.lblValue)
        Me.gbCoins.Controls.Add(Me.lblVal)
        Me.gbCoins.Controls.Add(Me.btnInsert)
        Me.gbCoins.Controls.Add(Me.lsbCoin)
        Me.gbCoins.Location = New System.Drawing.Point(229, 16)
        Me.gbCoins.Name = "gbCoins"
        Me.gbCoins.Size = New System.Drawing.Size(158, 183)
        Me.gbCoins.TabIndex = 8
        Me.gbCoins.TabStop = False
        Me.gbCoins.Text = "Coins"
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValue.Location = New System.Drawing.Point(49, 147)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(100, 23)
        Me.lblValue.TabIndex = 3
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(6, 148)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(37, 13)
        Me.lblVal.TabIndex = 2
        Me.lblVal.Text = "Value:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(49, 107)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lsbCoin
        '
        Me.lsbCoin.FormattingEnabled = True
        Me.lsbCoin.Items.AddRange(New Object() {"Penny", "Nickel", "Dime", "Quarter", "Half-Dollar", "Dollar"})
        Me.lsbCoin.Location = New System.Drawing.Point(6, 19)
        Me.lsbCoin.Name = "lsbCoin"
        Me.lsbCoin.Size = New System.Drawing.Size(143, 82)
        Me.lsbCoin.TabIndex = 0
        '
        'gbCoffee
        '
        Me.gbCoffee.Controls.Add(Me.lblPrice)
        Me.gbCoffee.Controls.Add(Me.lblP)
        Me.gbCoffee.Controls.Add(Me.btnBuy)
        Me.gbCoffee.Controls.Add(Me.lsbCoffee)
        Me.gbCoffee.Location = New System.Drawing.Point(10, 16)
        Me.gbCoffee.Name = "gbCoffee"
        Me.gbCoffee.Size = New System.Drawing.Size(145, 183)
        Me.gbCoffee.TabIndex = 7
        Me.gbCoffee.TabStop = False
        Me.gbCoffee.Text = "Coffees"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(37, 146)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 1
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(3, 147)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(34, 13)
        Me.lblP.TabIndex = 1
        Me.lblP.Text = "Price:"
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(37, 100)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 1
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'lsbCoffee
        '
        Me.lsbCoffee.FormattingEnabled = True
        Me.lsbCoffee.Items.AddRange(New Object() {"Brazilian", "Columbian", "French", "Javan"})
        Me.lsbCoffee.Location = New System.Drawing.Point(6, 19)
        Me.lsbCoffee.Name = "lsbCoffee"
        Me.lsbCoffee.Size = New System.Drawing.Size(131, 56)
        Me.lsbCoffee.TabIndex = 1
        '
        'msMode
        '
        Me.msMode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem})
        Me.msMode.Location = New System.Drawing.Point(0, 0)
        Me.msMode.Name = "msMode"
        Me.msMode.Size = New System.Drawing.Size(424, 24)
        Me.msMode.TabIndex = 1
        Me.msMode.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.VendorToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VendorToolStripMenuItem.Text = "Vendor"
        '
        'gbVendor
        '
        Me.gbVendor.Controls.Add(Me.gbBrands)
        Me.gbVendor.Location = New System.Drawing.Point(12, 33)
        Me.gbVendor.Name = "gbVendor"
        Me.gbVendor.Size = New System.Drawing.Size(400, 468)
        Me.gbVendor.TabIndex = 13
        Me.gbVendor.TabStop = False
        Me.gbVendor.Text = "Vendor"
        '
        'gbBrands
        '
        Me.gbBrands.Controls.Add(Me.btnRefill)
        Me.gbBrands.Controls.Add(Me.lsbBrands)
        Me.gbBrands.Location = New System.Drawing.Point(16, 35)
        Me.gbBrands.Name = "gbBrands"
        Me.gbBrands.Size = New System.Drawing.Size(365, 249)
        Me.gbBrands.TabIndex = 0
        Me.gbBrands.TabStop = False
        Me.gbBrands.Text = "Coffee"
        '
        'lsbBrands
        '
        Me.lsbBrands.FormattingEnabled = True
        Me.lsbBrands.Items.AddRange(New Object() {"Brazilian", "Columbian", "French", "Javan"})
        Me.lsbBrands.Location = New System.Drawing.Point(21, 46)
        Me.lsbBrands.Name = "lsbBrands"
        Me.lsbBrands.Size = New System.Drawing.Size(336, 95)
        Me.lsbBrands.TabIndex = 0
        '
        'btnRefill
        '
        Me.btnRefill.Location = New System.Drawing.Point(63, 189)
        Me.btnRefill.Name = "btnRefill"
        Me.btnRefill.Size = New System.Drawing.Size(221, 23)
        Me.btnRefill.TabIndex = 1
        Me.btnRefill.Text = "Refill"
        Me.btnRefill.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 505)
        Me.Controls.Add(Me.gbVendor)
        Me.Controls.Add(Me.gbCustomer)
        Me.Controls.Add(Me.msMode)
        Me.MainMenuStrip = Me.msMode
        Me.Name = "MainForm"
        Me.Text = "Coffee Vending Machine"
        Me.gbCustomer.ResumeLayout(False)
        Me.gbCustomer.PerformLayout()
        Me.gbQuantities.ResumeLayout(False)
        Me.gbQuantities.PerformLayout()
        Me.gbCoins.ResumeLayout(False)
        Me.gbCoins.PerformLayout()
        Me.gbCoffee.ResumeLayout(False)
        Me.gbCoffee.PerformLayout()
        Me.msMode.ResumeLayout(False)
        Me.msMode.PerformLayout()
        Me.gbVendor.ResumeLayout(False)
        Me.gbBrands.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblYC As System.Windows.Forms.Label
    Friend WithEvents gbQuantities As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lblEmpty As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents lblZero As System.Windows.Forms.Label
    Friend WithEvents lblCoffee As System.Windows.Forms.Label
    Friend WithEvents pgbTotalQuantity As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbQuantity As System.Windows.Forms.ProgressBar
    Friend WithEvents gbCoins As System.Windows.Forms.GroupBox
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lblVal As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lsbCoin As System.Windows.Forms.ListBox
    Friend WithEvents gbCoffee As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents lsbCoffee As System.Windows.Forms.ListBox
    Friend WithEvents msMode As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbVendor As System.Windows.Forms.GroupBox
    Friend WithEvents gbBrands As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefill As System.Windows.Forms.Button
    Friend WithEvents lsbBrands As System.Windows.Forms.ListBox

End Class
