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
    ''' <returns>A <see cref="ServiceMethod"/> enum.</returns>
    Public ReadOnly Property Type As ServiceMethod

    ''' <summary>
    ''' A list of the items to be ordered.
    ''' </summary>
    ''' <returns>An <see cref="IReadOnlyList(Of DominosItem)"/></returns>
    Public ReadOnly Property Items As IReadOnlyList(Of DominosItem)

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>. 
    ''' <para>The closest store to the <see cref="DominosCustomer"/> will be selected to fulfill this new <see cref="DominosOrder"/>.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, orderType As ServiceMethod)
        Throw New NotImplementedException
    End Sub

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>. 
    ''' <para>The <see cref="DominosStore"/> that is passed in will be the store to fulfill this new <see cref="DominosOrder"/>.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, store As DominosStore, orderType As ServiceMethod)
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
    ''' <param name="item">Any <see cref="DominosItem"/> from <see cref="Items"/>.</param>
    ''' <returns>A <see cref="Boolean"/> indicating if this action was successful.</returns>
    Public Function Remove(item As DominosItem) As Boolean
        Throw New NotImplementedException
    End Function

End Class
