Namespace Enums
    ''' <summary>The various states of an order.</summary>
    Public Enum DominosOrderStatus
        ''' <summary>Order has been recieived by the store.</summary>
        Placed

        ''' <summary>Order is being prepared.</summary>
        Prep

        ''' <summary>Order is in the oven.</summary>
        Baking

        ''' <summary>Usually referred to as a "quality check" or "perfection check" in the tracker UI.</summary>
        Inspection

        ''' <summary>Order has been completed, but the customer has not received it yet.</summary>
        Ready

        ''' <summary>Order is on its way to the customer.</summary>
        Enroute

        ''' <summary>Order has been received by the customer.</summary>
        Completed
    End Enum
End Namespace