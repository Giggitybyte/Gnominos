Imports Gnominos.Enums
Imports Gnominos.Entities
Imports RestSharp
Imports RestSharp.Serializers.NewtonsoftJson
Imports System.Net
Imports Gnominos.Internal.Responses

Public NotInheritable Class DominosStoreLocator
    Private Const BaseUrl As String = "https://order.dominos.com/power/store-locator"
    Private ReadOnly _restClient As RestClient

    Public Sub New()
        _restClient = New RestClient
        _restClient.UseNewtonsoftJson()
    End Sub

    ''' <summary>Returns up to 10 stores near a customer's address.</summary>
    ''' <param name="customer">A <see cref="DominosCustomer"/> object with a valid address to base the search off of.</param>
    Public Async Function GetStoresAsync(customer As DominosCustomer) As Task(Of IReadOnlyList(Of DominosStore))
        Dim address = WebUtility.UrlEncode($"{customer.StreetAddress}{If($" {customer.Unit}", "")}")
        Dim postalCode = WebUtility.UrlEncode(customer.PostalCode)

        Dim request As New RestRequest($"{BaseUrl}?s={address}&c={postalCode}", Method.GET)
        Dim response = Await _restClient.ExecuteAsync(Of LocatorResponse)(request).ConfigureAwait(False)

        If Not response.StatusCode = HttpStatusCode.OK Then Return Nothing
        Return response.Data.Stores
    End Function

    ''' <summary>Returns up to 10 stores near a postal code.</summary>
    ''' <param name="postalCode">A postal/zip code to base the search off of.</param>
    Public Async Function GetStoresAsync(postalCode As String) As Task(Of IReadOnlyList(Of DominosStore))
        Dim request As New RestRequest($"{BaseUrl}?c={WebUtility.UrlEncode(postalCode)}", Method.GET)
        Dim response = Await _restClient.ExecuteAsync(Of LocatorResponse)(request).ConfigureAwait(False)

        If Not response.StatusCode = HttpStatusCode.OK Then Return Nothing
        Return response.Data.Stores
    End Function

    ''' <summary>Returns the store closest to a customer's address.</summary>
    ''' <param name="customer">A <see cref="DominosCustomer"/> object with a valid address to base the search off of.</param>
    Public Async Function GetClosestStoreAsync(customer As DominosCustomer) As Task(Of DominosStore)
        Return (Await GetStoresAsync(customer).ConfigureAwait(False)).FirstOrDefault
    End Function


    ''' <summary>Returns the store closest to the specified postal code.</summary>
    ''' <param name="postalCode">A zip/postal code to base the search off of.</param>
    Public Async Function GetClosestStoreAsync(postalCode As String) As Task(Of DominosStore)
        Return (Await GetStoresAsync(postalCode).ConfigureAwait(False)).FirstOrDefault
    End Function

    ''' <summary>Retrieves a specific store using its store number.</summary>
    ''' <param name="storeNumber">The number for a specific store.</param>
    ''' <param name="country">The country the store is in.</param>
    Public Async Function GetStoreAsync(storeNumber As Integer, country As DominosCountry) As Task(Of DominosStore)
        Throw New NotImplementedException
    End Function
End Class