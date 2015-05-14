'******************************************************************************************
'Module/Form:           frmReservationSummary.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form displays all collected and calculated information to the
'                       user before finalizing the reservation.  It is re-used as the
'                       cancel reservation screen when the user cancels an existing trip.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmReservationSummary

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Dim intRecConfirmationNumber As Integer

    'receive the confirmation number
    Public Sub New(ByVal intConfirmationNumber As Integer)
        InitializeComponent()
        intRecConfirmationNumber = intConfirmationNumber

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Owner.Show()
        Me.Hide()
    End Sub

    Private Sub frmReservationSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'if this instance of summary form was called from main reservation sub system page, then we're doing a cancel, and only show cancel button
        If Me.Owner.Equals(ReservationSubSystem) Then
            btnPrevious.Visible = False
            btnConfirm.Visible = False
            btnCancelReservation.Visible = True
            btnReturnWithoutCancel.Visible = True
            'also change page text
            lblPageText.Text = "Press cancel if you are absolutely sure you want to cancel your reservation."
        End If

        'get data for the 3 data grids based on confirmation number

        'TODO: This line of code loads data into the 'CustomerSummaryInfo.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomerSummaryInfo.customers, confirmation_number:=intRecConfirmationNumber)

        'TODO: This line of code loads data into the 'ActivitiesSummaryInfo.activities' table. You can move, or remove it, as needed.
        Me.ActivitiesTableAdapter.Fill(Me.ActivitiesSummaryInfo.activities, confirmaiton_number:=intRecConfirmationNumber)

        'TODO: This line of code loads data into the 'ReservationSummaryInfo.reservations' table. You can move, or remove it, as needed.
        Me.ReservationsTableAdapter.Fill(Me.ReservationSummaryInfo.reservations, confirmation_number:=intRecConfirmationNumber)

        DataGridView1.Columns(3).DefaultCellStyle.Format = "C2"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "C2"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "C2"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "C2"

        DataGridView2.Columns(2).DefaultCellStyle.Format = "C2"



    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim frmConf As New frmConfirmationPage(intRecConfirmationNumber)
        frmConf.ShowDialog(Me)
        HostCitySubSystem.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelReservation.Click

        'erase all records in all tables for the current confirmation number
        ReservationsTableAdapter.DeleteReservation(confirmation_number:=intRecConfirmationNumber)
        ActivitiesTableAdapter.DeleteActivitiesForReservation(confirmation_number:=intRecConfirmationNumber)
        CustomersTableAdapter.DeleteCustomerDataForReservation(confirmation_number:=intRecConfirmationNumber)

        're-build the datasets so grids are updated to display that there is no data for the confirmation number anymore

        'TODO: This line of code loads data into the 'CustomerSummaryInfo.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomerSummaryInfo.customers, confirmation_number:=intRecConfirmationNumber)

        'TODO: This line of code loads data into the 'ActivitiesSummaryInfo.activities' table. You can move, or remove it, as needed.
        Me.ActivitiesTableAdapter.Fill(Me.ActivitiesSummaryInfo.activities, confirmaiton_number:=intRecConfirmationNumber)

        'TODO: This line of code loads data into the 'ReservationSummaryInfo.reservations' table. You can move, or remove it, as needed.
        Me.ReservationsTableAdapter.Fill(Me.ReservationSummaryInfo.reservations, confirmation_number:=intRecConfirmationNumber)

        'show label and change buttons
        lblCancelComplete.Visible = True
        btnReturnWithoutCancel.Text = "Return to Welcome Screen"
        btnCancelReservation.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReservationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
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

    Private Sub btnReturnWithoutCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnWithoutCancel.Click
        HostCitySubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmReservationSummaryHelp.ShowDialog(Me)

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines
End Class

