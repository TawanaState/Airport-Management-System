<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTickets))
        Dim IDLabel As System.Windows.Forms.Label
        Dim FlightIDLabel As System.Windows.Forms.Label
        Dim PassengerIDLabel As System.Windows.Forms.Label
        Dim PricePaidLabel As System.Windows.Forms.Label
        Me.FlightsLogicDatabaseDataSet = New AirportManagementSystem.FlightsLogicDatabaseDataSet()
        Me.TicketsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketsTableTableAdapter = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TicketsTableTableAdapter()
        Me.TableAdapterManager = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TicketsTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TicketsTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TicketsTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FlightIDTextBox = New System.Windows.Forms.TextBox()
        Me.PassengerIDTextBox = New System.Windows.Forms.TextBox()
        Me.PricePaidTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        FlightIDLabel = New System.Windows.Forms.Label()
        PassengerIDLabel = New System.Windows.Forms.Label()
        PricePaidLabel = New System.Windows.Forms.Label()
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TicketsTableBindingNavigator.SuspendLayout()
        CType(Me.TicketsTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlightsLogicDatabaseDataSet
        '
        Me.FlightsLogicDatabaseDataSet.DataSetName = "FlightsLogicDatabaseDataSet"
        Me.FlightsLogicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketsTableBindingSource
        '
        Me.TicketsTableBindingSource.DataMember = "TicketsTable"
        Me.TicketsTableBindingSource.DataSource = Me.FlightsLogicDatabaseDataSet
        '
        'TicketsTableTableAdapter
        '
        Me.TicketsTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableTableAdapter = Nothing
        Me.TableAdapterManager.FlightsTableTableAdapter = Nothing
        Me.TableAdapterManager.PassengersTableTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableTableAdapter = Nothing
        Me.TableAdapterManager.TicketsTableTableAdapter = Me.TicketsTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TicketsTableBindingNavigator
        '
        Me.TicketsTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TicketsTableBindingNavigator.BindingSource = Me.TicketsTableBindingSource
        Me.TicketsTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TicketsTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TicketsTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TicketsTableBindingNavigatorSaveItem})
        Me.TicketsTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TicketsTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TicketsTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TicketsTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TicketsTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TicketsTableBindingNavigator.Name = "TicketsTableBindingNavigator"
        Me.TicketsTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TicketsTableBindingNavigator.Size = New System.Drawing.Size(745, 25)
        Me.TicketsTableBindingNavigator.TabIndex = 0
        Me.TicketsTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TicketsTableBindingNavigatorSaveItem
        '
        Me.TicketsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TicketsTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TicketsTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TicketsTableBindingNavigatorSaveItem.Name = "TicketsTableBindingNavigatorSaveItem"
        Me.TicketsTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TicketsTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TicketsTableDataGridView
        '
        Me.TicketsTableDataGridView.AutoGenerateColumns = False
        Me.TicketsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketsTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TicketsTableDataGridView.DataSource = Me.TicketsTableBindingSource
        Me.TicketsTableDataGridView.Location = New System.Drawing.Point(423, 28)
        Me.TicketsTableDataGridView.Name = "TicketsTableDataGridView"
        Me.TicketsTableDataGridView.Size = New System.Drawing.Size(300, 239)
        Me.TicketsTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FlightID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FlightID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PassengerID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PassengerID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PricePaid"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PricePaid"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(43, 54)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(28, 21)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsTableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(158, 51)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(230, 28)
        Me.IDTextBox.TabIndex = 3
        '
        'FlightIDLabel
        '
        FlightIDLabel.AutoSize = True
        FlightIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FlightIDLabel.Location = New System.Drawing.Point(43, 110)
        FlightIDLabel.Name = "FlightIDLabel"
        FlightIDLabel.Size = New System.Drawing.Size(71, 21)
        FlightIDLabel.TabIndex = 4
        FlightIDLabel.Text = "Flight ID:"
        '
        'FlightIDTextBox
        '
        Me.FlightIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsTableBindingSource, "FlightID", True))
        Me.FlightIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlightIDTextBox.Location = New System.Drawing.Point(158, 107)
        Me.FlightIDTextBox.Name = "FlightIDTextBox"
        Me.FlightIDTextBox.Size = New System.Drawing.Size(230, 28)
        Me.FlightIDTextBox.TabIndex = 5
        '
        'PassengerIDLabel
        '
        PassengerIDLabel.AutoSize = True
        PassengerIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PassengerIDLabel.Location = New System.Drawing.Point(43, 166)
        PassengerIDLabel.Name = "PassengerIDLabel"
        PassengerIDLabel.Size = New System.Drawing.Size(103, 21)
        PassengerIDLabel.TabIndex = 6
        PassengerIDLabel.Text = "Passenger ID:"
        '
        'PassengerIDTextBox
        '
        Me.PassengerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsTableBindingSource, "PassengerID", True))
        Me.PassengerIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassengerIDTextBox.Location = New System.Drawing.Point(158, 163)
        Me.PassengerIDTextBox.Name = "PassengerIDTextBox"
        Me.PassengerIDTextBox.Size = New System.Drawing.Size(230, 28)
        Me.PassengerIDTextBox.TabIndex = 7
        '
        'PricePaidLabel
        '
        PricePaidLabel.AutoSize = True
        PricePaidLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricePaidLabel.Location = New System.Drawing.Point(43, 222)
        PricePaidLabel.Name = "PricePaidLabel"
        PricePaidLabel.Size = New System.Drawing.Size(81, 21)
        PricePaidLabel.TabIndex = 8
        PricePaidLabel.Text = "Price Paid:"
        '
        'PricePaidTextBox
        '
        Me.PricePaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketsTableBindingSource, "PricePaid", True))
        Me.PricePaidTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricePaidTextBox.Location = New System.Drawing.Point(158, 219)
        Me.PricePaidTextBox.Name = "PricePaidTextBox"
        Me.PricePaidTextBox.Size = New System.Drawing.Size(230, 28)
        Me.PricePaidTextBox.TabIndex = 9
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 306)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(FlightIDLabel)
        Me.Controls.Add(Me.FlightIDTextBox)
        Me.Controls.Add(PassengerIDLabel)
        Me.Controls.Add(Me.PassengerIDTextBox)
        Me.Controls.Add(PricePaidLabel)
        Me.Controls.Add(Me.PricePaidTextBox)
        Me.Controls.Add(Me.TicketsTableDataGridView)
        Me.Controls.Add(Me.TicketsTableBindingNavigator)
        Me.Name = "frmTickets"
        Me.Text = "frmTickets"
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TicketsTableBindingNavigator.ResumeLayout(False)
        Me.TicketsTableBindingNavigator.PerformLayout()
        CType(Me.TicketsTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlightsLogicDatabaseDataSet As AirportManagementSystem.FlightsLogicDatabaseDataSet
    Friend WithEvents TicketsTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TicketsTableTableAdapter As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TicketsTableTableAdapter
    Friend WithEvents TableAdapterManager As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TicketsTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TicketsTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TicketsTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlightIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassengerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePaidTextBox As System.Windows.Forms.TextBox
End Class
