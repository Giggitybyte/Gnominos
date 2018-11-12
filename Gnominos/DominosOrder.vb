Imports Gnominos.Entities
Imports Gnominos.Enums


''' <summary>
''' A representation of a Dominos order. This is the primary interface with the API.
''' </summary>
Public NotInheritable Class DominosOrder

    ''' <summary>
    ''' The customer who will be receiving this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <returns>A <see cref="DominosCustomer"/> object.</returns>
    Public ReadOnly Property Customer As DominosCustomer

    ''' <summary>
    ''' The store that will fulfill this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <returns>A <see cref="DominosStore"/> object.</returns>
    Public ReadOnly Property Store As DominosStore

    ''' <summary>
    ''' The menu for the <see cref="DominosStore"/> assocated with this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <returns>A <see cref="DominosMenu"/> object.</returns>
    Public ReadOnly Property Menu As DominosMenu

    ''' <summary>
    ''' How this <see cref="DominosOrder"/> will be fulfilled.
    ''' </summary>
    ''' <returns>A <see cref="DominosServiceMethod"/> enum.</returns>
    Public ReadOnly Property ServiceMethod As DominosServiceMethod

    ''' <summary>
    ''' The items to be sent to the associated <see cref="DominosStore"/> for fulfillment.
    ''' </summary>
    ''' <returns>An <see cref="IReadOnlyList(Of DominosItem)"/></returns>
    Public ReadOnly Property Items As IReadOnlyList(Of DominosItem)

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>.
    ''' <para>The closest store to the <see cref="DominosCustomer"/> will be selected to fulfill this new <see cref="DominosOrder"/>. This overload supports both delivery and carryout service methods; delivery is the default.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, Optional orderType As DominosServiceMethod = DominosServiceMethod.DELIVERY)
        _ServiceMethod = orderType

        Throw New NotImplementedException
    End Sub

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>. 
    ''' <para>The <see cref="DominosStore"/> that is passed in will be the store to fulfill this new <see cref="DominosOrder"/>. The service method will be carryout; delivery is not supported with this overload.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, store As DominosStore)
        _ServiceMethod = DominosServiceMethod.CARRYOUT

        Throw New NotImplementedException
    End Sub

    ''' <summary>
    ''' Add an item to this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <param name="item">Any <see cref="DominosItem"/> from the menu or a custom pizza from the <see cref="DominosPizzaBuilder"/></param>
    ''' <returns>A <see cref="Boolean"/> indicating if this action was successful.</returns>
    Public Function Add(item As DominosItem) As Boolean
        Throw New NotImplementedException
    End Function

    ''' <summary>
    ''' Remove an item from this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <param name="item">Any <see cref="DominosItem"/> from <see cref="DominosOrder.Items"/>.</param>
    ''' <returns>A <see cref="Boolean"/> indicating if this action was successful.</returns>
    Public Function Remove(item As DominosItem) As Boolean
        Throw New NotImplementedException
    End Function

    ''' <summary>
    ''' Submits this <see cref="DominosOrder"/> to the selected <see cref="DominosStore"/> for fulfillment.
    ''' </summary>
    ''' <returns>A <see cref="DominosTrackerData"/> object which contains information about the fulfillment of the order.</returns>
    Public Function Place() As DominosTrackerData
        Throw New NotImplementedException
    End Function

    ''' <summary>
    ''' Retrieves tracking information for an existing order.
    ''' </summary>
    ''' <param name="lookupKey">A ten digit, non-hyphenated phone number or an order key.</param>
    ''' <returns>A <see cref="DominosTrackerData"/> object which contains information about the fulfillment of an order.</returns>
    Public Shared Function GetTrackerInfo(lookupKey As String) As DominosTrackerData
        Throw New NotImplementedException
    End Function
End Class
