Public Class MainForm

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtRadius.Clear()
        txtSide1.Clear()
        txtSide2.Clear()
        lblArea.Text = String.Empty
        lblCircumference.Text = String.Empty
        lblPerimeter.Text = String.Empty
        radCircle.Checked = False
        radRectangle.Checked = False
        radSquare.Checked = False
        chkArea.Checked = False
        chkCircumference.Checked = False
        chkPerimeter.Checked = False
    End Sub

    Private Sub btncCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncCalculate.Click
        Dim objSquare As New clsSquare
        Dim objRectange As New clsRectangle
        Dim objCircle As New clsCircle

        Try
            If radSquare.Checked = True Then
                objSquare.side = CDbl(txtSide1.Text)
                If chkArea.Checked = True Then
                    lblArea.Text = CStr(objSquare.calcArea)
                End If
                If chkPerimeter.Checked = True Then
                    lblPerimeter.Text = CStr(objSquare.calcPerimeter)
                End If
            ElseIf radRectangle.Checked = True Then
                objRectange.side1 = CDbl(txtSide1.Text)
                objRectange.side2 = CDbl(txtSide2.Text)
                If chkArea.Checked = True Then
                    lblArea.Text = CStr(objRectange.calcArea)
                End If
                If chkPerimeter.Checked = True Then
                    lblPerimeter.Text = CStr(objRectange.calcPerimeter)
                End If
            ElseIf radCircle.Checked = True Then
                objCircle.radius = CDbl(txtRadius.Text)
                If chkArea.Checked = True Then
                    lblArea.Text = CStr(objCircle.calcArea)
                End If
                If chkCircumference.Checked = True Then
                    lblCircumference.Text = CStr(objCircle.calcCircumference)
                End If
            Else
                MessageBox.Show("Please make a shape selection", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
