﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobForm
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
        Me.txtJobStatus = New System.Windows.Forms.TextBox()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnJobPending = New System.Windows.Forms.Button()
        Me.btnJobCompleted = New System.Windows.Forms.Button()
        Me.btnJobAll = New System.Windows.Forms.Button()
        Me.btnJobStatus = New System.Windows.Forms.Button()
        Me.btnJobEdit = New System.Windows.Forms.Button()
        Me.btnNewJob = New System.Windows.Forms.Button()
        Me.btnJobBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Job/Appointment Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJobStatus)
        Me.GroupBox1.Controls.Add(Me.lblJobStatus)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnJobStatus)
        Me.GroupBox1.Controls.Add(Me.btnJobEdit)
        Me.GroupBox1.Controls.Add(Me.btnNewJob)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 240)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What Would You Like to do?"
        '
        'txtJobStatus
        '
        Me.txtJobStatus.Location = New System.Drawing.Point(285, 191)
        Me.txtJobStatus.Name = "txtJobStatus"
        Me.txtJobStatus.Size = New System.Drawing.Size(174, 26)
        Me.txtJobStatus.TabIndex = 6
        Me.txtJobStatus.Text = " "
        Me.txtJobStatus.Visible = False
        '
        'lblJobStatus
        '
        Me.lblJobStatus.AutoSize = True
        Me.lblJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJobStatus.Location = New System.Drawing.Point(220, 199)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(58, 13)
        Me.lblJobStatus.TabIndex = 5
        Me.lblJobStatus.Text = "Job Name:"
        Me.lblJobStatus.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnJobPending)
        Me.GroupBox2.Controls.Add(Me.btnJobCompleted)
        Me.GroupBox2.Controls.Add(Me.btnJobAll)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(223, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 142)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job Lists"
        '
        'btnJobPending
        '
        Me.btnJobPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobPending.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobPending.Location = New System.Drawing.Point(33, 103)
        Me.btnJobPending.Name = "btnJobPending"
        Me.btnJobPending.Size = New System.Drawing.Size(165, 26)
        Me.btnJobPending.TabIndex = 5
        Me.btnJobPending.Text = "Display Pending Jobs"
        Me.btnJobPending.UseVisualStyleBackColor = True
        '
        'btnJobCompleted
        '
        Me.btnJobCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobCompleted.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobCompleted.Location = New System.Drawing.Point(33, 62)
        Me.btnJobCompleted.Name = "btnJobCompleted"
        Me.btnJobCompleted.Size = New System.Drawing.Size(165, 26)
        Me.btnJobCompleted.TabIndex = 4
        Me.btnJobCompleted.Text = "Display Completed Jobs"
        Me.btnJobCompleted.UseVisualStyleBackColor = True
        '
        'btnJobAll
        '
        Me.btnJobAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobAll.Location = New System.Drawing.Point(33, 21)
        Me.btnJobAll.Name = "btnJobAll"
        Me.btnJobAll.Size = New System.Drawing.Size(165, 26)
        Me.btnJobAll.TabIndex = 3
        Me.btnJobAll.Text = "Display All Jobs"
        Me.btnJobAll.UseVisualStyleBackColor = True
        '
        'btnJobStatus
        '
        Me.btnJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobStatus.Location = New System.Drawing.Point(18, 192)
        Me.btnJobStatus.Name = "btnJobStatus"
        Me.btnJobStatus.Size = New System.Drawing.Size(165, 26)
        Me.btnJobStatus.TabIndex = 2
        Me.btnJobStatus.Text = "Display Job Status"
        Me.btnJobStatus.UseVisualStyleBackColor = True
        '
        'btnJobEdit
        '
        Me.btnJobEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJobEdit.Location = New System.Drawing.Point(18, 95)
        Me.btnJobEdit.Name = "btnJobEdit"
        Me.btnJobEdit.Size = New System.Drawing.Size(165, 26)
        Me.btnJobEdit.TabIndex = 1
        Me.btnJobEdit.Text = "Edit Job Info"
        Me.btnJobEdit.UseVisualStyleBackColor = True
        '
        'btnNewJob
        '
        Me.btnNewJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewJob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewJob.Location = New System.Drawing.Point(18, 45)
        Me.btnNewJob.Name = "btnNewJob"
        Me.btnNewJob.Size = New System.Drawing.Size(165, 26)
        Me.btnNewJob.TabIndex = 0
        Me.btnNewJob.Text = "Add New Job"
        Me.btnNewJob.UseVisualStyleBackColor = True
        '
        'btnJobBack
        '
        Me.btnJobBack.Location = New System.Drawing.Point(511, 284)
        Me.btnJobBack.Name = "btnJobBack"
        Me.btnJobBack.Size = New System.Drawing.Size(103, 23)
        Me.btnJobBack.TabIndex = 5
        Me.btnJobBack.Text = "&Back"
        Me.btnJobBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip1.TabIndex = 9
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
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 326)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnJobBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JobForm"
        Me.Text = "Manage Job Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnJobStatus As System.Windows.Forms.Button
    Friend WithEvents btnJobEdit As System.Windows.Forms.Button
    Friend WithEvents btnNewJob As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnJobPending As System.Windows.Forms.Button
    Friend WithEvents btnJobCompleted As System.Windows.Forms.Button
    Friend WithEvents btnJobAll As System.Windows.Forms.Button
    Friend WithEvents btnJobBack As System.Windows.Forms.Button
    Friend WithEvents txtJobStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblJobStatus As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
