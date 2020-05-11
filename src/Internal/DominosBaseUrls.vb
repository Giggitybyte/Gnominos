Imports Gnominos.Enums

Namespace Internal
    ''' <summary>Hard-coded URLs for Dominos.</summary>
    Friend NotInheritable Class DominosBaseUrls
        Private _locatorUrl, _storeUrl, _menuUrl As String

        ''' <summary>Dominos store locator URL.</summary>
        Friend ReadOnly Property LocatorUrl As String
            Get
                Return _locatorUrl
            End Get
        End Property

        ''' <summary>Dominos store profile URL.</summary>
        Friend ReadOnly Property StoreUrl(storeId As String) As String
            Get
                Return _storeUrl.Replace("[STOREID]", storeId)
            End Get
        End Property

        ''' <summary>Menu URL for a Dominos store.</summary>
        Friend ReadOnly Property MenuUrl(storeId As String, Optional language As String = "en") As String
            Get
                Return _menuUrl.Replace("[STOREID]", storeId).Replace("[LANG]", language)
            End Get
        End Property

        ''' <summary>A collection of hard-coded country specific URLs.</summary>
        Friend Shared ReadOnly Property Countries As New Dictionary(Of DominosCountry, DominosBaseUrls) From {
            {
                DominosCountry.US, New DominosBaseUrls() With {
                    ._locatorUrl = "https://order.dominos.com/power/store-locator",
                    ._storeUrl = "https://order.dominos.com/power/store/[STOREID]/profile",
                    ._menuUrl = "https://order.dominos.com/power/store/[STOREID]/menu?lang=[LANG]&structured=true"
                }
            },
            {
                DominosCountry.CA, New DominosBaseUrls() With {
                    ._locatorUrl = "https://order.dominos.ca/power/store-locator",
                    ._storeUrl = "https://order.dominos.ca/power/store/[STOREID]/profile",
                    ._menuUrl = "https://order.dominos.ca/power/store/[STOREID]/menu?lang=[LANG]&structured=true"
                }
            }
        }
    End Class
End Namespace
