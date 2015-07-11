Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Font = SystemFonts.MessageBoxFont

        radNormal.Font = New Font(Font, FontStyle.Bold)
        radError.Font = radNormal.Font
        radPaused.Font = radNormal.Font
        radMarquee.Font = radNormal.Font
    End Sub

    Private Sub radNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNormal.CheckedChanged

        If radNormal.Checked Then
            progressor.Enabled = True
            windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Normal
        End If

    End Sub

    Private Sub radPaused_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaused.CheckedChanged

        If radPaused.Checked Then
            progressor.Enabled = False
            windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Pause
        End If

    End Sub

    Private Sub radError_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radError.CheckedChanged

        If radError.Checked Then
            progressor.Enabled = False
            windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Error
        End If

    End Sub

    Private Sub radMarquee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMarquee.CheckedChanged

        If radMarquee.Checked Then
            progressor.Enabled = False
            windows7ProgressBar.Style = ProgressBarStyle.Marquee
        End If

    End Sub

    Private Sub chkShowInTaskbar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowInTaskbar.CheckedChanged
        windows7ProgressBar.ShowInTaskbar = chkShowInTaskbar.Checked
    End Sub

    Private Sub progressor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progressor.Tick

        If windows7ProgressBar.Value = 100 Then
            windows7ProgressBar.Value = 0
        Else
            windows7ProgressBar.Increment(1)
        End If

    End Sub
End Class
