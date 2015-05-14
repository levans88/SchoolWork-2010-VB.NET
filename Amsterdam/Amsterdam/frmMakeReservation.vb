'******************************************************************************************
'Module/Form:           frmMakeReservation.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form asks for the departure date and number of adults, and
'                       shows some initial summary information including the return date,
'                       departure date, base price for the number of adults chosen, and
'                       number of adults.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmMakeReservation

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
    Dim intNumberOfConfirmations As Integer
    Dim intNewConfirmationNumber As Integer
    Dim intNumberOfAdults As Integer
    Dim dtmDepartureDate As Date
    Dim dtmReturnDate As Date
    Dim dblBasePrice As Double
    Dim intConfirmationFromChange As Integer
    'Dim frmSelectPackages As New System.Windows.Forms.Form()

    Public Sub New(ByVal intConfirmationNumber As Integer)
        InitializeComponent()
        intConfirmationFromChange = intConfirmationNumber

    End Sub

    'check for valid input (not empty), change color to red and show warnings if empty, get data from text boxes if it's valid,
    'add 14 days to departure date to determine return date (static 2 week trip), show this summary info on the right side with
    'calculation for base trip price according to number of adults
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If txtNumberOfAdults.Text.Equals("") Then
            lblNumberOfAdults.Text = "(required)"
        Else
            'get data from text fields
            dtmDepartureDate = cmbDepartureDate.Text
            dtmReturnDate = dtmDepartureDate.AddDays(14)
            intNumberOfAdults = txtNumberOfAdults.Text
            Panel1.Visible = True
            btnNext.Text = "Recalculate"
            lblCurSumDepDateShow.Text = dtmDepartureDate
            lblCurSumRetDateShow.Text = dtmReturnDate
            lblCurSumNumAdultsShow.Text = intNumberOfAdults

            'perform calculations
            dblBasePrice = 5638.75 * intNumberOfAdults
            lblCurSumTotalShow.Text = dblBasePrice.ToString("$#,##0.00")
            btnCurSumNext.Focus()
        End If

    End Sub

    'accept initial entries, pass collected data to an instance of next form in the process, retrieve data as necessary
    Private Sub btnCurSumNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurSumNext.Click

        'create new instance of next form and pass confirmation number and other data
        Dim frmSelectPack As New frmSelectPackages(intNewConfirmationNumber, dtmDepartureDate, _
            dtmReturnDate, intNumberOfAdults)

        'check if confirmation number exists, if it does, retrieve appropriate info because we are doing a "change", not a "make"
        If ReservationsTableAdapter.GetDataByConfirmationNumber(confirmation_number:=intNewConfirmationNumber).Rows.Count = 1 Then
            ReservationsTableAdapter.UpdateMakeReservation(confirmation_number:=intNewConfirmationNumber, _
                    departure_date:=dtmDepartureDate, return_date:=dtmReturnDate, qty_adults:=intNumberOfAdults, _
                    base_price:=dblBasePrice)

        Else
            'confirmation number didn't exist, so insert it and some other data to DB
            ReservationsTableAdapter.InsertMakeReservation(confirmation_number:=intNewConfirmationNumber, _
                    departure_date:=dtmDepartureDate, return_date:=dtmReturnDate, qty_adults:=intNumberOfAdults, _
                    base_price:=dblBasePrice)

        End If

        frmSelectPack.Show(Me)
        Me.Hide()
    End Sub

    'on form load, if confirmation number recieved from pass was 0, we're doing a "make" and a new confirmation number should be created
    Private Sub frmMakeReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If intConfirmationFromChange = 0 Then

            intNumberOfConfirmations = ReservationsTableAdapter.getNumberOfConfirmations()
            intNewConfirmationNumber = intNumberOfConfirmations + 1
            cmbDepartureDate.SelectedIndex = 0
        Else
            'if this is not a "make" and it's a "change" instead, use the passed in confirmation number
            intNewConfirmationNumber = intConfirmationFromChange

            'and set label text to "Change a Reservation" instead of "Make a Reservation"
            lblSubTitle.Text = "Change a Reservation"

            'retrieve existing data from database according to confirmation number for "change"
            Me.ReservationsTableAdapter.FillByConfirmationNumber(Me.ReservationDataSet.reservations, confirmation_number:=intNewConfirmationNumber)
            dtmDepartureDate = ReservationDataSet.Tables(0).Rows(0)(1).ToString()
            cmbDepartureDate.Text = dtmDepartureDate

            txtNumberOfAdults.Text = ReservationDataSet.Tables(0).Rows(0)(3).ToString

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReservationSubSystem.Show()
        Me.Hide()
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

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmMakeReservationHelp.ShowDialog(Me)

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
