<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Me.txt_clientscity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_clientsemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_clientsaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_clientsphone2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_clientsphone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_addclient = New System.Windows.Forms.Button()
        Me.btn_removeclient = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_clientslastname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_clientsfirstname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_addjobforclient = New System.Windows.Forms.Button()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JustTheJobDataSet = New WindowsApplication1.JustTheJobDataSet()
        Me.ClientsTableAdapter = New WindowsApplication1.JustTheJobDataSetTableAdapters.ClientsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager()
        Me.MyTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewer = New System.Windows.Forms.DataGridView()
        Me.ClientLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientCellphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_clientscity
        '
        Me.txt_clientscity.Location = New System.Drawing.Point(121, 163)
        Me.txt_clientscity.Name = "txt_clientscity"
        Me.txt_clientscity.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientscity.TabIndex = 6
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
        'txt_clientsemail
        '
        Me.txt_clientsemail.Location = New System.Drawing.Point(121, 109)
        Me.txt_clientsemail.Name = "txt_clientsemail"
        Me.txt_clientsemail.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientsemail.TabIndex = 4
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
        'txt_clientsaddress
        '
        Me.txt_clientsaddress.Location = New System.Drawing.Point(121, 137)
        Me.txt_clientsaddress.Name = "txt_clientsaddress"
        Me.txt_clientsaddress.Size = New System.Drawing.Size(205, 20)
        Me.txt_clientsaddress.TabIndex = 5
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
        'txt_clientsphone2
        '
        Me.txt_clientsphone2.Location = New System.Drawing.Point(121, 83)
        Me.txt_clientsphone2.Name = "txt_clientsphone2"
        Me.txt_clientsphone2.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientsphone2.TabIndex = 3
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
        'txt_clientsphone
        '
        Me.txt_clientsphone.Location = New System.Drawing.Point(121, 57)
        Me.txt_clientsphone.Name = "txt_clientsphone"
        Me.txt_clientsphone.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientsphone.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 59)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Clients"
        '
        'btn_addclient
        '
        Me.btn_addclient.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addclient.Location = New System.Drawing.Point(3, 4)
        Me.btn_addclient.Name = "btn_addclient"
        Me.btn_addclient.Size = New System.Drawing.Size(161, 49)
        Me.btn_addclient.TabIndex = 0
        Me.btn_addclient.Text = "Add Client"
        Me.btn_addclient.UseVisualStyleBackColor = True
        '
        'btn_removeclient
        '
        Me.btn_removeclient.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeclient.Location = New System.Drawing.Point(4, 66)
        Me.btn_removeclient.Name = "btn_removeclient"
        Me.btn_removeclient.Size = New System.Drawing.Size(161, 49)
        Me.btn_removeclient.TabIndex = 2
        Me.btn_removeclient.Text = "Remove Client"
        Me.btn_removeclient.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.txt_clientslastname)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_clientscity)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_clientsemail)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_clientsaddress)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_clientsphone2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_clientsphone)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_clientsfirstname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(204, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 194)
        Me.Panel2.TabIndex = 13
        '
        'txt_clientslastname
        '
        Me.txt_clientslastname.Location = New System.Drawing.Point(121, 31)
        Me.txt_clientslastname.Name = "txt_clientslastname"
        Me.txt_clientslastname.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientslastname.TabIndex = 2
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
        'txt_clientsfirstname
        '
        Me.txt_clientsfirstname.Location = New System.Drawing.Point(121, 5)
        Me.txt_clientsfirstname.Name = "txt_clientsfirstname"
        Me.txt_clientsfirstname.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientsfirstname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btn_addclient)
        Me.Panel1.Controls.Add(Me.btn_removeclient)
        Me.Panel1.Location = New System.Drawing.Point(13, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 121)
        Me.Panel1.TabIndex = 11
        '
        'btn_addjobforclient
        '
        Me.btn_addjobforclient.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addjobforclient.Location = New System.Drawing.Point(628, 175)
        Me.btn_addjobforclient.Name = "btn_addjobforclient"
        Me.btn_addjobforclient.Size = New System.Drawing.Size(242, 31)
        Me.btn_addjobforclient.TabIndex = 14
        Me.btn_addjobforclient.Text = "Add Job for Client"
        Me.btn_addjobforclient.UseVisualStyleBackColor = True
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.JustTheJobDataSet
        '
        'JustTheJobDataSet
        '
        Me.JustTheJobDataSet.DataSetName = "JustTheJobDataSet"
        Me.JustTheJobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CleanersTableAdapter = Nothing
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MyTabControl
        '
        Me.MyTabControl.Controls.Add(Me.TabPage1)
        Me.MyTabControl.Controls.Add(Me.TabPage2)
        Me.MyTabControl.Location = New System.Drawing.Point(12, 218)
        Me.MyTabControl.Name = "MyTabControl"
        Me.MyTabControl.SelectedIndex = 0
        Me.MyTabControl.Size = New System.Drawing.Size(858, 242)
        Me.MyTabControl.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.DataGridViewer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(850, 216)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "All Clients"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(850, 216)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Premium Clients"
        '
        'DataGridViewer
        '
        Me.DataGridViewer.AllowUserToAddRows = False
        Me.DataGridViewer.AllowUserToDeleteRows = False
        Me.DataGridViewer.AllowUserToResizeColumns = False
        Me.DataGridViewer.AllowUserToResizeRows = False
        Me.DataGridViewer.AutoGenerateColumns = False
        Me.DataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientLastNameDataGridViewTextBoxColumn, Me.ClientFirstNameDataGridViewTextBoxColumn, Me.ClientPhoneDataGridViewTextBoxColumn, Me.ClientEmailDataGridViewTextBoxColumn, Me.ClientAddressDataGridViewTextBoxColumn, Me.ClientCityDataGridViewTextBoxColumn, Me.ClientCellphoneDataGridViewTextBoxColumn})
        Me.DataGridViewer.DataSource = Me.ClientsBindingSource
        Me.DataGridViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewer.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewer.Name = "DataGridViewer"
        Me.DataGridViewer.ReadOnly = True
        Me.DataGridViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewer.Size = New System.Drawing.Size(844, 210)
        Me.DataGridViewer.TabIndex = 16
        '
        'ClientLastNameDataGridViewTextBoxColumn
        '
        Me.ClientLastNameDataGridViewTextBoxColumn.DataPropertyName = "clientLastName"
        Me.ClientLastNameDataGridViewTextBoxColumn.HeaderText = "clientLastName"
        Me.ClientLastNameDataGridViewTextBoxColumn.Name = "ClientLastNameDataGridViewTextBoxColumn"
        Me.ClientLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientFirstNameDataGridViewTextBoxColumn
        '
        Me.ClientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "clientFirstName"
        Me.ClientFirstNameDataGridViewTextBoxColumn.HeaderText = "clientFirstName"
        Me.ClientFirstNameDataGridViewTextBoxColumn.Name = "ClientFirstNameDataGridViewTextBoxColumn"
        Me.ClientFirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientPhoneDataGridViewTextBoxColumn
        '
        Me.ClientPhoneDataGridViewTextBoxColumn.DataPropertyName = "clientPhone"
        Me.ClientPhoneDataGridViewTextBoxColumn.HeaderText = "clientPhone"
        Me.ClientPhoneDataGridViewTextBoxColumn.Name = "ClientPhoneDataGridViewTextBoxColumn"
        Me.ClientPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientEmailDataGridViewTextBoxColumn
        '
        Me.ClientEmailDataGridViewTextBoxColumn.DataPropertyName = "clientEmail"
        Me.ClientEmailDataGridViewTextBoxColumn.HeaderText = "clientEmail"
        Me.ClientEmailDataGridViewTextBoxColumn.Name = "ClientEmailDataGridViewTextBoxColumn"
        Me.ClientEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientAddressDataGridViewTextBoxColumn
        '
        Me.ClientAddressDataGridViewTextBoxColumn.DataPropertyName = "clientAddress"
        Me.ClientAddressDataGridViewTextBoxColumn.HeaderText = "clientAddress"
        Me.ClientAddressDataGridViewTextBoxColumn.Name = "ClientAddressDataGridViewTextBoxColumn"
        Me.ClientAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClientAddressDataGridViewTextBoxColumn.Width = 200
        '
        'ClientCityDataGridViewTextBoxColumn
        '
        Me.ClientCityDataGridViewTextBoxColumn.DataPropertyName = "clientCity"
        Me.ClientCityDataGridViewTextBoxColumn.HeaderText = "clientCity"
        Me.ClientCityDataGridViewTextBoxColumn.Name = "ClientCityDataGridViewTextBoxColumn"
        Me.ClientCityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientCellphoneDataGridViewTextBoxColumn
        '
        Me.ClientCellphoneDataGridViewTextBoxColumn.DataPropertyName = "clientCellphone"
        Me.ClientCellphoneDataGridViewTextBoxColumn.HeaderText = "clientCellphone"
        Me.ClientCellphoneDataGridViewTextBoxColumn.Name = "ClientCellphoneDataGridViewTextBoxColumn"
        Me.ClientCellphoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(844, 210)
        Me.DataGridView1.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "clientLastName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "clientLastName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "clientFirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "clientFirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "clientPhone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "clientPhone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "clientEmail"
        Me.DataGridViewTextBoxColumn4.HeaderText = "clientEmail"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "clientAddress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "clientAddress"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "clientCity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "clientCity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "clientCellphone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "clientCellphone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(884, 472)
        Me.Controls.Add(Me.MyTabControl)
        Me.Controls.Add(Me.btn_addjobforclient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.BlueViolet
        Me.Name = "Clients"
        Me.Text = "Clients"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JustTheJobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_clientscity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_clientsemail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_clientsaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_clientsphone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_clientsphone As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_addclient As System.Windows.Forms.Button
    Public WithEvents btn_removeclient As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_clientsfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btn_addjobforclient As System.Windows.Forms.Button
    Friend WithEvents JustTheJobDataSet As WindowsApplication1.JustTheJobDataSet
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As WindowsApplication1.JustTheJobDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents txt_clientslastname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As WindowsApplication1.JustTheJobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MyTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewer As System.Windows.Forms.DataGridView
    Friend WithEvents ClientLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientCellphoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
