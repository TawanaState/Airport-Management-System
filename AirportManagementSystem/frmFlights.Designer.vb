<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlights))
        Dim IDLabel As System.Windows.Forms.Label
        Dim FlightIDLabel As System.Windows.Forms.Label
        Dim PlaneNumberLabel As System.Windows.Forms.Label
        Dim Pilot1Label As System.Windows.Forms.Label
        Dim Pilot2Label As System.Windows.Forms.Label
        Dim DepartureTimeLabel As System.Windows.Forms.Label
        Dim EstimatedArrivalTimeLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.FlightsLogicDatabaseDataSet = New AirportManagementSystem.FlightsLogicDatabaseDataSet()
        Me.FlightsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableTableAdapter = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.FlightsTableTableAdapter()
        Me.TableAdapterManager = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.FlightsTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FlightsTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FlightsTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FlightIDTextBox = New System.Windows.Forms.TextBox()
        Me.PlaneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Pilot1TextBox = New System.Windows.Forms.TextBox()
        Me.Pilot2TextBox = New System.Windows.Forms.TextBox()
        Me.DepartureTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EstimatedArrivalTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        FlightIDLabel = New System.Windows.Forms.Label()
        PlaneNumberLabel = New System.Windows.Forms.Label()
        Pilot1Label = New System.Windows.Forms.Label()
        Pilot2Label = New System.Windows.Forms.Label()
        DepartureTimeLabel = New System.Windows.Forms.Label()
        EstimatedArrivalTimeLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlightsTableBindingNavigator.SuspendLayout()
        CType(Me.FlightsTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlightsLogicDatabaseDataSet
        '
        Me.FlightsLogicDatabaseDataSet.DataSetName = "FlightsLogicDatabaseDataSet"
        Me.FlightsLogicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsTableBindingSource
        '
        Me.FlightsTableBindingSource.DataMember = "FlightsTable"
        Me.FlightsTableBindingSource.DataSource = Me.FlightsLogicDatabaseDataSet
        '
        'FlightsTableTableAdapter
        '
        Me.FlightsTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableTableAdapter = Nothing
        Me.TableAdapterManager.FlightsTableTableAdapter = Me.FlightsTableTableAdapter
        Me.TableAdapterManager.PassengersTableTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableTableAdapter = Nothing
        Me.TableAdapterManager.TicketsTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlightsTableBindingNavigator
        '
        Me.FlightsTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FlightsTableBindingNavigator.BindingSource = Me.FlightsTableBindingSource
        Me.FlightsTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsTableBindingNavigatorSaveItem})
        Me.FlightsTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FlightsTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsTableBindingNavigator.Name = "FlightsTableBindingNavigator"
        Me.FlightsTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsTableBindingNavigator.Size = New System.Drawing.Size(966, 25)
        Me.FlightsTableBindingNavigator.TabIndex = 0
        Me.FlightsTableBindingNavigator.Text = "BindingNavigator1"
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
        'FlightsTableBindingNavigatorSaveItem
        '
        Me.FlightsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FlightsTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("FlightsTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FlightsTableBindingNavigatorSaveItem.Name = "FlightsTableBindingNavigatorSaveItem"
        Me.FlightsTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FlightsTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FlightsTableDataGridView
        '
        Me.FlightsTableDataGridView.AutoGenerateColumns = False
        Me.FlightsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlightsTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.FlightsTableDataGridView.DataSource = Me.FlightsTableBindingSource
        Me.FlightsTableDataGridView.Location = New System.Drawing.Point(531, 40)
        Me.FlightsTableDataGridView.Name = "FlightsTableDataGridView"
        Me.FlightsTableDataGridView.Size = New System.Drawing.Size(415, 301)
        Me.FlightsTableDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PlaneNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PlaneNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Pilot1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pilot1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pilot2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pilot2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DepartureTime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DepartureTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EstimatedArrivalTime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "EstimatedArrivalTime"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(15, 53)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 19)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(184, 53)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(316, 27)
        Me.IDTextBox.TabIndex = 3
        '
        'FlightIDLabel
        '
        FlightIDLabel.AutoSize = True
        FlightIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FlightIDLabel.Location = New System.Drawing.Point(15, 82)
        FlightIDLabel.Name = "FlightIDLabel"
        FlightIDLabel.Size = New System.Drawing.Size(68, 19)
        FlightIDLabel.TabIndex = 4
        FlightIDLabel.Text = "Flight ID:"
        '
        'FlightIDTextBox
        '
        Me.FlightIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "FlightID", True))
        Me.FlightIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlightIDTextBox.Location = New System.Drawing.Point(184, 82)
        Me.FlightIDTextBox.Name = "FlightIDTextBox"
        Me.FlightIDTextBox.Size = New System.Drawing.Size(316, 27)
        Me.FlightIDTextBox.TabIndex = 5
        '
        'PlaneNumberLabel
        '
        PlaneNumberLabel.AutoSize = True
        PlaneNumberLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlaneNumberLabel.Location = New System.Drawing.Point(15, 111)
        PlaneNumberLabel.Name = "PlaneNumberLabel"
        PlaneNumberLabel.Size = New System.Drawing.Size(106, 19)
        PlaneNumberLabel.TabIndex = 6
        PlaneNumberLabel.Text = "Plane Number:"
        '
        'PlaneNumberTextBox
        '
        Me.PlaneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "PlaneNumber", True))
        Me.PlaneNumberTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaneNumberTextBox.Location = New System.Drawing.Point(184, 111)
        Me.PlaneNumberTextBox.Name = "PlaneNumberTextBox"
        Me.PlaneNumberTextBox.Size = New System.Drawing.Size(316, 27)
        Me.PlaneNumberTextBox.TabIndex = 7
        '
        'Pilot1Label
        '
        Pilot1Label.AutoSize = True
        Pilot1Label.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pilot1Label.Location = New System.Drawing.Point(15, 140)
        Pilot1Label.Name = "Pilot1Label"
        Pilot1Label.Size = New System.Drawing.Size(50, 19)
        Pilot1Label.TabIndex = 8
        Pilot1Label.Text = "Pilot1:"
        '
        'Pilot1TextBox
        '
        Me.Pilot1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "Pilot1", True))
        Me.Pilot1TextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pilot1TextBox.Location = New System.Drawing.Point(184, 140)
        Me.Pilot1TextBox.Name = "Pilot1TextBox"
        Me.Pilot1TextBox.Size = New System.Drawing.Size(316, 27)
        Me.Pilot1TextBox.TabIndex = 9
        '
        'Pilot2Label
        '
        Pilot2Label.AutoSize = True
        Pilot2Label.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pilot2Label.Location = New System.Drawing.Point(15, 169)
        Pilot2Label.Name = "Pilot2Label"
        Pilot2Label.Size = New System.Drawing.Size(50, 19)
        Pilot2Label.TabIndex = 10
        Pilot2Label.Text = "Pilot2:"
        '
        'Pilot2TextBox
        '
        Me.Pilot2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "Pilot2", True))
        Me.Pilot2TextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pilot2TextBox.Location = New System.Drawing.Point(184, 169)
        Me.Pilot2TextBox.Name = "Pilot2TextBox"
        Me.Pilot2TextBox.Size = New System.Drawing.Size(316, 27)
        Me.Pilot2TextBox.TabIndex = 11
        '
        'DepartureTimeLabel
        '
        DepartureTimeLabel.AutoSize = True
        DepartureTimeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartureTimeLabel.Location = New System.Drawing.Point(15, 198)
        DepartureTimeLabel.Name = "DepartureTimeLabel"
        DepartureTimeLabel.Size = New System.Drawing.Size(116, 19)
        DepartureTimeLabel.TabIndex = 12
        DepartureTimeLabel.Text = "Departure Time:"
        '
        'DepartureTimeDateTimePicker
        '
        Me.DepartureTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsTableBindingSource, "DepartureTime", True))
        Me.DepartureTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartureTimeDateTimePicker.Location = New System.Drawing.Point(184, 198)
        Me.DepartureTimeDateTimePicker.Name = "DepartureTimeDateTimePicker"
        Me.DepartureTimeDateTimePicker.Size = New System.Drawing.Size(316, 27)
        Me.DepartureTimeDateTimePicker.TabIndex = 13
        '
        'EstimatedArrivalTimeLabel
        '
        EstimatedArrivalTimeLabel.AutoSize = True
        EstimatedArrivalTimeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstimatedArrivalTimeLabel.Location = New System.Drawing.Point(15, 227)
        EstimatedArrivalTimeLabel.Name = "EstimatedArrivalTimeLabel"
        EstimatedArrivalTimeLabel.Size = New System.Drawing.Size(162, 19)
        EstimatedArrivalTimeLabel.TabIndex = 14
        EstimatedArrivalTimeLabel.Text = "Estimated Arrival Time:"
        '
        'EstimatedArrivalTimeDateTimePicker
        '
        Me.EstimatedArrivalTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsTableBindingSource, "EstimatedArrivalTime", True))
        Me.EstimatedArrivalTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimatedArrivalTimeDateTimePicker.Location = New System.Drawing.Point(184, 227)
        Me.EstimatedArrivalTimeDateTimePicker.Name = "EstimatedArrivalTimeDateTimePicker"
        Me.EstimatedArrivalTimeDateTimePicker.Size = New System.Drawing.Size(316, 27)
        Me.EstimatedArrivalTimeDateTimePicker.TabIndex = 15
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(15, 256)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(88, 19)
        DestinationLabel.TabIndex = 16
        DestinationLabel.Text = "Destination:"
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "Destination", True))
        Me.DestinationTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationTextBox.Location = New System.Drawing.Point(184, 256)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(316, 27)
        Me.DestinationTextBox.TabIndex = 17
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(15, 285)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(88, 19)
        DescriptionLabel.TabIndex = 18
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(184, 285)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(316, 27)
        Me.DescriptionTextBox.TabIndex = 19
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(15, 314)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(44, 19)
        PriceLabel.TabIndex = 20
        PriceLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsTableBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(184, 314)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(316, 27)
        Me.PriceTextBox.TabIndex = 21
        '
        'frmFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 377)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(FlightIDLabel)
        Me.Controls.Add(Me.FlightIDTextBox)
        Me.Controls.Add(PlaneNumberLabel)
        Me.Controls.Add(Me.PlaneNumberTextBox)
        Me.Controls.Add(Pilot1Label)
        Me.Controls.Add(Me.Pilot1TextBox)
        Me.Controls.Add(Pilot2Label)
        Me.Controls.Add(Me.Pilot2TextBox)
        Me.Controls.Add(DepartureTimeLabel)
        Me.Controls.Add(Me.DepartureTimeDateTimePicker)
        Me.Controls.Add(EstimatedArrivalTimeLabel)
        Me.Controls.Add(Me.EstimatedArrivalTimeDateTimePicker)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.FlightsTableDataGridView)
        Me.Controls.Add(Me.FlightsTableBindingNavigator)
        Me.Name = "frmFlights"
        Me.Text = "frmFlights"
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlightsTableBindingNavigator.ResumeLayout(False)
        Me.FlightsTableBindingNavigator.PerformLayout()
        CType(Me.FlightsTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlightsLogicDatabaseDataSet As AirportManagementSystem.FlightsLogicDatabaseDataSet
    Friend WithEvents FlightsTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FlightsTableTableAdapter As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.FlightsTableTableAdapter
    Friend WithEvents TableAdapterManager As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlightsTableBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FlightsTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FlightsTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlightIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlaneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pilot1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pilot2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartureTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EstimatedArrivalTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DestinationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
End Class
