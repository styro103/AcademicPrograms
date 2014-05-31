<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailForm))
        Dim FlightNumberLabel As System.Windows.Forms.Label
        Dim DepartureCityLabel As System.Windows.Forms.Label
        Dim ArrivalCityLabel As System.Windows.Forms.Label
        Dim DepartureDateLabel As System.Windows.Forms.Label
        Me.AirlineDatabaseDataSet = New AirIndy.AirlineDatabaseDataSet()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableAdapter = New AirIndy.AirlineDatabaseDataSetTableAdapters.FlightsTableAdapter()
        Me.TableAdapterManager = New AirIndy.AirlineDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.FlightsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FlightsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FlightNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureCityTextBox = New System.Windows.Forms.TextBox()
        Me.ArrivalCityTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        FlightNumberLabel = New System.Windows.Forms.Label()
        DepartureCityLabel = New System.Windows.Forms.Label()
        ArrivalCityLabel = New System.Windows.Forms.Label()
        DepartureDateLabel = New System.Windows.Forms.Label()
        CType(Me.AirlineDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlightsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AirlineDatabaseDataSet
        '
        Me.AirlineDatabaseDataSet.DataSetName = "AirlineDatabaseDataSet"
        Me.AirlineDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.AirlineDatabaseDataSet
        '
        'FlightsTableAdapter
        '
        Me.FlightsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlightsTableAdapter = Me.FlightsTableAdapter
        Me.TableAdapterManager.UpdateOrder = AirIndy.AirlineDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlightsBindingNavigator
        '
        Me.FlightsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FlightsBindingNavigator.BindingSource = Me.FlightsBindingSource
        Me.FlightsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsBindingNavigatorSaveItem})
        Me.FlightsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FlightsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsBindingNavigator.Name = "FlightsBindingNavigator"
        Me.FlightsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsBindingNavigator.Size = New System.Drawing.Size(319, 25)
        Me.FlightsBindingNavigator.TabIndex = 0
        Me.FlightsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FlightsBindingNavigatorSaveItem
        '
        Me.FlightsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FlightsBindingNavigatorSaveItem.Image = CType(resources.GetObject("FlightsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FlightsBindingNavigatorSaveItem.Name = "FlightsBindingNavigatorSaveItem"
        Me.FlightsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FlightsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FlightNumberLabel
        '
        FlightNumberLabel.AutoSize = True
        FlightNumberLabel.Location = New System.Drawing.Point(12, 46)
        FlightNumberLabel.Name = "FlightNumberLabel"
        FlightNumberLabel.Size = New System.Drawing.Size(75, 13)
        FlightNumberLabel.TabIndex = 1
        FlightNumberLabel.Text = "Flight Number:"
        '
        'FlightNumberTextBox
        '
        Me.FlightNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "FlightNumber", True))
        Me.FlightNumberTextBox.Location = New System.Drawing.Point(101, 43)
        Me.FlightNumberTextBox.Name = "FlightNumberTextBox"
        Me.FlightNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FlightNumberTextBox.TabIndex = 2
        '
        'DepartureCityLabel
        '
        DepartureCityLabel.AutoSize = True
        DepartureCityLabel.Location = New System.Drawing.Point(12, 72)
        DepartureCityLabel.Name = "DepartureCityLabel"
        DepartureCityLabel.Size = New System.Drawing.Size(77, 13)
        DepartureCityLabel.TabIndex = 3
        DepartureCityLabel.Text = "Departure City:"
        '
        'DepartureCityTextBox
        '
        Me.DepartureCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "DepartureCity", True))
        Me.DepartureCityTextBox.Location = New System.Drawing.Point(101, 69)
        Me.DepartureCityTextBox.Name = "DepartureCityTextBox"
        Me.DepartureCityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartureCityTextBox.TabIndex = 4
        '
        'ArrivalCityLabel
        '
        ArrivalCityLabel.AutoSize = True
        ArrivalCityLabel.Location = New System.Drawing.Point(12, 98)
        ArrivalCityLabel.Name = "ArrivalCityLabel"
        ArrivalCityLabel.Size = New System.Drawing.Size(59, 13)
        ArrivalCityLabel.TabIndex = 5
        ArrivalCityLabel.Text = "Arrival City:"
        '
        'ArrivalCityTextBox
        '
        Me.ArrivalCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "ArrivalCity", True))
        Me.ArrivalCityTextBox.Location = New System.Drawing.Point(101, 95)
        Me.ArrivalCityTextBox.Name = "ArrivalCityTextBox"
        Me.ArrivalCityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ArrivalCityTextBox.TabIndex = 6
        '
        'DepartureDateLabel
        '
        DepartureDateLabel.AutoSize = True
        DepartureDateLabel.Location = New System.Drawing.Point(12, 125)
        DepartureDateLabel.Name = "DepartureDateLabel"
        DepartureDateLabel.Size = New System.Drawing.Size(83, 13)
        DepartureDateLabel.TabIndex = 7
        DepartureDateLabel.Text = "Departure Date:"
        '
        'DepartureDateDateTimePicker
        '
        Me.DepartureDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "DepartureDate", True))
        Me.DepartureDateDateTimePicker.Location = New System.Drawing.Point(101, 121)
        Me.DepartureDateDateTimePicker.Name = "DepartureDateDateTimePicker"
        Me.DepartureDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DepartureDateDateTimePicker.TabIndex = 8
        '
        'DetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 169)
        Me.Controls.Add(FlightNumberLabel)
        Me.Controls.Add(Me.FlightNumberTextBox)
        Me.Controls.Add(DepartureCityLabel)
        Me.Controls.Add(Me.DepartureCityTextBox)
        Me.Controls.Add(ArrivalCityLabel)
        Me.Controls.Add(Me.ArrivalCityTextBox)
        Me.Controls.Add(DepartureDateLabel)
        Me.Controls.Add(Me.DepartureDateDateTimePicker)
        Me.Controls.Add(Me.FlightsBindingNavigator)
        Me.Name = "DetailForm"
        Me.Text = "Airline Information"
        CType(Me.AirlineDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlightsBindingNavigator.ResumeLayout(False)
        Me.FlightsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AirlineDatabaseDataSet As AirIndy.AirlineDatabaseDataSet
    Friend WithEvents FlightsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FlightsTableAdapter As AirIndy.AirlineDatabaseDataSetTableAdapters.FlightsTableAdapter
    Friend WithEvents TableAdapterManager As AirIndy.AirlineDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlightsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FlightsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FlightNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartureCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArrivalCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartureDateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
