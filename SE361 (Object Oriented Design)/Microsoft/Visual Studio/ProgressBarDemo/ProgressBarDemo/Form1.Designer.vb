<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pbDemo = New System.Windows.Forms.ProgressBar()
        Me.btnFillUp = New System.Windows.Forms.Button()
        Me.btnEmpty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pbDemo
        '
        Me.pbDemo.Location = New System.Drawing.Point(35, 42)
        Me.pbDemo.Name = "pbDemo"
        Me.pbDemo.Size = New System.Drawing.Size(200, 23)
        Me.pbDemo.TabIndex = 0
        '
        'btnFillUp
        '
        Me.btnFillUp.Location = New System.Drawing.Point(35, 89)
        Me.btnFillUp.Name = "btnFillUp"
        Me.btnFillUp.Size = New System.Drawing.Size(75, 23)
        Me.btnFillUp.TabIndex = 1
        Me.btnFillUp.Text = "Fill Up"
        Me.btnFillUp.UseVisualStyleBackColor = True
        '
        'btnEmpty
        '
        Me.btnEmpty.Location = New System.Drawing.Point(141, 89)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpty.TabIndex = 2
        Me.btnEmpty.Text = "Empty"
        Me.btnEmpty.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 159)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.btnFillUp)
        Me.Controls.Add(Me.pbDemo)
        Me.Name = "Form1"
        Me.Text = "Progress Bar Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbDemo As System.Windows.Forms.ProgressBar
    Friend WithEvents btnFillUp As System.Windows.Forms.Button
    Friend WithEvents btnEmpty As System.Windows.Forms.Button

End Class
