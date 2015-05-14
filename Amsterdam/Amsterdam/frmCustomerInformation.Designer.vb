<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInformation
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblStateExample = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblRequiredField = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtStreet = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.BindingSourceCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New Amsterdam.customersDataSet
        Me.CustomersTableAdapter = New Amsterdam.customersDataSetTableAdapters.customersTableAdapter
        Me.lblNotNumericError = New System.Windows.Forms.Label
        CType(Me.BindingSourceCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblPageTitle.Location = New System.Drawing.Point(678, 10)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(286, 36)
        Me.lblPageTitle.TabIndex = 19
        Me.lblPageTitle.Text = "Customer Information"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(518, 70)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Please enter the requested information below.  When finished, press ""Next Screen""" & _
            " to review your complete trip summary.  Customer information will not be saved u" & _
            "ntil pressing ""Next Screen""."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "*First Name:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "*Last Name:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "*Street Address:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "*City:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "*State:"
        '
        'lblStateExample
        '
        Me.lblStateExample.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblStateExample.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblStateExample.Location = New System.Drawing.Point(194, 314)
        Me.lblStateExample.Name = "lblStateExample"
        Me.lblStateExample.Size = New System.Drawing.Size(104, 20)
        Me.lblStateExample.TabIndex = 36
        Me.lblStateExample.Text = "(ex: TX)"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 25)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "*Zip Code:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Email Address:"
        '
        'lblRequiredField
        '
        Me.lblRequiredField.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblRequiredField.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblRequiredField.Location = New System.Drawing.Point(130, 434)
        Me.lblRequiredField.Name = "lblRequiredField"
        Me.lblRequiredField.Size = New System.Drawing.Size(118, 25)
        Me.lblRequiredField.TabIndex = 39
        Me.lblRequiredField.Text = "(* = required field)"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(155, 211)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 20)
        Me.txtFirstName.TabIndex = 40
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(155, 237)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 20)
        Me.txtLastName.TabIndex = 41
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(155, 261)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(238, 20)
        Me.txtStreet.TabIndex = 42
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(155, 287)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(93, 20)
        Me.txtCity.TabIndex = 43
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(155, 311)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(33, 20)
        Me.txtState.TabIndex = 44
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(155, 336)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(93, 20)
        Me.txtZip.TabIndex = 45
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(155, 388)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(152, 20)
        Me.txtEmail.TabIndex = 47
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(61, 486)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(129, 32)
        Me.btnPrevious.TabIndex = 68
        Me.btnPrevious.Text = "Previous Screen"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(196, 486)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(129, 32)
        Me.btnNext.TabIndex = 67
        Me.btnNext.Text = "Next Screen"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(74, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 25)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "*Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(155, 361)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(93, 20)
        Me.txtPhone.TabIndex = 46
        '
        'BindingSourceCustomers
        '
        Me.BindingSourceCustomers.DataMember = "customers"
        Me.BindingSourceCustomers.DataSource = Me.CustomersDataSet
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "customersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'lblNotNumericError
        '
        Me.lblNotNumericError.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblNotNumericError.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblNotNumericError.ForeColor = System.Drawing.Color.Red
        Me.lblNotNumericError.Location = New System.Drawing.Point(254, 347)
        Me.lblNotNumericError.Name = "lblNotNumericError"
        Me.lblNotNumericError.Size = New System.Drawing.Size(174, 20)
        Me.lblNotNumericError.TabIndex = 71
        Me.lblNotNumericError.Text = "(must be numeric, no dashes)"
        Me.lblNotNumericError.Visible = False
        '
        'frmCustomerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblNotNumericError)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblRequiredField)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblStateExample)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmCustomerInformation"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnHelp, 0)
        Me.Controls.SetChildIndex(Me.btnAmsterdamProfile, 0)
        Me.Controls.SetChildIndex(Me.btnReservations, 0)
        Me.Controls.SetChildIndex(Me.btnVacationLine, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.lblPageTitle, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.lblStateExample, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.lblRequiredField, 0)
        Me.Controls.SetChildIndex(Me.txtFirstName, 0)
        Me.Controls.SetChildIndex(Me.txtLastName, 0)
        Me.Controls.SetChildIndex(Me.txtStreet, 0)
        Me.Controls.SetChildIndex(Me.txtCity, 0)
        Me.Controls.SetChildIndex(Me.txtState, 0)
        Me.Controls.SetChildIndex(Me.txtZip, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.btnNext, 0)
        Me.Controls.SetChildIndex(Me.btnPrevious, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtPhone, 0)
        Me.Controls.SetChildIndex(Me.lblNotNumericError, 0)
        CType(Me.BindingSourceCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblStateExample As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblRequiredField As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents BindingSourceCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersDataSet As Amsterdam.customersDataSet
    Friend WithEvents CustomersTableAdapter As Amsterdam.customersDataSetTableAdapters.customersTableAdapter
    Friend WithEvents lblNotNumericError As System.Windows.Forms.Label

End Class
