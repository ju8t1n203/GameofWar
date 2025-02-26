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

        'Dim deck As New CardGenerator("Deck")

        PlayerListBox.Items.Clear()
        ComputerListBox.Items.Clear()

        Dim competitor As New Players()

        Dim player As Stack(Of PlayingCard) = competitor.CreatePlayerStack()
        Dim computer As Stack(Of PlayingCard) = competitor.CreateComputerStack()


        For Each card As PlayingCard In player
            PlayerListBox.Items.Add(card.ToString) ' Assuming PlayingCard has a ToString method for display
        Next

        For Each card As PlayingCard In computer
            ComputerListBox.Items.Add(card.ToString()) ' Assuming PlayingCard has a ToString method for display
        Next


    End Sub
End Class
