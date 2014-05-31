Public Class ScheduleChangeForm
    Dim objFileManager As New clsFileManager
    Dim appointmentList As New Collection
    'Closes Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes Form
    Private Sub btnSCBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCBack.Click
        Me.Close()
    End Sub


    'Removes appointment from Manager's Schedule
    Private Sub btnSCCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCCancel.Click
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer = 1

        objFileManager.LoadAppointment(appointmentList)

        For Each apt In appointmentList
            temp = apt
            temp = temp.Substring(6)                    'Removes beginning <name> tags
            tempName = temp.Substring(0, temp.IndexOf("<"))

            If (tempName = txtCAName.Text) Then
                appointmentList.Remove(counter)
            End If
            counter = counter + 1
        Next
        objFileManager.deleteItem(appointmentList, "Appointments.txt")
        MessageBox.Show("Appointment Cancelled", "Cancel Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtCAName.Text.Length = 0 Or txtCALocation.Text.Length = 0 Or txtCADate.Text.Length = 0 Or txtCATime.Text.Length = 0 Or txtCALength.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    'Submits the changes made to the appointment to the database

    Private Sub btnSCEdit_Click(sender As Object, e As EventArgs) Handles btnSCEdit.Click
        Dim fieldsFilled As Boolean
        Dim temp As String
        Dim tempName As String
        Dim counter As Integer = 1

        fieldsFilled = checkFieldsFilled()
        If fieldsFilled = True Then
            objFileManager.LoadAppointment(appointmentList)
            For Each apt In appointmentList
                temp = apt
                temp = temp.Substring(6)                    'Removes beginning <name> tags
                tempName = temp.Substring(0, temp.IndexOf("<"))

                If (tempName = txtCAName.Text) Then
                    appointmentList.Remove(counter)
                End If
                counter = counter + 1
            Next


            appointmentList.Add("<name>" + txtCAName.Text.Trim + " <location>" + txtCALocation.Text.Trim + " <date>" + txtCADate.Text.Trim + " <time>" + txtCATime.Text.Trim +
                                     " <length>" + txtCALength.Text.Trim + " <brief>" + txtCABrief.Text.Trim)

            objFileManager.deleteItem(appointmentList, "Appointments.txt")
            Me.Close()
        End If
    End Sub
End Class