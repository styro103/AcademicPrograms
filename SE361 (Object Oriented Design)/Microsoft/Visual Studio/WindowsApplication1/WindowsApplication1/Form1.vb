Public Class Form1

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtRadius.Clear()
        txtSide1.Clear()
        txtSide2.Clear()
        lblAreaOut.Text = String.Empty
        lblCirumferenceOut.Text = String.Empty
        lblPerimeterOut.Text = String.Empty
        rdbCircle.Checked = False
        rdbSquare.Checked = False
        rdbRectangle.Checked = False
        cbArea.Checked = False
        cbPerimeter.Checked = False
        cbCircumference.Checked = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Create an Object of the Class clsSquare'
        Dim objSquare As New clsSquare
        Dim objRectangle As New clsRectangle
        Dim objCircle As New clsCircle

        If rdbSquare.Checked = True Then
            objSquare.Side = CDbl(txtSide1.Text)
            If cbArea.Checked = True Then
                'Ask objSquare to Calculate Area and to Display it in Appropriate Label'
                lblAreaOut.Text = CStr(objSquare.CalcArea)
            End If
            If cbPerimeter.Checked = True Then
                lblPerimeterOut.Text = objSquare.CalcPerimeter.ToString
            End If
        ElseIf rdbRectangle.Checked = True Then
            objRectangle.Side1 = CDbl(txtSide1.Text)
            objRectangle.Side2 = CDbl(txtSide2.Text)
            If cbArea.Checked = True Then
                lblAreaOut.Text = CStr(objRectangle.CalcArea)
            End If
            If cbPerimeter.Checked = True Then
                lblPerimeterOut.Text = objRectangle.CalcPerimeter.ToString
            End If
        ElseIf rdbCircle.Checked = True Then
            objCircle.Radius = CDbl(txtRadius.Text)
            If cbArea.Checked = True Then
                lblAreaOut.Text = CStr(objCircle.CalcArea)
            End If
            If cbCircumference.Checked = True Then
                lblCirumferenceOut.Text = objCircle.CalcCircumference.ToString
            End If
        Else
            MessageBox.Show("Please Make A Shape Selection", "Warning")
        End If
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSide1.Clear()
        txtSide2.Clear()
        txtRadius.Clear()
        lblAreaOut.Text = ""
        lblPerimeterOut.Text = ""
        lblCirumferenceOut.Text = ""
        rdbRectangle.Checked = False
        rdbSquare.Checked = False
        rdbCircle.Checked = False
        cbArea.Checked = False
        cbCircumference.Checked = False
        cbPerimeter.Checked = False
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
