'******************************************************************************************
'Module/Form:           frmLanguage.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form contains some common phrases in Dutch and English.
'                       It inherits from the MainT template.  It also plays sample sounds.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmLanguage

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        HostCitySubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub frmLanguage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAmsterdamProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmsterdamProfile.Click
        My.Computer.Audio.Stop()
        HostCitySubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnVacationLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVacationLine.Click
        My.Computer.Audio.Stop()
        VacationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        My.Computer.Audio.Stop()
        ReservationSubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlay1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay1.Click
        My.Computer.Audio.Play(My.Resources.hallo, AudioPlayMode.Background)
    End Sub

    Private Sub btnStop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop1.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnPlay2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay2.Click
        My.Computer.Audio.Play(My.Resources.hoemaaktUhet, AudioPlayMode.Background)
    End Sub

    Private Sub btnStop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop2.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnPlay3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay3.Click
        My.Computer.Audio.Play(My.Resources.kuntUdatnogeens, AudioPlayMode.Background)
    End Sub

    Private Sub btnStop3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop3.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        My.Computer.Audio.Stop()
        frmLanguageHelp.showdialog()

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines
End Class
