<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationSubSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationSubSystem))
        Me.lblPageTitle = New System.Windows.Forms.Label
        Me.btnMakeReservation = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtConfirmationNumber = New System.Windows.Forms.TextBox
        Me.lblEnterConf = New System.Windows.Forms.Label
        Me.txtConfirmationNumber2 = New System.Windows.Forms.TextBox
        Me.lblEnterConf2 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationsDataSetForReservationSubSystem = New Amsterdam.reservationsDataSetForReservationSubSystem
        Me.ReservationsTableAdapterForReservationSubSystem = New Amsterdam.reservationsDataSetForReservationSubSystemTableAdapters.reservationsTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsDataSetForReservationSubSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnReservations.Enabled = False
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
        Me.lblPageTitle.Size = New System.Drawing.Size(172, 36)
        Me.lblPageTitle.TabIndex = 17
        Me.lblPageTitle.Text = "Reservations"
        '
        'btnMakeReservation
        '
        Me.btnMakeReservation.BackColor = System.Drawing.Color.White
        Me.btnMakeReservation.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMakeReservation.FlatAppearance.BorderSize = 0
        Me.btnMakeReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMakeReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMakeReservation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeReservation.Location = New System.Drawing.Point(34, 159)
        Me.btnMakeReservation.Name = "btnMakeReservation"
        Me.btnMakeReservation.Size = New System.Drawing.Size(160, 32)
        Me.btnMakeReservation.TabIndex = 24
        Me.btnMakeReservation.Text = "Make a Reservation"
        Me.btnMakeReservation.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(34, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 32)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Change a Reservation"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(34, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 32)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Cancel a Reservation"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtConfirmationNumber
        '
        Me.txtConfirmationNumber.Location = New System.Drawing.Point(217, 217)
        Me.txtConfirmationNumber.Name = "txtConfirmationNumber"
        Me.txtConfirmationNumber.Size = New System.Drawing.Size(70, 20)
        Me.txtConfirmationNumber.TabIndex = 27
        '
        'lblEnterConf
        '
        Me.lblEnterConf.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblEnterConf.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterConf.Location = New System.Drawing.Point(293, 219)
        Me.lblEnterConf.Name = "lblEnterConf"
        Me.lblEnterConf.Size = New System.Drawing.Size(158, 23)
        Me.lblEnterConf.TabIndex = 46
        Me.lblEnterConf.Text = "(enter valid confirmation #)"
        '
        'txtConfirmationNumber2
        '
        Me.txtConfirmationNumber2.Location = New System.Drawing.Point(217, 270)
        Me.txtConfirmationNumber2.Name = "txtConfirmationNumber2"
        Me.txtConfirmationNumber2.Size = New System.Drawing.Size(70, 20)
        Me.txtConfirmationNumber2.TabIndex = 47
        '
        'lblEnterConf2
        '
        Me.lblEnterConf2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblEnterConf2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterConf2.Location = New System.Drawing.Point(293, 272)
        Me.lblEnterConf2.Name = "lblEnterConf2"
        Me.lblEnterConf2.Size = New System.Drawing.Size(158, 23)
        Me.lblEnterConf2.TabIndex = 48
        Me.lblEnterConf2.Text = "(enter valid confirmation #)"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "reservations"
        Me.BindingSource1.DataSource = Me.ReservationsDataSetForReservationSubSystem
        '
        'ReservationsDataSetForReservationSubSystem
        '
        Me.ReservationsDataSetForReservationSubSystem.DataSetName = "reservationsDataSetForReservationSubSystem"
        Me.ReservationsDataSetForReservationSubSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationsTableAdapterForReservationSubSystem
        '
        Me.ReservationsTableAdapterForReservationSubSystem.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(533, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 110)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(533, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 24)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Make, Change, or Cancel a Reservation"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.Black
        Me.lblLine.Location = New System.Drawing.Point(503, 159)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(1, 434)
        Me.lblLine.TabIndex = 51
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Amsterdam.My.Resources.Resources.Amsterdam_Airport_Schiphol_Front
        Me.PictureBox4.Location = New System.Drawing.Point(575, 312)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(372, 249)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 52
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 564)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Amsterdam Schiphol Airport"
        '
        'ReservationSubSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEnterConf2)
        Me.Controls.Add(Me.txtConfirmationNumber2)
        Me.Controls.Add(Me.lblEnterConf)
        Me.Controls.Add(Me.txtConfirmationNumber)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnMakeReservation)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "ReservationSubSystem"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.btnMakeReservation, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.txtConfirmationNumber, 0)
        Me.Controls.SetChildIndex(Me.lblEnterConf, 0)
        Me.Controls.SetChildIndex(Me.txtConfirmationNumber2, 0)
        Me.Controls.SetChildIndex(Me.lblEnterConf2, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblLine, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsDataSetForReservationSubSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents btnMakeReservation As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtConfirmationNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterConf As System.Windows.Forms.Label
    Friend WithEvents txtConfirmationNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterConf2 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationsDataSetForReservationSubSystem As Amsterdam.reservationsDataSetForReservationSubSystem
    Friend WithEvents ReservationsTableAdapterForReservationSubSystem As Amsterdam.reservationsDataSetForReservationSubSystemTableAdapters.reservationsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
