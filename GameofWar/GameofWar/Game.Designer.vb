<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DealButton = New System.Windows.Forms.Button()
        Me.HitButton = New System.Windows.Forms.Button()
        Me.RoundsLabel = New System.Windows.Forms.Label()
        Me.WarPictureBox = New System.Windows.Forms.PictureBox()
        Me.CCardPictureBox = New System.Windows.Forms.PictureBox()
        Me.PCardPictureBox = New System.Windows.Forms.PictureBox()
        Me.PDeckPictureBox = New System.Windows.Forms.PictureBox()
        Me.CDeckPictureBox = New System.Windows.Forms.PictureBox()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.PlayerCardsLabel = New System.Windows.Forms.Label()
        Me.PCardCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CCardCountLabel = New System.Windows.Forms.Label()
        CType(Me.WarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDeckPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDeckPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(911, 552)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(151, 98)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DealButton
        '
        Me.DealButton.Location = New System.Drawing.Point(12, 552)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(151, 98)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "&Deal"
        Me.DealButton.UseVisualStyleBackColor = True
        '
        'HitButton
        '
        Me.HitButton.Enabled = False
        Me.HitButton.Location = New System.Drawing.Point(169, 552)
        Me.HitButton.Name = "HitButton"
        Me.HitButton.Size = New System.Drawing.Size(151, 98)
        Me.HitButton.TabIndex = 1
        Me.HitButton.Text = "&Hit"
        Me.HitButton.UseVisualStyleBackColor = True
        '
        'RoundsLabel
        '
        Me.RoundsLabel.AutoSize = True
        Me.RoundsLabel.Location = New System.Drawing.Point(549, 20)
        Me.RoundsLabel.Name = "RoundsLabel"
        Me.RoundsLabel.Size = New System.Drawing.Size(13, 13)
        Me.RoundsLabel.TabIndex = 3
        Me.RoundsLabel.Text = "0"
        '
        'WarPictureBox
        '
        Me.WarPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.WarPictureBox.Image = Global.GameofWar.My.Resources.Resources.warImage
        Me.WarPictureBox.Location = New System.Drawing.Point(373, 457)
        Me.WarPictureBox.Name = "WarPictureBox"
        Me.WarPictureBox.Size = New System.Drawing.Size(280, 142)
        Me.WarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WarPictureBox.TabIndex = 6
        Me.WarPictureBox.TabStop = False
        Me.WarPictureBox.Visible = False
        '
        'CCardPictureBox
        '
        Me.CCardPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.CCardPictureBox.Location = New System.Drawing.Point(538, 125)
        Me.CCardPictureBox.Name = "CCardPictureBox"
        Me.CCardPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.CCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CCardPictureBox.TabIndex = 5
        Me.CCardPictureBox.TabStop = False
        '
        'PCardPictureBox
        '
        Me.PCardPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PCardPictureBox.Location = New System.Drawing.Point(302, 125)
        Me.PCardPictureBox.Name = "PCardPictureBox"
        Me.PCardPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.PCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCardPictureBox.TabIndex = 5
        Me.PCardPictureBox.TabStop = False
        '
        'PDeckPictureBox
        '
        Me.PDeckPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PDeckPictureBox.Image = Global.GameofWar.My.Resources.Resources.Fancy_Back1
        Me.PDeckPictureBox.Location = New System.Drawing.Point(66, 125)
        Me.PDeckPictureBox.Name = "PDeckPictureBox"
        Me.PDeckPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.PDeckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PDeckPictureBox.TabIndex = 7
        Me.PDeckPictureBox.TabStop = False
        '
        'CDeckPictureBox
        '
        Me.CDeckPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.CDeckPictureBox.Image = Global.GameofWar.My.Resources.Resources.Fancy_Back1
        Me.CDeckPictureBox.Location = New System.Drawing.Point(778, 125)
        Me.CDeckPictureBox.Name = "CDeckPictureBox"
        Me.CDeckPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.CDeckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CDeckPictureBox.TabIndex = 7
        Me.CDeckPictureBox.TabStop = False
        '
        'RoundLabel
        '
        Me.RoundLabel.AutoSize = True
        Me.RoundLabel.Location = New System.Drawing.Point(507, 20)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(42, 13)
        Me.RoundLabel.TabIndex = 8
        Me.RoundLabel.Text = "Round:"
        '
        'PlayerCardsLabel
        '
        Me.PlayerCardsLabel.AutoSize = True
        Me.PlayerCardsLabel.Location = New System.Drawing.Point(108, 103)
        Me.PlayerCardsLabel.Name = "PlayerCardsLabel"
        Me.PlayerCardsLabel.Size = New System.Drawing.Size(121, 13)
        Me.PlayerCardsLabel.TabIndex = 10
        Me.PlayerCardsLabel.Text = "Number of Player Cards:"
        '
        'PCardCountLabel
        '
        Me.PCardCountLabel.AutoSize = True
        Me.PCardCountLabel.Location = New System.Drawing.Point(229, 103)
        Me.PCardCountLabel.Name = "PCardCountLabel"
        Me.PCardCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.PCardCountLabel.TabIndex = 9
        Me.PCardCountLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(806, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Number of Computer Cards:"
        '
        'CCardCountLabel
        '
        Me.CCardCountLabel.AutoSize = True
        Me.CCardCountLabel.Location = New System.Drawing.Point(943, 103)
        Me.CCardCountLabel.Name = "CCardCountLabel"
        Me.CCardCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.CCardCountLabel.TabIndex = 11
        Me.CCardCountLabel.Text = "0"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameofWar.My.Resources.Resources.BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 662)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CCardCountLabel)
        Me.Controls.Add(Me.PlayerCardsLabel)
        Me.Controls.Add(Me.PCardCountLabel)
        Me.Controls.Add(Me.RoundLabel)
        Me.Controls.Add(Me.CDeckPictureBox)
        Me.Controls.Add(Me.PDeckPictureBox)
        Me.Controls.Add(Me.WarPictureBox)
        Me.Controls.Add(Me.CCardPictureBox)
        Me.Controls.Add(Me.PCardPictureBox)
        Me.Controls.Add(Me.HitButton)
        Me.Controls.Add(Me.RoundsLabel)
        Me.Controls.Add(Me.DealButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of War"
        CType(Me.WarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDeckPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDeckPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents DealButton As Button
    Friend WithEvents HitButton As Button
    Friend WithEvents RoundsLabel As Label
    Friend WithEvents PCardPictureBox As PictureBox
    Friend WithEvents CCardPictureBox As PictureBox
    Friend WithEvents WarPictureBox As PictureBox
    Friend WithEvents PDeckPictureBox As PictureBox
    Friend WithEvents CDeckPictureBox As PictureBox
    Friend WithEvents RoundLabel As Label
    Friend WithEvents PlayerCardsLabel As Label
    Friend WithEvents PCardCountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CCardCountLabel As Label
End Class
