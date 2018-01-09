Public Class ArtofWarMenu
    Dim second As Integer

    Private Sub ArtofWarMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrLogo.Interval = 5000
        tmrLogo.Start() 'Timer starts functioning


        'If picLogo.Visible And picBackGround.Visible = False Then
        WindowsMediaPlayer.Hide()
        WindowsMediaPlayer.URL = "C:\Users\jp134125\Desktop\Visual Basic\FinalVB-1\ART of WAR\ART of WAR\Resources\The Prisoner.wav"
        WindowsMediaPlayer.Ctlcontrols.play()
        'WindowsMediaPlayer.settings.volume = WindowsMediaPlayer.settings.volume = 35
        'End If
    End Sub

    Private Sub tmrLogo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogo.Tick
        picLogo.Visible = False
        picBackGround.Visible = False


        second = second + 1
        If second >= 10 Then
            tmrLogo.Stop() 'Timer stops functioning
        End If
    End Sub

    Private Sub btnCampaign_Click(sender As Object, e As EventArgs) Handles btnCampaign.Click
        Me.Hide()
        CampaignMenu.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class