Namespace Enums
    ''' <summary>The various states of an order.</summary>
    Public Enum DominosOrderStatus
        ''' <summary>Order has been recieived by the store.</summary>
        Placed = 1

        ''' <summary>Order is being prepared.</summary>
        Prep = 2

        ''' <summary>Order is in the oven.</summary>
        Baking = 3

        ''' <summary>Usually referred to as a "quality check" or "perfection check" in the tracker UI.</summary>
        Inspection = 4

        ''' <summary>Order has been completed, but the customer has not received it yet.</summary>
        Ready = 5

        ''' <summary>Order is on its way to the customer.</summary>
        Enroute = 6

        ''' <summary>Order has been received by the customer.</summary>
        Completed = 7
    End Enum
End Namespace