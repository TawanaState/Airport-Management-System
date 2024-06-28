<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanes))
        Dim IDLabel As System.Windows.Forms.Label
        Dim PlaneIDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim ConditionLabel As System.Windows.Forms.Label
        Dim MaxPassengersLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.FlightsLogicDatabaseDataSet = New AirportManagementSystem.FlightsLogicDatabaseDataSet()
        Me.PlanesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanesTableTableAdapter = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.PlanesTableTableAdapter()
        Me.TableAdapterManager = New AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlanesTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PlanesTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PlanesTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PlaneIDTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.ConditionTextBox = New System.Windows.Forms.TextBox()
        Me.MaxPassengersTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        PlaneIDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        ConditionLabel = New System.Windows.Forms.Label()
        MaxPassengersLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanesTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanesTableBindingNavigator.SuspendLayout()
        CType(Me.PlanesTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlightsLogicDatabaseDataSet
        '
        Me.FlightsLogicDatabaseDataSet.DataSetName = "FlightsLogicDatabaseDataSet"
        Me.FlightsLogicDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanesTableBindingSource
        '
        Me.PlanesTableBindingSource.DataMember = "PlanesTable"
        Me.PlanesTableBindingSource.DataSource = Me.FlightsLogicDatabaseDataSet
        '
        'PlanesTableTableAdapter
        '
        Me.PlanesTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableTableAdapter = Nothing
        Me.TableAdapterManager.FlightsTableTableAdapter = Nothing
        Me.TableAdapterManager.PassengersTableTableAdapter = Nothing
        Me.TableAdapterManager.PlanesTableTableAdapter = Me.PlanesTableTableAdapter
        Me.TableAdapterManager.TicketsTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlanesTableBindingNavigator
        '
        Me.PlanesTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanesTableBindingNavigator.BindingSource = Me.PlanesTableBindingSource
        Me.PlanesTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanesTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanesTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanesTableBindingNavigatorSaveItem})
        Me.PlanesTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanesTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanesTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanesTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanesTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanesTableBindingNavigator.Name = "PlanesTableBindingNavigator"
        Me.PlanesTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanesTableBindingNavigator.Size = New System.Drawing.Size(745, 25)
        Me.PlanesTableBindingNavigator.TabIndex = 0
        Me.PlanesTableBindingNavigator.Text = "BindingNavigator1"
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
        'PlanesTableBindingNavigatorSaveItem
        '
        Me.PlanesTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanesTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanesTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanesTableBindingNavigatorSaveItem.Name = "PlanesTableBindingNavigatorSaveItem"
        Me.PlanesTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PlanesTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PlanesTableDataGridView
        '
        Me.PlanesTableDataGridView.AutoGenerateColumns = False
        Me.PlanesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanesTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PlanesTableDataGridView.DataSource = Me.PlanesTableBindingSource
        Me.PlanesTableDataGridView.Location = New System.Drawing.Point(425, 41)
        Me.PlanesTableDataGridView.Name = "PlanesTableDataGridView"
        Me.PlanesTableDataGridView.Size = New System.Drawing.Size(300, 274)
        Me.PlanesTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PlaneID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PlaneID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FullName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Condition"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Condition"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MaxPassengers"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MaxPassengers"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(38, 69)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(28, 21)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(158, 69)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(246, 28)
        Me.IDTextBox.TabIndex = 3
        '
        'PlaneIDLabel
        '
        PlaneIDLabel.AutoSize = True
        PlaneIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlaneIDLabel.Location = New System.Drawing.Point(38, 109)
        PlaneIDLabel.Name = "PlaneIDLabel"
        PlaneIDLabel.Size = New System.Drawing.Size(70, 21)
        PlaneIDLabel.TabIndex = 4
        PlaneIDLabel.Text = "Plane ID:"
        '
        'PlaneIDTextBox
        '
        Me.PlaneIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "PlaneID", True))
        Me.PlaneIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaneIDTextBox.Location = New System.Drawing.Point(158, 109)
        Me.PlaneIDTextBox.Name = "PlaneIDTextBox"
        Me.PlaneIDTextBox.Size = New System.Drawing.Size(246, 28)
        Me.PlaneIDTextBox.TabIndex = 5
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FullNameLabel.Location = New System.Drawing.Point(38, 149)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(84, 21)
        FullNameLabel.TabIndex = 6
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "FullName", True))
        Me.FullNameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTextBox.Location = New System.Drawing.Point(158, 149)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(246, 28)
        Me.FullNameTextBox.TabIndex = 7
        '
        'ConditionLabel
        '
        ConditionLabel.AutoSize = True
        ConditionLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ConditionLabel.Location = New System.Drawing.Point(38, 189)
        ConditionLabel.Name = "ConditionLabel"
        ConditionLabel.Size = New System.Drawing.Size(81, 21)
        ConditionLabel.TabIndex = 8
        ConditionLabel.Text = "Condition:"
        '
        'ConditionTextBox
        '
        Me.ConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "Condition", True))
        Me.ConditionTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConditionTextBox.Location = New System.Drawing.Point(158, 189)
        Me.ConditionTextBox.Name = "ConditionTextBox"
        Me.ConditionTextBox.Size = New System.Drawing.Size(246, 28)
        Me.ConditionTextBox.TabIndex = 9
        '
        'MaxPassengersLabel
        '
        MaxPassengersLabel.AutoSize = True
        MaxPassengersLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaxPassengersLabel.Location = New System.Drawing.Point(38, 229)
        MaxPassengersLabel.Name = "MaxPassengersLabel"
        MaxPassengersLabel.Size = New System.Drawing.Size(124, 21)
        MaxPassengersLabel.TabIndex = 10
        MaxPassengersLabel.Text = "Max Passengers:"
        '
        'MaxPassengersTextBox
        '
        Me.MaxPassengersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "MaxPassengers", True))
        Me.MaxPassengersTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxPassengersTextBox.Location = New System.Drawing.Point(158, 229)
        Me.MaxPassengersTextBox.Name = "MaxPassengersTextBox"
        Me.MaxPassengersTextBox.Size = New System.Drawing.Size(246, 28)
        Me.MaxPassengersTextBox.TabIndex = 11
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(38, 269)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(92, 21)
        DescriptionLabel.TabIndex = 12
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanesTableBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(158, 269)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(246, 28)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'frmPlanes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 330)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(PlaneIDLabel)
        Me.Controls.Add(Me.PlaneIDTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(ConditionLabel)
        Me.Controls.Add(Me.ConditionTextBox)
        Me.Controls.Add(MaxPassengersLabel)
        Me.Controls.Add(Me.MaxPassengersTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PlanesTableDataGridView)
        Me.Controls.Add(Me.PlanesTableBindingNavigator)
        Me.Name = "frmPlanes"
        Me.Text = "frmPlanes"
        CType(Me.FlightsLogicDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanesTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanesTableBindingNavigator.ResumeLayout(False)
        Me.PlanesTableBindingNavigator.PerformLayout()
        CType(Me.PlanesTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlightsLogicDatabaseDataSet As AirportManagementSystem.FlightsLogicDatabaseDataSet
    Friend WithEvents PlanesTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanesTableTableAdapter As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.PlanesTableTableAdapter
    Friend WithEvents TableAdapterManager As AirportManagementSystem.FlightsLogicDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanesTableBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PlanesTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanesTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlaneIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConditionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxPassengersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
End Class
