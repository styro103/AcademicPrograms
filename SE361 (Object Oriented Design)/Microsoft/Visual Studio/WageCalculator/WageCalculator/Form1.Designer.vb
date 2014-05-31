<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WageCalculator
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
        Me.lblHW = New System.Windows.Forms.Label()
        Me.txtHW = New System.Windows.Forms.TextBox()
        Me.lblHPR = New System.Windows.Forms.Label()
        Me.txtHPR = New System.Windows.Forms.TextBox()
        Me.lblGPE = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.btnCGP = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblGP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHW
        '
        Me.lblHW.AutoSize = True
        Me.lblHW.Location = New System.Drawing.Point(12, 37)
        Me.lblHW.Name = "lblHW"
        Me.lblHW.Size = New System.Drawing.Size(128, 13)
        Me.lblHW.TabIndex = 0
        Me.lblHW.Text = "Number of Hours Worked"
        '
        'txtHW
        '
        Me.txtHW.Location = New System.Drawing.Point(162, 34)
        Me.txtHW.Name = "txtHW"
        Me.txtHW.Size = New System.Drawing.Size(100, 20)
        Me.txtHW.TabIndex = 1
        '
        'lblHPR
        '
        Me.lblHPR.AutoSize = True
        Me.lblHPR.Location = New System.Drawing.Point(34, 94)
        Me.lblHPR.Name = "lblHPR"
        Me.lblHPR.Size = New System.Drawing.Size(84, 13)
        Me.lblHPR.TabIndex = 2
        Me.lblHPR.Text = "Hourly Pay Rate"
        '
        'txtHPR
        '
        Me.txtHPR.Location = New System.Drawing.Point(162, 91)
        Me.txtHPR.Name = "txtHPR"
        Me.txtHPR.Size = New System.Drawing.Size(100, 20)
        Me.txtHPR.TabIndex = 3
        '
        'lblGPE
        '
        Me.lblGPE.AutoSize = True
        Me.lblGPE.Location = New System.Drawing.Point(34, 153)
        Me.lblGPE.Name = "lblGPE"
        Me.lblGPE.Size = New System.Drawing.Size(92, 13)
        Me.lblGPE.TabIndex = 4
        Me.lblGPE.Text = "Gross Pay Earned"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(195, 153)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(0, 13)
        Me.lblP.TabIndex = 5
        '
        'btnCGP
        '
        Me.btnCGP.Location = New System.Drawing.Point(35, 197)
        Me.btnCGP.Name = "btnCGP"
        Me.btnCGP.Size = New System.Drawing.Size(83, 53)
        Me.btnCGP.TabIndex = 6
        Me.btnCGP.Text = "Calculate Gross Pay"
        Me.btnCGP.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(179, 197)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 53)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblGP
        '
        Me.lblGP.AutoSize = True
        Me.lblGP.Location = New System.Drawing.Point(195, 153)
        Me.lblGP.Name = "lblGP"
        Me.lblGP.Size = New System.Drawing.Size(28, 13)
        Me.lblGP.TabIndex = 8
        Me.lblGP.Text = "0.00"
        '
        'WageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblGP)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCGP)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.lblGPE)
        Me.Controls.Add(Me.txtHPR)
        Me.Controls.Add(Me.lblHPR)
        Me.Controls.Add(Me.txtHW)
        Me.Controls.Add(Me.lblHW)
        Me.Name = "WageCalculator"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHW As System.Windows.Forms.Label
    Friend WithEvents txtHW As System.Windows.Forms.TextBox
    Friend WithEvents lblHPR As System.Windows.Forms.Label
    Friend WithEvents txtHPR As System.Windows.Forms.TextBox
    Friend WithEvents lblGPE As System.Windows.Forms.Label
    Friend WithEvents lblP As System.Windows.Forms.Label
    Friend WithEvents btnCGP As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblGP As System.Windows.Forms.Label

End Class
