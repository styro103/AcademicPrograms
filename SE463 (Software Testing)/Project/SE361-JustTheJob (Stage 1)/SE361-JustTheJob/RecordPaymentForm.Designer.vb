<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordPaymentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRPInvoice = New System.Windows.Forms.Label()
        Me.gbRPInvoice = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRPCustomer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRPAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRPPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRPChange = New System.Windows.Forms.TextBox()
        Me.btnRPBack = New System.Windows.Forms.Button()
        Me.btnRPSubmit = New System.Windows.Forms.Button()
        Me.gbRPInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Recording Payment Form"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search Invoices"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRPInvoice
        '
        Me.lblRPInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRPInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRPInvoice.Location = New System.Drawing.Point(183, 50)
        Me.lblRPInvoice.Name = "lblRPInvoice"
        Me.lblRPInvoice.Size = New System.Drawing.Size(152, 23)
        Me.lblRPInvoice.TabIndex = 6
        '
        'gbRPInvoice
        '
        Me.gbRPInvoice.Controls.Add(Me.lblRPAmount)
        Me.gbRPInvoice.Controls.Add(Me.Label4)
        Me.gbRPInvoice.Controls.Add(Me.lblRPCustomer)
        Me.gbRPInvoice.Controls.Add(Me.Label2)
        Me.gbRPInvoice.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbRPInvoice.Location = New System.Drawing.Point(13, 80)
        Me.gbRPInvoice.Name = "gbRPInvoice"
        Me.gbRPInvoice.Size = New System.Drawing.Size(375, 85)
        Me.gbRPInvoice.TabIndex = 7
        Me.gbRPInvoice.TabStop = False
        Me.gbRPInvoice.Text = "Invoice Information"
        Me.gbRPInvoice.Visible = False
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
        'lblRPCustomer
        '
        Me.lblRPCustomer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRPCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRPCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRPCustomer.Location = New System.Drawing.Point(210, 19)
        Me.lblRPCustomer.Name = "lblRPCustomer"
        Me.lblRPCustomer.Size = New System.Drawing.Size(125, 23)
        Me.lblRPCustomer.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount Due:"
        '
        'lblRPAmount
        '
        Me.lblRPAmount.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRPAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRPAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRPAmount.Location = New System.Drawing.Point(247, 49)
        Me.lblRPAmount.Name = "lblRPAmount"
        Me.lblRPAmount.Size = New System.Drawing.Size(88, 23)
        Me.lblRPAmount.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount Paid:"
        '
        'txtRPPaid
        '
        Me.txtRPPaid.Location = New System.Drawing.Point(260, 169)
        Me.txtRPPaid.Name = "txtRPPaid"
        Me.txtRPPaid.Size = New System.Drawing.Size(88, 20)
        Me.txtRPPaid.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Change Due:"
        '
        'txtRPChange
        '
        Me.txtRPChange.Location = New System.Drawing.Point(288, 195)
        Me.txtRPChange.Name = "txtRPChange"
        Me.txtRPChange.Size = New System.Drawing.Size(60, 20)
        Me.txtRPChange.TabIndex = 11
        '
        'btnRPBack
        '
        Me.btnRPBack.Location = New System.Drawing.Point(285, 240)
        Me.btnRPBack.Name = "btnRPBack"
        Me.btnRPBack.Size = New System.Drawing.Size(103, 23)
        Me.btnRPBack.TabIndex = 12
        Me.btnRPBack.Text = "&Back"
        Me.btnRPBack.UseVisualStyleBackColor = True
        '
        'btnRPSubmit
        '
        Me.btnRPSubmit.Location = New System.Drawing.Point(161, 240)
        Me.btnRPSubmit.Name = "btnRPSubmit"
        Me.btnRPSubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnRPSubmit.TabIndex = 13
        Me.btnRPSubmit.Text = "&Submit Payment"
        Me.btnRPSubmit.UseVisualStyleBackColor = True
        '
        'RecordPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 275)
        Me.Controls.Add(Me.btnRPSubmit)
        Me.Controls.Add(Me.btnRPBack)
        Me.Controls.Add(Me.txtRPChange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRPPaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbRPInvoice)
        Me.Controls.Add(Me.lblRPInvoice)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RecordPaymentForm"
        Me.Text = "Record Payment Form"
        Me.gbRPInvoice.ResumeLayout(False)
        Me.gbRPInvoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblRPInvoice As System.Windows.Forms.Label
    Friend WithEvents gbRPInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblRPAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRPCustomer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRPPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRPChange As System.Windows.Forms.TextBox
    Friend WithEvents btnRPBack As System.Windows.Forms.Button
    Friend WithEvents btnRPSubmit As System.Windows.Forms.Button
End Class
