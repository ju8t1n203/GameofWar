Option Compare Text
Option Explicit On
Option Strict On
'Justin Bell
'RCET 3371
'Spring 2025
' link

Imports System.Globalization

Public Class Game

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DealButton_Click(sender As Object, e As EventArgs) Handles DealButton.Click

        ' The code that was associated with using the now obsolete "Shuffler" class

        'Dim dealtCards As Integer(,) = Shuffler.Shuffle() 'shuffle and deal for the player and computer

        ''clears the listboxes before adding new items
        'PlayerListBox.Items.Clear()
        'ComputerListBox.Items.Clear()

        'Dim playerIndex As Integer = 0          'indexes the oth column of the shuffled cards
        'Dim computerIndex As Integer = 1      'indexes the 1st column of the shuffled cards

        ''loops through the cards for the selected index and add them to the corrosponding listbox
        'For card As Integer = 0 To dealtCards.GetLength(1) - 1
        '    PlayerListBox.Items.Add(dealtCards(playerIndex, card))
        'Next

        'For card As Integer = 0 To dealtCards.GetLength(1) - 1
        '    ComputerListBox.Items.Add(dealtCards(computerIndex, card))
        'Next

        PlayerListBox.Items.Clear()
        ComputerListBox.Items.Clear()

        Dim deck As New CardGenerator("Deck")

        For i = 0 To 25

            PlayerListBox.Items.Add(deck.Deal().PrettyName)
            ComputerListBox.Items.Add(deck.Deal().PrettyName)

        Next

    End Sub
End Class
