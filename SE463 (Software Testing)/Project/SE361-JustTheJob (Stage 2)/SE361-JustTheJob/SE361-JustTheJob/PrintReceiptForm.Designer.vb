<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintReceiptForm
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
        Me.gbRPInvoice = New System.Windows.Forms.GroupBox()
        Me.lblPRInvoice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPRAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPRCustomer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPRPaid = New System.Windows.Forms.Label()
        Me.lblPRChange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPRMethod = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbRPInvoice.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRPInvoice
        '
        Me.gbRPInvoice.Controls.Add(Me.lblPRInvoice)
        Me.gbRPInvoice.Controls.Add(Me.Label3)
        Me.gbRPInvoice.Controls.Add(Me.lblPRAmount)
        Me.gbRPInvoice.Controls.Add(Me.Label4)
        Me.gbRPInvoice.Controls.Add(Me.lblPRCustomer)
        Me.gbRPInvoice.Controls.Add(Me.Label2)
        Me.gbRPInvoice.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbRPInvoice.Location = New System.Drawing.Point(12, 71)
        Me.gbRPInvoice.Name = "gbRPInvoice"
        Me.gbRPInvoice.Size = New System.Drawing.Size(393, 112)
        Me.gbRPInvoice.TabIndex = 8
        Me.gbRPInvoice.TabStop = False
        Me.gbRPInvoice.Text = "Invoice Information"
        Me.gbRPInvoice.Visible = False
        '
        'lblPRInvoice
        '
        Me.lblPRInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRInvoice.Location = New System.Drawing.Point(247, 49)
        Me.lblPRInvoice.Name = "lblPRInvoice"
        Me.lblPRInvoice.Size = New System.Drawing.Size(88, 23)
        Me.lblPRInvoice.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Invoice Number:"
        '
        'lblPRAmount
        '
        Me.lblPRAmount.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRAmount.Location = New System.Drawing.Point(247, 78)
        Me.lblPRAmount.Name = "lblPRAmount"
        Me.lblPRAmount.Size = New System.Drawing.Size(88, 23)
        Me.lblPRAmount.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount Due:"
        '
        'lblPRCustomer
        '
        Me.lblPRCustomer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRCustomer.Location = New System.Drawing.Point(210, 19)
        Me.lblPRCustomer.Name = "lblPRCustomer"
        Me.lblPRCustomer.Size = New System.Drawing.Size(125, 23)
        Me.lblPRCustomer.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Payment Receipt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Amount Paid:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Change Due:"
        '
        'lblPRPaid
        '
        Me.lblPRPaid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRPaid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRPaid.Location = New System.Drawing.Point(259, 186)
        Me.lblPRPaid.Name = "lblPRPaid"
        Me.lblPRPaid.Size = New System.Drawing.Size(88, 23)
        Me.lblPRPaid.TabIndex = 12
        '
        'lblPRChange
        '
        Me.lblPRChange.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRChange.Location = New System.Drawing.Point(291, 248)
        Me.lblPRChange.Name = "lblPRChange"
        Me.lblPRChange.Size = New System.Drawing.Size(56, 23)
        Me.lblPRChange.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Payment Method:"
        '
        'lblPRMethod
        '
        Me.lblPRMethod.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPRMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPRMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPRMethod.Location = New System.Drawing.Point(259, 216)
        Me.lblPRMethod.Name = "lblPRMethod"
        Me.lblPRMethod.Size = New System.Drawing.Size(88, 23)
        Me.lblPRMethod.TabIndex = 15
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(417, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'PrintReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 301)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblPRMethod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPRChange)
        Me.Controls.Add(Me.lblPRPaid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbRPInvoice)
        Me.Name = "PrintReceiptForm"
        Me.Text = "Customer Receipt Form"
        Me.gbRPInvoice.ResumeLayout(False)
        Me.gbRPInvoice.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbRPInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblPRAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPRCustomer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPRInvoice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPRPaid As System.Windows.Forms.Label
    Friend WithEvents lblPRChange As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPRMethod As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
