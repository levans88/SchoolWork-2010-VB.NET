'******************************************************************************************
'Module/Form:           frmTravelMap.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form contains the a map of the project city's center showing
'                       the location of the hotel and providing a hotspot link to more
'                       information on another form.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmTravelMap

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.MainT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub btnTravelMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHotelOkura.Click
        frmAboutHotel.ShowDialog()
        frmAboutHotel.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HostCitySubSystem.Show()
        Me.Hide()
    End Sub

    Private Sub lblHotelHotSpot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHotelHotSpot.Click
        frmAboutHotel.ShowDialog()
        frmAboutHotel.Focus()

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
        frmTravelMapHelp.ShowDialog()

    End Sub
    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
