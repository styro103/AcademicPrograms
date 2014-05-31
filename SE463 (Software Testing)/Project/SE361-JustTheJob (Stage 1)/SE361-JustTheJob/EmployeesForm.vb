Public Class EmployeesForm
    'Opens Add new Employee Form
    Private Sub btnNewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewEmployee.Click
        NewEmployee.Show()
        NewEmployee.txtNEName.Focus()
    End Sub
    'Displays a form containing a list of employees
    Private Sub btnEmpList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpList.Click
        EmployeeListForm.Show()
    End Sub
    'sets txtbox & label to visible
    Private Sub btnEmpShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpShow.Click
        txtEmpShow.Visible = True
        lblEmpShow.Visible = True
    End Sub
    'Opens form containing employee information. This form will contain option for editing & printing info, as well as giving option to delete
    'the employee if the user is a Manager

    'Saves Employee Information
    Private Sub btnEmpSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes EmployeeForm
    Private Sub btnEmpBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpBack.Click
        Me.Close()
    End Sub
    'Saves Info
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtEmpShow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpShow.KeyDown
        If e.KeyCode = Keys.Enter Then
            EmployeeInfo.Show()
        End If
    End Sub
End Class