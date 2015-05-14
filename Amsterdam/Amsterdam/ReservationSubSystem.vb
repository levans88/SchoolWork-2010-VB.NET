'******************************************************************************************
'Module/Form:           ReservationSubSystem.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This is the main form for the reservation system.  It gives the 
'                       user buttons/links to make, modify, or cancel a reservation, and
'                       provides brief instructions on how to do so.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class ReservationSubSystem

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Dim intConfirmationNumber As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HostCitySubSystem.Show()
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

    Private Sub btnTravelMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeReservation.Click
        Dim frmMakeRes As New frmMakeReservation(0)
        frmMakeRes.Show(Me)
        Me.Hide()
    End Sub

    'check if fields are empty or invalid (for change reservation button, confirmation # not found in database), set to red if so
    'show frmMakeReservation form, pass it the confirmation number we are working on
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtConfirmationNumber.Text.Equals("") Then
            lblEnterConf.ForeColor = Color.Red
        Else
            intConfirmationNumber = txtConfirmationNumber.Text
            'if confirmation number is not in DB...
            If Not ReservationsTableAdapterForReservationSubSystem.GetDataByConfirmationNumberForCount _
            (confirmation_number:=intConfirmationNumber).Rows.Count = 1 Then
                lblEnterConf.ForeColor = Color.Red
            Else
                lblEnterConf.ForeColor = Color.Black
                lblEnterConf2.ForeColor = Color.Black
                Dim frmMakeRes As New frmMakeReservation(intConfirmationNumber)
                frmMakeRes.Show(Me)
                Me.Hide()
            End If
        End If

    End Sub

    'check if fields are empty or invalid (for cancel a reservation button, confirmation # not found in database), set to red if so
    'show frmReservationSummary form, pass it the confirmation number we are working on
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtConfirmationNumber2.Text.Equals("") Then
            lblEnterConf2.ForeColor = Color.Red
        Else
            intConfirmationNumber = txtConfirmationNumber2.Text
            'if confirmation number is not in DB...
            If Not ReservationsTableAdapterForReservationSubSystem.GetDataByConfirmationNumberForCount _
            (confirmation_number:=intConfirmationNumber).Rows.Count = 1 Then
                lblEnterConf2.ForeColor = Color.Red
            Else
                lblEnterConf2.ForeColor = Color.Black
                lblEnterConf.ForeColor = Color.Black
                Dim frmResSum As New frmReservationSummary(intConfirmationNumber)
                frmResSum.Show(Me)
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub ReservationSubSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmReservationSubSystemHelp.ShowDialog()

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
