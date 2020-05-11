Imports System.Text.RegularExpressions
Imports Gnominos.Enums

Namespace Entities
    ''' <summary>A representation of a credit or debit card. Used as payment for an order.</summary>
    Public NotInheritable Class DominosCreditCard
        Private Shared ReadOnly _cardRegex As New Regex("^(?<Visa>4[0-9]{12}(?:[0-9]{3})?)|" _
                                                       + "(?<MasterCard>5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720[0-9]{12})|" _
                                                       + "(?<Discover>6(?:011|5[0-9]{2})[0-9]{12})|" _
                                                       + "(?<AmericanExpress>3[47][0-9]{13})|" _
                                                       + "(?<DinersClub>3(?:0[0-5]|[68][0-9])[0-9]{11})|" _
                                                       + "(?<JCB>(?:2131|1800|35[0-9]{3})[0-9]{11})$", RegexOptions.Compiled)

        ''' <summary>Account number on the front of a credit/debit card.</summary>
        Public Property CardNumber As String

        ''' <summary>Security code on the card; typically found on the back.</summary>
        Public Property SecurityCode As String

        ''' <summary>The name on the card.</summary>
        Public Property CardholderName As String

        ''' <summary>Checks whether or not the card number is valid and correctly formatted</summary>
        Public Function ValidateCard() As DominosCardBrand
            Dim result = _cardRegex.Match(Regex.Replace(_CardNumber, "[^0-9]", ""))
            For Each group As Group In result.Groups
                If group.Success Then Return [Enum].Parse(Of DominosCardBrand)(group.Name)
            Next

            Return Nothing
        End Function
    End Class
End Namespace