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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(623, 338)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(151, 98)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DealButton
        '
        Me.DealButton.Location = New System.Drawing.Point(466, 338)
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
        Me.PlayerListBox.Location = New System.Drawing.Point(259, 25)
        Me.PlayerListBox.Name = "PlayerListBox"
        Me.PlayerListBox.Size = New System.Drawing.Size(196, 388)
        Me.PlayerListBox.TabIndex = 1
        '
        'ComputerListBox
        '
        Me.ComputerListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerListBox.FormattingEnabled = True
        Me.ComputerListBox.ItemHeight = 24
        Me.ComputerListBox.Location = New System.Drawing.Point(12, 25)
        Me.ComputerListBox.Name = "ComputerListBox"
        Me.ComputerListBox.Size = New System.Drawing.Size(196, 388)
        Me.ComputerListBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComputerListBox)
        Me.Controls.Add(Me.PlayerListBox)
        Me.Controls.Add(Me.DealButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Game"
        Me.Text = "Game of War"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents DealButton As Button
    Friend WithEvents PlayerListBox As ListBox
    Friend WithEvents ComputerListBox As ListBox
    Friend WithEvents Label1 As Label
End Class
