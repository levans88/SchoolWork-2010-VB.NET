<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationSummary
    Inherits BaseFormLibrary.MainT

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblPageTitle = New System.Windows.Forms.Label
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.lblPageText = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DeparturedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReturndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyadultsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BasepriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActivitiestotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrenttotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationSummaryInfo = New Amsterdam.reservationSummaryInfo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.activity_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesSummaryInfo = New Amsterdam.ActivitiesSummaryInfo
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.Confirmaiton_numberToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Confirmaiton_numberToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerSummaryInfo = New Amsterdam.CustomerSummaryInfo
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.FillByToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Confirmation_numberToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Confirmation_numberToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillByToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.CustomersTableAdapter = New Amsterdam.CustomerSummaryInfoTableAdapters.customersTableAdapter
        Me.btnCancelReservation = New System.Windows.Forms.Button
        Me.ReservationsTableAdapter = New Amsterdam.reservationSummaryInfoTableAdapters.reservationsTableAdapter
        Me.ActivitiesTableAdapter = New Amsterdam.ActivitiesSummaryInfoTableAdapters.activitiesTableAdapter
        Me.Reservation_activitiesTableAdapter = New Amsterdam.ActivitiesSummaryInfoTableAdapters.reservation_activitiesTableAdapter
        Me.btnReturnWithoutCancel = New System.Windows.Forms.Button
        Me.lblCancelComplete = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationSummaryInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesSummaryInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerSummaryInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        '
        'btnVacationLine
        '
        '
        'btnReservations
        '
        '
        'btnAmsterdamProfile
        '
        '
        'btnHelp
        '
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(678, 9)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(283, 36)
        Me.lblPageTitle.TabIndex = 20
        Me.lblPageTitle.Text = "Reservation Summary"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(363, 542)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(129, 32)
        Me.btnPrevious.TabIndex = 71
        Me.btnPrevious.Text = "Previous Screen"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(498, 542)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(129, 32)
        Me.btnConfirm.TabIndex = 72
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblPageText
        '
        Me.lblPageText.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblPageText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageText.Location = New System.Drawing.Point(12, 126)
        Me.lblPageText.Name = "lblPageText"
        Me.lblPageText.Size = New System.Drawing.Size(1000, 49)
        Me.lblPageText.TabIndex = 73
        Me.lblPageText.Text = "Please review the details of your trip below.  You can return to the previous scr" & _
            "een and update any information as needed.  Press ""Confirm"" when you are ready to" & _
            " complete your reservation."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeparturedateDataGridViewTextBoxColumn, Me.ReturndateDataGridViewTextBoxColumn, Me.QtyadultsDataGridViewTextBoxColumn, Me.BasepriceDataGridViewTextBoxColumn, Me.ActivitiestotalDataGridViewTextBoxColumn, Me.TaxamountDataGridViewTextBoxColumn, Me.CurrenttotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationsBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.BlanchedAlmond
        Me.DataGridView1.Location = New System.Drawing.Point(102, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.Size = New System.Drawing.Size(798, 30)
        Me.DataGridView1.TabIndex = 74
        '
        'DeparturedateDataGridViewTextBoxColumn
        '
        Me.DeparturedateDataGridViewTextBoxColumn.DataPropertyName = "departure_date"
        Me.DeparturedateDataGridViewTextBoxColumn.HeaderText = "departure_date"
        Me.DeparturedateDataGridViewTextBoxColumn.Name = "DeparturedateDataGridViewTextBoxColumn"
        Me.DeparturedateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeparturedateDataGridViewTextBoxColumn.Width = 145
        '
        'ReturndateDataGridViewTextBoxColumn
        '
        Me.ReturndateDataGridViewTextBoxColumn.DataPropertyName = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.HeaderText = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.Name = "ReturndateDataGridViewTextBoxColumn"
        Me.ReturndateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReturndateDataGridViewTextBoxColumn.Width = 155
        '
        'QtyadultsDataGridViewTextBoxColumn
        '
        Me.QtyadultsDataGridViewTextBoxColumn.DataPropertyName = "qty_adults"
        Me.QtyadultsDataGridViewTextBoxColumn.HeaderText = "qty_adults"
        Me.QtyadultsDataGridViewTextBoxColumn.Name = "QtyadultsDataGridViewTextBoxColumn"
        Me.QtyadultsDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyadultsDataGridViewTextBoxColumn.Width = 115
        '
        'BasepriceDataGridViewTextBoxColumn
        '
        Me.BasepriceDataGridViewTextBoxColumn.DataPropertyName = "base_price"
        Me.BasepriceDataGridViewTextBoxColumn.HeaderText = "base_price"
        Me.BasepriceDataGridViewTextBoxColumn.Name = "BasepriceDataGridViewTextBoxColumn"
        Me.BasepriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivitiestotalDataGridViewTextBoxColumn
        '
        Me.ActivitiestotalDataGridViewTextBoxColumn.DataPropertyName = "activities_total"
        Me.ActivitiestotalDataGridViewTextBoxColumn.HeaderText = "activities_total"
        Me.ActivitiestotalDataGridViewTextBoxColumn.Name = "ActivitiestotalDataGridViewTextBoxColumn"
        Me.ActivitiestotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActivitiestotalDataGridViewTextBoxColumn.Width = 75
        '
        'TaxamountDataGridViewTextBoxColumn
        '
        Me.TaxamountDataGridViewTextBoxColumn.DataPropertyName = "tax_amount"
        Me.TaxamountDataGridViewTextBoxColumn.HeaderText = "tax_amount"
        Me.TaxamountDataGridViewTextBoxColumn.Name = "TaxamountDataGridViewTextBoxColumn"
        Me.TaxamountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrenttotalDataGridViewTextBoxColumn
        '
        Me.CurrenttotalDataGridViewTextBoxColumn.DataPropertyName = "current_total"
        Me.CurrenttotalDataGridViewTextBoxColumn.HeaderText = "current_total"
        Me.CurrenttotalDataGridViewTextBoxColumn.Name = "CurrenttotalDataGridViewTextBoxColumn"
        Me.CurrenttotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReservationsBindingSource
        '
        Me.ReservationsBindingSource.DataMember = "reservations"
        Me.ReservationsBindingSource.DataSource = Me.ReservationSummaryInfo
        '
        'ReservationSummaryInfo
        '
        Me.ReservationSummaryInfo.DataSetName = "reservationSummaryInfo"
        Me.ReservationSummaryInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 26)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Departure Date"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Return Date"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 26)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Number of Adults"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 26)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Base Price"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(596, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 26)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Activities"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(701, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 26)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Tax"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(790, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 26)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Total"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.activity_number, Me.NameDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BindingSource1
        Me.DataGridView2.GridColor = System.Drawing.Color.BlanchedAlmond
        Me.DataGridView2.Location = New System.Drawing.Point(102, 318)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.Size = New System.Drawing.Size(798, 95)
        Me.DataGridView2.TabIndex = 82
        '
        'activity_number
        '
        Me.activity_number.DataPropertyName = "activity_number"
        Me.activity_number.HeaderText = "activity_number"
        Me.activity_number.Name = "activity_number"
        Me.activity_number.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 425
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "activities"
        Me.BindingSource1.DataSource = Me.ActivitiesSummaryInfo
        '
        'ActivitiesSummaryInfo
        '
        Me.ActivitiesSummaryInfo.DataSetName = "ActivitiesSummaryInfo"
        Me.ActivitiesSummaryInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Confirmaiton_numberToolStripLabel, Me.Confirmaiton_numberToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1031, 25)
        Me.FillByToolStrip.TabIndex = 83
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'Confirmaiton_numberToolStripLabel
        '
        Me.Confirmaiton_numberToolStripLabel.Name = "Confirmaiton_numberToolStripLabel"
        Me.Confirmaiton_numberToolStripLabel.Size = New System.Drawing.Size(112, 22)
        Me.Confirmaiton_numberToolStripLabel.Text = "confirmaiton_number:"
        '
        'Confirmaiton_numberToolStripTextBox
        '
        Me.Confirmaiton_numberToolStripTextBox.Name = "Confirmaiton_numberToolStripTextBox"
        Me.Confirmaiton_numberToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(102, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 26)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "#"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(199, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 26)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Activity Name"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(585, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 26)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Activity Cost"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.ColumnHeadersVisible = False
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.CustomersBindingSource
        Me.DataGridView3.GridColor = System.Drawing.Color.BlanchedAlmond
        Me.DataGridView3.Location = New System.Drawing.Point(102, 463)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView3.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView3.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.Size = New System.Drawing.Size(798, 29)
        Me.DataGridView3.TabIndex = 87
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Width = 70
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn.Width = 70
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        Me.StreetDataGridViewTextBoxColumn.ReadOnly = True
        Me.StreetDataGridViewTextBoxColumn.Width = 175
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.Width = 75
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StateDataGridViewTextBoxColumn.Width = 75
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        Me.ZipDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZipDataGridViewTextBoxColumn.Width = 75
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Width = 80
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 165
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.CustomerSummaryInfo
        '
        'CustomerSummaryInfo
        '
        Me.CustomerSummaryInfo.DataSetName = "CustomerSummaryInfo"
        Me.CustomerSummaryInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(103, 434)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 26)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "First, Last"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(246, 434)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 26)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Street Address"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(419, 434)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 26)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "City"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(485, 434)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 26)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "State"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(561, 434)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 26)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Zip Code"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(639, 434)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 26)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "Phone"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(766, 434)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 26)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Email"
        '
        'FillByToolStrip1
        '
        Me.FillByToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Confirmation_numberToolStripLabel, Me.Confirmation_numberToolStripTextBox, Me.FillByToolStripButton1})
        Me.FillByToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip1.Name = "FillByToolStrip1"
        Me.FillByToolStrip1.Size = New System.Drawing.Size(1024, 25)
        Me.FillByToolStrip1.TabIndex = 96
        Me.FillByToolStrip1.Text = "FillByToolStrip1"
        Me.FillByToolStrip1.Visible = False
        '
        'Confirmation_numberToolStripLabel
        '
        Me.Confirmation_numberToolStripLabel.Name = "Confirmation_numberToolStripLabel"
        Me.Confirmation_numberToolStripLabel.Size = New System.Drawing.Size(112, 22)
        Me.Confirmation_numberToolStripLabel.Text = "confirmation_number:"
        '
        'Confirmation_numberToolStripTextBox
        '
        Me.Confirmation_numberToolStripTextBox.Name = "Confirmation_numberToolStripTextBox"
        Me.Confirmation_numberToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton1
        '
        Me.FillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton1.Name = "FillByToolStripButton1"
        Me.FillByToolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton1.Text = "FillBy"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.BackColor = System.Drawing.Color.White
        Me.btnCancelReservation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelReservation.ForeColor = System.Drawing.Color.Red
        Me.btnCancelReservation.Location = New System.Drawing.Point(301, 556)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(191, 32)
        Me.btnCancelReservation.TabIndex = 97
        Me.btnCancelReservation.Text = "Cancel Reservation"
        Me.btnCancelReservation.UseVisualStyleBackColor = False
        Me.btnCancelReservation.Visible = False
        '
        'ReservationsTableAdapter
        '
        Me.ReservationsTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesTableAdapter
        '
        Me.ActivitiesTableAdapter.ClearBeforeFill = True
        '
        'Reservation_activitiesTableAdapter
        '
        Me.Reservation_activitiesTableAdapter.ClearBeforeFill = True
        '
        'btnReturnWithoutCancel
        '
        Me.btnReturnWithoutCancel.BackColor = System.Drawing.Color.White
        Me.btnReturnWithoutCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnWithoutCancel.ForeColor = System.Drawing.Color.Black
        Me.btnReturnWithoutCancel.Location = New System.Drawing.Point(498, 556)
        Me.btnReturnWithoutCancel.Name = "btnReturnWithoutCancel"
        Me.btnReturnWithoutCancel.Size = New System.Drawing.Size(191, 32)
        Me.btnReturnWithoutCancel.TabIndex = 98
        Me.btnReturnWithoutCancel.Text = "Return Without Cancelling"
        Me.btnReturnWithoutCancel.UseVisualStyleBackColor = False
        Me.btnReturnWithoutCancel.Visible = False
        '
        'lblCancelComplete
        '
        Me.lblCancelComplete.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCancelComplete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelComplete.Location = New System.Drawing.Point(371, 513)
        Me.lblCancelComplete.Name = "lblCancelComplete"
        Me.lblCancelComplete.Size = New System.Drawing.Size(248, 26)
        Me.lblCancelComplete.TabIndex = 99
        Me.lblCancelComplete.Text = "Your reservation has been cancelled."
        Me.lblCancelComplete.Visible = False
        '
        'frmReservationSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblCancelComplete)
        Me.Controls.Add(Me.btnReturnWithoutCancel)
        Me.Controls.Add(Me.btnCancelReservation)
        Me.Controls.Add(Me.FillByToolStrip1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblPageText)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmReservationSummary"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.btnPrevious, 0)
        Me.Controls.SetChildIndex(Me.btnConfirm, 0)
        Me.Controls.SetChildIndex(Me.lblPageText, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.DataGridView2, 0)
        Me.Controls.SetChildIndex(Me.FillByToolStrip, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.DataGridView3, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.FillByToolStrip1, 0)
        Me.Controls.SetChildIndex(Me.btnCancelReservation, 0)
        Me.Controls.SetChildIndex(Me.btnReturnWithoutCancel, 0)
        Me.Controls.SetChildIndex(Me.lblCancelComplete, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationSummaryInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesSummaryInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerSummaryInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip1.ResumeLayout(False)
        Me.FillByToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lblPageText As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReservationSummaryInfo As Amsterdam.reservationSummaryInfo
    Friend WithEvents ReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationsTableAdapter As Amsterdam.reservationSummaryInfoTableAdapters.reservationsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DeparturedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturndateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyadultsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasepriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivitiestotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxamountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrenttotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesSummaryInfo As Amsterdam.ActivitiesSummaryInfo
    Friend WithEvents ActivitiesTableAdapter As Amsterdam.ActivitiesSummaryInfoTableAdapters.activitiesTableAdapter
    Friend WithEvents Reservation_activitiesTableAdapter As Amsterdam.ActivitiesSummaryInfoTableAdapters.reservation_activitiesTableAdapter
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Confirmaiton_numberToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Confirmaiton_numberToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents activity_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CustomerSummaryInfo As Amsterdam.CustomerSummaryInfo
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Amsterdam.CustomerSummaryInfoTableAdapters.customersTableAdapter
    Friend WithEvents FillByToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Confirmation_numberToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Confirmation_numberToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelReservation As System.Windows.Forms.Button
    Friend WithEvents btnReturnWithoutCancel As System.Windows.Forms.Button
    Friend WithEvents lblCancelComplete As System.Windows.Forms.Label

End Class
