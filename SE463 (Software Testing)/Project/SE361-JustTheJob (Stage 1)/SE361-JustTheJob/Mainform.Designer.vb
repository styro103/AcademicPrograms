<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnInvoices = New System.Windows.Forms.Button()
        Me.btnJobs = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Just-the-Job's Automated Solutions Center"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSchedule)
        Me.GroupBox1.Controls.Add(Me.btnPayments)
        Me.GroupBox1.Controls.Add(Me.btnInvoices)
        Me.GroupBox1.Controls.Add(Me.btnJobs)
        Me.GroupBox1.Controls.Add(Me.btnEmployees)
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 275)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What Would You Like To Do?"
        '
        'btnSchedule
        '
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSchedule.Location = New System.Drawing.Point(298, 51)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(119, 48)
        Me.btnSchedule.TabIndex = 5
        Me.btnSchedule.Text = "Manager's Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPayments.Location = New System.Drawing.Point(298, 180)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(119, 48)
        Me.btnPayments.TabIndex = 4
        Me.btnPayments.Text = "Manage Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnInvoices
        '
        Me.btnInvoices.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvoices.Location = New System.Drawing.Point(298, 116)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(119, 48)
        Me.btnInvoices.TabIndex = 3
        Me.btnInvoices.Text = "Manage Invoices"
        Me.btnInvoices.UseVisualStyleBackColor = True
        '
        'btnJobs
        '
        Me.btnJobs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobs.Location = New System.Drawing.Point(30, 180)
        Me.btnJobs.Name = "btnJobs"
        Me.btnJobs.Size = New System.Drawing.Size(119, 51)
        Me.btnJobs.TabIndex = 2
        Me.btnJobs.Text = "Manage Jobs"
        Me.btnJobs.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmployees.Location = New System.Drawing.Point(30, 116)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(119, 48)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Manage Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustomer.Location = New System.Drawing.Point(30, 51)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(119, 48)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Manage Customers"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(519, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.BackToolStripMenuItem.Text = "E&xit"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 378)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mainform"
        Me.Text = "Just-The-Job Automations"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnInvoices As System.Windows.Forms.Button
    Friend WithEvents btnJobs As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
