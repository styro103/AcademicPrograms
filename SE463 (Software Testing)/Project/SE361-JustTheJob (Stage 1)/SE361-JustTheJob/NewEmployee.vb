'Author: Devin Edmundowicz
Public Class NewEmployee
    Dim employeeList As New clsEmployeeListManager
    'Closes New Employee Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'set lblNEPay to "Hourly rate:" & set txtNECommWage, lblCommission, and txtNECommission to visible
    Private Sub radNECommission_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNECommission.CheckedChanged
        txtNECommission.Visible = True
        txtNECommission.Focus()
        txtNECommWages.Visible = True
        lblNEPay.Text = "Hourly rate:"
        lblNEComm.Visible = True
        txtNEHourly.Visible = False
        txtNESalary.Visible = False
    End Sub
    'set lblNEPay to "Hourly rate:" & set txtNEHourly to visible
    Private Sub radNEHourly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNEHourly.CheckedChanged
        txtNECommission.Visible = False
        txtNECommWages.Visible = False
        txtNEHourly.Visible = True
        txtNEHourly.Focus()
        txtNESalary.Visible = False
        lblNEPay.Text = "Hourly rate:"
        lblNEComm.Visible = False

    End Sub

    Private Sub radNESalary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNESalary.CheckedChanged
        txtNECommission.Visible = False
        txtNECommWages.Visible = False
        txtNEHourly.Visible = False
        txtNESalary.Visible = True
        txtNESalary.Focus()
        lblNEPay.Text = "Salary:"
        lblNEComm.Visible = False
    End Sub

    Private Sub btnNEBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEBack.Click
        Me.Close()
    End Sub

    Private Sub btnNESubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNESubmit.Click

        'This test does not work for checking if any of the wage txtboxes are empty or not
        'we also need to calculate commission, as it's using two data fields
        If txtNEAddress.Text = "" Or txtNEName.Text = "" Or txtNEEmail.Text = "" Or txtNEHome.Text = "" Or txtNEMobile.Text = "" Or txtNEMobile.Text = "" Or txtNENameEM.Text = "" Or txtNEPhone.Text = "" Or txtNEPosition.Text = "" Then
            MessageBox.Show("Fill in all fields please", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If radNEHourly.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, txtNEHome.Text, txtNEMobile.Text, txtNEEmail.Text, txtNENameEM.Text,
                                     txtNEPhone.Text, txtNEPosition.Text, "Hourly", txtNEHourly.Text)
            ElseIf radNECommission.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, txtNEHome.Text, txtNEMobile.Text, txtNEEmail.Text, txtNENameEM.Text,
                                    txtNEPhone.Text, txtNEPosition.Text, "Commission", txtNECommWages.Text)
            ElseIf radNESalary.Checked = True Then
                employeeList.addEmployee(txtNEName.Text, txtNEAddress.Text, txtNEHome.Text, txtNEMobile.Text, txtNEEmail.Text, txtNENameEM.Text,
                                    txtNEPhone.Text, txtNEPosition.Text, "Salary", txtNESalary.Text)
            End If

            employeeList.viewEmployeeName(EmployeeListForm.lstName)
            employeeList.viewEmployeecellPhone(EmployeeListForm.lstPhone)
            employeeList.viewEmployeeposition(EmployeeListForm.lstPosition)
            employeeList.viewEmployeewages(EmployeeListForm.lstWages)

            'code for saving stuff here
            Me.Close()
        End If




    End Sub

    Private Sub NewEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class