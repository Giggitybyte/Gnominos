Namespace Entities

    ''' <summary>
    ''' Representation of a Dominos Coupon
    ''' </summary>
    Public NotInheritable Class DominosCoupon
        Public ReadOnly Property Code As String
        Public ReadOnly Property Quantity As Integer
        Public ReadOnly Property Id As Integer

        Sub New()
            Throw New NotImplementedException
        End Sub
    End Class
End Namespace
