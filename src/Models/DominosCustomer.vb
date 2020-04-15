Imports Gnominos.Enums

Namespace Models
    Public NotInheritable Class DominosCustomer
        ''' <summary>
        ''' The first name of the customer.<para/>
        ''' This is required for all orders.
        ''' </summary>
        Public Property FirstName As String

        ''' <summary>
        ''' The last name of the customer.<para/>
        ''' This is required for all orders.
        ''' </summary>
        Public Property LastName As String

        ''' <summary>
        ''' The customer's email address.<para/>
        ''' This is required for all orders.
        ''' </summary>
        Public Property Email As String

        ''' <summary>
        ''' The customer's phone number.<para/>
        ''' This is required for all orders.
        ''' </summary>
        Public Property PhoneNumber As String

        ''' <summary>
        ''' The customer's street address.<para/>
        ''' Required for delivery orders.
        ''' </summary>
        Public Property StreetAddress As String

        ''' <summary>
        ''' Either an apartment number or a unit number/code.<para/>
        ''' Used for delivery orders; can be empty.
        ''' </summary>
        Public Property Unit As String

        ''' <summary>
        ''' The state or province of the customer's country.<para/>
        ''' This is required for delivery orders.
        ''' </summary>
        Public Property Region As String

        ''' <summary>
        ''' The postal code for the customer's address.<para/>
        ''' This is required for delivery orders.
        ''' </summary>
        Public Property PostalCode As String

        ''' <summary>
        ''' The country of the customer's address.<para/>
        ''' This is required for delivery orders.
        ''' </summary>
        Public Property Country As DominosCountry
    End Class
End Namespace