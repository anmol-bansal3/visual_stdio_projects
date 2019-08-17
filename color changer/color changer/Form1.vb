Public Class Form1

    

    Private Sub chkred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkred.CheckedChanged
        If chkred.Checked = True Then
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub chkblue_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkblue.CheckedChanged
        If chkblue.Checked = True Then
            Me.BackColor = Color.Blue
        End If
    End Sub

    Private Sub chkorange_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkorange.CheckedChanged
        If chkorange.Checked = True Then
            Me.BackColor = Color.Orange
        End If
    End Sub
End Class
