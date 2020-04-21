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
    End Class
End Namespace