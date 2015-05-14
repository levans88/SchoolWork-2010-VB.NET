'******************************************************************************************
'Module/Form:           HostCitySubSystem.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This is the main form and welcome screen in the Amsterdam project.
'                       It inherits from the MainT template and provides access to the
'                       rest of the forms in the project.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias
Imports System.Runtime.InteropServices.ComTypes

Public Class HostCitySubSystem

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub HostCitySubSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'prep for API call for getting current date/time, then convert it to Amsterdam time and display it
        Dim t As ULong
        GetSystemTimeAsFileTime(t)
        Dim dd As DateTime = Date.FromFileTime(t)
        lblAmsterdamTime.Text = "Local Time is:  " + dd.AddHours(7).ToShortTimeString
    End Sub

    'API call
    Public Declare Sub GetSystemTimeAsFileTime Lib "kernel32.dll" (ByRef t As ULong)

    Private Sub btnTravelMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTravelMap.Click
        wmPlayer.Ctlcontrols.stop()
        frmTravelMap.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        wmPlayer.Ctlcontrols.stop()
        frmHistory.Show()
        Me.Hide()
    End Sub

    Private Sub btnLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanguage.Click
        wmPlayer.Ctlcontrols.stop()
        frmLanguage.Show()
        Me.Hide()
    End Sub

    Private Sub btnLocalTravel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalTravel.Click
        wmPlayer.Ctlcontrols.stop()
        frmLocalTravel.Show()
        Me.Hide()
    End Sub

    Private Sub btnCurrencyConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrencyConversion.Click
        wmPlayer.Ctlcontrols.stop()
        frmCurrencyConversion.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnVacationLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVacationLine.Click
        wmPlayer.Ctlcontrols.stop()
        VacationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        wmPlayer.Ctlcontrols.stop()
        ReservationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        wmPlayer.Ctlcontrols.stop()
        frmHostCitySubSystemHelp.ShowDialog()
    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class