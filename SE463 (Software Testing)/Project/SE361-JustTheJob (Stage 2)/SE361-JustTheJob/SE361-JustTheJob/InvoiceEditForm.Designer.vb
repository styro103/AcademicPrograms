﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceEditForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEIPaid = New System.Windows.Forms.TextBox()
        Me.lblEIPaid = New System.Windows.Forms.Label()
        Me.txtEIWeek = New System.Windows.Forms.TextBox()
        Me.lblEIWeek = New System.Windows.Forms.Label()
        Me.txtEIComplete = New System.Windows.Forms.TextBox()
        Me.cmbEIMethod = New System.Windows.Forms.ComboBox()
        Me.txtEIPayment = New System.Windows.Forms.TextBox()
        Me.txtEIEmployee = New System.Windows.Forms.TextBox()
        Me.txtEIName = New System.Windows.Forms.TextBox()
        Me.lblEIType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtEIPaid)
        Me.GroupBox1.Controls.Add(Me.lblEIPaid)
        Me.GroupBox1.Controls.Add(Me.txtEIWeek)
        Me.GroupBox1.Controls.Add(Me.lblEIWeek)
        Me.GroupBox1.Controls.Add(Me.txtEIComplete)
        Me.GroupBox1.Controls.Add(Me.cmbEIMethod)
        Me.GroupBox1.Controls.Add(Me.txtEIPayment)
        Me.GroupBox1.Controls.Add(Me.txtEIEmployee)
        Me.GroupBox1.Controls.Add(Me.txtEIName)
        Me.GroupBox1.Controls.Add(Me.lblEIType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 305)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide the Following Information:"
        '
        'txtEIPaid
        '
        Me.txtEIPaid.Location = New System.Drawing.Point(420, 206)
        Me.txtEIPaid.Name = "txtEIPaid"
        Me.txtEIPaid.Size = New System.Drawing.Size(82, 22)
        Me.txtEIPaid.TabIndex = 5
        '
        'lblEIPaid
        '
        Me.lblEIPaid.AutoSize = True
        Me.lblEIPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEIPaid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEIPaid.Location = New System.Drawing.Point(6, 211)
        Me.lblEIPaid.Name = "lblEIPaid"
        Me.lblEIPaid.Size = New System.Drawing.Size(67, 13)
        Me.lblEIPaid.TabIndex = 21
        Me.lblEIPaid.Text = "Amount Paid"
        '
        'txtEIWeek
        '
        Me.txtEIWeek.Location = New System.Drawing.Point(379, 94)
        Me.txtEIWeek.Name = "txtEIWeek"
        Me.txtEIWeek.Size = New System.Drawing.Size(123, 22)
        Me.txtEIWeek.TabIndex = 1
        Me.txtEIWeek.Visible = False
        '
        'lblEIWeek
        '
        Me.lblEIWeek.AutoSize = True
        Me.lblEIWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEIWeek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEIWeek.Location = New System.Drawing.Point(6, 99)
        Me.lblEIWeek.Name = "lblEIWeek"
        Me.lblEIWeek.Size = New System.Drawing.Size(156, 13)
        Me.lblEIWeek.TabIndex = 19
        Me.lblEIWeek.Text = "Week (Sunday DD/MM/YYYY)"
        Me.lblEIWeek.Visible = False
        '
        'txtEIComplete
        '
        Me.txtEIComplete.Location = New System.Drawing.Point(379, 264)
        Me.txtEIComplete.Name = "txtEIComplete"
        Me.txtEIComplete.Size = New System.Drawing.Size(123, 22)
        Me.txtEIComplete.TabIndex = 7
        '
        'cmbEIMethod
        '
        Me.cmbEIMethod.FormattingEnabled = True
        Me.cmbEIMethod.Items.AddRange(New Object() {"Cash", "Credit", "Debit"})
        Me.cmbEIMethod.Location = New System.Drawing.Point(379, 234)
        Me.cmbEIMethod.Name = "cmbEIMethod"
        Me.cmbEIMethod.Size = New System.Drawing.Size(123, 24)
        Me.cmbEIMethod.TabIndex = 6
        '
        'txtEIPayment
        '
        Me.txtEIPayment.Location = New System.Drawing.Point(420, 178)
        Me.txtEIPayment.Name = "txtEIPayment"
        Me.txtEIPayment.Size = New System.Drawing.Size(82, 22)
        Me.txtEIPayment.TabIndex = 4
        '
        'txtEIEmployee
        '
        Me.txtEIEmployee.Location = New System.Drawing.Point(379, 150)
        Me.txtEIEmployee.Name = "txtEIEmployee"
        Me.txtEIEmployee.Size = New System.Drawing.Size(123, 22)
        Me.txtEIEmployee.TabIndex = 3
        '
        'txtEIName
        '
        Me.txtEIName.Location = New System.Drawing.Point(379, 122)
        Me.txtEIName.Name = "txtEIName"
        Me.txtEIName.Size = New System.Drawing.Size(123, 22)
        Me.txtEIName.TabIndex = 2
        '
        'lblEIType
        '
        Me.lblEIType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEIType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEIType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEIType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEIType.Location = New System.Drawing.Point(379, 26)
        Me.lblEIType.Name = "lblEIType"
        Me.lblEIType.Size = New System.Drawing.Size(123, 24)
        Me.lblEIType.TabIndex = 12
        Me.lblEIType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 269)
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
        Me.Label6.Location = New System.Drawing.Point(6, 239)
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
        Me.Label5.Location = New System.Drawing.Point(6, 183)
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
        Me.Label4.Location = New System.Drawing.Point(6, 155)
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
        Me.Label8.Location = New System.Drawing.Point(6, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Edit Invoice"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(341, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(452, 366)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblID.Location = New System.Drawing.Point(379, 58)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(123, 24)
        Me.lblID.TabIndex = 22
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Invoice ID Number:"
        '
        'InvoiceEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 401)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InvoiceEditForm"
        Me.Text = "Edit Invoice Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEIType As System.Windows.Forms.Label
    Friend WithEvents txtEIPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtEIEmployee As System.Windows.Forms.TextBox
    Friend WithEvents txtEIName As System.Windows.Forms.TextBox
    Friend WithEvents txtEIComplete As System.Windows.Forms.TextBox
    Friend WithEvents cmbEIMethod As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtEIWeek As System.Windows.Forms.TextBox
    Friend WithEvents lblEIWeek As System.Windows.Forms.Label
    Friend WithEvents txtEIPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblEIPaid As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
