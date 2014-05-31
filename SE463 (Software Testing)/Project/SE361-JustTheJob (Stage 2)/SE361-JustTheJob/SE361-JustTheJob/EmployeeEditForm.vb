Public Class EmployeeEditForm
    Dim objFileManager As New clsFileManager
    Dim employeeList As New Collection
    'closes form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'closes form
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Removes old item from collection and adds modified info to collection. updates textfile
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer
        counter = 1
        If (txtName.Text.Trim <> "" Or txtAddress.Text.Trim <> "" Or txtHome.Text.Trim <> "" Or txtEmail.Text.Trim <> "" Or txtMobile.Text.Trim <> "" Or txtNameEM.Text.Trim <> "" Or txtPhoneEM.Text.Trim <> "" Or txtPosition.Text.Trim <> "" Or txtPay.Text.Trim <> "") Then
            objFileManager.LoadEmployee(employeeList)
            For Each empl In employeeList
                temp = empl
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

                If (tempName = EmployeeInfo.lblEIName.Text) Then
                    employeeList.Remove(counter)
                End If
                counter = counter + 1
            Next

            If radSalary.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                  " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                  " <payType>" + "Salary" + " <pay>" + txtPay.Text.Trim)
            ElseIf radCommission.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                      " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                      " <payType>" + "Commission" + " <pay>" + txtPay.Text.Trim)
            ElseIf radHourly.Checked = True Then
                employeeList.Add("<name>" + txtName.Text.Trim + " <address>" + txtAddress.Text.Trim + " <home>" + txtHome.Text.Trim + " <mobile>" + txtMobile.Text.Trim +
                                      " <email>" + txtEmail.Text.Trim + " <nameEM>" + txtNameEM.Text.Trim + " <phone>" + txtPhoneEM.Text.Trim + " <position>" + txtPosition.Text.Trim +
                                      " <payType>" + "Hourly" + " <pay>" + txtPay.Text.Trim)
            End If

            objFileManager.deleteItem(employeeList, "Employees.txt")

            MessageBox.Show("Employee Information Changed", "Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EmployeeInfo.Close()
            Me.Close()
        Else
            MessageBox.Show("All text boxes must be filled in.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class