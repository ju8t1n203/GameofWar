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
        Me.PlayerListBox = New System.Windows.Forms.ListBox()
        Me.ComputerListBox = New System.Windows.Forms.ListBox()
        Me.PTableListBox = New System.Windows.Forms.ListBox()
        Me.HitButton = New System.Windows.Forms.Button()
        Me.CTableListBox = New System.Windows.Forms.ListBox()
        Me.RoundsLabel = New System.Windows.Forms.Label()
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
        'PlayerListBox
        '
        Me.PlayerListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerListBox.FormattingEnabled = True
        Me.PlayerListBox.ItemHeight = 24
        Me.PlayerListBox.Location = New System.Drawing.Point(12, 12)
        Me.PlayerListBox.Name = "PlayerListBox"
        Me.PlayerListBox.Size = New System.Drawing.Size(148, 484)
        Me.PlayerListBox.TabIndex = 1
        Me.PlayerListBox.TabStop = False
        '
        'ComputerListBox
        '
        Me.ComputerListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerListBox.FormattingEnabled = True
        Me.ComputerListBox.ItemHeight = 24
        Me.ComputerListBox.Location = New System.Drawing.Point(736, 12)
        Me.ComputerListBox.Name = "ComputerListBox"
        Me.ComputerListBox.Size = New System.Drawing.Size(152, 484)
        Me.ComputerListBox.TabIndex = 1
        Me.ComputerListBox.TabStop = False
        '
        'PTableListBox
        '
        Me.PTableListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTableListBox.FormattingEnabled = True
        Me.PTableListBox.ItemHeight = 24
        Me.PTableListBox.Location = New System.Drawing.Point(12, 526)
        Me.PTableListBox.Name = "PTableListBox"
        Me.PTableListBox.Size = New System.Drawing.Size(148, 124)
        Me.PTableListBox.TabIndex = 4
        Me.PTableListBox.TabStop = False
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
        'CTableListBox
        '
        Me.CTableListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTableListBox.FormattingEnabled = True
        Me.CTableListBox.ItemHeight = 24
        Me.CTableListBox.Location = New System.Drawing.Point(736, 526)
        Me.CTableListBox.Name = "CTableListBox"
        Me.CTableListBox.Size = New System.Drawing.Size(152, 124)
        Me.CTableListBox.TabIndex = 4
        Me.CTableListBox.TabStop = False
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
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 662)
        Me.Controls.Add(Me.HitButton)
        Me.Controls.Add(Me.CTableListBox)
        Me.Controls.Add(Me.PTableListBox)
        Me.Controls.Add(Me.RoundsLabel)
        Me.Controls.Add(Me.ComputerListBox)
        Me.Controls.Add(Me.PlayerListBox)
        Me.Controls.Add(Me.DealButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of War"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents DealButton As Button
    Friend WithEvents PlayerListBox As ListBox
    Friend WithEvents ComputerListBox As ListBox
    Friend WithEvents PTableListBox As ListBox
    Friend WithEvents HitButton As Button
    Friend WithEvents CTableListBox As ListBox
    Friend WithEvents RoundsLabel As Label
End Class
