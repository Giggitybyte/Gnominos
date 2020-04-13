Namespace Models
    ''' <summary>
    ''' A Dominos Pizza Profile.
    ''' </summary>
    Public NotInheritable Class DominosAccount
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property CustomerId As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PointBalance As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PendingPointBalance As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PointBalanceHistory As List(Of DominosPointTransaction)
    End Class
End Namespace