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
        Me.PCardPictureBox = New System.Windows.Forms.PictureBox()
        Me.CCardPictureBox = New System.Windows.Forms.PictureBox()
        Me.WarPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PCardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DealButton.Location = New System.Drawing.Point(911, 70)
        Me.DealButton.Name = "DealButton"
        Me.DealButton.Size = New System.Drawing.Size(151, 98)
        Me.DealButton.TabIndex = 0
        Me.DealButton.Text = "&Deal"
        Me.DealButton.UseVisualStyleBackColor = True
        '
        'HitButton
        '
        Me.HitButton.Enabled = False
        Me.HitButton.Location = New System.Drawing.Point(911, 174)
        Me.HitButton.Name = "HitButton"
        Me.HitButton.Size = New System.Drawing.Size(151, 98)
        Me.HitButton.TabIndex = 1
        Me.HitButton.Text = "&Hit"
        Me.HitButton.UseVisualStyleBackColor = True
        '
        'RoundsLabel
        '
        Me.RoundsLabel.AutoSize = True
        Me.RoundsLabel.Location = New System.Drawing.Point(922, 25)
        Me.RoundsLabel.Name = "RoundsLabel"
        Me.RoundsLabel.Size = New System.Drawing.Size(13, 13)
        Me.RoundsLabel.TabIndex = 3
        Me.RoundsLabel.Text = "0"
        '
        'PCardPictureBox
        '
        Me.PCardPictureBox.Location = New System.Drawing.Point(214, 140)
        Me.PCardPictureBox.Name = "PCardPictureBox"
        Me.PCardPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.PCardPictureBox.TabIndex = 5
        Me.PCardPictureBox.TabStop = False
        '
        'CCardPictureBox
        '
        Me.CCardPictureBox.Location = New System.Drawing.Point(482, 140)
        Me.CCardPictureBox.Name = "CCardPictureBox"
        Me.CCardPictureBox.Size = New System.Drawing.Size(220, 300)
        Me.CCardPictureBox.TabIndex = 5
        Me.CCardPictureBox.TabStop = False
        '
        'WarPictureBox
        '
        Me.WarPictureBox.Location = New System.Drawing.Point(320, 217)
        Me.WarPictureBox.Name = "WarPictureBox"
        Me.WarPictureBox.Size = New System.Drawing.Size(280, 142)
        Me.WarPictureBox.TabIndex = 6
        Me.WarPictureBox.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 662)
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
        CType(Me.PCardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
