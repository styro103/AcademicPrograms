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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btncCalculate = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblCircumference = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtSide2 = New System.Windows.Forms.TextBox()
        Me.txtSide1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCircumference = New System.Windows.Forms.CheckBox()
        Me.chkPerimeter = New System.Windows.Forms.CheckBox()
        Me.chkArea = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCircle = New System.Windows.Forms.RadioButton()
        Me.radRectangle = New System.Windows.Forms.RadioButton()
        Me.radSquare = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(429, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 42)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(429, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 42)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btncCalculate
        '
        Me.btncCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncCalculate.Location = New System.Drawing.Point(429, 194)
        Me.btncCalculate.Name = "btncCalculate"
        Me.btncCalculate.Size = New System.Drawing.Size(109, 42)
        Me.btncCalculate.TabIndex = 12
        Me.btncCalculate.Text = "Calculate"
        Me.btncCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblCircumference)
        Me.GroupBox4.Controls.Add(Me.lblPerimeter)
        Me.GroupBox4.Controls.Add(Me.lblArea)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 174)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'lblCircumference
        '
        Me.lblCircumference.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCircumference.Location = New System.Drawing.Point(147, 110)
        Me.lblCircumference.Name = "lblCircumference"
        Me.lblCircumference.Size = New System.Drawing.Size(120, 27)
        Me.lblCircumference.TabIndex = 5
        '
        'lblPerimeter
        '
        Me.lblPerimeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPerimeter.Location = New System.Drawing.Point(147, 72)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(120, 27)
        Me.lblPerimeter.TabIndex = 4
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblArea.Location = New System.Drawing.Point(147, 35)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(120, 27)
        Me.lblArea.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Circumference:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Perimeter:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Area:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRadius)
        Me.GroupBox3.Controls.Add(Me.txtSide2)
        Me.GroupBox3.Controls.Add(Me.txtSide1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(195, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 138)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enter Data"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(104, 100)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 26)
        Me.txtRadius.TabIndex = 5
        '
        'txtSide2
        '
        Me.txtSide2.Location = New System.Drawing.Point(104, 68)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(100, 26)
        Me.txtSide2.TabIndex = 4
        '
        'txtSide1
        '
        Me.txtSide1.Location = New System.Drawing.Point(104, 36)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(100, 26)
        Me.txtSide1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Radius:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Side 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Side 1:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCircumference)
        Me.GroupBox2.Controls.Add(Me.chkPerimeter)
        Me.GroupBox2.Controls.Add(Me.chkArea)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(429, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 138)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Output"
        '
        'chkCircumference
        '
        Me.chkCircumference.AutoSize = True
        Me.chkCircumference.Location = New System.Drawing.Point(31, 100)
        Me.chkCircumference.Name = "chkCircumference"
        Me.chkCircumference.Size = New System.Drawing.Size(144, 24)
        Me.chkCircumference.TabIndex = 5
        Me.chkCircumference.Text = "Circumference"
        Me.chkCircumference.UseVisualStyleBackColor = True
        '
        'chkPerimeter
        '
        Me.chkPerimeter.AutoSize = True
        Me.chkPerimeter.Location = New System.Drawing.Point(31, 66)
        Me.chkPerimeter.Name = "chkPerimeter"
        Me.chkPerimeter.Size = New System.Drawing.Size(105, 24)
        Me.chkPerimeter.TabIndex = 4
        Me.chkPerimeter.Text = "Perimeter"
        Me.chkPerimeter.UseVisualStyleBackColor = True
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Location = New System.Drawing.Point(31, 33)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(66, 24)
        Me.chkArea.TabIndex = 3
        Me.chkArea.Text = "Area"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCircle)
        Me.GroupBox1.Controls.Add(Me.radRectangle)
        Me.GroupBox1.Controls.Add(Me.radSquare)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 138)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Shape"
        '
        'radCircle
        '
        Me.radCircle.AutoSize = True
        Me.radCircle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCircle.Location = New System.Drawing.Point(31, 96)
        Me.radCircle.Name = "radCircle"
        Me.radCircle.Size = New System.Drawing.Size(72, 24)
        Me.radCircle.TabIndex = 2
        Me.radCircle.TabStop = True
        Me.radCircle.Text = "Circle"
        Me.radCircle.UseVisualStyleBackColor = True
        '
        'radRectangle
        '
        Me.radRectangle.AutoSize = True
        Me.radRectangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRectangle.Location = New System.Drawing.Point(31, 66)
        Me.radRectangle.Name = "radRectangle"
        Me.radRectangle.Size = New System.Drawing.Size(109, 24)
        Me.radRectangle.TabIndex = 1
        Me.radRectangle.TabStop = True
        Me.radRectangle.Text = "Rectangle"
        Me.radRectangle.UseVisualStyleBackColor = True
        '
        'radSquare
        '
        Me.radSquare.AutoSize = True
        Me.radSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSquare.Location = New System.Drawing.Point(31, 36)
        Me.radSquare.Name = "radSquare"
        Me.radSquare.Size = New System.Drawing.Size(85, 24)
        Me.radSquare.TabIndex = 0
        Me.radSquare.TabStop = True
        Me.radSquare.Text = "Square"
        Me.radSquare.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 364)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btncCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Simple Geometry with  Shapes"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btncCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCircumference As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents txtSide2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSide1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCircumference As System.Windows.Forms.CheckBox
    Friend WithEvents chkPerimeter As System.Windows.Forms.CheckBox
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCircle As System.Windows.Forms.RadioButton
    Friend WithEvents radRectangle As System.Windows.Forms.RadioButton
    Friend WithEvents radSquare As System.Windows.Forms.RadioButton

End Class
