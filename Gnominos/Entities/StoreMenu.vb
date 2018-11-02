Namespace Entities

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class StoreMenu

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PreconfiguredPizzas As IReadOnlyList(Of MenuItem)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Toppings As IReadOnlyList(Of MenuItem)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Crusts As IReadOnlyList(Of MenuItem)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Drinks As IReadOnlyList(Of MenuItem)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Desserts As IReadOnlyList(Of MenuItem)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Coupons As IReadOnlyList(Of Coupon)

        ''' <summary>
        ''' 
        ''' </summary>
        Sub New()
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace