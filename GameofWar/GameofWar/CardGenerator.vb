'Justin Bell
'RCET 3371
'Spring 2025

Option Explicit On
Option Strict On

Public Class CardGenerator

    'properties------------------------------------------

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _deck As New Queue(Of PlayingCard)

    Sub New(name As String)
        Me.name = name
        Shuffle()
    End Sub

    Public Sub Shuffle()
        Dim suit%, value%
        Dim card As PlayingCard
        Dim count As Integer

        Me._deck.Clear()

        Do
            suit = RandomNumber(4)
            value = RandomNumber(13)
            card = New PlayingCard(suit, value)
            If CheckForCard(card) = False Then
                Me._deck.Enqueue(card)
                count += 1
            End If
        Loop Until count >= 52

        Console.WriteLine()

    End Sub

    Public Function Deal() As PlayingCard
        If Me._deck.Count > 0 Then
            Return Me._deck.Dequeue
        Else
            Return Nothing
        End If
    End Function

    Public Function GetRemaining() As Integer
        Return Me._deck.Count
    End Function

    Private Function CheckForCard(newCard As PlayingCard) As Boolean
        For Each card In Me._deck
            If newCard.suit = card.suit And newCard.value = card.value Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function RandomNumber(max As Integer) As Integer
        Randomize()
        Return CInt(Math.Floor(Rnd() * max)) + 1
    End Function

End Class
