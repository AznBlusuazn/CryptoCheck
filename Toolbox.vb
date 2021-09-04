Public Class Toolbox
    Public Shared Function VersionConverter(versionpart As String, digits As Integer) As String
        Dim PartLength As Integer = Len(versionpart)
        Select Case PartLength
            Case digits - 1
                VersionConverter = "0" + versionpart
            Case digits - 2
                VersionConverter = "00" + versionpart
            Case digits - 3
                VersionConverter = "000" + versionpart
            Case digits - 4
                VersionConverter = "0000" + versionpart
            Case Else
                VersionConverter = versionpart
        End Select
    End Function
    Public Shared Sub AddToRich(rich As RichTextBox, text As String, color As Color)
        rich.SelectionColor = color
        rich.SelectedText = text
    End Sub
    Public Shared Sub GoToWeb(url As String)
        Try
            Process.Start(url)
        Catch ex As Exception
            'Logger.Logger.WriteToLog(1, "GoToWeb", "Something went wrong with launching system your browser." &
            '    vbCrLf & vbCrLf & "Please try going to " & url & " manually.", ex)
        End Try
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
