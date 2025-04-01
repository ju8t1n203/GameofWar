Public Class Logic

    Public Shared Function CompareCards(pCard As PlayingCard, cCard As PlayingCard) As String
        Dim highCard As String = ""

        If pCard.value > cCard.value Then
            highCard = "Player"
        ElseIf pCard.value < cCard.value Then
            highCard = "Computer"
        ElseIf pCard.value = cCard.value Then
            highCard = "Tie"
        End If

        Return highCard
    End Function

    Public Shared Sub HighPlayer()

    End Sub

End Class
