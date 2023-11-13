Public Class frmHighScore
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "sorry your score was Not Good Enough"
        Else
            lblMessage.Text = "congratulation your score will Be Added to the Hall of fame"
            lstHighScore.Items.Add(playerName & vbTab & playerScore)
        End If
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()

    End Sub
End Class