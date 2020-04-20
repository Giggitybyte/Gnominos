Imports Gnominos.Enums
Imports Gnominos.Internal.Converters
Imports Newtonsoft.Json

Namespace Models
    <JsonConverter(GetType(JsonPathConverter))>
    Public NotInheritable Class DominosStore
        ''' <summary>The ID of this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property Id As Integer
            Get
                Return _id
            End Get
        End Property

        ''' <summary>The preferred currency for this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property Currency As String
            Get
                Return _currency
            End Get
        End Property

        ''' <summary>The current date and time where the store is physically located.</summary>
        <JsonIgnore>
        Public ReadOnly Property StoreTime As Date
            Get
                Return Date.UtcNow.AddMinutes(_tzOffsetMinutes)
            End Get
        End Property

        ''' <summary>The direct phone number for this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property PhoneNumber As String
            Get
                Return _phoneNumber
            End Get
        End Property

        ''' <summary>The physical address of this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property Address As String
            Get
                Return _address.Trim
            End Get
        End Property

        ''' <summary>Whether or not this store accepts carryout orders.</summary>
        <JsonIgnore>
        Public ReadOnly Property AcceptsCarryoutOrders As Boolean
            Get
                Return _acceptsCarryout
            End Get
        End Property

        ''' <summary>Whether or not this store accepts delivery orders.</summary>
        <JsonIgnore>
        Public ReadOnly Property AcceptsDeliveryOrders As Boolean
            Get
                Return _acceptsDelivery
            End Get
        End Property

        ''' <summary>Whether or not the physical store is open.</summary>
        <JsonIgnore>
        Public ReadOnly Property IsOpen As Boolean
            Get
                Return _isOpen
            End Get
        End Property

        ''' <summary>The minimum order subtotal required for delivery orders.</summary>
        <JsonIgnore>
        Public ReadOnly Property DeliveryMinimum As Single
            Get
                Return _deliveryMinimum
            End Get
        End Property

        ''' <summary>
        ''' Operating hours for a specified service method. All <see cref="TimeSpan"/> from <see cref="ServiceOperatingHours"/> express time-of-day in 24-hour format, with <i>00:00</i> being 12:00 AM.<para/>
        ''' Some stores are open past midnight and remain open into the next day, e.g. 10:30am-2:00am. As such, if a <see cref="DayOfWeek"/> has more than one set of hours, the first value would be the remaining hours from the previous day.
        ''' </summary>
        <JsonIgnore>
        Public ReadOnly Property Hours(service As DominosServiceMethod) As IReadOnlyDictionary(Of DayOfWeek, IReadOnlyList(Of ServiceOperatingHours))
            Get
                Select Case service
                    Case DominosServiceMethod.Carryout
                        Return _carryoutHours
                    Case DominosServiceMethod.Delivery
                        Return _deliveryHours
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        ''' <summary>Estimated wait times for a service method.</summary>
        ''' <param name="service">The service method to get wait time for.</param>
        <JsonIgnore>
        Public ReadOnly Property WaitTime(service As DominosServiceMethod) As ServiceWaitTime
            Get
                Select Case service
                    Case DominosServiceMethod.Carryout
                        Return _carryoutWaitTime
                    Case DominosServiceMethod.Delivery
                        Return _deliveryWaitTime
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        ''' <summary>Whether or not a service method is currently open and available at this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property ServiceAvailability(service As DominosServiceMethod) As Boolean
            Get
                Select Case service
                    Case DominosServiceMethod.Carryout
                        Return _isCarryoutOpen
                    Case DominosServiceMethod.Delivery
                        Return _isDeliveryOpen
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        <JsonProperty("StoreID")>
        Friend _id As Integer

        <JsonProperty("PreferredLanguage")>
        Friend _language As String

        <JsonProperty("PreferredCurrency")>
        Friend _currency As String

        <JsonProperty("TimeZoneMinutes")>
        Friend _tzOffsetMinutes As Integer

        <JsonProperty("Phone")>
        Friend _phoneNumber As String

        <JsonProperty("AddressDescription")>
        Friend _address As String

        <JsonProperty("AllowCarryoutOrders")>
        Friend _acceptsCarryout As Boolean

        <JsonProperty("AllowDeliveryOrders")>
        Friend _acceptsDelivery As Boolean

        <JsonProperty("IsOpen")>
        Friend _isOpen As Boolean

        <JsonProperty("ServiceHours.Carryout")>
        Friend _carryoutHours As Dictionary(Of DayOfWeek, IReadOnlyList(Of ServiceOperatingHours))

        <JsonProperty("ServiceHours.Delivery")>
        Friend _deliveryHours As Dictionary(Of DayOfWeek, IReadOnlyList(Of ServiceOperatingHours))

        <JsonProperty("ServiceMethodEstimatedWaitMinutes.Carryout")>
        Friend _carryoutWaitTime As ServiceWaitTime

        <JsonProperty("ServiceMethodEstimatedWaitMinutes.Delivery")>
        Friend _deliveryWaitTime As ServiceWaitTime

        <JsonProperty("ServiceIsOpen.Carryout")>
        Friend _isCarryoutOpen As Boolean

        <JsonProperty("ServiceIsOpen.Delivery")>
        Friend _isDeliveryOpen As Boolean

        <JsonProperty("MinimumDeliveryOrderAmount")>
        Friend _deliveryMinimum As Single

#Region "Nested Classes"

        ''' <summary>Operating hours for a service method.</summary>
        <JsonArray> Public Class ServiceOperatingHours

            ''' <summary>Opening time; 24-hour based.</summary>
            <JsonIgnore>
            Public ReadOnly Property Open As TimeSpan
                Get
                    Return _openTime
                End Get
            End Property

            ''' <summary>Closing time; 24-hour based.</summary>
            <JsonIgnore>
            Public ReadOnly Property Close As TimeSpan
                Get
                    Return _closeTime
                End Get
            End Property

            <JsonProperty("OpenTime")>
            Friend _openTime As TimeSpan

            <JsonProperty("CloseTime")>
            Friend _closeTime As TimeSpan
        End Class

        ''' <summary>Estimated wait time for a service method.</summary>
        Public Class ServiceWaitTime
            ''' <summary>The minimum amount of time it'd take to fulfill an order.</summary>
            <JsonIgnore>
            Public ReadOnly Property Minimum As TimeSpan
                Get
                    Return TimeSpan.FromMinutes(_min)
                End Get
            End Property

            ''' <summary>The maximum amount of time it'd take to fulfill an order.</summary>
            <JsonIgnore>
            Public ReadOnly Property Maximum As TimeSpan
                Get
                    Return TimeSpan.FromMinutes(_max)
                End Get
            End Property

            <JsonProperty("Min")>
            Friend _min As Integer

            <JsonProperty("Max")>
            Friend _max As Integer
        End Class

#End Region

    End Class
End Namespace