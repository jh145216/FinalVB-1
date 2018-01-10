<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtofWarMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtofWarMenu))
        Me.btnCampaign = New System.Windows.Forms.Button()
        Me.btnSurvivleMode = New System.Windows.Forms.Button()
        Me.btnMulitplayer = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tmrLogo = New System.Windows.Forms.Timer(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSoldier = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picBackGround = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCampaign
        '
        Me.btnCampaign.BackColor = System.Drawing.Color.Transparent
        Me.btnCampaign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCampaign.Location = New System.Drawing.Point(191, 110)
        Me.btnCampaign.Name = "btnCampaign"
        Me.btnCampaign.Size = New System.Drawing.Size(190, 32)
        Me.btnCampaign.TabIndex = 0
        Me.btnCampaign.Text = "Campaign"
        Me.btnCampaign.UseVisualStyleBackColor = False
        '
        'btnSurvivleMode
        '
        Me.btnSurvivleMode.BackColor = System.Drawing.Color.Transparent
        Me.btnSurvivleMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurvivleMode.Location = New System.Drawing.Point(177, 205)
        Me.btnSurvivleMode.Name = "btnSurvivleMode"
        Me.btnSurvivleMode.Size = New System.Drawing.Size(215, 28)
        Me.btnSurvivleMode.TabIndex = 1
        Me.btnSurvivleMode.Text = "Survival Mode(Coming Soon)"
        Me.btnSurvivleMode.UseVisualStyleBackColor = False
        '
        'btnMulitplayer
        '
        Me.btnMulitplayer.BackColor = System.Drawing.Color.Transparent
        Me.btnMulitplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulitplayer.Location = New System.Drawing.Point(183, 156)
        Me.btnMulitplayer.Name = "btnMulitplayer"
        Me.btnMulitplayer.Size = New System.Drawing.Size(207, 30)
        Me.btnMulitplayer.TabIndex = 2
        Me.btnMulitplayer.Text = "Muitiplayer (Coming Soon)"
        Me.btnMulitplayer.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(191, 359)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(190, 32)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Snow
        Me.lblTitle.Location = New System.Drawing.Point(174, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 54)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Art of War"
        '
        'tmrLogo
        '
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(191, 307)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(190, 32)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings (WIP)"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnSoldier
        '
        Me.btnSoldier.BackColor = System.Drawing.Color.Transparent
        Me.btnSoldier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoldier.Location = New System.Drawing.Point(154, 254)
        Me.btnSoldier.Name = "btnSoldier"
        Me.btnSoldier.Size = New System.Drawing.Size(268, 30)
        Me.btnSoldier.TabIndex = 6
        Me.btnSoldier.Text = "Player Customization (Coming Soon)"
        Me.btnSoldier.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(463, 405)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(91, 38)
        Me.btnCredits.TabIndex = 7
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Black
        Me.picLogo.BackgroundImage = Global.ART_of_WAR.My.Resources.Resources.Company_Logo
        Me.picLogo.Image = Global.ART_of_WAR.My.Resources.Resources.Company_Logo
        Me.picLogo.Location = New System.Drawing.Point(43, 57)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(482, 364)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 28
        Me.picLogo.TabStop = False
        '
        'picBackGround
        '
        Me.picBackGround.BackColor = System.Drawing.Color.Black
        Me.picBackGround.Location = New System.Drawing.Point(-1, -1)
        Me.picBackGround.Name = "picBackGround"
        Me.picBackGround.Size = New System.Drawing.Size(590, 484)
        Me.picBackGround.TabIndex = 29
        Me.picBackGround.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(133, 54)
        Me.AxWindowsMediaPlayer1.TabIndex = 30
        '
        'ArtofWarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.ART_of_WAR.My.Resources.Resources.halo_wars_2_dlc_delayed_to_fix_game_breaking_bug_jgwh
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(589, 481)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picBackGround)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnSoldier)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMulitplayer)
        Me.Controls.Add(Me.btnSurvivleMode)
        Me.Controls.Add(Me.btnCampaign)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "ArtofWarMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCampaign As System.Windows.Forms.Button
    Friend WithEvents btnSurvivleMode As System.Windows.Forms.Button
    Friend WithEvents btnMulitplayer As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tmrLogo As System.Windows.Forms.Timer
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSoldier As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer

End Class