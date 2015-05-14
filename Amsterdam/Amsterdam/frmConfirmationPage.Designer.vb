<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmationPage
    Inherits BaseFormLibrary.frmPopupT

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmationPage))
        Me.lblMainText = New System.Windows.Forms.Label
        Me.lblConfirmationNumber = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lblCaption = New System.Windows.Forms.Label
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(615, 474)
        Me.Button1.Size = New System.Drawing.Size(193, 32)
        Me.Button1.Text = "Return to Welcome Screen"
        '
        'lblMainText
        '
        Me.lblMainText.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblMainText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainText.ForeColor = System.Drawing.Color.White
        Me.lblMainText.Location = New System.Drawing.Point(11, 389)
        Me.lblMainText.Name = "lblMainText"
        Me.lblMainText.Padding = New System.Windows.Forms.Padding(4)
        Me.lblMainText.Size = New System.Drawing.Size(511, 89)
        Me.lblMainText.TabIndex = 74
        Me.lblMainText.Text = resources.GetString("lblMainText.Text")
        '
        'lblConfirmationNumber
        '
        Me.lblConfirmationNumber.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblConfirmationNumber.Font = New System.Drawing.Font("Calibri", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmationNumber.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmationNumber.Location = New System.Drawing.Point(648, 389)
        Me.lblConfirmationNumber.Name = "lblConfirmationNumber"
        Me.lblConfirmationNumber.Size = New System.Drawing.Size(128, 56)
        Me.lblConfirmationNumber.TabIndex = 75
        Me.lblConfirmationNumber.Text = "temp"
        Me.lblConfirmationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(823, 520)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 76
        Me.PictureBox4.TabStop = False
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(12, 493)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(166, 13)
        Me.lblCaption.TabIndex = 77
        Me.lblCaption.Text = "Fireworks Over Amsterdam Bridge"
        '
        'frmConfirmationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(820, 518)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lblConfirmationNumber)
        Me.Controls.Add(Me.lblMainText)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "frmConfirmationPage"
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.lblMainText, 0)
        Me.Controls.SetChildIndex(Me.lblConfirmationNumber, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.lblCaption, 0)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainText As System.Windows.Forms.Label
    Friend WithEvents lblConfirmationNumber As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCaption As System.Windows.Forms.Label

End Class
