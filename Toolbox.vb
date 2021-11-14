Public Class Toolbox

    Public Shared Sub AddToRich(rich As RichTextBox, text As String, color As Color)
        rich.SelectionColor = color
        rich.SelectedText = text
    End Sub
    Public Shared Function TestKeyPress(key As String, type As String) As Boolean
        Dim ReturnValue As Boolean = False
        Select Case LCase(type)
            Case "alphanumeric"
                If Not ((Asc(key) = 8 OrElse key = " ") OrElse (key >= "A" AndAlso key <= "Z") _
                    OrElse (key >= "a" AndAlso key <= "z") OrElse (key >= "0" AndAlso key <= "9")) Then
                    ReturnValue = True
                    WarningSound()
                Else
                    ReturnValue = False
                End If
            Case "numbers"
                If Not ((Asc(key) = 8 OrElse key = ".") OrElse (key >= "0" AndAlso key <= "9")) Then
                    ReturnValue = True
                    WarningSound()
                Else
                    ReturnValue = False
                End If
            Case "negnumbers"
                If Not ((Asc(key) = 8 OrElse key = "." OrElse key = "-") OrElse (key >= "0" AndAlso key <= "9")) Then
                    ReturnValue = True
                    WarningSound()
                Else
                    ReturnValue = False
                End If
            Case "letters"
                If Not ((Asc(key) = 8) OrElse (key >= "A" AndAlso key <= "Z") OrElse (key >= "a" _
                    AndAlso key <= "z")) Then
                    ReturnValue = True
                    WarningSound()
                Else
                    ReturnValue = False
                End If
        End Select
        Return ReturnValue
    End Function
    Private Shared Sub WarningSound()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
    End Sub

    Public Shared Function DoubleUp(amount As String, numofzeroes As Long)
        Return FormatCurrency(amount, numofzeroes, , TriState.True, TriState.True)
    End Function
    Public Shared Sub ZeroIfBlank(textbox As TextBox)
        If textbox.Text = "" Then textbox.Text = "$0.00"
    End Sub
    Public Shared Function CTGExtractor(text As String) As String
        Return text
    End Function
    Public Shared Function CTGRBuilder(text As String)
        Return text
    End Function
End Class
