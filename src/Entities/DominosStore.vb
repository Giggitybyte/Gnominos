Imports Gnominos.Enums
Imports Gnominos.Internal
Imports Newtonsoft.Json

Namespace Entities
    <JsonConverter(GetType(JsonPathConverter))>
    Public NotInheritable Class DominosStore
        ''' <summary>The ID of this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property Id As Integer
            Get
                Return _id
            End Get
        End Property

        ''' <summary>
        ''' The distance from the customer's address.<para/>
        ''' If only a postal code was used to retrieve this store, this will be 0.
        ''' </summary>
        <JsonIgnore>
        Public ReadOnly Property Distance As Single
            Get
                Return _distance
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

        ''' <summary>The operating hours for each service method.</summary>
        <JsonIgnore>
        Public ReadOnly Property Hours As IReadOnlyDictionary(Of DominosServiceMethod, String)
            Get
                Return New Dictionary(Of DominosServiceMethod, String) From {
                    {DominosServiceMethod.Carryout, _carryoutHours},
                    {DominosServiceMethod.Delivery, _deliveryHours}
                }
            End Get
        End Property

        ''' <summary>Estimated wait times for each service method.</summary>
        <JsonIgnore>
        Public ReadOnly Property WaitTime As IReadOnlyDictionary(Of DominosServiceMethod, ServiceWaitTime)
            Get
                Return New Dictionary(Of DominosServiceMethod, ServiceWaitTime) From {
                    {DominosServiceMethod.Carryout, _carryoutWaitTime},
                    {DominosServiceMethod.Delivery, _deliveryWaitTime}
                }
            End Get
        End Property

        ''' <summary>Whether or not a service method is currently open and available at this store.</summary>
        <JsonIgnore>
        Public ReadOnly Property ServiceAvailability As IReadOnlyDictionary(Of DominosServiceMethod, Boolean)
            Get
                Return New Dictionary(Of DominosServiceMethod, Boolean) From {
                    {DominosServiceMethod.Carryout, _isCarryoutOpen},
                    {DominosServiceMethod.Delivery, _isDeliveryOpen}
                }
            End Get
        End Property

        <JsonProperty("StoreID")>
        Friend _id As Integer

        <JsonProperty("MaxDistance")>
        Friend _distance As Single

        <JsonProperty("Phone")>
        Friend _phoneNumber As String

        <JsonProperty("AddressDescription")>
        Friend _address As String

        <JsonProperty("ServiceHoursDescription.Carryout")>
        Friend _carryoutHours As String

        <JsonProperty("ServiceHoursDescription.Delivery")>
        Friend _deliveryHours As String

        <JsonProperty("AllowCarryoutOrders")>
        Friend _acceptsCarryout As Boolean

        <JsonProperty("AllowDeliveryOrders")>
        Friend _acceptsDelivery As Boolean

        <JsonProperty("IsOpen")>
        Friend _isOpen As Boolean

        <JsonProperty("ServiceMethodEstimatedWaitMinutes.Carryout")>
        Friend _carryoutWaitTime As ServiceWaitTime

        <JsonProperty("ServiceMethodEstimatedWaitMinutes.Delivery")>
        Friend _deliveryWaitTime As ServiceWaitTime

        <JsonProperty("ServiceIsOpen.Carryout")>
        Friend _isCarryoutOpen As Boolean

        <JsonProperty("ServiceIsOpen.Delivery")>
        Friend _isDeliveryOpen As Boolean

        ''' <summary>Estimated wait time for a service method.</summary>
        Public Class ServiceWaitTime
            ''' <summary>The minimum amount of time.</summary>
            <JsonIgnore>
            Public ReadOnly Property Minimum As TimeSpan
                Get
                    Return TimeSpan.FromMinutes(_min)
                End Get
            End Property

            ''' <summary>The maximum amount of time.</summary>
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
    End Class
End Namespace