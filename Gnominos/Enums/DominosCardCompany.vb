Namespace Enums

    ''' <summary>
    ''' Bitwise flags of card companies accepted by Dominos.
    ''' </summary>
    <Flags>
    Public Enum DominosCardCompany
        VISA = 1

        MASTERCARD = 2

        DISCOVER = 4

        AMERICANEXPRESS = 8

        ''' <summary>
        ''' An American Express card.
        ''' </summary>
        OPTIMA = 8
    End Enum
End Namespace