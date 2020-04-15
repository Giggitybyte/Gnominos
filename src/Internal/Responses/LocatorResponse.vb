Imports Newtonsoft.Json

Namespace Internal.Responses
    Friend NotInheritable Class LocatorResponse
        <JsonProperty("Status")>
        Public Property Status As Integer

        <JsonProperty("Address")>
        Public Property Address As CustomerAddress

        <JsonProperty("Stores")>
        Public Property Stores As List(Of Store)

        Friend NotInheritable Class Store
            <JsonProperty("StoreID")>
            Public Property Id As String
        End Class

        Friend NotInheritable Class CustomerAddress
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
    End Class
End Namespace