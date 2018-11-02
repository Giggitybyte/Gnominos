Namespace Entities

    ''' <summary>
    ''' 
    ''' </summary>
    Public NotInheritable Class Address

        ''' <summary>
        ''' 
        ''' </summary>
        Public ReadOnly StreetAddress As String

        ''' <summary>
        ''' 
        ''' </summary>
        Public ReadOnly ApartmentNumber As String

        ''' <summary>
        ''' 
        ''' </summary>
        Public ReadOnly City As String

        ''' <summary>
        ''' 
        ''' </summary>
        Public ReadOnly Region As String

        ''' <summary>
        ''' 
        ''' </summary>
        Private _deliveryStore As (store As Store, cachedTimestamp As Date)

        ''' <summary>
        ''' 
        ''' </summary>
        Private _nearbyStores As (stores As List(Of Store), cachedTimestamp As Date)

        ''' <summary>
        ''' 
        ''' </summary>
        Sub New()
            Throw New NotImplementedException
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetDeliveryStore() As Store
            Throw New NotImplementedException
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetNearbyStores() As IReadOnlyList(Of Store)
            Throw New NotImplementedException
        End Function
    End Class

End Namespace