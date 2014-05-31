<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Me.btnInvBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpOneTime = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblOTShow = New System.Windows.Forms.Label()
        Me.txtInvShow = New System.Windows.Forms.TextBox()
        Me.lblInvShow = New System.Windows.Forms.Label()
        Me.btnInv1TStatus = New System.Windows.Forms.Button()
        Me.btnInv1TShow = New System.Windows.Forms.Button()
        Me.btnNew1TInvoice = New System.Windows.Forms.Button()
        Me.gpRegular = New System.Windows.Forms.GroupBox()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.lblRShow = New System.Windows.Forms.Label()
        Me.txtInvRShow = New System.Windows.Forms.TextBox()
        Me.lblInvRShow = New System.Windows.Forms.Label()
        Me.btnInvStatus = New System.Windows.Forms.Button()
        Me.btnInvRShow = New System.Windows.Forms.Button()
        Me.btnNewRInvoice = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneTimeInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpOneTime.SuspendLayout()
        Me.gpRegular.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInvBack
        '
        Me.btnInvBack.Location = New System.Drawing.Point(555, 409)
        Me.btnInvBack.Name = "btnInvBack"
        Me.btnInvBack.Size = New System.Drawing.Size(96, 23)
        Me.btnInvBack.TabIndex = 3
        Me.btnInvBack.Text = "&Back"
        Me.btnInvBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Managing Invoices Form"
        '
        'gpOneTime
        '
        Me.gpOneTime.Controls.Add(Me.lblStatus)
        Me.gpOneTime.Controls.Add(Me.lblOTShow)
        Me.gpOneTime.Controls.Add(Me.txtInvShow)
        Me.gpOneTime.Controls.Add(Me.lblInvShow)
        Me.gpOneTime.Controls.Add(Me.btnInv1TStatus)
        Me.gpOneTime.Controls.Add(Me.btnInv1TShow)
        Me.gpOneTime.Controls.Add(Me.btnNew1TInvoice)
        Me.gpOneTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpOneTime.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gpOneTime.Location = New System.Drawing.Point(12, 79)
        Me.gpOneTime.Name = "gpOneTime"
        Me.gpOneTime.Size = New System.Drawing.Size(518, 183)
        Me.gpOneTime.TabIndex = 6
        Me.gpOneTime.TabStop = False
        Me.gpOneTime.Text = "One-Time Invoices:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(300, 145)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.Visible = False
        '
        'lblOTShow
        '
        Me.lblOTShow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOTShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOTShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOTShow.Location = New System.Drawing.Point(346, 139)
        Me.lblOTShow.Name = "lblOTShow"
        Me.lblOTShow.Size = New System.Drawing.Size(114, 26)
        Me.lblOTShow.TabIndex = 6
        Me.lblOTShow.Visible = False
        '
        'txtInvShow
        '
        Me.txtInvShow.Location = New System.Drawing.Point(346, 87)
        Me.txtInvShow.Name = "txtInvShow"
        Me.txtInvShow.Size = New System.Drawing.Size(142, 26)
        Me.txtInvShow.TabIndex = 5
        '
        'lblInvShow
        '
        Me.lblInvShow.AutoSize = True
        Me.lblInvShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInvShow.Location = New System.Drawing.Point(264, 95)
        Me.lblInvShow.Name = "lblInvShow"
        Me.lblInvShow.Size = New System.Drawing.Size(76, 13)
        Me.lblInvShow.TabIndex = 4
        Me.lblInvShow.Text = "Invoice Name:"
        '
        'btnInv1TStatus
        '
        Me.btnInv1TStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv1TStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInv1TStatus.Location = New System.Drawing.Point(16, 138)
        Me.btnInv1TStatus.Name = "btnInv1TStatus"
        Me.btnInv1TStatus.Size = New System.Drawing.Size(165, 26)
        Me.btnInv1TStatus.TabIndex = 3
        Me.btnInv1TStatus.Text = "Show Invoice Payment Status"
        Me.btnInv1TStatus.UseVisualStyleBackColor = True
        '
        'btnInv1TShow
        '
        Me.btnInv1TShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv1TShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInv1TShow.Location = New System.Drawing.Point(16, 88)
        Me.btnInv1TShow.Name = "btnInv1TShow"
        Me.btnInv1TShow.Size = New System.Drawing.Size(165, 26)
        Me.btnInv1TShow.TabIndex = 2
        Me.btnInv1TShow.Text = "Show Invoice"
        Me.btnInv1TShow.UseVisualStyleBackColor = True
        '
        'btnNew1TInvoice
        '
        Me.btnNew1TInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew1TInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNew1TInvoice.Location = New System.Drawing.Point(16, 40)
        Me.btnNew1TInvoice.Name = "btnNew1TInvoice"
        Me.btnNew1TInvoice.Size = New System.Drawing.Size(165, 26)
        Me.btnNew1TInvoice.TabIndex = 1
        Me.btnNew1TInvoice.Text = "Create Invoice"
        Me.btnNew1TInvoice.UseVisualStyleBackColor = True
        '
        'gpRegular
        '
        Me.gpRegular.Controls.Add(Me.lblStatus2)
        Me.gpRegular.Controls.Add(Me.lblRShow)
        Me.gpRegular.Controls.Add(Me.txtInvRShow)
        Me.gpRegular.Controls.Add(Me.lblInvRShow)
        Me.gpRegular.Controls.Add(Me.btnInvStatus)
        Me.gpRegular.Controls.Add(Me.btnInvRShow)
        Me.gpRegular.Controls.Add(Me.btnNewRInvoice)
        Me.gpRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpRegular.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gpRegular.Location = New System.Drawing.Point(12, 277)
        Me.gpRegular.Name = "gpRegular"
        Me.gpRegular.Size = New System.Drawing.Size(518, 183)
        Me.gpRegular.TabIndex = 7
        Me.gpRegular.TabStop = False
        Me.gpRegular.Text = "Regular Invoices:"
        '
        'lblStatus2
        '
        Me.lblStatus2.AutoSize = True
        Me.lblStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus2.Location = New System.Drawing.Point(300, 145)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus2.TabIndex = 8
        Me.lblStatus2.Text = "Status:"
        Me.lblStatus2.Visible = False
        '
        'lblRShow
        '
        Me.lblRShow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRShow.Location = New System.Drawing.Point(346, 139)
        Me.lblRShow.Name = "lblRShow"
        Me.lblRShow.Size = New System.Drawing.Size(114, 26)
        Me.lblRShow.TabIndex = 7
        Me.lblRShow.Visible = False
        '
        'txtInvRShow
        '
        Me.txtInvRShow.Location = New System.Drawing.Point(346, 87)
        Me.txtInvRShow.Name = "txtInvRShow"
        Me.txtInvRShow.Size = New System.Drawing.Size(142, 26)
        Me.txtInvRShow.TabIndex = 5
        '
        'lblInvRShow
        '
        Me.lblInvRShow.AutoSize = True
        Me.lblInvRShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvRShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInvRShow.Location = New System.Drawing.Point(264, 95)
        Me.lblInvRShow.Name = "lblInvRShow"
        Me.lblInvRShow.Size = New System.Drawing.Size(76, 13)
        Me.lblInvRShow.TabIndex = 4
        Me.lblInvRShow.Text = "Invoice Name:"
        '
        'btnInvStatus
        '
        Me.btnInvStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvStatus.Location = New System.Drawing.Point(16, 138)
        Me.btnInvStatus.Name = "btnInvStatus"
        Me.btnInvStatus.Size = New System.Drawing.Size(165, 26)
        Me.btnInvStatus.TabIndex = 3
        Me.btnInvStatus.Text = "Show Invoice Payment Status"
        Me.btnInvStatus.UseVisualStyleBackColor = True
        '
        'btnInvRShow
        '
        Me.btnInvRShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvRShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvRShow.Location = New System.Drawing.Point(16, 88)
        Me.btnInvRShow.Name = "btnInvRShow"
        Me.btnInvRShow.Size = New System.Drawing.Size(165, 26)
        Me.btnInvRShow.TabIndex = 2
        Me.btnInvRShow.Text = "Show Invoice"
        Me.btnInvRShow.UseVisualStyleBackColor = True
        '
        'btnNewRInvoice
        '
        Me.btnNewRInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewRInvoice.Location = New System.Drawing.Point(16, 40)
        Me.btnNewRInvoice.Name = "btnNewRInvoice"
        Me.btnNewRInvoice.Size = New System.Drawing.Size(165, 26)
        Me.btnNewRInvoice.TabIndex = 1
        Me.btnNewRInvoice.Text = "Create Invoice"
        Me.btnNewRInvoice.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHideToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OneTimeInvoicesToolStripMenuItem, Me.RegularInvoicesToolStripMenuItem})
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowHideToolStripMenuItem.Text = "Show/Hide"
        '
        'OneTimeInvoicesToolStripMenuItem
        '
        Me.OneTimeInvoicesToolStripMenuItem.Name = "OneTimeInvoicesToolStripMenuItem"
        Me.OneTimeInvoicesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OneTimeInvoicesToolStripMenuItem.Text = "One-Time Invoices"
        '
        'RegularInvoicesToolStripMenuItem
        '
        Me.RegularInvoicesToolStripMenuItem.Name = "RegularInvoicesToolStripMenuItem"
        Me.RegularInvoicesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RegularInvoicesToolStripMenuItem.Text = "Regular Invoices"
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 472)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gpRegular)
        Me.Controls.Add(Me.gpOneTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInvBack)
        Me.Name = "InvoiceForm"
        Me.Text = "Manage Invoice Form"
        Me.gpOneTime.ResumeLayout(False)
        Me.gpOneTime.PerformLayout()
        Me.gpRegular.ResumeLayout(False)
        Me.gpRegular.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInvBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpOneTime As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvShow As System.Windows.Forms.TextBox
    Friend WithEvents lblInvShow As System.Windows.Forms.Label
    Friend WithEvents btnInv1TStatus As System.Windows.Forms.Button
    Friend WithEvents btnInv1TShow As System.Windows.Forms.Button
    Friend WithEvents btnNew1TInvoice As System.Windows.Forms.Button
    Friend WithEvents gpRegular As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvRShow As System.Windows.Forms.TextBox
    Friend WithEvents lblInvRShow As System.Windows.Forms.Label
    Friend WithEvents btnInvStatus As System.Windows.Forms.Button
    Friend WithEvents btnInvRShow As System.Windows.Forms.Button
    Friend WithEvents btnNewRInvoice As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneTimeInvoicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegularInvoicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblOTShow As System.Windows.Forms.Label
    Friend WithEvents lblStatus2 As System.Windows.Forms.Label
    Friend WithEvents lblRShow As System.Windows.Forms.Label
End Class
