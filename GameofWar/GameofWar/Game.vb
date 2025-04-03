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

        Dim competitor As New Players()

        player = competitor.CreatePlayerStack()
        computer = competitor.CreateComputerStack()

        PCardCountLabel.Text = CStr($"{player.Count}")
        CCardCountLabel.Text = CStr($"{computer.Count}")

        HitButton.Enabled = True
        DealButton.Enabled = False
    End Sub

    Private Sub HitButton_Click(sender As Object, e As EventArgs) Handles HitButton.Click
        Dim over As Boolean = False
        Dim pCard As PlayingCard
        Dim cCard As PlayingCard

        Try
            pCard = player.Dequeue
            cCard = computer.Dequeue
        Catch ex As Exception
            over = True
            DealButton.Enabled = True
            HitButton.Enabled = False
        End Try


        If over = False Then

            RoundsLabel.Text = $"{CInt(RoundsLabel.Text) + 1}"
            PCardCountLabel.Text = CStr($"{player.Count}")
            CCardCountLabel.Text = CStr($"{computer.Count}")

            ShowCard(pCard.ShowCard, PCardPictureBox)
            ShowCard(cCard.ShowCard, CCardPictureBox)

            MoreLogic(Logic.CompareCards(pCard, cCard), pCard, cCard)

        Else
            If player.Count.Equals(0) Then
                MsgBox("Computer Wins!")
            Else
                MsgBox("Player Wins!")
            End If
        End If

    End Sub

    Sub MoreLogic(roundwinner As String, pCard As PlayingCard, cCard As PlayingCard)
        Select Case roundwinner
            Case "Player"

                WarPictureBox.Visible = False

                player.Enqueue(pCard)
                player.Enqueue(cCard)

                If war.Count > 0 Then
                    'MsgBox("Player wins WAR!!!")
                    Dim active As PlayingCard
                    For i = 0 To war.Count - 1
                        active = war.Dequeue
                        player.Enqueue(active)
                    Next
                End If

            Case "Computer"

                WarPictureBox.Visible = False

                computer.Enqueue(cCard)
                computer.Enqueue(pCard)

                If war.Count > 0 Then
                    'MsgBox("Computer wins WAR!!!")
                    Dim active As PlayingCard
                    For i = 0 To war.Count - 1
                        active = war.Dequeue
                        computer.Enqueue(active)
                    Next
                End If

            Case "Tie"
                'MsgBox("WAR!!!")
                WarPictureBox.Visible = True
                war.Enqueue(pCard)
                war.Enqueue(cCard)
        End Select
    End Sub

    Sub ShowCard(cardname As String, destination As PictureBox)
        Dim g As Graphics = destination.CreateGraphics
        Dim cardImage As Image
        Dim h% = CInt(destination.Height + 0.8)
        Dim x% = CardGenerator.RandomNumber(CInt(destination.Width / 5))
        Dim y% = CardGenerator.RandomNumber(CInt(destination.Height / 5))

        cardImage = CType(My.Resources.ResourceManager.GetObject(cardname), Image)

        destination.Image = cardImage

        'g.DrawImage(cardImage, x%, y%)
        g.Dispose()
    End Sub

End Class
