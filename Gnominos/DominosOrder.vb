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
    ''' The service method of this <see cref="DominosOrder"/>.
    ''' </summary>
    ''' <returns>A <see cref="ServiceMethod"/> enum.</returns>
    Public ReadOnly Property Type As ServiceMethod

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>. 
    ''' <para>The closest store to the <see cref="DominosCustomer"/> will be selected to fulfill this new <see cref="DominosOrder"/>.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, orderType As ServiceMethod)
        Throw New NotImplementedException
    End Sub

    ''' <summary>
    ''' Creates a new instance of a <see cref="DominosOrder"/>. 
    ''' <para>The <see cref="DominosStore"/> that is passed in will be the store that will fulfill this new <see cref="DominosOrder"/>.</para>
    ''' </summary>
    Sub New(customer As DominosCustomer, store As DominosStore, orderType As ServiceMethod)
        Throw New NotImplementedException
    End Sub

End Class
