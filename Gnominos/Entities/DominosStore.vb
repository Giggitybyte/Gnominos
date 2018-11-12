Imports Gnominos.Enums

Namespace Entities

    ''' <summary>
    ''' Representation of a Dominos store.
    ''' </summary>
    Public NotInheritable Class DominosStore

        ''' <summary>
        ''' The potential customer for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="DominosCustomer"/> object.</returns>
        Public ReadOnly Property Customer As DominosCustomer

        ''' <summary>
        ''' The Dominos ID number for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="Short"/> containing four numbers.</returns>
        Public ReadOnly Property ID As Short

        ''' <summary>
        ''' The official name for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a store name.</returns>
        Public ReadOnly Property Name As String

        ''' <summary>
        ''' Whether or not this <see cref="DominosStore"/> would be the delivery store for the associated <see cref="DominosCustomer"/>.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property IsDeliveryStore As Boolean

        ''' <summary>
        ''' Whether or not this <see cref="DominosStore"/> is currently open.
        ''' <para>An exception will be thrown when creating a <see cref="DominosOrder"/> using this <see cref="DominosStore"/> if it is not open.</para>
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property IsOpen As Boolean

        ''' <summary>
        ''' Whether or not this <see cref="DominosStore"/> can take online orders.
        ''' <para>An exception will be thrown when creating a <see cref="DominosOrder"/> using this <see cref="DominosStore"/> if it cannot take online orders.</para>
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property IsOnlineCapable As Boolean

        ''' <summary>
        ''' The phone number for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a phone number.</returns>
        Public ReadOnly Property PhoneNumber As String

        ''' <summary>
        ''' The physical address for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a physical address.</returns>
        Public ReadOnly Property Address As String

        ''' <summary>
        ''' A brief description of the landmarks and streets near this <see cref="DominosStore"/>.
        ''' <para>This value can be an empty <see cref="String"/>.</para>
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a short description of the area near a <see cref="DominosStore"/> or an empty <see cref="String"/>.</returns>
        Public ReadOnly Property LocationDescription As String

        ''' <summary>
        ''' The latitude and longitude coordinates for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing geographic coordinates.</returns>
        Public ReadOnly Property Coordinates As String

        ''' <summary>
        ''' The carryout hours for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>An <see cref="OperatingHours"/> object containing seven two-value tuples.</returns>
        Public ReadOnly Property CarryoutHours As OperatingHours

        ''' <summary>
        ''' The delivery hours for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>An <see cref="OperatingHours"/> object containing seven two-value tuples.</returns>
        Public ReadOnly Property DeliveryHours As OperatingHours

        ''' <summary>
        ''' The accepted forms of payment for this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>An <see cref="[Enum]"/> containing bitwise flags of all acceptable forms of payment.</returns>
        Public ReadOnly Property AcceptedPaymentMethods As DominosPaymentMethod

        ''' <summary>
        ''' The card companies that are accepted by this <see cref="DominosStore"/>.
        ''' </summary>
        ''' <returns>An <see cref="[Enum]"/> containing bitwise flags of all acceptable card companies.</returns>
        Public ReadOnly Property AcceptedCreditCards As DominosCardCompany

        Friend Sub New()
            Throw New NotImplementedException
        End Sub

        Public Class OperatingHours
            ''' <summary>
            ''' The opening and closing times for Monday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Monday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Tuesday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Tuesday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Wednesday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Wednesday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Thursday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Thursday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Friday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Friday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Saturday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Saturday As (openingTime As TimeSpan, closingTime As TimeSpan)

            ''' <summary>
            ''' The opening and closing times for Sunday.
            ''' </summary>
            ''' <returns>A two value tuple. Each value contains a <see cref="TimeSpan"/>.</returns>
            Public ReadOnly Property Sunday As (openingTime As TimeSpan, closingTime As TimeSpan)

            Friend Sub New()
                Throw New NotImplementedException
            End Sub
        End Class
    End Class
End Namespace
