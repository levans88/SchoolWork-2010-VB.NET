<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostCitySubSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HostCitySubSystem))
        Me.lblPageTitle = New System.Windows.Forms.Label
        Me.btnTravelMap = New System.Windows.Forms.Button
        Me.btnHistory = New System.Windows.Forms.Button
        Me.btnLanguage = New System.Windows.Forms.Button
        Me.btnLocalTravel = New System.Windows.Forms.Button
        Me.btnCurrencyConversion = New System.Windows.Forms.Button
        Me.lblAmsterdamTime = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.wmPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.lblHistoryThumbsTitle = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.TabIndex = 28
        '
        'btnVacationLine
        '
        Me.btnVacationLine.TabIndex = 30
        '
        'btnReservations
        '
        Me.btnReservations.TabIndex = 31
        '
        'btnAmsterdamProfile
        '
        Me.btnAmsterdamProfile.Enabled = False
        Me.btnAmsterdamProfile.TabIndex = 29
        '
        'btnHelp
        '
        Me.btnHelp.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(1035, 530)
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(678, 9)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(129, 36)
        Me.lblPageTitle.TabIndex = 7
        Me.lblPageTitle.Text = "Welcome"
        '
        'btnTravelMap
        '
        Me.btnTravelMap.BackColor = System.Drawing.Color.White
        Me.btnTravelMap.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnTravelMap.FlatAppearance.BorderSize = 0
        Me.btnTravelMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTravelMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTravelMap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTravelMap.Location = New System.Drawing.Point(40, 152)
        Me.btnTravelMap.Name = "btnTravelMap"
        Me.btnTravelMap.Size = New System.Drawing.Size(153, 32)
        Me.btnTravelMap.TabIndex = 23
        Me.btnTravelMap.Text = "Travel Map"
        Me.btnTravelMap.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.White
        Me.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnHistory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(40, 207)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(153, 32)
        Me.btnHistory.TabIndex = 24
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnLanguage
        '
        Me.btnLanguage.BackColor = System.Drawing.Color.White
        Me.btnLanguage.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnLanguage.FlatAppearance.BorderSize = 0
        Me.btnLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLanguage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanguage.Location = New System.Drawing.Point(40, 260)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(153, 32)
        Me.btnLanguage.TabIndex = 25
        Me.btnLanguage.Text = "Language"
        Me.btnLanguage.UseVisualStyleBackColor = False
        '
        'btnLocalTravel
        '
        Me.btnLocalTravel.BackColor = System.Drawing.Color.White
        Me.btnLocalTravel.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnLocalTravel.FlatAppearance.BorderSize = 0
        Me.btnLocalTravel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLocalTravel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLocalTravel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalTravel.Location = New System.Drawing.Point(40, 311)
        Me.btnLocalTravel.Name = "btnLocalTravel"
        Me.btnLocalTravel.Size = New System.Drawing.Size(153, 32)
        Me.btnLocalTravel.TabIndex = 26
        Me.btnLocalTravel.Text = "Local Travel"
        Me.btnLocalTravel.UseVisualStyleBackColor = False
        '
        'btnCurrencyConversion
        '
        Me.btnCurrencyConversion.BackColor = System.Drawing.Color.White
        Me.btnCurrencyConversion.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btnCurrencyConversion.FlatAppearance.BorderSize = 0
        Me.btnCurrencyConversion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCurrencyConversion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCurrencyConversion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrencyConversion.Location = New System.Drawing.Point(40, 361)
        Me.btnCurrencyConversion.Name = "btnCurrencyConversion"
        Me.btnCurrencyConversion.Size = New System.Drawing.Size(153, 32)
        Me.btnCurrencyConversion.TabIndex = 27
        Me.btnCurrencyConversion.Text = "Currency Conversion"
        Me.btnCurrencyConversion.UseVisualStyleBackColor = False
        '
        'lblAmsterdamTime
        '
        Me.lblAmsterdamTime.BackColor = System.Drawing.Color.White
        Me.lblAmsterdamTime.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmsterdamTime.Location = New System.Drawing.Point(485, 195)
        Me.lblAmsterdamTime.Name = "lblAmsterdamTime"
        Me.lblAmsterdamTime.Size = New System.Drawing.Size(149, 19)
        Me.lblAmsterdamTime.TabIndex = 30
        Me.lblAmsterdamTime.Text = "Local Time is:  11:37 AM"
        Me.lblAmsterdamTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(247, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "A BCIS #### class project by Leonard Evans"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Calibri", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(247, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(387, 43)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Welcome to Amsterdam!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.Amsterdam.My.Resources.Resources.mainbackground1
        Me.PictureBox4.Location = New System.Drawing.Point(230, 112)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(801, 519)
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'wmPlayer
        '
        Me.wmPlayer.Enabled = True
        Me.wmPlayer.Location = New System.Drawing.Point(40, 498)
        Me.wmPlayer.Name = "wmPlayer"
        Me.wmPlayer.OcxState = CType(resources.GetObject("wmPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmPlayer.Size = New System.Drawing.Size(140, 44)
        Me.wmPlayer.TabIndex = 36
        '
        'lblHistoryThumbsTitle
        '
        Me.lblHistoryThumbsTitle.AutoSize = True
        Me.lblHistoryThumbsTitle.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblHistoryThumbsTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistoryThumbsTitle.Location = New System.Drawing.Point(57, 470)
        Me.lblHistoryThumbsTitle.Name = "lblHistoryThumbsTitle"
        Me.lblHistoryThumbsTitle.Size = New System.Drawing.Size(106, 19)
        Me.lblHistoryThumbsTitle.TabIndex = 37
        Me.lblHistoryThumbsTitle.Text = "Music Controls"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 545)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 60)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Sound clip of a local street drummer playing the ""hang drum"" in Amsterdam."
        '
        'HostCitySubSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHistoryThumbsTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAmsterdamTime)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnTravelMap)
        Me.Controls.Add(Me.btnLocalTravel)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnCurrencyConversion)
        Me.Controls.Add(Me.btnLanguage)
        Me.Controls.Add(Me.wmPlayer)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "HostCitySubSystem"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.wmPlayer, 0)
        Me.Controls.SetChildIndex(Me.btnLanguage, 0)
        Me.Controls.SetChildIndex(Me.btnCurrencyConversion, 0)
        Me.Controls.SetChildIndex(Me.btnHistory, 0)
        Me.Controls.SetChildIndex(Me.btnLocalTravel, 0)
        Me.Controls.SetChildIndex(Me.btnTravelMap, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.lblAmsterdamTime, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.lblHistoryThumbsTitle, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents btnLocalTravel As System.Windows.Forms.Button
    Friend WithEvents btnLanguage As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnTravelMap As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyConversion As System.Windows.Forms.Button
    Friend WithEvents lblAmsterdamTime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents wmPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblHistoryThumbsTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
