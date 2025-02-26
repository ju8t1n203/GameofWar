'Justin Bell
'RCET 3371
'Spring 2025

Option Explicit On
Option Strict On

Public Class PlayingCard

    Property _suit As Integer
    Public ReadOnly Property suit() As Integer
        Get
            Return _suit
        End Get
    End Property

    Property _value As Integer
    Public ReadOnly Property value() As Integer
        Get
            Return _value
        End Get
    End Property

    Sub New(suit As Integer, value As Integer)
        Me._suit = suit
        Me._value = value
    End Sub

    Public Function PrettyName() As String
        Return $"{PrettyValue()} of {PrettySuit()}"
    End Function

    Public Function PrettySuit() As String
        Dim _suit As String

        Select Case Me.suit
            Case 1
                _suit = "Clubs"
            Case 2
                _suit = "Diamonds"
            Case 3
                _suit = "Hearts"
            Case 4
                _suit = "Spades"
        End Select

        Return _suit
    End Function

    Public Function PrettyValue() As String
        Dim _value As String
        Select Case Me.value
            Case 1
                _value = "Ace"
            Case 11
                _value = "Jack"
            Case 12
                _value = "Queen"
            Case 13
                _value = "King"
            Case Else
                _value = Me.value.ToString
        End Select
        Return _value
    End Function

    'override ToString
    Public Overrides Function ToString() As String
        Return $"{PrettyValue()} of {PrettySuit()}"
    End Function

End Class