Public Class Credits
    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load

        AxWindowsMediaPlayer1.Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ArtofWarMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ArtofWarMenu.Close()
    End Sub
End Class