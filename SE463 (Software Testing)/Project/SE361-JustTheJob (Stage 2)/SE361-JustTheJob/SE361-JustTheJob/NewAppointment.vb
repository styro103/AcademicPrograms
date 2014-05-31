Public Class NewAppointment
    Dim appointmentList As New clsAppointmentListManager
    Dim objFileManager As New clsFileManager
    'Close Form
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Close Form
    Private Sub btnNABack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNABack.Click
        Me.Close()
    End Sub
    'Adds the Appointment to the Manager's Schedule
    Private Sub btnNASubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNASubmit.Click
        Dim fieldsFilled As Boolean

        fieldsFilled = checkFieldsFilled()
        If fieldsFilled = True Then
            appointmentList.addAppointment(txtNAName.Text, txtNALocation.Text, txtNADate.Text, txtNAStart.Text, txtNALength.Text, txtNABrief.Text)
            objFileManager.SaveAppointment(txtNAName.Text, txtNALocation.Text, txtNADate.Text, txtNAStart.Text, txtNALength.Text, txtNABrief.Text)
        End If
        Me.Close()
    End Sub

    'Checks to see if all the fields are filled out
    Private Function checkFieldsFilled() As Boolean

        If txtNAName.Text.Length = 0 Or txtNALocation.Text.Length = 0 Or txtNADate.Text.Length = 0 Or txtNAStart.Text.Length = 0 Or txtNALength.Text.Length = 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

End Class