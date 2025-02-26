'Justin Bell
'RCET 3371
'Spring 2025
' link

Option Compare Text
Option Explicit On
Option Strict On
Public Class Shuffler
    ''' <summary>
    ''' This was my initial attempt at creating a deck using arrays rather than a stack.
    ''' It works but using a stack with defined properties makes the code more generalized.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function Shuffle() As Integer(,)

        Const totalCards As Integer = 52
        Dim deck(totalCards - 1) As Integer 'this creates an array with 52 elements (0 to 51)

        'initialize the deck with card values (0-51)
        For i As Integer = 0 To totalCards - 1
            deck(i) = i
        Next

        'shuffles the deck
        Dim rand As New Random()
        For i As Integer = 0 To deck.Length - 1
            Dim j As Integer = rand.Next(i, deck.Length)
            'swap to shuffled deck
            Dim temp As Integer = deck(i)
            deck(i) = deck(j)
            deck(j) = temp
        Next

        'calculate the number of cards per player
        Dim result(1, 25) As Integer '2D array for players and their cards

        ' Deal the cards to players
        For player As Integer = 0 To 1
            For card As Integer = 0 To 25
                Dim index As Integer = player * 26 + card
                result(player, card) = deck(index) ' Assign the card to the player
            Next
        Next

        Return result
    End Function
End Class
