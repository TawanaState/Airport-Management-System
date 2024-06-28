Public Class frmPassengers

    Private Sub PassengersTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassengersTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PassengersTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FlightsLogicDatabaseDataSet)

    End Sub

    Private Sub frmPassengers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsLogicDatabaseDataSet.PassengersTable' table. You can move, or remove it, as needed.
        Me.PassengersTableTableAdapter.Fill(Me.FlightsLogicDatabaseDataSet.PassengersTable)

    End Sub
End Class