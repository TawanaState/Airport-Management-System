Public Class frmTickets

    Private Sub TicketsTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketsTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TicketsTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FlightsLogicDatabaseDataSet)

    End Sub

    Private Sub frmTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsLogicDatabaseDataSet.TicketsTable' table. You can move, or remove it, as needed.
        Me.TicketsTableTableAdapter.Fill(Me.FlightsLogicDatabaseDataSet.TicketsTable)

    End Sub
End Class