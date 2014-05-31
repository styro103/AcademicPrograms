<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnGridView = New System.Windows.Forms.Button()
        Me.btnDetailView = New System.Windows.Forms.Button()
        Me.lblAirIndy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGridView
        '
        Me.btnGridView.Location = New System.Drawing.Point(51, 144)
        Me.btnGridView.Name = "btnGridView"
        Me.btnGridView.Size = New System.Drawing.Size(163, 23)
        Me.btnGridView.TabIndex = 0
        Me.btnGridView.Text = "Open Grid View"
        Me.btnGridView.UseVisualStyleBackColor = True
        '
        'btnDetailView
        '
        Me.btnDetailView.Location = New System.Drawing.Point(51, 198)
        Me.btnDetailView.Name = "btnDetailView"
        Me.btnDetailView.Size = New System.Drawing.Size(163, 23)
        Me.btnDetailView.TabIndex = 1
        Me.btnDetailView.Text = "Open Detail View"
        Me.btnDetailView.UseVisualStyleBackColor = True
        '
        'lblAirIndy
        '
        Me.lblAirIndy.AutoSize = True
        Me.lblAirIndy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirIndy.Location = New System.Drawing.Point(46, 49)
        Me.lblAirIndy.Name = "lblAirIndy"
        Me.lblAirIndy.Size = New System.Drawing.Size(199, 25)
        Me.lblAirIndy.TabIndex = 2
        Me.lblAirIndy.Text = "Air Indy Database"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAirIndy)
        Me.Controls.Add(Me.btnDetailView)
        Me.Controls.Add(Me.btnGridView)
        Me.Name = "MainForm"
        Me.Text = "Air Indy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGridView As System.Windows.Forms.Button
    Friend WithEvents btnDetailView As System.Windows.Forms.Button
    Friend WithEvents lblAirIndy As System.Windows.Forms.Label
End Class
