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
    Dim war As Queue(Of PlayingCard)

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

        HitButton.Enabled = True
        DealButton.Enabled = False
    End Sub

    Private Sub HitButton_Click(sender As Object, e As EventArgs) Handles HitButton.Click
        Dim over As Boolean = False
        Dim pCard As PlayingCard
        Dim cCard As PlayingCard
        Dim roundWinner As String = ""

        Try
            pCard = player.Dequeue
            cCard = computer.Dequeue
            PlayerListBox.Items.RemoveAt(0)
            PTableListBox.Items.Add($"      Player's Card: {pCard} ")
            ComputerListBox.Items.RemoveAt(0)
            CTableListBox.Items.Add($"Computer's Card: {cCard}")
        Catch ex As Exception
            over = True
            DealButton.Enabled = True
            HitButton.Enabled = False
        End Try

        If over = False Then
            'make this a sub
            roundWinner = Logic.CompareCards(pCard, cCard)

            Select Case roundWinner
                Case "Player"
                    player.Enqueue(pCard)
                    player.Enqueue(cCard)
                    PTableListBox.Items.Clear()
                    CTableListBox.Items.Clear()
                Case "Computer"
                    computer.Enqueue(cCard)
                    computer.Enqueue(pCard)
                    PTableListBox.Items.Clear()
                    CTableListBox.Items.Clear()
                Case "Tie"
                    war.Enqueue(pCard)
                    war.Enqueue(cCard)
            End Select
        Else
            If PlayerListBox.Items.Count.Equals(0) Then
                MsgBox("Computer Wins!")
            Else
                MsgBox("Player Wins!")
            End If
        End If

    End Sub

End Class
