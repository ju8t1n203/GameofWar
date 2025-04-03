Public Class Logic

    Public Shared Function CompareCards(pCard As PlayingCard, cCard As PlayingCard) As String
        Dim highCard As String = ""
        Dim first As Integer = pCard.value
        Dim second As Integer = cCard.value

        If first = 1 Then
            first = 14
        End If

        If second = 1 Then
            second = 14
        End If

        If first > second Then
            highCard = "Player"
        ElseIf first < second Then
            highCard = "Computer"
        ElseIf first = second Then
            highCard = "Tie"
        End If

        Return highCard
    End Function

End Class
