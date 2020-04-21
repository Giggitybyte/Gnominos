Imports Gnominos.Enums

Namespace Models
    Public NotInheritable Class DominosAddress
        ''' <summary>Street address.</summary>
        Public Property StreetAddress As String

        ''' <summary>Unit number/code.</summary>
        Public Property Unit As String

        ''' <summary>State, province, or territory.</summary>
        Public Property Region As String

        ''' <summary>Postal code.</summary>
        Public Property PostalCode As String

        ''' <summary>Country.</summary>
        Public Property Country As DominosCountry
    End Class
End Namespace