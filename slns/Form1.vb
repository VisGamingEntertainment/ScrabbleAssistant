Public Class Form1

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
End Class
