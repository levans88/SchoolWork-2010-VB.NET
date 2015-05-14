<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTravelMap
    'Inherits BaseFormLibrary.MainT

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
        Me.lblPageTitle = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnHotelOkura = New System.Windows.Forms.Button
        Me.lblHotelHotSpot = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        '
        'btnVacationLine
        '
        Me.btnVacationLine.TabIndex = 15
        '
        'btnReservations
        '
        Me.btnReservations.TabIndex = 16
        '
        'btnAmsterdamProfile
        '
        Me.btnAmsterdamProfile.TabIndex = 14
        '
        'btnHelp
        '
        Me.btnHelp.TabIndex = 17
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(678, 9)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(149, 36)
        Me.lblPageTitle.TabIndex = 17
        Me.lblPageTitle.Text = "Travel Map"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Amsterdam.My.Resources.Resources.HotelMap
        Me.PictureBox4.Location = New System.Drawing.Point(327, 148)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(360, 423)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Central Amsterdam Travel Map"
        '
        'btnHotelOkura
        '
        Me.btnHotelOkura.BackColor = System.Drawing.Color.White
        Me.btnHotelOkura.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnHotelOkura.FlatAppearance.BorderSize = 0
        Me.btnHotelOkura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHotelOkura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnHotelOkura.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHotelOkura.Location = New System.Drawing.Point(60, 237)
        Me.btnHotelOkura.Name = "btnHotelOkura"
        Me.btnHotelOkura.Size = New System.Drawing.Size(186, 32)
        Me.btnHotelOkura.TabIndex = 24
        Me.btnHotelOkura.Text = "Hotel Okura Information"
        Me.btnHotelOkura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHotelOkura.UseVisualStyleBackColor = False
        '
        'lblHotelHotSpot
        '
        Me.lblHotelHotSpot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHotelHotSpot.Image = Global.Amsterdam.My.Resources.Resources.Hotel_Map_Button
        Me.lblHotelHotSpot.Location = New System.Drawing.Point(401, 473)
        Me.lblHotelHotSpot.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHotelHotSpot.Name = "lblHotelHotSpot"
        Me.lblHotelHotSpot.Size = New System.Drawing.Size(114, 44)
        Me.lblHotelHotSpot.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 62)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Click the link below, or the Hotel bubble on the map to view details about Hotel " & _
            "Okura."
        '
        'frmTravelMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHotelHotSpot)
        Me.Controls.Add(Me.btnHotelOkura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmTravelMap"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.btnHotelOkura, 0)
        Me.Controls.SetChildIndex(Me.lblHotelHotSpot, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Public WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHotelOkura As System.Windows.Forms.Button
    Friend WithEvents lblHotelHotSpot As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
