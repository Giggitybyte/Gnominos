Imports Gnominos.Entities

Namespace Core

    ''' <summary>
    ''' A representation of a Dominos order.
    ''' </summary>
    Public NotInheritable Class Order

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property CustomerAddress As Address

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Items As IReadOnlyList(Of Object)

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Total As Double

        ''' <summary>
        ''' 
        ''' </summary>
        Sub New()
            Throw New NotImplementedException
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub Add()
            Throw New NotImplementedException
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub Remove()
            Throw New NotImplementedException
        End Sub
    End Class
End Namespace
