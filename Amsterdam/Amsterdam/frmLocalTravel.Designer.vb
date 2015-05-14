<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalTravel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalTravel))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.lblPageTitle = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lblRidingSchool = New System.Windows.Forms.Label
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
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(470, 153)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(536, 466)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(678, 9)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(155, 36)
        Me.lblPageTitle.TabIndex = 20
        Me.lblPageTitle.Text = "Local Travel"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Amsterdam.My.Resources.Resources.transportation
        Me.PictureBox4.Location = New System.Drawing.Point(37, 153)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(416, 334)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'lblRidingSchool
        '
        Me.lblRidingSchool.AutoSize = True
        Me.lblRidingSchool.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblRidingSchool.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRidingSchool.Location = New System.Drawing.Point(34, 490)
        Me.lblRidingSchool.Name = "lblRidingSchool"
        Me.lblRidingSchool.Size = New System.Drawing.Size(76, 13)
        Me.lblRidingSchool.TabIndex = 34
        Me.lblRidingSchool.Text = "Transportation"
        '
        'frmLocalTravel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblRidingSchool)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmLocalTravel"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.lblRidingSchool, 0)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRidingSchool As System.Windows.Forms.Label

End Class
