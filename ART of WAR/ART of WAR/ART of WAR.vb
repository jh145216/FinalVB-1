Public Class ArtofWarMenu
    Dim second As Integer

    Private Sub ArtofWarMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        tmrLogo.Interval = 5000
        tmrLogo.Start() 'Timer starts functioning

    End Sub

    Private Sub tmrLogo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogo.Tick
        picLogo.Visible = False
        picBackGround.Visible = False

        AxWindowsMediaPlayer1.Hide()
        If Me.Visible = True Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
        second = second + 1
        If second >= 10 Then
            tmrLogo.Stop() 'Timer stops functioning

        End If
    End Sub

    Private Sub btnCampaign_Click(sender As Object, e As EventArgs) Handles btnCampaign.Click
        Me.Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        CampaignMenu.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        Me.Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Credits.Show()
    End Sub

End Class
