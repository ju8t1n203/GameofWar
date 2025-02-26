'Justin Bell
'RCET 3371
'Spring 2025

Option Explicit On
Option Strict On

Public Class Players

    Dim deck As New CardGenerator("Deck")
    Dim playerStack As New Stack(Of PlayingCard)
    Dim computerStack As New Stack(Of PlayingCard)

    Public Function CreatePlayerStack() As Stack(Of PlayingCard)
        For i = 0 To 25
            Dim pCard As PlayingCard = deck.Deal()
            playerStack.Push(pCard)
        Next
        Return playerStack
    End Function

    Public Function CreateComputerStack() As Stack(Of PlayingCard)
        For i = 0 To 25
            Dim cCard As PlayingCard = deck.Deal
            computerStack.Push(cCard)
        Next
        Return computerStack
    End Function

End Class