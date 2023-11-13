Public Class frmQuestion2
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        Me.Hide()

    End Sub

    Private Sub ProgressBarQ2_Click(sender As Object, e As EventArgs) Handles ProgressBarQ2.Click

    End Sub
End Class