Imports Gnominos.Enums
Imports Gnominos.Models

''' <summary>
''' An order that'll be fulfilled by a store.
''' </summary>
Public NotInheritable Class DominosOrder
    Friend _items As List(Of DominosItem)
    Friend _coupons As List(Of DominosCoupon)
    Friend _orderKey As String

    ''' <summary>Create a new order for the provided store.</summary>
    ''' <param name="store">The store that will fulfill this order.</param>
    ''' <param name="customer">The customer that will receive this order.</param>
    ''' <param name="method">How the customer will receive this order.</param>
    Public Sub New(store As DominosStore, customer As DominosCustomer, method As DominosServiceMethod)
        Throw New NotImplementedException
    End Sub

    ''' <summary>The customer that will receive this order.</summary>
    Public Property Customer As DominosCustomer

    ''' <summary>How the customer will receive this order.</summary>
    Public Property Method As DominosServiceMethod

    ''' <summary>The store that will be fulfilling this order.</summary>
    Public ReadOnly Property Store As DominosStore

    ''' <summary>The contents of this order.</summary>
    Public ReadOnly Property Items As IReadOnlyList(Of DominosItem)
        Get
            Return _items.AsReadOnly
        End Get
    End Property

    ''' <summary>Coupons that will be used in this order.</summary>
    Public ReadOnly Property Coupons As IReadOnlyList(Of DominosCoupon)
        Get
            Return _coupons.AsReadOnly
        End Get
    End Property

    ''' <summary>Verifies that the provided item can be ordered at the store associated with this order, then adds it to the list of items.</summary>
    ''' <param name="item">A valid item from the menu.</param>
    ''' <exception cref="InvalidOperationException"/><exception cref="ArgumentException"/>
    Public Function AddItem(item As DominosItem) As Boolean
        If _orderKey IsNot Nothing Then Throw New InvalidOperationException("This order has been placed.")
        ' TODO: verify item can be ordered at the store associated with current object.
    End Function

    ''' <summary> Verifies that the provided coupon can be use at the store associated with this order, then adds it to the list of coupons.</summary>
    ''' <param name="coupon">A valid coupon object.</param>
    ''' <exception cref="InvalidOperationException"/><exception cref="ArgumentException"/>
    Public Sub AddCoupon(coupon As DominosCoupon)
        If _orderKey IsNot Nothing Then Throw New InvalidOperationException("This order has been placed.")
        ' TODO: verify coupon is accepted at the store associated with current object.
    End Sub

    ''' <summary>Attempts to remove an item from this order. Returns <see langword="True"/> if the provided item was a part of this order.</summary>
    ''' <param name="item">The item to be removed.</param>
    Public Function RemoveItem(item As DominosItem) As Boolean
        If _orderKey IsNot Nothing Then Throw New InvalidOperationException("This order has been placed.")
        ' TODO: check if item is a part of this order then remove it.
    End Function

    ''' <summary>Attempts to remove a coupon from this order. Returns <see langword="True"/> if the provided coupon was a part of this order.</summary>
    ''' <param name="coupon">The coupon to be removed.</param>
    Public Function RemoveCoupon(coupon As DominosCoupon) As Boolean
        If _orderKey IsNot Nothing Then Throw New InvalidOperationException("This order has been placed.")
        ' TODO: check if this coupon is a part of this order then remove it.
    End Function

    ''' <summary>Returns a breakdown of the total cost of this order.</summary>
    Public Function CalculateCost() As OrderCost
        Throw New NotImplementedException
    End Function

    ''' <summary>Verifies that all items and coupons are valid then sends this order off to it's associated store. Returns a <see cref="DominosTracker"/> object.</summary>
    ''' <param name="payment">A credit or debit card that'll be used to pay for this order.</param>
    Public Async Function PlaceAsync(payment As DominosCreditCard) As Task(Of DominosTracker)
        If _orderKey IsNot Nothing Then Throw New InvalidOperationException("This order has already been placed.")
        ' Place order, get order key.
    End Function

    ''' <summary>
    ''' A breakdown of the cost for an order.
    ''' </summary>
    Public Structure OrderCost
        ''' <summary>
        ''' The monetary sum of all items.
        ''' </summary>
        Public ReadOnly Property Items As Decimal

        ''' <summary>
        ''' The superfluous delivery fee to boost Domino's bottom line.
        ''' </summary>
        Public ReadOnly Property Delivery As Decimal

        ''' <summary>
        ''' In applicable states and territories, a monetary deposit (fee) on beverage containers.
        ''' </summary>
        Public ReadOnly Property BottleDeposit As Decimal

        ''' <summary>
        ''' Coupons and other discounts.
        ''' </summary>
        Public ReadOnly Property Discounts As Decimal

        ''' <summary>
        ''' The total cost of all items and fees with coupons and discounts taken into account.
        ''' </summary>
        Public ReadOnly Property Total As Decimal
            Get
                Return (Items + Delivery + BottleDeposit) - Discounts
            End Get
        End Property

        Friend Sub New(items As Decimal, delivery As Decimal, bottle As Decimal, discounts As Decimal)
            _Items = items
            _Delivery = delivery
            _BottleDeposit = bottle
            _Discounts = discounts
        End Sub
    End Structure
End Class