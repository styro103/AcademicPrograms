<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleGeometryApplication
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
        Me.gbSS = New System.Windows.Forms.GroupBox()
        Me.rdbCircle = New System.Windows.Forms.RadioButton()
        Me.rdbRectangle = New System.Windows.Forms.RadioButton()
        Me.rdbSquare = New System.Windows.Forms.RadioButton()
        Me.gbInputSides = New System.Windows.Forms.GroupBox()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.txtSide2 = New System.Windows.Forms.TextBox()
        Me.lblSide2 = New System.Windows.Forms.Label()
        Me.txtSide1 = New System.Windows.Forms.TextBox()
        Me.lblSide1 = New System.Windows.Forms.Label()
        Me.gbOutputData = New System.Windows.Forms.GroupBox()
        Me.lblCirumferenceOut = New System.Windows.Forms.Label()
        Me.lblCircumference = New System.Windows.Forms.Label()
        Me.lblPerimeterOut = New System.Windows.Forms.Label()
        Me.lblAreaOut = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCircumference = New System.Windows.Forms.CheckBox()
        Me.cbPerimeter = New System.Windows.Forms.CheckBox()
        Me.cbArea = New System.Windows.Forms.CheckBox()
        Me.gbSS.SuspendLayout()
        Me.gbInputSides.SuspendLayout()
        Me.gbOutputData.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSS
        '
        Me.gbSS.Controls.Add(Me.rdbCircle)
        Me.gbSS.Controls.Add(Me.rdbRectangle)
        Me.gbSS.Controls.Add(Me.rdbSquare)
        Me.gbSS.Location = New System.Drawing.Point(21, 28)
        Me.gbSS.Name = "gbSS"
        Me.gbSS.Size = New System.Drawing.Size(114, 173)
        Me.gbSS.TabIndex = 0
        Me.gbSS.TabStop = False
        Me.gbSS.Text = "Select Shape"
        '
        'rdbCircle
        '
        Me.rdbCircle.AutoSize = True
        Me.rdbCircle.Location = New System.Drawing.Point(23, 124)
        Me.rdbCircle.Name = "rdbCircle"
        Me.rdbCircle.Size = New System.Drawing.Size(51, 17)
        Me.rdbCircle.TabIndex = 6
        Me.rdbCircle.TabStop = True
        Me.rdbCircle.Text = "Circle"
        Me.rdbCircle.UseVisualStyleBackColor = True
        '
        'rdbRectangle
        '
        Me.rdbRectangle.AutoSize = True
        Me.rdbRectangle.Location = New System.Drawing.Point(23, 81)
        Me.rdbRectangle.Name = "rdbRectangle"
        Me.rdbRectangle.Size = New System.Drawing.Size(74, 17)
        Me.rdbRectangle.TabIndex = 2
        Me.rdbRectangle.TabStop = True
        Me.rdbRectangle.Text = "Rectangle"
        Me.rdbRectangle.UseVisualStyleBackColor = True
        '
        'rdbSquare
        '
        Me.rdbSquare.AutoSize = True
        Me.rdbSquare.Location = New System.Drawing.Point(23, 38)
        Me.rdbSquare.Name = "rdbSquare"
        Me.rdbSquare.Size = New System.Drawing.Size(59, 17)
        Me.rdbSquare.TabIndex = 1
        Me.rdbSquare.TabStop = True
        Me.rdbSquare.Text = "Square"
        Me.rdbSquare.UseVisualStyleBackColor = True
        '
        'gbInputSides
        '
        Me.gbInputSides.Controls.Add(Me.txtRadius)
        Me.gbInputSides.Controls.Add(Me.lblRadius)
        Me.gbInputSides.Controls.Add(Me.txtSide2)
        Me.gbInputSides.Controls.Add(Me.lblSide2)
        Me.gbInputSides.Controls.Add(Me.txtSide1)
        Me.gbInputSides.Controls.Add(Me.lblSide1)
        Me.gbInputSides.Location = New System.Drawing.Point(175, 28)
        Me.gbInputSides.Name = "gbInputSides"
        Me.gbInputSides.Size = New System.Drawing.Size(124, 173)
        Me.gbInputSides.TabIndex = 1
        Me.gbInputSides.TabStop = False
        Me.gbInputSides.Text = "Input Data"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(18, 131)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 4
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(16, 115)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(71, 13)
        Me.lblRadius.TabIndex = 3
        Me.lblRadius.Text = "Enter Radius:"
        '
        'txtSide2
        '
        Me.txtSide2.Location = New System.Drawing.Point(18, 89)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(100, 20)
        Me.txtSide2.TabIndex = 2
        '
        'lblSide2
        '
        Me.lblSide2.AutoSize = True
        Me.lblSide2.Location = New System.Drawing.Point(16, 68)
        Me.lblSide2.Name = "lblSide2"
        Me.lblSide2.Size = New System.Drawing.Size(68, 13)
        Me.lblSide2.TabIndex = 2
        Me.lblSide2.Text = "Enter Side 2:"
        '
        'txtSide1
        '
        Me.txtSide1.Location = New System.Drawing.Point(18, 45)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(99, 20)
        Me.txtSide1.TabIndex = 2
        '
        'lblSide1
        '
        Me.lblSide1.AutoSize = True
        Me.lblSide1.Location = New System.Drawing.Point(16, 24)
        Me.lblSide1.Name = "lblSide1"
        Me.lblSide1.Size = New System.Drawing.Size(68, 13)
        Me.lblSide1.TabIndex = 0
        Me.lblSide1.Text = "Enter Side 1:"
        '
        'gbOutputData
        '
        Me.gbOutputData.Controls.Add(Me.lblCirumferenceOut)
        Me.gbOutputData.Controls.Add(Me.lblCircumference)
        Me.gbOutputData.Controls.Add(Me.lblPerimeterOut)
        Me.gbOutputData.Controls.Add(Me.lblAreaOut)
        Me.gbOutputData.Controls.Add(Me.lblPerimeter)
        Me.gbOutputData.Controls.Add(Me.lblArea)
        Me.gbOutputData.Location = New System.Drawing.Point(21, 228)
        Me.gbOutputData.Name = "gbOutputData"
        Me.gbOutputData.Size = New System.Drawing.Size(224, 173)
        Me.gbOutputData.TabIndex = 2
        Me.gbOutputData.TabStop = False
        Me.gbOutputData.Text = "Output Data"
        '
        'lblCirumferenceOut
        '
        Me.lblCirumferenceOut.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.lblCirumferenceOut.Location = New System.Drawing.Point(90, 127)
        Me.lblCirumferenceOut.Name = "lblCirumferenceOut"
        Me.lblCirumferenceOut.Size = New System.Drawing.Size(130, 20)
        Me.lblCirumferenceOut.TabIndex = 6
        '
        'lblCircumference
        '
        Me.lblCircumference.AutoSize = True
        Me.lblCircumference.Location = New System.Drawing.Point(6, 133)
        Me.lblCircumference.Name = "lblCircumference"
        Me.lblCircumference.Size = New System.Drawing.Size(78, 13)
        Me.lblCircumference.TabIndex = 5
        Me.lblCircumference.Text = "Circumference:"
        '
        'lblPerimeterOut
        '
        Me.lblPerimeterOut.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.lblPerimeterOut.Location = New System.Drawing.Point(88, 81)
        Me.lblPerimeterOut.Name = "lblPerimeterOut"
        Me.lblPerimeterOut.Size = New System.Drawing.Size(130, 20)
        Me.lblPerimeterOut.TabIndex = 4
        '
        'lblAreaOut
        '
        Me.lblAreaOut.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.lblAreaOut.Location = New System.Drawing.Point(88, 35)
        Me.lblAreaOut.Name = "lblAreaOut"
        Me.lblAreaOut.Size = New System.Drawing.Size(130, 20)
        Me.lblAreaOut.TabIndex = 3
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(16, 84)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(54, 13)
        Me.lblPerimeter.TabIndex = 2
        Me.lblPerimeter.Text = "Perimeter:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(28, 35)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Area:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(312, 239)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(312, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(312, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCircumference)
        Me.GroupBox2.Controls.Add(Me.cbPerimeter)
        Me.GroupBox2.Controls.Add(Me.cbArea)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 172)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Output(s)"
        '
        'cbCircumference
        '
        Me.cbCircumference.AutoSize = True
        Me.cbCircumference.Location = New System.Drawing.Point(23, 123)
        Me.cbCircumference.Name = "cbCircumference"
        Me.cbCircumference.Size = New System.Drawing.Size(94, 17)
        Me.cbCircumference.TabIndex = 2
        Me.cbCircumference.Text = "Circumference"
        Me.cbCircumference.UseVisualStyleBackColor = True
        '
        'cbPerimeter
        '
        Me.cbPerimeter.AutoSize = True
        Me.cbPerimeter.Location = New System.Drawing.Point(23, 80)
        Me.cbPerimeter.Name = "cbPerimeter"
        Me.cbPerimeter.Size = New System.Drawing.Size(70, 17)
        Me.cbPerimeter.TabIndex = 1
        Me.cbPerimeter.Text = "Perimeter"
        Me.cbPerimeter.UseVisualStyleBackColor = True
        '
        'cbArea
        '
        Me.cbArea.AutoSize = True
        Me.cbArea.Location = New System.Drawing.Point(23, 34)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(48, 17)
        Me.cbArea.TabIndex = 0
        Me.cbArea.Text = "Area"
        Me.cbArea.UseVisualStyleBackColor = True
        '
        'SimpleGeometryApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbOutputData)
        Me.Controls.Add(Me.gbInputSides)
        Me.Controls.Add(Me.gbSS)
        Me.Name = "SimpleGeometryApplication"
        Me.Text = "Simple Geometry Application"
        Me.gbSS.ResumeLayout(False)
        Me.gbSS.PerformLayout()
        Me.gbInputSides.ResumeLayout(False)
        Me.gbInputSides.PerformLayout()
        Me.gbOutputData.ResumeLayout(False)
        Me.gbOutputData.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSS As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRectangle As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSquare As System.Windows.Forms.RadioButton
    Friend WithEvents gbInputSides As System.Windows.Forms.GroupBox
    Friend WithEvents txtSide2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSide2 As System.Windows.Forms.Label
    Friend WithEvents txtSide1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSide1 As System.Windows.Forms.Label
    Friend WithEvents gbOutputData As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerimeterOut As System.Windows.Forms.Label
    Friend WithEvents lblAreaOut As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCircumference As System.Windows.Forms.Label
    Friend WithEvents rdbCircle As System.Windows.Forms.RadioButton
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblCirumferenceOut As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCircumference As System.Windows.Forms.CheckBox
    Friend WithEvents cbPerimeter As System.Windows.Forms.CheckBox
    Friend WithEvents cbArea As System.Windows.Forms.CheckBox

End Class
