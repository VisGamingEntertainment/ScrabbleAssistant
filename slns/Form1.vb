Public Class Form1

Public Enum GameModes 'List of modes available
Classic = 0
TimeLimit = 1
ScoreMad = 2
Challenge = 3
End Enum
    Private Sub Opt1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt1.CheckedChanged
        If Opt1.Checked = True Then
            TxtName2.Enabled = False
            TxtName3.Enabled = False
            TxtName4.Enabled = False
            TxtName5.Enabled = False
            TxtName6.Enabled = False
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = False
            LblName3.Enabled = False
            LblName4.Enabled = False
            LblName5.Enabled = False
            LblName6.Enabled = False
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub
    
        Private Sub Opt2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt2.CheckedChanged
        If Opt2.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = False
            TxtName4.Enabled = False
            TxtName5.Enabled = False
            TxtName6.Enabled = False
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = False
            LblName4.Enabled = False
            LblName5.Enabled = False
            LblName6.Enabled = False
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt3.CheckedChanged
        If Opt3.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = False
            TxtName5.Enabled = False
            TxtName6.Enabled = False
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = False
            LblName5.Enabled = False
            LblName6.Enabled = False
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt4.CheckedChanged
        If Opt4.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = True
            TxtName5.Enabled = False
            TxtName6.Enabled = False
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = True
            LblName5.Enabled = False
            LblName6.Enabled = False
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt5.CheckedChanged
        If Opt5.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = True
            TxtName5.Enabled = True
            TxtName6.Enabled = False
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = True
            LblName5.Enabled = True
            LblName6.Enabled = False
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt6.CheckedChanged
        If Opt6.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = True
            TxtName5.Enabled = True
            TxtName6.Enabled = True
            TxtName7.Enabled = False
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = True
            LblName5.Enabled = True
            LblName6.Enabled = True
            LblName7.Enabled = False
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt7.CheckedChanged
        If Opt7.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = True
            TxtName5.Enabled = True
            TxtName6.Enabled = True
            TxtName7.Enabled = True
            TxtName8.Enabled = False
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = True
            LblName5.Enabled = True
            LblName6.Enabled = True
            LblName7.Enabled = True
            LblName8.Enabled = False
        End If
    End Sub

    Private Sub Opt8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Opt8.CheckedChanged
        If Opt8.Checked = True Then
            TxtName2.Enabled = True
            TxtName3.Enabled = True
            TxtName4.Enabled = True
            TxtName5.Enabled = True
            TxtName6.Enabled = True
            TxtName7.Enabled = True
            TxtName8.Enabled = True
            LblName2.Enabled = True
            LblName3.Enabled = True
            LblName4.Enabled = True
            LblName5.Enabled = True
            LblName6.Enabled = True
            LblName7.Enabled = True
            LblName8.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As System.EventArgs) Handles ComboBox1.Click
        'Classic Scrabble
        'Time Attack
        'Point Madness
        'Challenge Mode
'TODO assign modes to the next form
        Select Case ComboBox1.Text
            Case "Classic Scrabble"
                Label14.Text = "A classic game of Scrabble for everyone which uses the usual rules of Scrabble. Not that fun, but it's a good start"
            Case "Time Attack"
                Label14.Text = "Play Scrabble with a time limit on each move! The game can also be configured to have its own time limit. Useful for Quick plays!"
            Case "Point Madness"
                Label14.Text = "Adds new rules regarding how to earn points in the game. For those who love to earn numbers!"
            Case "Challenge Mode"
                Label14.Text = "Challenges just for Scrabble!"
        End Select
    End Sub
End Class
