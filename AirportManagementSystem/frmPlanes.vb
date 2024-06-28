Public Class frmPlanes

    Private Sub PlanesTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanesTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanesTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FlightsLogicDatabaseDataSet)

    End Sub

    Private Sub frmPlanes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsLogicDatabaseDataSet.PlanesTable' table. You can move, or remove it, as needed.
        Me.PlanesTableTableAdapter.Fill(Me.FlightsLogicDatabaseDataSet.PlanesTable)

    End Sub
End Class