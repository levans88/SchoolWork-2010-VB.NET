'******************************************************************************************
'Module/Form:           frmCurrencyConversion.vb
'Written by:            Leonard Evans
'Latest Version Date:   2/16/2010
'Description:           This form allows for converting US Dollars to Euros, or Euros to 
'                       US Dollars.  It will show an error message in the form if the user
'                       enters non-numeric characters or does not enter a value before
'                       pressing a convert button.  The form is derived from frmPopupT.vb.
'******************************************************************************************

Option Explicit On

'Any import statements go here, to reference namespaces
'outside current project, ex:

'Imports System.IO
'Imports Str = Microsoft.VisualBasic.Strings  'Can use an alias

Public Class frmCurrencyConversion

    'If there is an Inherits statement, it must appear here
    Inherits BaseFormLibrary.frmPopupT

    '[Windows Form Designer generated code]

    '[Other WFD generated code can go here, ex., Standard Menu Code]

    '*** MODULE-LEVEL DECLARATIONS ***
    Dim decUSD As Decimal
    Dim strUSD As String

    Dim decEuro As Decimal
    Dim strEuro As String

    Dim strEuroSymbol As String
    Dim strUSDSymbol As String

    '*** INITIALIZATION STATEMENTS ***
    'These were handled in the "do not modify by hand" section of the the Designer's code

    '*** FORM EVENT PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HostCitySubSystem.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    'This form event procedure is executed when the user presses the
    '"US Dollars to Euros" button.  It first gets the contents of the Dollars text box,
    'and if it was not empty (excluding the currency symbol), it trims out the currency symbol
    'and performs the calculation.  The result is converted to string with the appropriate
    'currency symbol appended to it and displayed in the associated read-only output text box.
    'An error is shown to the user if the input box was empty or contained non-numeric data.

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertUSDtoEuros.Click

        strEuroSymbol = "€"
        strUSDSymbol = "$"

        If txtInputCurrencyUSD.Text.Equals("") Or txtInputCurrencyUSD.Text.Equals("$") Then
            lblMessage.Text = "You must enter a value."
        ElseIf IsNumeric(txtInputCurrencyUSD.Text.Trim("$")) Then

            lblMessage.Text = ""
            decUSD = txtInputCurrencyUSD.Text.Trim("$")
            decEuro = decUSD * 0.735402265
            decEuro = Decimal.Round(decEuro, 2)

            strEuro = Decimal.Parse(decEuro).ToString()

            txtOutputCurrencyEuros.Text = strEuroSymbol & strEuro
            txtInputCurrencyUSD.Text = strUSDSymbol & decUSD
        Else
            lblMessage.Text = "Value must be numeric."
        End If

    End Sub

    'This form event procedure is executed when the user presses the
    '"Euros to US Dollars" button.  It first gets the contents of the Euros text box,
    'and if it was not empty (excluding the currency symbol), it trims out the currency symbol
    'and performs the calculation.  The result is converted to string with the appropriate
    'currency symbol appended to it and displayed in the associated read-only output text box.
    'An error is shown to the user if the input box was empty or contained non-numeric data.

    Private Sub btnConvertEurosToUSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertEurosToUSD.Click

        If txtInputCurrencyEuros.Text.Equals("") Or txtInputCurrencyEuros.Text.Equals("€") Then
            lblMessage.Text = "You must enter a value."
        ElseIf IsNumeric(txtInputCurrencyEuros.Text.Trim("€")) Then

            lblMessage.Text = ""
            decEuro = txtInputCurrencyEuros.Text.Trim("€")
            decUSD = decEuro * 1.3598
            decUSD = Decimal.Round(decUSD, 2)

            strUSD = Decimal.Parse(decUSD).ToString()

            txtOutputCurrencyUSD.Text = strUSDSymbol & strUSD
            txtInputCurrencyEuros.Text = strEuroSymbol & decEuro
        Else
            lblMessage.Text = "Value must be numeric."
        End If

    End Sub

    '*** GENERAL PROCEDURES ***
    'Document purpose/activity of any code block > 5 lines

End Class
