Imports Gnominos.Enums

Namespace Entities

    ''' <summary>
    ''' 
    ''' </summary>
    Public NotInheritable Class DominosCustomer

        ''' <summary>
        ''' The first name of the customer.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a first name.</returns>
        Public ReadOnly Property FirstName As String

        ''' <summary>
        ''' The last name of the customer.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a last name.</returns>
        Public ReadOnly Property LastName As String

        ''' <summary>
        ''' The customer's email address.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing an email address.</returns>
        Public ReadOnly Property Email As String

        ''' <summary>
        ''' The customer's phone number.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a phone number.</returns>
        Public ReadOnly Property PhoneNumber As String

        ''' <summary>
        ''' The customer's street address.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a street address.</returns>
        Public ReadOnly Property StreetAddress As String

        ''' <summary>
        ''' Either an apartment number or a unit number/code. Can be empty.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing an apartment number or a unit number/code.</returns>
        Public ReadOnly Property Unit As String

        ''' <summary>
        ''' The state or province of the customer's country.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a state or province.</returns>
        Public ReadOnly Property Region As String

        ''' <summary>
        ''' The postal code for the customer's address.
        ''' </summary>
        ''' <returns>A <see cref="String"/> containing a postal code.</returns>
        Public ReadOnly Property PostalCode As String

        ''' <summary>
        ''' The country of the customer's address.
        ''' </summary>
        ''' <returns>A <see cref="DominosCountry"/>.</returns>
        Public ReadOnly Property Country As DominosCountry

        ''' <summary>
        ''' Creates a new instance of a <see cref="DominosCustomer"/>.
        ''' </summary>
        Sub New(firstName As String, lastName As String, email As String, phoneNumber As String,
                streetAddress As String, region As String, postalCode As String, country As DominosCountry)

            Throw New NotImplementedException
        End Sub

        ''' <summary>
        ''' Creates a new instance of a <see cref="DominosCustomer"/>.
        ''' </summary>
        Sub New(firstName As String, lastName As String, email As String,
                phoneNumber As String, streetAddress As String, unit As String,
                region As String, postalCode As String, country As DominosCountry)

            Throw New NotImplementedException
        End Sub

        ''' <summary>
        ''' Retreves stores near this <see cref="DominosCustomer"/>.
        ''' </summary>
        ''' <returns>A list of <see cref="DominosStore"/>.</returns>
        Public Function GetNearbyStores() As IReadOnlyList(Of DominosStore)
            Throw New NotImplementedException
        End Function
    End Class
End Namespace