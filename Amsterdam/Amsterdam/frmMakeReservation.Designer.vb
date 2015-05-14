<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeReservation
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumberOfAdults = New System.Windows.Forms.TextBox
        Me.lblLine = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCurSumTotalShow = New System.Windows.Forms.Label
        Me.lblCurSumNumAdultsShow = New System.Windows.Forms.Label
        Me.btnCurSumNext = New System.Windows.Forms.Button
        Me.lblCurSumTotal = New System.Windows.Forms.Label
        Me.lblCurSumNumAdults = New System.Windows.Forms.Label
        Me.lblCurSumRetDateShow = New System.Windows.Forms.Label
        Me.lblCurSumDepDateShow = New System.Windows.Forms.Label
        Me.lblCurSumRetDate = New System.Windows.Forms.Label
        Me.lblCurSumDepDate = New System.Windows.Forms.Label
        Me.lblCurSumHeader = New System.Windows.Forms.Label
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmsterdamDataSet = New Amsterdam.amsterdamDataSet
        Me.ActivitiesTableAdapter = New Amsterdam.amsterdamDataSetTableAdapters.activitiesTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDataSet = New Amsterdam.reservationDataSet
        Me.ReservationsTableAdapter = New Amsterdam.reservationDataSetTableAdapters.reservationsTableAdapter
        Me.lblNumberOfAdults = New System.Windows.Forms.Label
        Me.lblSubTitle = New System.Windows.Forms.Label
        Me.cmbDepartureDate = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmsterdamDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblPageTitle.Size = New System.Drawing.Size(160, 36)
        Me.lblPageTitle.TabIndex = 18
        Me.lblPageTitle.Text = "Reservation"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 78)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Please provide the data requested below to customize your two-week vacation to Am" & _
            "sterdam. The base price per adult traveler is $5,638.75."
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(198, 368)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 32)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Departure Date:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Number of Adults:"
        '
        'txtNumberOfAdults
        '
        Me.txtNumberOfAdults.Location = New System.Drawing.Point(198, 312)
        Me.txtNumberOfAdults.Name = "txtNumberOfAdults"
        Me.txtNumberOfAdults.Size = New System.Drawing.Size(114, 20)
        Me.txtNumberOfAdults.TabIndex = 28
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.Black
        Me.lblLine.Location = New System.Drawing.Point(503, 153)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(1, 451)
        Me.lblLine.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.lblCurSumTotalShow)
        Me.Panel1.Controls.Add(Me.lblCurSumNumAdultsShow)
        Me.Panel1.Controls.Add(Me.btnCurSumNext)
        Me.Panel1.Controls.Add(Me.lblCurSumTotal)
        Me.Panel1.Controls.Add(Me.lblCurSumNumAdults)
        Me.Panel1.Controls.Add(Me.lblCurSumRetDateShow)
        Me.Panel1.Controls.Add(Me.lblCurSumDepDateShow)
        Me.Panel1.Controls.Add(Me.lblCurSumRetDate)
        Me.Panel1.Controls.Add(Me.lblCurSumDepDate)
        Me.Panel1.Controls.Add(Me.lblCurSumHeader)
        Me.Panel1.Location = New System.Drawing.Point(512, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 328)
        Me.Panel1.TabIndex = 44
        Me.Panel1.Visible = False
        '
        'lblCurSumTotalShow
        '
        Me.lblCurSumTotalShow.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumTotalShow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumTotalShow.Location = New System.Drawing.Point(262, 191)
        Me.lblCurSumTotalShow.Name = "lblCurSumTotalShow"
        Me.lblCurSumTotalShow.Size = New System.Drawing.Size(118, 23)
        Me.lblCurSumTotalShow.TabIndex = 53
        '
        'lblCurSumNumAdultsShow
        '
        Me.lblCurSumNumAdultsShow.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumNumAdultsShow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumNumAdultsShow.Location = New System.Drawing.Point(262, 153)
        Me.lblCurSumNumAdultsShow.Name = "lblCurSumNumAdultsShow"
        Me.lblCurSumNumAdultsShow.Size = New System.Drawing.Size(118, 23)
        Me.lblCurSumNumAdultsShow.TabIndex = 52
        '
        'btnCurSumNext
        '
        Me.btnCurSumNext.BackColor = System.Drawing.Color.White
        Me.btnCurSumNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurSumNext.Location = New System.Drawing.Point(191, 247)
        Me.btnCurSumNext.Name = "btnCurSumNext"
        Me.btnCurSumNext.Size = New System.Drawing.Size(114, 32)
        Me.btnCurSumNext.TabIndex = 51
        Me.btnCurSumNext.Text = "Next"
        Me.btnCurSumNext.UseVisualStyleBackColor = False
        '
        'lblCurSumTotal
        '
        Me.lblCurSumTotal.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumTotal.Location = New System.Drawing.Point(147, 190)
        Me.lblCurSumTotal.Name = "lblCurSumTotal"
        Me.lblCurSumTotal.Size = New System.Drawing.Size(91, 24)
        Me.lblCurSumTotal.TabIndex = 50
        Me.lblCurSumTotal.Text = "Base Price:"
        '
        'lblCurSumNumAdults
        '
        Me.lblCurSumNumAdults.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumNumAdults.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumNumAdults.Location = New System.Drawing.Point(102, 153)
        Me.lblCurSumNumAdults.Name = "lblCurSumNumAdults"
        Me.lblCurSumNumAdults.Size = New System.Drawing.Size(142, 23)
        Me.lblCurSumNumAdults.TabIndex = 49
        Me.lblCurSumNumAdults.Text = "Number of Adults:"
        '
        'lblCurSumRetDateShow
        '
        Me.lblCurSumRetDateShow.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumRetDateShow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumRetDateShow.Location = New System.Drawing.Point(262, 115)
        Me.lblCurSumRetDateShow.Name = "lblCurSumRetDateShow"
        Me.lblCurSumRetDateShow.Size = New System.Drawing.Size(118, 23)
        Me.lblCurSumRetDateShow.TabIndex = 48
        '
        'lblCurSumDepDateShow
        '
        Me.lblCurSumDepDateShow.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumDepDateShow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumDepDateShow.Location = New System.Drawing.Point(262, 80)
        Me.lblCurSumDepDateShow.Name = "lblCurSumDepDateShow"
        Me.lblCurSumDepDateShow.Size = New System.Drawing.Size(118, 23)
        Me.lblCurSumDepDateShow.TabIndex = 47
        '
        'lblCurSumRetDate
        '
        Me.lblCurSumRetDate.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumRetDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumRetDate.Location = New System.Drawing.Point(136, 115)
        Me.lblCurSumRetDate.Name = "lblCurSumRetDate"
        Me.lblCurSumRetDate.Size = New System.Drawing.Size(96, 23)
        Me.lblCurSumRetDate.TabIndex = 46
        Me.lblCurSumRetDate.Text = "Return Date:"
        '
        'lblCurSumDepDate
        '
        Me.lblCurSumDepDate.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumDepDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumDepDate.Location = New System.Drawing.Point(114, 80)
        Me.lblCurSumDepDate.Name = "lblCurSumDepDate"
        Me.lblCurSumDepDate.Size = New System.Drawing.Size(118, 23)
        Me.lblCurSumDepDate.TabIndex = 45
        Me.lblCurSumDepDate.Text = "Departure Date:"
        '
        'lblCurSumHeader
        '
        Me.lblCurSumHeader.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCurSumHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSumHeader.Location = New System.Drawing.Point(14, 7)
        Me.lblCurSumHeader.Name = "lblCurSumHeader"
        Me.lblCurSumHeader.Size = New System.Drawing.Size(468, 44)
        Me.lblCurSumHeader.TabIndex = 44
        Me.lblCurSumHeader.Text = "Current package price including airfare, rental car, and stay at Okura Hotel (req" & _
            "uired for this package):"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "activities"
        Me.BindingSource2.DataSource = Me.AmsterdamDataSet
        '
        'AmsterdamDataSet
        '
        Me.AmsterdamDataSet.DataSetName = "amsterdamDataSet"
        Me.AmsterdamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesTableAdapter
        '
        Me.ActivitiesTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "reservations"
        Me.BindingSource1.DataSource = Me.ReservationDataSet
        '
        'ReservationDataSet
        '
        Me.ReservationDataSet.DataSetName = "reservationDataSet"
        Me.ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationsTableAdapter
        '
        Me.ReservationsTableAdapter.ClearBeforeFill = True
        '
        'lblNumberOfAdults
        '
        Me.lblNumberOfAdults.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblNumberOfAdults.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfAdults.ForeColor = System.Drawing.Color.Red
        Me.lblNumberOfAdults.Location = New System.Drawing.Point(318, 311)
        Me.lblNumberOfAdults.Name = "lblNumberOfAdults"
        Me.lblNumberOfAdults.Size = New System.Drawing.Size(118, 23)
        Me.lblNumberOfAdults.TabIndex = 46
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblSubTitle.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(33, 153)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(166, 23)
        Me.lblSubTitle.TabIndex = 47
        Me.lblSubTitle.Text = "Make a Reservation"
        '
        'cmbDepartureDate
        '
        Me.cmbDepartureDate.FormattingEnabled = True
        Me.cmbDepartureDate.Items.AddRange(New Object() {"06/04/2010", "07/08/2010", "08/23/2010"})
        Me.cmbDepartureDate.Location = New System.Drawing.Point(198, 277)
        Me.cmbDepartureDate.Name = "cmbDepartureDate"
        Me.cmbDepartureDate.Size = New System.Drawing.Size(114, 21)
        Me.cmbDepartureDate.TabIndex = 48
        '
        'frmMakeReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.cmbDepartureDate)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblNumberOfAdults)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.txtNumberOfAdults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmMakeReservation"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.btnNext, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtNumberOfAdults, 0)
        Me.Controls.SetChildIndex(Me.lblLine, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.lblNumberOfAdults, 0)
        Me.Controls.SetChildIndex(Me.lblSubTitle, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.cmbDepartureDate, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmsterdamDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfAdults As System.Windows.Forms.TextBox
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurSumTotalShow As System.Windows.Forms.Label
    Friend WithEvents lblCurSumNumAdultsShow As System.Windows.Forms.Label
    Friend WithEvents btnCurSumNext As System.Windows.Forms.Button
    Friend WithEvents lblCurSumTotal As System.Windows.Forms.Label
    Friend WithEvents lblCurSumNumAdults As System.Windows.Forms.Label
    Friend WithEvents lblCurSumRetDateShow As System.Windows.Forms.Label
    Friend WithEvents lblCurSumDepDateShow As System.Windows.Forms.Label
    Friend WithEvents lblCurSumRetDate As System.Windows.Forms.Label
    Friend WithEvents lblCurSumDepDate As System.Windows.Forms.Label
    Friend WithEvents lblCurSumHeader As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationDataSet As Amsterdam.reservationDataSet
    Friend WithEvents ReservationsTableAdapter As Amsterdam.reservationDataSetTableAdapters.reservationsTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents AmsterdamDataSet As Amsterdam.amsterdamDataSet
    Friend WithEvents ActivitiesTableAdapter As Amsterdam.amsterdamDataSetTableAdapters.activitiesTableAdapter
    Friend WithEvents lblNumberOfAdults As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents cmbDepartureDate As System.Windows.Forms.ComboBox

End Class
