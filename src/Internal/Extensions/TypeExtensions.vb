Imports System.Runtime.CompilerServices

Public Module TypeExtensions
    <Extension()>
    Public Function IsA(type As Type, typeToBe As Type) As Boolean ' https://stackoverflow.com/a/7010231
        If Not typeToBe.IsGenericTypeDefinition Then Return typeToBe.IsAssignableFrom(type)

        Dim toCheckTypes = New List(Of Type) From {type}
        If typeToBe.IsInterface Then toCheckTypes.AddRange(type.GetInterfaces())

        Dim basedOn = type
        While basedOn.BaseType IsNot Nothing
            toCheckTypes.Add(basedOn.BaseType)
            basedOn = basedOn.BaseType
        End While

        Return toCheckTypes.Any(Function(x) x.IsGenericType AndAlso x.GetGenericTypeDefinition() = typeToBe)
    End Function
End Module
