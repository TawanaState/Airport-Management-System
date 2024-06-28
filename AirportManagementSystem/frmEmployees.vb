Public Class frmEmployees

    Private Sub EmployeesTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FlightsLogicDatabaseDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsLogicDatabaseDataSet.EmployeesTable' table. You can move, or remove it, as needed.
        Me.EmployeesTableTableAdapter.Fill(Me.FlightsLogicDatabaseDataSet.EmployeesTable)

    End Sub
End Class
