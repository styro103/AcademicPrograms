<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_paymentAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_paymentLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_paymentFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_paymentID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_addpayment = New System.Windows.Forms.Button()
        Me.btn_removepayment = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JustTheJobDataSet = New WindowsApplication1.JustTheJobDataSet()
        Me.JustTheJobDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New WindowsApplication1.JustTheJobDataSetTableAdapters.PaymentsTableAdapter()
        Me.PaymentFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentInvoiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JustTheJobDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 59)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Payments"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.PaymentDatePicker)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_paymentAmount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_paymentLastname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_paymentFirstname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_paymentID)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(186, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 163)
        Me.Panel2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Date"
        '
        'txt_paymentAmount
        '
        Me.txt_paymentAmount.Location = New System.Drawing.Point(121, 80)
        Me.txt_paymentAmount.Name = "txt_paymentAmount"
        Me.txt_paymentAmount.Size = New System.Drawing.Size(100, 20)
        Me.txt_paymentAmount.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Amount"
        '
        'txt_paymentLastname
        '
        Me.txt_paymentLastname.Location = New System.Drawing.Point(121, 57)
        Me.txt_paymentLastname.Name = "txt_paymentLastname"
        Me.txt_paymentLastname.Size = New System.Drawing.Size(100, 20)
        Me.txt_paymentLastname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Last Name"
        '
        'txt_paymentFirstname
        '
        Me.txt_paymentFirstname.Location = New System.Drawing.Point(121, 31)
        Me.txt_paymentFirstname.Name = "txt_paymentFirstname"
        Me.txt_paymentFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txt_paymentFirstname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "First Name"
        '
        'txt_paymentID
        '
        Me.txt_paymentID.Location = New System.Drawing.Point(121, 5)
        Me.txt_paymentID.Name = "txt_paymentID"
        Me.txt_paymentID.Size = New System.Drawing.Size(100, 20)
        Me.txt_paymentID.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Invoice ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.btn_addpayment)
        Me.Panel3.Controls.Add(Me.btn_removepayment)
        Me.Panel3.Location = New System.Drawing.Point(12, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 118)
        Me.Panel3.TabIndex = 20
        '
        'btn_addpayment
        '
        Me.btn_addpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addpayment.Location = New System.Drawing.Point(3, 4)
        Me.btn_addpayment.Name = "btn_addpayment"
        Me.btn_addpayment.Size = New System.Drawing.Size(161, 49)
        Me.btn_addpayment.TabIndex = 0
        Me.btn_addpayment.Text = "Add Payment"
        Me.btn_addpayment.UseVisualStyleBackColor = True
        '
        'btn_removepayment
        '
        Me.btn_removepayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removepayment.Location = New System.Drawing.Point(4, 66)
        Me.btn_removepayment.Name = "btn_removepayment"
        Me.btn_removepayment.Size = New System.Drawing.Size(161, 49)
        Me.btn_removepayment.TabIndex = 2
        Me.btn_removepayment.Text = "Remove Payment"
        Me.btn_removepayment.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentFirstnameDataGridViewTextBoxColumn, Me.PaymentLastnameDataGridViewTextBoxColumn, Me.PaymentInvoiceIDDataGridViewTextBoxColumn, Me.PaymentAmountDataGridViewTextBoxColumn, Me.paymentDate})
        Me.DataGridView1.DataSource = Me.PaymentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(544, 174)
        Me.DataGridView1.TabIndex = 23
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.JustTheJobDataSet
        '
        'JustTheJobDataSet
        '
        Me.JustTheJobDataSet.DataSetName = "JustTheJobDataSet"
        Me.JustTheJobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JustTheJobDataSetBindingSource
        '
        Me.JustTheJobDataSetBindingSource.DataSource = Me.JustTheJobDataSet
        Me.JustTheJobDataSetBindingSource.Position = 0
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'PaymentFirstnameDataGridViewTextBoxColumn
        '
        Me.PaymentFirstnameDataGridViewTextBoxColumn.DataPropertyName = "paymentFirstname"
        Me.PaymentFirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.PaymentFirstnameDataGridViewTextBoxColumn.Name = "PaymentFirstnameDataGridViewTextBoxColumn"
        Me.PaymentFirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentLastnameDataGridViewTextBoxColumn
        '
        Me.PaymentLastnameDataGridViewTextBoxColumn.DataPropertyName = "paymentLastname"
        Me.PaymentLastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.PaymentLastnameDataGridViewTextBoxColumn.Name = "PaymentLastnameDataGridViewTextBoxColumn"
        Me.PaymentLastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentInvoiceIDDataGridViewTextBoxColumn
        '
        Me.PaymentInvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "paymentInvoiceID"
        Me.PaymentInvoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice ID"
        Me.PaymentInvoiceIDDataGridViewTextBoxColumn.Name = "PaymentInvoiceIDDataGridViewTextBoxColumn"
        Me.PaymentInvoiceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentAmountDataGridViewTextBoxColumn
        '
        Me.PaymentAmountDataGridViewTextBoxColumn.DataPropertyName = "paymentAmount"
        Me.PaymentAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.PaymentAmountDataGridViewTextBoxColumn.Name = "PaymentAmountDataGridViewTextBoxColumn"
        Me.PaymentAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'paymentDate
        '
        Me.paymentDate.DataPropertyName = "paymentDate"
        Me.paymentDate.HeaderText = "Date"
        Me.paymentDate.Name = "paymentDate"
        Me.paymentDate.ReadOnly = True
        '
        'PaymentDatePicker
        '
        Me.PaymentDatePicker.Location = New System.Drawing.Point(121, 106)
        Me.PaymentDatePicker.Name = "PaymentDatePicker"
        Me.PaymentDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.PaymentDatePicker.TabIndex = 21
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(572, 446)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.BlueViolet
        Me.Name = "Payments"
        Me.Text = "Payments"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JustTheJobDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_paymentAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_paymentLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_paymentFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_paymentID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_addpayment As System.Windows.Forms.Button
    Public WithEvents btn_removepayment As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents JustTheJobDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JustTheJobDataSet As WindowsApplication1.JustTheJobDataSet
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentsTableAdapter As WindowsApplication1.JustTheJobDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents PaymentFirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentLastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentInvoiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDatePicker As System.Windows.Forms.DateTimePicker
End Class
