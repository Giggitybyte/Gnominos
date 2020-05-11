Imports Gnominos.Enums
Imports Gnominos.Models
Imports RestSharp
Imports RestSharp.Serializers.NewtonsoftJson
Imports System.Net
Imports Gnominos.Internal.Responses
Imports Gnominos.Internal
Imports Newtonsoft.Json
Imports Gnominos.Internal.Converters

Public NotInheritable Class DominosStoreLocator
    Private ReadOnly _restClient As RestClient
    Private _urls As DominosBaseUrls

    Public Sub New(country As DominosCountry)
        _restClient = New RestClient
        _restClient.UseNewtonsoftJson(New JsonSerializerSettings With {
            .Converters = {New DominosHoursConverter, New DominosDayConverter}
        })

        _urls = DominosBaseUrls.Countries(country)
    End Sub

    ''' <summary>Returns up to 10 stores near a customer's address.</summary>
    ''' <param name="address">A <see cref="DominosAddress"/> object with a valid address to base the search off of.</param>
    Public Async Function GetStoresAsync(address As DominosAddress) As Task(Of IReadOnlyList(Of DominosStore))
        Dim custAddress = WebUtility.UrlEncode($"{address.StreetAddress}{If($" {address.Unit}", "")}")
        Dim postalCode = WebUtility.UrlEncode(address.PostalCode)

        Return Await GetStoresAsync(New Uri($"{_urls.LocatorUrl}?s={custAddress}&c={postalCode}")).ConfigureAwait(False)
    End Function

    ''' <summary>Returns up to 10 stores near a postal code.</summary>
    ''' <param name="postalCode">A postal/zip code to base the search off of.</param>
    Public Async Function GetStoresAsync(postalCode As String) As Task(Of IReadOnlyList(Of DominosStore))
        Return Await GetStoresAsync(New Uri($"{_urls.LocatorUrl}?c={WebUtility.UrlEncode(postalCode)}")).ConfigureAwait(False)
    End Function

    ''' <summary>Retrieves dominos store IDs via the store locator endpoint, then gets a collection of <see cref="DominosStore"/> objects from the store profile endpoint.</summary>
    ''' <param name="locatorUrl">Store locator URL. Used to retrieve store IDs.</param>
    Private Async Function GetStoresAsync(locatorUrl As Uri) As Task(Of List(Of DominosStore))
        Dim request As New RestRequest(locatorUrl, Method.GET)
        Dim response = Await _restClient.ExecuteAsync(Of LocatorResponse)(request).ConfigureAwait(False)

        If Not response.StatusCode = HttpStatusCode.OK Then Return Nothing

        Dim tasks As New List(Of Task(Of DominosStore))
        For Each returnedStore In response.Data.Stores
            tasks.Add(GetStoreAsync(returnedStore.Id))
        Next
        Dim stores = (Await Task.WhenAll(tasks)).ToList

        Return stores
    End Function

    ''' <summary>Returns the store closest to a customer's address.</summary>
    ''' <param name="address">A <see cref="DominosAddress"/> object with a valid address to base the search off of.</param>
    Public Async Function GetClosestStoreAsync(address As DominosAddress) As Task(Of DominosStore)
        Return (Await GetStoresAsync(address).ConfigureAwait(False)).FirstOrDefault
    End Function

    ''' <summary>Returns the store closest to the specified postal code.</summary>
    ''' <param name="postalCode">A zip/postal code to base the search off of.</param>
    Public Async Function GetClosestStoreAsync(postalCode As String) As Task(Of DominosStore)
        Return (Await GetStoresAsync(postalCode).ConfigureAwait(False)).FirstOrDefault
    End Function

    ''' <summary>Retrieves a specific store using its store number.</summary>
    ''' <param name="storeId">The ID of a specific store.</param>
    Public Async Function GetStoreAsync(storeId As String) As Task(Of DominosStore)
        Dim request As New RestRequest(_urls.StoreUrl(storeId), Method.GET)
        Dim response = Await _restClient.ExecuteAsync(Of DominosStore)(request).ConfigureAwait(False)

        If Not response.StatusCode = HttpStatusCode.OK Then Return Nothing
        Return response.Data
    End Function
End Class