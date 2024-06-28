Public Class frmFlights

    Private Sub FlightsTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightsTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FlightsLogicDatabaseDataSet)

    End Sub

    Private Sub frmFlights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsLogicDatabaseDataSet.FlightsTable' table. You can move, or remove it, as needed.
        Me.FlightsTableTableAdapter.Fill(Me.FlightsLogicDatabaseDataSet.FlightsTable)

    End Sub
End Class