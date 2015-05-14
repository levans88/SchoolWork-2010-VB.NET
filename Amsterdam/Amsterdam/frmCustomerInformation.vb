'******************************************************************************************
'Module/Form:           frmCustomerInformation.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form asks for the necessary customer information to book the
'                       trip.  Email is optional.  Some fields are checked for appropriate
'                       data types.  All but the email field are required.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmCustomerInformation

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    'dimension variables
    Dim intConfirmationNumber As Integer
    Dim strFname As String
    Dim strLname As String
    Dim strStreet As String
    Dim strCity As String
    Dim strState As String
    Dim strZip As String
    Dim strPhone As String
    Dim strEmail As String

    'receive confirmation number from owner form
    Public Sub New(ByVal intRecConfirmationNumber As Integer)
        InitializeComponent()
        intConfirmationNumber = intRecConfirmationNumber

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Owner.Show()
        Me.Hide()
    End Sub

    'collect data for customer record, validate input, update/create record in DB
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        'set variables from text box contents
        strFname = txtFirstName.Text
        strLname = txtLastName.Text
        strStreet = txtStreet.Text
        strCity = txtCity.Text
        strState = txtState.Text
        strZip = txtZip.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text

        'check validity or at least not empty of some text box contents
        If strFname.Equals("") Or strLname.Equals("") Or strStreet.Equals("") Or strCity.Equals("") Or strState.Equals("") Or _
            strZip.Equals("") Or strPhone.Equals("") Then
            lblRequiredField.ForeColor = Color.Red
        Else

            If Not IsNumeric(strZip) Or Not IsNumeric(strPhone) Then
                lblNotNumericError.Visible = True
            Else
                If strState.Length() > 2 Then
                    lblStateExample.ForeColor = Color.Red
                Else

                    'if the customer record already exists in DB, update it...
                    If CustomersTableAdapter.GetDataByConfirmationNumber(confirmation_number:=intConfirmationNumber).Rows.Count = 1 Then
                        CustomersTableAdapter.UpdateQuery(confirmation_number:=intConfirmationNumber, fname:=strFname, lname:=strLname, _
                        street:=strStreet, city:=strCity, state:=strState, zip:=strZip, phone:=strPhone, email:=strEmail)
                    Else
                        '...otherwise create the record
                        CustomersTableAdapter.InsertQuery(confirmation_number:=intConfirmationNumber, fname:=strFname, lname:=strLname, _
                            street:=strStreet, city:=strCity, state:=strState, zip:=strZip, phone:=strPhone, email:=strEmail)
                    End If
                    'create new instance of next form (summary form) and show it
                    Dim frmResSum As New frmReservationSummary(intConfirmationNumber)
                    frmResSum.Show(Me)
                    Me.Hide()
                End If

            End If
        End If


    End Sub

    'auto fill in data in text boxes for current confirmation number if it already exists (doing a change, not a make)
    Private Sub frmCustomerInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtFirstName.Focus()
        'check if confirmation number exists, pull data if so
        If CustomersTableAdapter.GetDataByConfirmationNumber(confirmation_number:=intConfirmationNumber).Rows.Count = 1 Then

            'TODO: This line of code loads data into the 'CustomersDataSet.customers' table. You can move, or remove it, as needed.
            Me.CustomersTableAdapter.FillByConfirmationNumber(Me.CustomersDataSet.customers, confirmation_number:=intConfirmationNumber)
            'put data in text boxes
            txtFirstName.Text = CustomersDataSet.Tables(0).Rows(0)(1).ToString()
            txtLastName.Text = CustomersDataSet.Tables(0).Rows(0)(2).ToString()
            txtStreet.Text = CustomersDataSet.Tables(0).Rows(0)(3).ToString()
            txtCity.Text = CustomersDataSet.Tables(0).Rows(0)(4).ToString()
            txtState.Text = CustomersDataSet.Tables(0).Rows(0)(5).ToString()
            txtZip.Text = CustomersDataSet.Tables(0).Rows(0)(6).ToString()
            txtPhone.Text = CustomersDataSet.Tables(0).Rows(0)(8).ToString()
            txtEmail.Text = CustomersDataSet.Tables(0).Rows(0)(7).ToString()
        End If

    End Sub

    Private Sub btnAmsterdamProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmsterdamProfile.Click
        HostCitySubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnVacationLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVacationLine.Click
        VacationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        ReservationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReservationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmCustomerInformationHelp.ShowDialog(Me)

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines
End Class
