Public Class GridForm

    Private Sub FlightsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.FlightsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AirlineDatabaseDataSet)
            MessageBox.Show("Update Successful")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Failure")
        End Try
    End Sub

    Private Sub GridForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'AirlineDatabaseDataSet.Flights' table. You can move, or remove it, as needed.
            Me.FlightsTableAdapter.Fill(Me.AirlineDatabaseDataSet.Flights)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Loading Failure")
        End Try
    End Sub

    Private Sub FlightsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FlightsDataGridView.CellContentClick

    End Sub
End Class
