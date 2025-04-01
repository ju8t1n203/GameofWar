'Justin Bell
'RCET 3371
'Spring 2025

Option Explicit On
Option Strict On

Public Class Players

    Dim deck As New CardGenerator("Deck")
    Dim playerQueue As New Queue(Of PlayingCard)
    Dim computerQueue As New Queue(Of PlayingCard)

    Public Function CreatePlayerStack() As Queue(Of PlayingCard)
        For i = 0 To 25
            Dim pCard As PlayingCard = deck.Deal()
            playerQueue.Enqueue(pCard)
        Next
        Return playerQueue
    End Function

    Public Function CreateComputerStack() As Queue(Of PlayingCard)
        For i = 0 To 25
            Dim cCard As PlayingCard = deck.Deal
            computerQueue.Enqueue(cCard)
        Next
        Return computerQueue
    End Function


End Class