'******************************************************************************************
'Module/Form:           frmConfirmationPage.vb
'Written by:            Leonard Evans
'Latest Version Date:   5/3/2010
'Description:           This form is inherited from frmPopupT.vb, and provides a 
'                       confirmation number for the user and a back button.  The 
'                       reservation can still be modified by using the "previous" button.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmConfirmationPage

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.frmPopupT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Dim intRecConfirmationNumber As Integer

    'enable transparency
    Public Sub New(ByVal intConfirmationNumber As Integer)
        InitializeComponent()
        intRecConfirmationNumber = intConfirmationNumber

        lblMainText.Parent = PictureBox4
        lblMainText.BackColor = Color.Transparent

        lblConfirmationNumber.Parent = PictureBox4
        lblConfirmationNumber.BackColor = Color.Transparent

        lblCaption.Parent = PictureBox4
        lblCaption.BackColor = Color.Transparent

    End Sub

    Private Sub frmConfirmationPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblConfirmationNumber.Text = intRecConfirmationNumber
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
        Me.Dispose()

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
