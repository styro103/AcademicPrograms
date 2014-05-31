<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices
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
        Me.txt_invoiceID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_InvoiceBalance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_invoicedate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_addinvoice = New System.Windows.Forms.Button()
        Me.btn_removeinvoice = New System.Windows.Forms.Button()
        Me.JustTheJobDataSet = New WindowsApplication1.JustTheJobDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New WindowsApplication1.JustTheJobDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager()
        Me.InvoicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.invoiceJobID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.invoiceRegular = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MyTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(174, 59)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Invoices"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.txt_invoiceID)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_InvoiceBalance)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_invoicedate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(200, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 115)
        Me.Panel2.TabIndex = 14
        '
        'txt_invoiceID
        '
        Me.txt_invoiceID.Location = New System.Drawing.Point(119, 43)
        Me.txt_invoiceID.Name = "txt_invoiceID"
        Me.txt_invoiceID.Size = New System.Drawing.Size(100, 20)
        Me.txt_invoiceID.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Job ID"
        '
        'txt_InvoiceBalance
        '
        Me.txt_InvoiceBalance.Location = New System.Drawing.Point(119, 69)
        Me.txt_InvoiceBalance.Name = "txt_InvoiceBalance"
        Me.txt_InvoiceBalance.Size = New System.Drawing.Size(100, 20)
        Me.txt_InvoiceBalance.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Remaining"
        '
        'txt_invoicedate
        '
        Me.txt_invoicedate.Location = New System.Drawing.Point(119, 17)
        Me.txt_invoicedate.Name = "txt_invoicedate"
        Me.txt_invoicedate.Size = New System.Drawing.Size(100, 20)
        Me.txt_invoicedate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Miramonte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button5.Location = New System.Drawing.Point(12, 449)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(532, 33)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Create Payment"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.btn_addinvoice)
        Me.Panel3.Controls.Add(Me.btn_removeinvoice)
        Me.Panel3.Location = New System.Drawing.Point(12, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 118)
        Me.Panel3.TabIndex = 15
        '
        'btn_addinvoice
        '
        Me.btn_addinvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addinvoice.Location = New System.Drawing.Point(3, 4)
        Me.btn_addinvoice.Name = "btn_addinvoice"
        Me.btn_addinvoice.Size = New System.Drawing.Size(161, 49)
        Me.btn_addinvoice.TabIndex = 0
        Me.btn_addinvoice.Text = "Add Invoice"
        Me.btn_addinvoice.UseVisualStyleBackColor = True
        '
        'btn_removeinvoice
        '
        Me.btn_removeinvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeinvoice.Location = New System.Drawing.Point(4, 66)
        Me.btn_removeinvoice.Name = "btn_removeinvoice"
        Me.btn_removeinvoice.Size = New System.Drawing.Size(161, 49)
        Me.btn_removeinvoice.TabIndex = 2
        Me.btn_removeinvoice.Text = "Remove Invoice"
        Me.btn_removeinvoice.UseVisualStyleBackColor = True
        '
        'JustTheJobDataSet
        '
        Me.JustTheJobDataSet.DataSetName = "JustTheJobDataSet"
        Me.JustTheJobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.JustTheJobDataSet
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CleanersTableAdapter = Nothing
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.JobsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoicesDataGridView
        '
        Me.InvoicesDataGridView.AllowUserToAddRows = False
        Me.InvoicesDataGridView.AllowUserToDeleteRows = False
        Me.InvoicesDataGridView.AllowUserToResizeColumns = False
        Me.InvoicesDataGridView.AllowUserToResizeRows = False
        Me.InvoicesDataGridView.AutoGenerateColumns = False
        Me.InvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceJobID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.invoiceRegular})
        Me.InvoicesDataGridView.DataSource = Me.InvoicesBindingSource
        Me.InvoicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoicesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.InvoicesDataGridView.Name = "InvoicesDataGridView"
        Me.InvoicesDataGridView.ReadOnly = True
        Me.InvoicesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.InvoicesDataGridView.Size = New System.Drawing.Size(518, 189)
        Me.InvoicesDataGridView.TabIndex = 16
        '
        'invoiceJobID
        '
        Me.invoiceJobID.DataPropertyName = "invoiceJobID"
        Me.invoiceJobID.HeaderText = "Job ID"
        Me.invoiceJobID.Name = "invoiceJobID"
        Me.invoiceJobID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "invoiceDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Invoice Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "invoiceToPay"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Payment Remaining"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "invoiceStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Paid?"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 75
        '
        'invoiceRegular
        '
        Me.invoiceRegular.DataPropertyName = "invoiceRegular"
        Me.invoiceRegular.HeaderText = "Recurring?"
        Me.invoiceRegular.Name = "invoiceRegular"
        Me.invoiceRegular.ReadOnly = True
        Me.invoiceRegular.Width = 75
        '
        'MyTabControl
        '
        Me.MyTabControl.Controls.Add(Me.TabPage1)
        Me.MyTabControl.Controls.Add(Me.TabPage2)
        Me.MyTabControl.Location = New System.Drawing.Point(12, 222)
        Me.MyTabControl.Name = "MyTabControl"
        Me.MyTabControl.SelectedIndex = 0
        Me.MyTabControl.Size = New System.Drawing.Size(532, 221)
        Me.MyTabControl.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.InvoicesDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(524, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "All Invoices"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(524, 195)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pending Invoices"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.DataGridView1.DataSource = Me.InvoicesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(518, 189)
        Me.DataGridView1.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "invoiceJobID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Job ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "invoiceDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Invoice Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "invoiceToPay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Payment Remaining"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "invoiceStatus"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Paid?"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 75
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "invoiceRegular"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Recurring?"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Width = 75
        '
        'Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(557, 493)
        Me.Controls.Add(Me.MyTabControl)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.BlueViolet
        Me.Name = "Invoices"
        Me.Text = "Invoices"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_invoiceID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_InvoiceBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_invoicedate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_addinvoice As System.Windows.Forms.Button
    Public WithEvents btn_removeinvoice As System.Windows.Forms.Button
    Friend WithEvents JustTheJobDataSet As WindowsApplication1.JustTheJobDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As WindowsApplication1.JustTheJobDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoicesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents invoiceJobID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents invoiceRegular As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MyTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
