'******************************************************************************************
'Module/Form:           MainT.vb
'Written by:            Leonard Evans
'Latest Version Date:   3/8/2010
'Description:           This is the main template from which other screen sized forms are
'                       derived.  It sets the functionality of the bottom menu buttons, 
'                       the hidden exit button, and structures layout/images on any
'                       derived forms.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class MainT

    'If there is an Inherits statement, it must appear here

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()

    End Sub

    Private Sub btnAmsterdamProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmsterdamProfile.Click

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
