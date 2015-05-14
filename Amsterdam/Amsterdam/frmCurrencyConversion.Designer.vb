<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrencyConversion
    'Inherits BaseFormLibrary.frmPopupT

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
        Me.txtInputCurrencyUSD = New System.Windows.Forms.TextBox
        Me.btnConvertUSDtoEuros = New System.Windows.Forms.Button
        Me.txtOutputCurrencyEuros = New System.Windows.Forms.TextBox
        Me.btnConvertEurosToUSD = New System.Windows.Forms.Button
        Me.txtInputCurrencyEuros = New System.Windows.Forms.TextBox
        Me.txtOutputCurrencyUSD = New System.Windows.Forms.TextBox
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(483, 7)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(267, 36)
        Me.lblPageTitle.TabIndex = 17
        Me.lblPageTitle.Text = "Currency Conversion"
        '
        'txtInputCurrencyUSD
        '
        Me.txtInputCurrencyUSD.Location = New System.Drawing.Point(460, 236)
        Me.txtInputCurrencyUSD.Name = "txtInputCurrencyUSD"
        Me.txtInputCurrencyUSD.Size = New System.Drawing.Size(114, 20)
        Me.txtInputCurrencyUSD.TabIndex = 19
        Me.txtInputCurrencyUSD.Text = "$"
        '
        'btnConvertUSDtoEuros
        '
        Me.btnConvertUSDtoEuros.BackColor = System.Drawing.Color.White
        Me.btnConvertUSDtoEuros.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertUSDtoEuros.Location = New System.Drawing.Point(280, 228)
        Me.btnConvertUSDtoEuros.Name = "btnConvertUSDtoEuros"
        Me.btnConvertUSDtoEuros.Size = New System.Drawing.Size(151, 32)
        Me.btnConvertUSDtoEuros.TabIndex = 20
        Me.btnConvertUSDtoEuros.Text = "US Dollars to Euros"
        Me.btnConvertUSDtoEuros.UseVisualStyleBackColor = False
        '
        'txtOutputCurrencyEuros
        '
        Me.txtOutputCurrencyEuros.Location = New System.Drawing.Point(616, 236)
        Me.txtOutputCurrencyEuros.Name = "txtOutputCurrencyEuros"
        Me.txtOutputCurrencyEuros.ReadOnly = True
        Me.txtOutputCurrencyEuros.Size = New System.Drawing.Size(114, 20)
        Me.txtOutputCurrencyEuros.TabIndex = 21
        '
        'btnConvertEurosToUSD
        '
        Me.btnConvertEurosToUSD.BackColor = System.Drawing.Color.White
        Me.btnConvertEurosToUSD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertEurosToUSD.Location = New System.Drawing.Point(280, 293)
        Me.btnConvertEurosToUSD.Name = "btnConvertEurosToUSD"
        Me.btnConvertEurosToUSD.Size = New System.Drawing.Size(151, 32)
        Me.btnConvertEurosToUSD.TabIndex = 22
        Me.btnConvertEurosToUSD.Text = "Euros to US Dollars"
        Me.btnConvertEurosToUSD.UseVisualStyleBackColor = False
        '
        'txtInputCurrencyEuros
        '
        Me.txtInputCurrencyEuros.Location = New System.Drawing.Point(460, 293)
        Me.txtInputCurrencyEuros.Name = "txtInputCurrencyEuros"
        Me.txtInputCurrencyEuros.Size = New System.Drawing.Size(114, 20)
        Me.txtInputCurrencyEuros.TabIndex = 23
        Me.txtInputCurrencyEuros.Text = "€"
        '
        'txtOutputCurrencyUSD
        '
        Me.txtOutputCurrencyUSD.Location = New System.Drawing.Point(616, 293)
        Me.txtOutputCurrencyUSD.Name = "txtOutputCurrencyUSD"
        Me.txtOutputCurrencyUSD.ReadOnly = True
        Me.txtOutputCurrencyUSD.Size = New System.Drawing.Size(114, 20)
        Me.txtOutputCurrencyUSD.TabIndex = 24
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(460, 361)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(270, 23)
        Me.lblMessage.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 44)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Enter a currency value and press the appropriate convert button.  Exchange rate i" & _
            "s current as of 5/4/2010."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amsterdam.My.Resources.Resources.euro1
        Me.PictureBox1.Location = New System.Drawing.Point(78, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmCurrencyConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(820, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtOutputCurrencyUSD)
        Me.Controls.Add(Me.txtInputCurrencyEuros)
        Me.Controls.Add(Me.btnConvertEurosToUSD)
        Me.Controls.Add(Me.txtOutputCurrencyEuros)
        Me.Controls.Add(Me.btnConvertUSDtoEuros)
        Me.Controls.Add(Me.txtInputCurrencyUSD)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Name = "frmCurrencyConversion"
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtInputCurrencyUSD, 0)
        Me.Controls.SetChildIndex(Me.btnConvertUSDtoEuros, 0)
        Me.Controls.SetChildIndex(Me.txtOutputCurrencyEuros, 0)
        Me.Controls.SetChildIndex(Me.btnConvertEurosToUSD, 0)
        Me.Controls.SetChildIndex(Me.txtInputCurrencyEuros, 0)
        Me.Controls.SetChildIndex(Me.txtOutputCurrencyUSD, 0)
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents txtInputCurrencyUSD As System.Windows.Forms.TextBox
    Friend WithEvents btnConvertUSDtoEuros As System.Windows.Forms.Button
    Friend WithEvents txtOutputCurrencyEuros As System.Windows.Forms.TextBox
    Friend WithEvents btnConvertEurosToUSD As System.Windows.Forms.Button
    Friend WithEvents txtInputCurrencyEuros As System.Windows.Forms.TextBox
    Friend WithEvents txtOutputCurrencyUSD As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
