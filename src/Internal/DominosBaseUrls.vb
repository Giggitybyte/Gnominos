Imports Gnominos.Enums

Namespace Internal
    Friend NotInheritable Class DominosBaseUrls
        Friend Property Locator As String
        Friend Property Store As String
        Friend Property Menu As String

        Friend Shared ReadOnly Property Countries As New Dictionary(Of DominosCountry, DominosBaseUrls) From {
            {
                DominosCountry.US, New DominosBaseUrls() With {
                    .Locator = "https://order.dominos.com/power/store-locator",
                    .Store = "https://order.dominos.com/power/store/[STOREID]/profile",
                    .Menu = "https://order.dominos.com/power/store/[STOREID]/menu?lang=[LANG]&structured=true"
                }
            },
            {
                DominosCountry.CA, New DominosBaseUrls() With {
                    .Locator = "https://order.dominos.ca/power/store-locator",
                    .Store = "https://order.dominos.ca/power/store/[STOREID]/profile",
                    .Menu = "https://order.dominos.ca/power/store/[STOREID]/menu?lang=[LANG]&structured=true"
                }
            }
        }
    End Class
End Namespace
