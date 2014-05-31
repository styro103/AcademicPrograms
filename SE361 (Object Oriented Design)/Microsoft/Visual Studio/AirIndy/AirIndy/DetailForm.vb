Public Class DetailForm

    Private Sub FlightsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AirlineDatabaseDataSet)

    End Sub

    Private Sub DetailForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDatabaseDataSet.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.AirlineDatabaseDataSet.Flights)

    End Sub
End Class