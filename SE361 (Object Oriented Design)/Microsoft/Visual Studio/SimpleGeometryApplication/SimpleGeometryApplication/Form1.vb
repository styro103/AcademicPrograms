Public Class SimpleGeometryApplication

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
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

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim side1, side2, radius, area, perimeter, circumference As Double
        Const pi As Double = 3.14
        Try
            If rdbRectangle.Checked = True Then
                side1 = CDbl(txtSide1.Text)
                side2 = CDbl(txtSide2.Text)
                area = side1 * side2
                perimeter = (2 * side1) + (2 * side2)
                If cbArea.Checked = True Then
                    lblAreaOut.Text = area.ToString
                End If
                If cbPerimeter.Checked=True then
                    lblPerimeterOut.Text = perimeter.ToString
                End If
                rdbSquare.Checked = False
                rdbCircle.Checked = False
            ElseIf rdbSquare.Checked = True Then
                side1 = CDbl(txtSide1.Text)
                area = side1 * side1
                perimeter = 4 * side1
                If cbArea.Checked = True Then
                    lblAreaOut.Text = area.ToString
                End If
                If cbPerimeter.Checked = True Then
                    lblPerimeterOut.Text = perimeter.ToString
                End If
                rdbRectangle.Checked = False
                rdbCircle.Checked = False
            ElseIf rdbCircle.Checked = True Then
                radius = CDbl(txtRadius.Text)
                area = pi * radius * radius
                circumference = 2 * pi * radius
                If cbArea.Checked = True Then
                    lblAreaOut.Text = area.ToString
                End If
                If cbCircumference.Checked = True Then
                    lblCirumferenceOut.Text = circumference.ToString
                End If
                rdbRectangle.Checked = False
                rdbSquare.Checked = False
                End If
        Catch ex As Exception
            MessageBox.Show("Only numeric data please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
