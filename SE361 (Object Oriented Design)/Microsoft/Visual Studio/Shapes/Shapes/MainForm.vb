'Author: Panos Linos
'Project Name: Shapes
'Objective: To demonstrate the use of nested If-Elseif statements
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
        radArea.Checked = False
        radCircle.Checked = False
        radCircumference.Checked = False
        radPerimeter.Checked = False
        radRectangle.Checked = False
        radSquare.Checked = False
    End Sub

    Private Sub btncCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncCalculate.Click
        'declare all variables needed
        Dim decSide1, decSide2, decRadius As Decimal
        Dim decArea, decPerimeter, decCircumference As Decimal

        Try
            'first check to see what type of shape is selected
            If radSquare.Checked = True Then
                'a square has been selected so I need to get side1
                decSide1 = CDec(txtSide1.Text)
                'check what output is selected
                If radArea.Checked = True Then
                    'calculate and display the area of a square
                    decArea = decSide1 * decSide1
                    lblArea.Text = decArea.ToString
                    'clear all other output/input
                    lblCircumference.Text = String.Empty
                    lblPerimeter.Text = String.Empty
                    txtRadius.Clear()
                    txtSide2.Clear()
                ElseIf radPerimeter.Checked = True Then
                    'calculate and display the perimeter of a square
                    decPerimeter = 4 * decSide1
                    lblPerimeter.Text = decPerimeter.ToString
                    'clear all other output/input
                    lblCircumference.Text = String.Empty
                    lblArea.Text = String.Empty
                    txtRadius.Clear()
                    txtSide2.Clear()
                Else
                    MessageBox.Show("Wrong selections. Please try again!", "Warning",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            ElseIf radRectangle.Checked = True Then
                'it is a rectangle so I need to get side1 and side2
                decSide1 = CDec(txtSide1.Text)
                decSide2 = CDec(txtSide2.Text)
                'check what output is selected
                If radArea.Checked = True Then
                    'calculate and display the area of a rectangle
                    decArea = decSide1 * decSide2
                    lblArea.Text = decArea.ToString
                    'clear all other output/input
                    lblCircumference.Text = String.Empty
                    lblPerimeter.Text = String.Empty
                    txtRadius.Clear()
                ElseIf radPerimeter.Checked = True Then
                    'calculate and display the perimeter of a rectangle
                    decPerimeter = (2 * decSide1) + (2 * decSide2)
                    lblPerimeter.Text = decPerimeter.ToString
                    'clear all other output/input
                    lblCircumference.Text = String.Empty
                    lblArea.Text = String.Empty
                    txtRadius.Clear()
                Else
                    MessageBox.Show("Wrong selections. Please try again!", "Warning",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            ElseIf radCircle.Checked = True Then
                'a circle is selected so I need to get the radius
                decRadius = CDec(txtRadius.Text)
                'check what output is selected
                If radArea.Checked = True Then
                    'calculate and display the area of a circle
                    decArea = 3.14 * decRadius ^ 2
                    lblArea.Text = decArea.ToString
                    'clear all other output/input
                    lblCircumference.Text = String.Empty
                    lblPerimeter.Text = String.Empty
                    txtSide1.Clear()
                    txtSide2.Clear()
                ElseIf radCircumference.Checked = True Then
                    'calculate and display the circumference of a circle
                    decCircumference = 2 * decRadius * 3.14
                    lblCircumference.Text = decCircumference.ToString
                    'clear all other output
                    lblArea.Text = String.Empty
                    lblPerimeter.Text = String.Empty
                    txtSide1.Clear()
                    txtSide2.Clear()
                Else
                    MessageBox.Show("Wrong selections. Please try again!", "Warning",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please select a shape", "Warning",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid input data or selection", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
