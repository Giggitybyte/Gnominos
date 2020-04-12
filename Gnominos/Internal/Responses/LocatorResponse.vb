Imports Gnominos.Entities
Imports Newtonsoft.Json

Namespace Internal.Responses
    Public Class LocatorResponse
        <JsonProperty("Status")>
        Public Property Status As Integer

        <JsonProperty("Address")>
        Public Property Address As Address

        <JsonProperty("Stores")>
        Public Property Stores As List(Of DominosStore)
    End Class

    Public Class Address
        <JsonProperty("Street")>
        Public Property Street As String

        <JsonProperty("StreetNumber")>
        Public Property StreetNumber As String

        <JsonProperty("StreetName")>
        Public Property StreetName As String

        <JsonProperty("UnitType")>
        Public Property UnitType As String

        <JsonProperty("UnitNumber")>
        Public Property UnitNumber As String

        <JsonProperty("City")>
        Public Property City As String

        <JsonProperty("Region")>
        Public Property Region As String

        <JsonProperty("PostalCode")>
        Public Property PostalCode As String
    End Class
End Namespace