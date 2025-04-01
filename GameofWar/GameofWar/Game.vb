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
