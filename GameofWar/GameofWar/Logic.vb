Public Class Logic

    Public Shared Sub CompareCards(pQueue As Queue(Of PlayingCard), pCard As PlayingCard, cQueue As Queue(Of PlayingCard), cCard As PlayingCard, pContainer As ListBox, cContainer As ListBox)

        If pCard.value > cCard.value Then
            pQueue.Enqueue(pCard)
            pQueue.Enqueue(cCard)
            pContainer.Items.Add(pCard)
            pContainer.Items.Add(cCard)
        ElseIf pCard.value < cCard.value Then
            cQueue.Enqueue(cCard)
            cQueue.Enqueue(pCard)
            cContainer.Items.Add(cCard)
            cContainer.Items.Add(pCard)
        ElseIf pCard.value = cCard.value Then
            'war
        End If
    End Sub

End Class
