'******************************************************************************************
'Module/Form:           frmSelectPackages.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form enables the user to select packages they would like with
'                       their vacation.  Selections are saved while moving forward and 
'                       back amongst screens.  Selection summary and cost information is
'                       displayed on the right side.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmSelectPackages

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
    Dim dblActivitiesTotal As Double
    Dim dblBasePrice As Double
    Dim dblTaxAmount As Double
    Dim dblCurrentTotal As Double

    'Receiving these dimensioned variables
    Dim intRecConfirmationNumber As Integer
    Dim dtmRecDepartureDate As Date
    Dim dtmRecReturnDate As Date
    Dim intRecNumberOfAdults As Integer

    'receive the confirmation number, departure date, return date, and number of adults
    Public Sub New(ByVal intConfirmationNumber As Integer, ByVal dtmDepartureDate As Date, ByVal dtmReturnDate As Date, _
            ByVal intNumberOfAdults As Integer)
        InitializeComponent()
        intRecConfirmationNumber = intConfirmationNumber
        dtmRecDepartureDate = dtmDepartureDate
        dtmRecReturnDate = dtmReturnDate
        intRecNumberOfAdults = intNumberOfAdults
    End Sub

    'perform calculations, get data, write new data, and display summary,
    'this is done at form load and everytime a check box status is changed
    Private Sub CalculateSummaryBlock()
        'for hidden test label that shows the confirmation number we're working on
        Label22.Text = intRecConfirmationNumber.ToString

        'get the data to display in the grid, data is activities that are selected for current confirmation number, none is fine
        Me.ActivitiesTableAdapter1.Fill(Me.GridDataSet.activities, confirmation_number:=intRecConfirmationNumber)

        'run a query based on confirmation number that sums the cost of activities, if there is a value then use it, otherwise set it to zero
        If Reservation_activitiesTableAdapter.ScalarQueryGetActivitiesTotalByConfirmationNumber _
            (confirmation_number:=intRecConfirmationNumber).HasValue Then

            dblActivitiesTotal = Reservation_activitiesTableAdapter.ScalarQueryGetActivitiesTotalByConfirmationNumber _
            (confirmation_number:=intRecConfirmationNumber)
        Else
            dblActivitiesTotal = 0
        End If

        'get reservation data based on passed in confirmation number
        Me.ReservationsTableAdapter.FillByConfirmationNumber(Me.ReservationDataSet.reservations, _
            confirmation_number:=intRecConfirmationNumber)

        'calculate/recalculate tax, current total, etc.
        dblBasePrice = ReservationDataSet.Tables(0).Rows(0)(4)
        dblTaxAmount = (dblBasePrice + dblActivitiesTotal) * 0.3
        dblCurrentTotal = (dblBasePrice + dblActivitiesTotal) + dblTaxAmount

        'display calculations
        lblBasePrice.Text = "$" + dblBasePrice.ToString("#,##0.00")
        lblActivitiesTotal.Text = "$" + dblActivitiesTotal.ToString("#,##0.00")
        lblTaxes.Text = "$" + dblTaxAmount.ToString("#,##0.00")
        lblCurTotal.Text = "$" + dblCurrentTotal.ToString("#,##0.00")

        'update reservation with new calculated data
        ReservationsTableAdapter.UpdateReservationBeyondBasePrice(confirmation_number:=intRecConfirmationNumber, _
            activities_total:=dblActivitiesTotal, tax_amount:=dblTaxAmount, current_total:=dblCurrentTotal)

    End Sub

    'check database for selected activities, bring in all activities, display them on lables, show selected ones as already selected
    Private Sub frmSelectPackages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblNumberOfAdults.Text = intRecNumberOfAdults.ToString + " adult(s),"
        lblDepartureDate.Text = dtmRecDepartureDate.ToString
        lblReturnDate.Text = dtmRecReturnDate.ToString

        'for each activity number, check the database for the given confirmation number's selected activities
        For intActivityNumber As Integer = 1 To 15
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=intActivityNumber)

            'if the database shows an activity is selected for the current confirmation number, show the box checked by default
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 1 Then

                If intActivityNumber = 1 Then
                    chkActivity1.Checked = True
                End If
                If intActivityNumber = 2 Then
                    chkActivity2.Checked = True
                End If
                If intActivityNumber = 3 Then
                    chkActivity3.Checked = True
                End If
                If intActivityNumber = 4 Then
                    chkActivity4.Checked = True
                End If
                If intActivityNumber = 5 Then
                    chkActivity5.Checked = True
                End If
                If intActivityNumber = 6 Then
                    chkActivity6.Checked = True
                End If
                If intActivityNumber = 7 Then
                    chkActivity7.Checked = True
                End If
                If intActivityNumber = 8 Then
                    chkActivity8.Checked = True
                End If
                If intActivityNumber = 9 Then
                    chkActivity9.Checked = True
                End If
                If intActivityNumber = 10 Then
                    chkActivity10.Checked = True
                End If
                If intActivityNumber = 11 Then
                    chkActivity11.Checked = True
                End If
                If intActivityNumber = 12 Then
                    chkActivity12.Checked = True
                End If
                If intActivityNumber = 13 Then
                    chkActivity13.Checked = True
                End If
                If intActivityNumber = 14 Then
                    chkActivity14.Checked = True
                End If
                If intActivityNumber = 15 Then
                    chkActivity15.Checked = True
                End If

            End If
        Next

        CalculateSummaryBlock()

        'make sure activity cost gridview displays $'s
        DataGridView1.Columns(1).DefaultCellStyle.Format = "C2"

        'fill data set with activity info from activities table, for use in panel
        Me.ActivitiesTableAdapter.Fill(Me.AmsterdamDataSet.activities)

        'bring in activity names
        lblTest.Text = AmsterdamDataSet.Tables(0).Rows(0)(1).ToString()
        Label2.Text = AmsterdamDataSet.Tables(0).Rows(1)(1).ToString()
        Label3.Text = AmsterdamDataSet.Tables(0).Rows(2)(1).ToString()
        Label4.Text = AmsterdamDataSet.Tables(0).Rows(3)(1).ToString()
        Label5.Text = AmsterdamDataSet.Tables(0).Rows(4)(1).ToString()
        Label6.Text = AmsterdamDataSet.Tables(0).Rows(5)(1).ToString()
        Label7.Text = AmsterdamDataSet.Tables(0).Rows(6)(1).ToString()
        Label8.Text = AmsterdamDataSet.Tables(0).Rows(7)(1).ToString()
        Label9.Text = AmsterdamDataSet.Tables(0).Rows(8)(1).ToString()
        Label10.Text = AmsterdamDataSet.Tables(0).Rows(9)(1).ToString()
        Label11.Text = AmsterdamDataSet.Tables(0).Rows(10)(1).ToString()
        Label12.Text = AmsterdamDataSet.Tables(0).Rows(11)(1).ToString()
        Label13.Text = AmsterdamDataSet.Tables(0).Rows(12)(1).ToString()
        Label14.Text = AmsterdamDataSet.Tables(0).Rows(13)(1).ToString()
        Label15.Text = AmsterdamDataSet.Tables(0).Rows(14)(1).ToString()

        'bring in activity descriptions
        lblDesc1.Text = AmsterdamDataSet.Tables(0).Rows(0)(2).ToString()
        lblDesc2.Text = AmsterdamDataSet.Tables(0).Rows(1)(2).ToString()
        lblDesc3.Text = AmsterdamDataSet.Tables(0).Rows(2)(2).ToString()
        lblDesc4.Text = AmsterdamDataSet.Tables(0).Rows(3)(2).ToString()
        lblDesc5.Text = AmsterdamDataSet.Tables(0).Rows(4)(2).ToString()
        lblDesc6.Text = AmsterdamDataSet.Tables(0).Rows(5)(2).ToString()
        lblDesc7.Text = AmsterdamDataSet.Tables(0).Rows(6)(2).ToString()
        lblDesc8.Text = AmsterdamDataSet.Tables(0).Rows(7)(2).ToString()
        lblDesc9.Text = AmsterdamDataSet.Tables(0).Rows(8)(2).ToString()
        lblDesc10.Text = AmsterdamDataSet.Tables(0).Rows(9)(2).ToString()
        lblDesc11.Text = AmsterdamDataSet.Tables(0).Rows(10)(2).ToString()
        lblDesc12.Text = AmsterdamDataSet.Tables(0).Rows(11)(2).ToString()
        lblDesc13.Text = AmsterdamDataSet.Tables(0).Rows(12)(2).ToString()
        lblDesc14.Text = AmsterdamDataSet.Tables(0).Rows(13)(2).ToString()
        lblDesc15.Text = AmsterdamDataSet.Tables(0).Rows(14)(2).ToString()

        'bring in activity prices
        lblPrice1.Text = "$" + AmsterdamDataSet.Tables(0).Rows(0)(3).ToString()
        lblPrice2.Text = "$" + AmsterdamDataSet.Tables(0).Rows(1)(3).ToString()
        lblPrice3.Text = "$" + AmsterdamDataSet.Tables(0).Rows(2)(3).ToString()
        lblPrice4.Text = "$" + AmsterdamDataSet.Tables(0).Rows(3)(3).ToString()
        lblPrice5.Text = "$" + AmsterdamDataSet.Tables(0).Rows(4)(3).ToString()
        lblPrice6.Text = "$" + AmsterdamDataSet.Tables(0).Rows(5)(3).ToString()
        lblPrice7.Text = "$" + AmsterdamDataSet.Tables(0).Rows(6)(3).ToString()
        lblPrice8.Text = "$" + AmsterdamDataSet.Tables(0).Rows(7)(3).ToString()
        lblPrice9.Text = "$" + AmsterdamDataSet.Tables(0).Rows(8)(3).ToString()
        lblPrice10.Text = "$" + AmsterdamDataSet.Tables(0).Rows(9)(3).ToString()
        lblPrice11.Text = "$" + AmsterdamDataSet.Tables(0).Rows(10)(3).ToString()
        lblPrice12.Text = "$" + AmsterdamDataSet.Tables(0).Rows(11)(3).ToString()
        lblPrice13.Text = "$" + AmsterdamDataSet.Tables(0).Rows(12)(3).ToString()
        lblPrice14.Text = "$" + AmsterdamDataSet.Tables(0).Rows(13)(3).ToString()
        lblPrice15.Text = "$" + AmsterdamDataSet.Tables(0).Rows(14)(3).ToString()

    End Sub

    '**************************************************************************************
    'This block repeats once for each activity, there are 15 - when the user checks or unchecks a box, this code will run.
    'upon making the box checked, if activity isn't already in DB then it will be added with confirmation number to reservation_activities table,
    'if it IS already there, it does not need to be re-added and won't be
    Private Sub chkActivity1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity1.CheckedChanged

        If chkActivity1.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=1)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=1)
            End If
        Else
            'if we are unchecking the box, remove row from reservations_activities table
            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=1)
        End If

        'call sub that recalculates all numbers/totals and re-displays
        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity2.CheckedChanged

        If chkActivity2.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=2)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=2)
            End If
        Else
            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=2)
        End If
        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity3.CheckedChanged
        If chkActivity3.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=3)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=3)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=3)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity4.CheckedChanged
        If chkActivity4.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=4)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=4)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=4)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity5.CheckedChanged
        If chkActivity5.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=5)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=5)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=5)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity6.CheckedChanged
        If chkActivity6.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=6)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=6)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=6)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity7.CheckedChanged
        If chkActivity7.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=7)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=7)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=7)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity8.CheckedChanged
        If chkActivity8.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=8)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=8)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=8)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity9.CheckedChanged
        If chkActivity9.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=9)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=9)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=9)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity10.CheckedChanged
        If chkActivity10.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=10)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=10)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=10)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity11.CheckedChanged
        If chkActivity11.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=11)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=11)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=11)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity12.CheckedChanged
        If chkActivity12.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=12)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=12)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=12)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity13.CheckedChanged
        If chkActivity13.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=13)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=13)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=13)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity14.CheckedChanged
        If chkActivity14.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=14)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=14)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=14)
        End If

        CalculateSummaryBlock()
    End Sub

    Private Sub chkActivity15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivity15.CheckedChanged
        If chkActivity15.CheckState = 1 Then

            'TODO: This line of code loads data into the 'ReservationActivitiesTableDataSet.reservation_activities' table. You can move, or remove it, as needed.
            Reservation_activitiesTableAdapter.FillByConfirmationAndActivity(ReservationActivitiesTableDataSet.reservation_activities, _
                confirmation_number:=intRecConfirmationNumber, activity_number:=15)
            If ReservationActivitiesTableDataSet.Tables(0).Rows.Count = 0 Then
                Reservation_activitiesTableAdapter.InsertQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=15)
            End If
        Else

            Reservation_activitiesTableAdapter.DeleteQuery(confirmation_number:=intRecConfirmationNumber, activity_number:=15)
        End If

        CalculateSummaryBlock()
    End Sub

    'create new instance of next form, pass it the confirmation number
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim frmCustinfo As New frmCustomerInformation(intRecConfirmationNumber)
        frmCustinfo.Show(Me)
        Me.Hide()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Owner.Show()
        Me.Hide()
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
        frmSelectPackagesHelp.ShowDialog(Me)

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
