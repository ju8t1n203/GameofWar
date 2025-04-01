Option Compare Text
Option Explicit On
Option Strict On
'Justin Bell
'RCET 3371
'Spring 2025
' link

Imports System.ComponentModel
Imports System.Globalization
Imports System.Media
Imports System.Windows.Forms.Design

Public Class Game
    Dim player As Queue(Of PlayingCard)
    Dim computer As Queue(Of PlayingCard)
    Dim war As New Queue(Of PlayingCard)

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DealButton_Click(sender As Object, e As EventArgs) Handles DealButton.Click

        RoundsLabel.Text = "0"
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

        PTableListBox.Items.Clear()
        CTableListBox.Items.Clear()

        Try
            pCard = player.Dequeue
            cCard = computer.Dequeue
            PlayerListBox.Items.RemoveAt(0)
            ComputerListBox.Items.RemoveAt(0)
        Catch ex As Exception
            over = True
            DealButton.Enabled = True
            HitButton.Enabled = False
        End Try


        If over = False Then

            PTableListBox.Items.Add($"      Player's Card: {pCard} ")
            CTableListBox.Items.Add($"Computer's Card: {cCard}")

            RoundsLabel.Text = $"{CInt(RoundsLabel.Text) + 1}"

            MoreLogic(Logic.CompareCards(pCard, cCard), pCard, cCard)

        Else
            If PlayerListBox.Items.Count.Equals(0) Then
                MsgBox("Computer Wins!")
            Else
                MsgBox("Player Wins!")
            End If
        End If

    End Sub

    Sub MoreLogic(roundwinner As String, pCard As PlayingCard, cCard As PlayingCard)
        Select Case roundwinner
            Case "Player"

                player.Enqueue(pCard)
                player.Enqueue(cCard)
                PlayerListBox.Items.Add(pCard)
                PlayerListBox.Items.Add(cCard)

                If war.Count > 0 Then
                    MsgBox("Player wins WAR!!!")
                    Dim active As PlayingCard
                    For i = 0 To war.Count - 1
                        active = war.Dequeue
                        player.Enqueue(active)
                        PlayerListBox.Items.Add(active)
                    Next
                End If

            Case "Computer"

                computer.Enqueue(cCard)
                computer.Enqueue(pCard)
                ComputerListBox.Items.Add(cCard)
                ComputerListBox.Items.Add(pCard)

                If war.Count > 0 Then
                    MsgBox("Computer wins WAR!!!")
                    Dim active As PlayingCard
                    For i = 0 To war.Count - 1
                        active = war.Dequeue
                        computer.Enqueue(active)
                        ComputerListBox.Items.Add(active)
                    Next
                End If

            Case "Tie"
                MsgBox("WAR!!!")
                war.Enqueue(pCard)
                war.Enqueue(cCard)
        End Select
    End Sub

End Class
