<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cleaners
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_addcleaner = New System.Windows.Forms.Button()
        Me.btn_removecleaner = New System.Windows.Forms.Button()
        Me.JustTheJobDataSet = New WindowsApplication1.JustTheJobDataSet()
        Me.CleanersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CleanersTableAdapter = New WindowsApplication1.JustTheJobDataSetTableAdapters.CleanersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager()
        Me.CleanersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cleanerslastname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cleanerscity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cleanersemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cleanersaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cleanersphone2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cleanersphone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cleanersfirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CleanersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CleanersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(175, 59)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cleaners"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btn_addcleaner)
        Me.Panel1.Controls.Add(Me.btn_removecleaner)
        Me.Panel1.Location = New System.Drawing.Point(12, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 118)
        Me.Panel1.TabIndex = 5
        '
        'btn_addcleaner
        '
        Me.btn_addcleaner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addcleaner.Location = New System.Drawing.Point(3, 4)
        Me.btn_addcleaner.Name = "btn_addcleaner"
        Me.btn_addcleaner.Size = New System.Drawing.Size(161, 49)
        Me.btn_addcleaner.TabIndex = 0
        Me.btn_addcleaner.Text = "Add Cleaner"
        Me.btn_addcleaner.UseVisualStyleBackColor = True
        '
        'btn_removecleaner
        '
        Me.btn_removecleaner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removecleaner.Location = New System.Drawing.Point(4, 66)
        Me.btn_removecleaner.Name = "btn_removecleaner"
        Me.btn_removecleaner.Size = New System.Drawing.Size(161, 49)
        Me.btn_removecleaner.TabIndex = 2
        Me.btn_removecleaner.Text = "Remove Cleaner"
        Me.btn_removecleaner.UseVisualStyleBackColor = True
        '
        'JustTheJobDataSet
        '
        Me.JustTheJobDataSet.DataSetName = "JustTheJobDataSet"
        Me.JustTheJobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CleanersBindingSource
        '
        Me.CleanersBindingSource.DataMember = "Cleaners"
        Me.CleanersBindingSource.DataSource = Me.JustTheJobDataSet
        '
        'CleanersTableAdapter
        '
        Me.CleanersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CleanersTableAdapter = Me.CleanersTableAdapter
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CleanersDataGridView
        '
        Me.CleanersDataGridView.AllowUserToAddRows = False
        Me.CleanersDataGridView.AllowUserToDeleteRows = False
        Me.CleanersDataGridView.AllowUserToResizeColumns = False
        Me.CleanersDataGridView.AllowUserToResizeRows = False
        Me.CleanersDataGridView.AutoGenerateColumns = False
        Me.CleanersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CleanersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CleanersDataGridView.DataSource = Me.CleanersBindingSource
        Me.CleanersDataGridView.Location = New System.Drawing.Point(12, 208)
        Me.CleanersDataGridView.Name = "CleanersDataGridView"
        Me.CleanersDataGridView.ReadOnly = True
        Me.CleanersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CleanersDataGridView.Size = New System.Drawing.Size(843, 220)
        Me.CleanersDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cleanerLastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cleanerLastName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cleanerFirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cleanerFirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cleanerPhone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cleanerPhone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cleanerEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cleanerEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cleanerAddress"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cleanerAddress"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cleanerCity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cleanerCity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cleanerCellphone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cleanerCellphone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.txt_cleanerslastname)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_cleanerscity)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_cleanersemail)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_cleanersaddress)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_cleanersphone2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_cleanersphone)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_cleanersfirstname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(205, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 190)
        Me.Panel2.TabIndex = 14
        '
        'txt_cleanerslastname
        '
        Me.txt_cleanerslastname.Location = New System.Drawing.Point(121, 31)
        Me.txt_cleanerslastname.Name = "txt_cleanerslastname"
        Me.txt_cleanerslastname.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanerslastname.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Last Name"
        '
        'txt_cleanerscity
        '
        Me.txt_cleanerscity.Location = New System.Drawing.Point(121, 163)
        Me.txt_cleanerscity.Name = "txt_cleanerscity"
        Me.txt_cleanerscity.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanerscity.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "City"
        '
        'txt_cleanersemail
        '
        Me.txt_cleanersemail.Location = New System.Drawing.Point(121, 109)
        Me.txt_cleanersemail.Name = "txt_cleanersemail"
        Me.txt_cleanersemail.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanersemail.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email"
        '
        'txt_cleanersaddress
        '
        Me.txt_cleanersaddress.Location = New System.Drawing.Point(121, 137)
        Me.txt_cleanersaddress.Name = "txt_cleanersaddress"
        Me.txt_cleanersaddress.Size = New System.Drawing.Size(205, 20)
        Me.txt_cleanersaddress.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Address"
        '
        'txt_cleanersphone2
        '
        Me.txt_cleanersphone2.Location = New System.Drawing.Point(121, 83)
        Me.txt_cleanersphone2.Name = "txt_cleanersphone2"
        Me.txt_cleanersphone2.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanersphone2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cell Phone"
        '
        'txt_cleanersphone
        '
        Me.txt_cleanersphone.Location = New System.Drawing.Point(121, 57)
        Me.txt_cleanersphone.Name = "txt_cleanersphone"
        Me.txt_cleanersphone.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanersphone.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Home Phone"
        '
        'txt_cleanersfirstname
        '
        Me.txt_cleanersfirstname.Location = New System.Drawing.Point(121, 5)
        Me.txt_cleanersfirstname.Name = "txt_cleanersfirstname"
        Me.txt_cleanersfirstname.Size = New System.Drawing.Size(100, 20)
        Me.txt_cleanersfirstname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "First Name"
        '
        'Cleaners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(865, 438)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CleanersDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.BlueViolet
        Me.Name = "Cleaners"
        Me.Text = "Cleaners"
        Me.Panel1.ResumeLayout(False)
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CleanersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CleanersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btn_removecleaner As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_addcleaner As System.Windows.Forms.Button
    Friend WithEvents JustTheJobDataSet As WindowsApplication1.JustTheJobDataSet
    Friend WithEvents CleanersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CleanersTableAdapter As WindowsApplication1.JustTheJobDataSetTableAdapters.CleanersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CleanersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_cleanerslastname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanerscity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanersemail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanersaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanersphone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanersphone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cleanersfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
