'******************************************************************************************
'Module/Form:           frmAboutHotel.vb
'Written by:            Leonard Evans
'Latest Version Date:   2/16/2010
'Description:           This is a pop-up form derived from frmPopupT that provides 
'                       information about the hotel.  This form is accessed via a hotspot
'                       on frmTravelMap.vb.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmAboutHotel

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.frmPopupT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmAboutHotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
