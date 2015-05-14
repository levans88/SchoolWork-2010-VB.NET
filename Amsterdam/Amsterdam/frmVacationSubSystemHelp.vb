'******************************************************************************************
'Module/Form:           frmVacationSubSystemHelp.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This is the help form for the vacation sub system.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmVacationSubSystemHelp

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.frmHelp

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        VacationSubSystem.Show()
        Me.Close()
        Me.Dispose()

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
