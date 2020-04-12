Imports System.Net
Imports Gnominos.Enums
Imports Gnominos.Entities

Public NotInheritable Class DominosStoreLocator
    Private Shared _webClient As New WebClient With {.BaseAddress = "TODO"}

    ''' <summary>Returns the closest store within 25 miles of a customer.</summary>
    ''' <param name="address">A <see cref="DominosCustomer"/> object.</param>
    Public Shared Async Function GetClosestStoreAsync(address As DominosCustomer) As Task(Of DominosStore)
        Throw New NotImplementedException
    End Function


    ''' <summary>Returns the closest store within 25 miles of a set of coordinates.</summary>
    ''' <param name="latitude">Latitude coordinate.</param>
    ''' <param name="longitude">Longitude coordinate.</param>
    Public Shared Async Function GetClosestStoreAsync(latitude As Double, longitude As Double) As Task(Of DominosStore)
        Throw New NotImplementedException
    End Function

    ''' <summary>Returns up to 25 stores within 25 miles of a customer.</summary>
    ''' <param name="address">A <see cref="DominosCustomer"/> object.</param>
    Public Shared Async Function GetStoresAsync(address As DominosCustomer) As Task(Of IReadOnlyList(Of DominosStore))
        Throw New NotImplementedException
    End Function

    ''' <summary>Returns up to 25 stores within 25 miles of a set of coordinates.</summary>
    ''' <param name="latitude">Latitude coordinate.</param>
    ''' <param name="longitude">Longitude coordinate.</param>
    Public Shared Async Function GetStoresAsync(latitude As Double, longitude As Double) As Task(Of IReadOnlyList(Of DominosStore))
        Throw New NotImplementedException
    End Function

    ''' <summary>Retrieves a specific store using its store number.</summary>
    ''' <param name="storeNumber">The number of a store.</param>
    Public Shared Async Function GetStoreAsync(country As DominosCountry, storeNumber As Integer) As Task(Of DominosStore)
        Throw New NotImplementedException
    End Function

    ''' <summary>Takes raw JSON and deserializes to a collection of POVO.</summary>
    Private Shared Function DeserializeStores(json As String) As List(Of DominosStore)
        Throw New NotImplementedException
    End Function
End Class