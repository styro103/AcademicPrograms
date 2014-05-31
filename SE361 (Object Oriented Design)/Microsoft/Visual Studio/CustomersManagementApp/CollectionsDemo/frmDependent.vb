'Boundary Class
Public Class frmDependent

    Dim dependentsList As New clsDependentList 'implements a one-to-one association between frmDependent and clsDependentList

    Private Sub btnAddDependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDependent.Click
        Try
            dependentsList.AddNewDependent(txtDepName.Text, CInt(txtDepAge.Text), txtDepAddress.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            lblDisplayDependents.Text = String.Empty
            lblDisplayDependents.Text = dependentsList.retrieveDependents()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Warning")
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblDisplayDependents.Text = String.Empty
        txtDepAddress.Clear()
        txtDepAge.Clear()
        txtDepName.Clear()
    End Sub

End Class