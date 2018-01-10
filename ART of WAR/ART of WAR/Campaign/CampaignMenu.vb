Public Class CampaignMenu

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ArtofWarMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSinglePlayer_Click(sender As Object, e As EventArgs) Handles btnSinglePlayer.Click
        Level1.Show()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ArtofWarMenu.Close()
    End Sub
End Class