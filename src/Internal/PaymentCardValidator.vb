Imports System.Text.RegularExpressions
Imports Gnominos.Enums

Namespace Internal
    Friend NotInheritable Class PaymentCardValidator
        Private Shared ReadOnly CardRegex As New Regex("^(?<Visa>4[0-9]{12}(?:[0-9]{3})?)|" _
                                                       + "(?<MasterCard>5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720[0-9]{12})|" _
                                                       + "(?<Discover>6(?:011|5[0-9]{2})[0-9]{12})|" _
                                                       + "(?<AmericanExpress>3[47][0-9]{13})|" _
                                                       + "(?<DinersClub>3(?:0[0-5]|[68][0-9])[0-9]{11})|" _
                                                       + "(?<JCB>(?:2131|1800|35[0-9]{3})[0-9]{11})$", RegexOptions.Compiled)

        Friend Shared Function ValidateCard(number As String) As DominosCardBrand
            number = Regex.Replace(number, "[^0-9]", "")
            Dim result = CardRegex.Match(number)

            For Each group As Group In result.Groups
                If group.Success Then Return [Enum].Parse(Of DominosCardBrand)(group.Name)
            Next

            Return Nothing
        End Function
    End Class
End Namespace
