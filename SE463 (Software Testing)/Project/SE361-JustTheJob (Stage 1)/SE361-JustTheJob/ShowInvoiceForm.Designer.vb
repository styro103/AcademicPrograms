<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowInvoiceForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSIInvoice = New System.Windows.Forms.Label()
        Me.lblSIType = New System.Windows.Forms.Label()
        Me.lblSIName = New System.Windows.Forms.Label()
        Me.lblSIEmployee = New System.Windows.Forms.Label()
        Me.lblSIPayment = New System.Windows.Forms.Label()
        Me.lblSIMethod = New System.Windows.Forms.Label()
        Me.lblSICompleteDate = New System.Windows.Forms.Label()
        Me.btnSIBack = New System.Windows.Forms.Button()
        Me.btnSIPrint = New System.Windows.Forms.Button()
        Me.btnSIDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Information"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSICompleteDate)
        Me.GroupBox1.Controls.Add(Me.lblSIMethod)
        Me.GroupBox1.Controls.Add(Me.lblSIPayment)
        Me.GroupBox1.Controls.Add(Me.lblSIEmployee)
        Me.GroupBox1.Controls.Add(Me.lblSIName)
        Me.GroupBox1.Controls.Add(Me.lblSIType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 214)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide the Following Information:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Job Completion Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Payment Method:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Payment Due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Invoice Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer Name:"
        '
        'lblSIInvoice
        '
        Me.lblSIInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIInvoice.Location = New System.Drawing.Point(205, 58)
        Me.lblSIInvoice.Name = "lblSIInvoice"
        Me.lblSIInvoice.Size = New System.Drawing.Size(143, 23)
        Me.lblSIInvoice.TabIndex = 1
        Me.lblSIInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSIType
        '
        Me.lblSIType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSIType.Location = New System.Drawing.Point(341, 23)
        Me.lblSIType.Name = "lblSIType"
        Me.lblSIType.Size = New System.Drawing.Size(132, 23)
        Me.lblSIType.TabIndex = 13
        '
        'lblSIName
        '
        Me.lblSIName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSIName.Location = New System.Drawing.Point(341, 58)
        Me.lblSIName.Name = "lblSIName"
        Me.lblSIName.Size = New System.Drawing.Size(132, 23)
        Me.lblSIName.TabIndex = 14
        '
        'lblSIEmployee
        '
        Me.lblSIEmployee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIEmployee.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSIEmployee.Location = New System.Drawing.Point(341, 86)
        Me.lblSIEmployee.Name = "lblSIEmployee"
        Me.lblSIEmployee.Size = New System.Drawing.Size(132, 23)
        Me.lblSIEmployee.TabIndex = 15
        '
        'lblSIPayment
        '
        Me.lblSIPayment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIPayment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSIPayment.Location = New System.Drawing.Point(402, 117)
        Me.lblSIPayment.Name = "lblSIPayment"
        Me.lblSIPayment.Size = New System.Drawing.Size(71, 23)
        Me.lblSIPayment.TabIndex = 16
        '
        'lblSIMethod
        '
        Me.lblSIMethod.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSIMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSIMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSIMethod.Location = New System.Drawing.Point(388, 149)
        Me.lblSIMethod.Name = "lblSIMethod"
        Me.lblSIMethod.Size = New System.Drawing.Size(85, 23)
        Me.lblSIMethod.TabIndex = 17
        '
        'lblSICompleteDate
        '
        Me.lblSICompleteDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSICompleteDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSICompleteDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSICompleteDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSICompleteDate.Location = New System.Drawing.Point(388, 181)
        Me.lblSICompleteDate.Name = "lblSICompleteDate"
        Me.lblSICompleteDate.Size = New System.Drawing.Size(85, 23)
        Me.lblSICompleteDate.TabIndex = 18
        '
        'btnSIBack
        '
        Me.btnSIBack.Location = New System.Drawing.Point(424, 317)
        Me.btnSIBack.Name = "btnSIBack"
        Me.btnSIBack.Size = New System.Drawing.Size(96, 23)
        Me.btnSIBack.TabIndex = 13
        Me.btnSIBack.Text = "&Back"
        Me.btnSIBack.UseVisualStyleBackColor = True
        '
        'btnSIPrint
        '
        Me.btnSIPrint.Location = New System.Drawing.Point(295, 317)
        Me.btnSIPrint.Name = "btnSIPrint"
        Me.btnSIPrint.Size = New System.Drawing.Size(96, 23)
        Me.btnSIPrint.TabIndex = 14
        Me.btnSIPrint.Text = "&Print"
        Me.btnSIPrint.UseVisualStyleBackColor = True
        '
        'btnSIDelete
        '
        Me.btnSIDelete.Location = New System.Drawing.Point(12, 317)
        Me.btnSIDelete.Name = "btnSIDelete"
        Me.btnSIDelete.Size = New System.Drawing.Size(96, 23)
        Me.btnSIDelete.TabIndex = 15
        Me.btnSIDelete.Text = "&Delete Invoice"
        Me.btnSIDelete.UseVisualStyleBackColor = True
        '
        'ShowInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 368)
        Me.Controls.Add(Me.btnSIDelete)
        Me.Controls.Add(Me.btnSIPrint)
        Me.Controls.Add(Me.btnSIBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblSIInvoice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ShowInvoiceForm"
        Me.Text = "Invoice Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSICompleteDate As System.Windows.Forms.Label
    Friend WithEvents lblSIMethod As System.Windows.Forms.Label
    Friend WithEvents lblSIPayment As System.Windows.Forms.Label
    Friend WithEvents lblSIEmployee As System.Windows.Forms.Label
    Friend WithEvents lblSIName As System.Windows.Forms.Label
    Friend WithEvents lblSIType As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSIInvoice As System.Windows.Forms.Label
    Friend WithEvents btnSIBack As System.Windows.Forms.Button
    Friend WithEvents btnSIPrint As System.Windows.Forms.Button
    Friend WithEvents btnSIDelete As System.Windows.Forms.Button
End Class
