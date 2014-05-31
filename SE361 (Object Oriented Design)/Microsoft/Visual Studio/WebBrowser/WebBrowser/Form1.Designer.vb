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
        Me.btnGO = New System.Windows.Forms.Button()
        Me.txtCLEAR = New System.Windows.Forms.Button()
        Me.txtEXIT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wbrDisplay = New System.Windows.Forms.WebBrowser()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(106, 76)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(75, 23)
        Me.btnGO.TabIndex = 1
        Me.btnGO.Text = "Go"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'txtCLEAR
        '
        Me.txtCLEAR.Location = New System.Drawing.Point(221, 76)
        Me.txtCLEAR.Name = "txtCLEAR"
        Me.txtCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.txtCLEAR.TabIndex = 2
        Me.txtCLEAR.Text = "Clear"
        Me.txtCLEAR.UseVisualStyleBackColor = True
        '
        'txtEXIT
        '
        Me.txtEXIT.Location = New System.Drawing.Point(336, 76)
        Me.txtEXIT.Name = "txtEXIT"
        Me.txtEXIT.Size = New System.Drawing.Size(75, 23)
        Me.txtEXIT.TabIndex = 3
        Me.txtEXIT.Text = "Exit"
        Me.txtEXIT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "URL"
        '
        'wbrDisplay
        '
        Me.wbrDisplay.Location = New System.Drawing.Point(-5, 139)
        Me.wbrDisplay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrDisplay.Name = "wbrDisplay"
        Me.wbrDisplay.Size = New System.Drawing.Size(517, 420)
        Me.wbrDisplay.TabIndex = 5
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(95, 37)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(326, 20)
        Me.txtURL.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 559)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.wbrDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEXIT)
        Me.Controls.Add(Me.txtCLEAR)
        Me.Controls.Add(Me.btnGO)
        Me.Name = "Form1"
        Me.Text = "Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents txtCLEAR As System.Windows.Forms.Button
    Friend WithEvents txtEXIT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wbrDisplay As System.Windows.Forms.WebBrowser
    Friend WithEvents txtURL As System.Windows.Forms.TextBox

End Class
