Namespace Models
    Public NotInheritable Class DominosCreditCard
        ''' <summary>Account number on the front of a credit/debit card.</summary>
        Public Property CardNumber As Integer

        ''' <summary>Security code on the card; typically found on the back.</summary>
        Public Property SecurityCode As Integer

        ''' <summary>The name on the card.</summary>
        Public Property CardholderName As String
    End Class
End Namespace