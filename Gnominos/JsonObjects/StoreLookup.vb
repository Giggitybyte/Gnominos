Imports Newtonsoft.Json

Namespace JsonObjects
    Friend Class StoreLookup

        <JsonProperty("Granularity")>
        Friend Property Granularity As String

        <JsonProperty("Stores")>
        Public Property Stores As List(Of Store)

        Friend Class Store

            <JsonProperty("StoreID")>
            Public Property StoreID As String

            <JsonProperty("IsDeliveryStore")>
            Public Property IsDeliveryStore As Boolean

            <JsonProperty("Phone")>
            Public Property Phone As String

            <JsonProperty("AddressDescription")>
            Public Property AddressDescription As String

            <JsonProperty("HolidaysDescription")>
            Public Property HolidaysDescription As String

            <JsonProperty("HoursDescription")>
            Public Property HoursDescription As String

            <JsonProperty("ServiceHoursDescription")>
            Public Property ServiceHoursDescription As ServiceHoursDescription

            <JsonProperty("IsOnlineCapable")>
            Public Property IsOnlineCapable As Boolean

            <JsonProperty("IsOnlineNow")>
            Public Property IsOnlineNow As Boolean

            <JsonProperty("LocationInfo")>
            Public Property LocationInfo As String

            <JsonProperty("AllowDeliveryOrders")>
            Public Property AllowDeliveryOrders As Boolean

            <JsonProperty("AllowCarryoutOrders")>
            Public Property AllowCarryoutOrders As Boolean

            <JsonProperty("ServiceMethodEstimatedWaitMinutes")>
            Public Property WaitTime As EstimatedWaitTime

            <JsonProperty("StoreCoordinates")>
            Public Property StoreCoordinates As StoreCoordinates

            <JsonProperty("IsOpen")>
            Public Property IsOpen As Boolean

            <JsonProperty("ServiceIsOpen")>
            Public Property OpenServices As ServiceIsOpen
        End Class

        Friend Class ServiceHoursDescription

            <JsonProperty("Carryout")>
            Public Property Carryout As String

            <JsonProperty("Delivery")>
            Public Property Delivery As String
        End Class

        Friend Class WaitTime

            <JsonProperty("Min")>
            Public Property Min As Integer

            <JsonProperty("Max")>
            Public Property Max As Integer
        End Class

        Friend Class EstimatedWaitTime

            <JsonProperty("Delivery")>
            Public Property Delivery As WaitTime

            <JsonProperty("Carryout")>
            Public Property Carryout As WaitTime
        End Class

        Friend Class StoreCoordinates

            <JsonProperty("StoreLatitude")>
            Public Property StoreLatitude As String

            <JsonProperty("StoreLongitude")>
            Public Property StoreLongitude As String
        End Class

        Friend Class ServiceIsOpen

            <JsonProperty("Carryout")>
            Public Property Carryout As Boolean

            <JsonProperty("Delivery")>
            Public Property Delivery As Boolean
        End Class
    End Class
End Namespace