Option Compare Text
Option Explicit On
Option Strict On
'Justin Bell
'RCET 3371
'Spring 2025
' link

Imports System.Globalization

Public Class Game
    Dim player As Queue(Of PlayingCard)
    Dim computer As Queue(Of PlayingCard)

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DealButton_Click(sender As Object, e As EventArgs) Handles DealButton.Click

        PlayerListBox.Items.Clear()
        ComputerListBox.Items.Clear()

        Dim competitor As New Players()

        player = competitor.CreatePlayerStack()
        computer = competitor.CreateComputerStack()


        For Each card As PlayingCard In player
            PlayerListBox.Items.Add(card.ToString)
        Next

        For Each card As PlayingCard In computer
            ComputerListBox.Items.Add(card.ToString())
        Next

        UpdateTimer.Enabled = True
        HitButton.Enabled = True
        DealButton.Enabled = False
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick

    End Sub

    Private Sub HitButton_Click(sender As Object, e As EventArgs) Handles HitButton.Click
        Dim over As Boolean = False
        Dim pCard As PlayingCard
        Dim cCard As PlayingCard

        TableListBox.Items.Clear()
        Try
            pCard = player.Dequeue
            cCard = computer.Dequeue
            PlayerListBox.Items.RemoveAt(0)
            TableListBox.Items.Add($"      Player's Card: {pCard} ")
            ComputerListBox.Items.RemoveAt(0)
            TableListBox.Items.Add($"Computer's Card: {cCard}")
        Catch ex As Exception
            over = True
            DealButton.Enabled = True
            HitButton.Enabled = False
        End Try

        If over = False Then
            Logic.CompareCards(player, pCard, computer, cCard, PlayerListBox, ComputerListBox)
        Else
            If PlayerListBox.Items.Count.Equals(0) Then
                MsgBox("Computer Wins!")
            Else
                MsgBox("Player Wins!")
            End If
        End If

    End Sub

End Class
