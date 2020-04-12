Imports System.Timers
Imports Gnominos.Enums
Imports RestSharp

''' <summary>Checks every two minutes for the status of an order and fires an event when there is a change.</summary>
Public NotInheritable Class DominosTracker
    Private Shared _restClient As New RestClient With {.BaseUrl = New Uri("TODO")}
    Private _timer As Timer

    ''' <summary>The order that is being tracked.</summary>
    Public ReadOnly Property Order As DominosOrder

    ''' <summary>The last order status received by Dominos.</summary>
    Public ReadOnly Property LastStatus As DominosOrderStatus

    ''' <summary>Fired when the status of the order has been updated.</summary>
    Public Event Updated(status As DominosOrderStatus)

    ''' <summary>Create a new <see cref="DominosTracker"/> instance for a recently placed order.</summary>
    ''' <param name="order">The order that was just placed.</param>
    Friend Sub New(order As DominosOrder)
        Initialize(order)
    End Sub

    ''' <summary>Create a new <see cref="DominosTracker"/> instance using the provided order key.</summary>
    ''' <param name="orderKey">A valid Dominos order key.</param>
    Public Sub New(orderKey As String)
        Dim order As DominosOrder ' Retrive order details.
        Initialize(order)
    End Sub

    ''' <summary>Constructor logic.</summary>
    Private Sub Initialize(order As DominosOrder)
        _Order = order

        _timer = New Timer(TimeSpan.FromMinutes(2).TotalMilliseconds)
        AddHandler _timer.Elapsed, AddressOf UpdateStatus
        _timer.Start()
    End Sub

    ''' <summary>Called every two minutes to check the status of the order.</summary>
    Private Sub UpdateStatus(sender As Object, e As ElapsedEventArgs)
        ' Retrieve status and parse to a string.

        Dim status As DominosOrderStatus
        [Enum].TryParse("parsed status", status)

        If status > _LastStatus Then
            RaiseEvent Updated(status)
            _LastStatus = status
        End If
    End Sub
End Class