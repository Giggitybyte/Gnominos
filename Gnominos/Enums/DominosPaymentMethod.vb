Namespace Enums

    ''' <summary>
    ''' Bitwise flags of payment methods.
    ''' </summary>
    <Flags>
    Public Enum DominosPaymentMethod

        ''' <summary>
        ''' Credit or debit card.
        ''' <para>This payment method can be used to pre-pay for a delivery order, or it can be used in store.</para>
        ''' </summary>
        CREDITCARD = 1

        ''' <summary>
        ''' A Dominos giftcard. 
        ''' <para>This payment method can be used to pre-pay for a delivery order, or it can be used in store.</para>
        ''' </summary>
        GIFTCARD = 2

        ''' <summary>
        ''' Fiat currency.
        ''' <para>This payment method can be used at the door for a delivery order, or it can be used in store.</para>
        ''' </summary>
        CASH = 4

        ''' <summary>
        ''' Debit card.
        ''' <para>This payment method can be used at the door for a delivery order.</para>
        ''' </summary>
        DOORDEBIT = 8

        ''' <summary>
        ''' Credit card.
        ''' <para>This payment method can be used at the door for a delivery order.</para>
        ''' </summary>
        DOORCREDIT = 16

    End Enum
End Namespace