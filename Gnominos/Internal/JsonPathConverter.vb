Imports System.Reflection
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Internal
    Friend NotInheritable Class JsonPathConverter 'Based off of https://stackoverflow.com/a/33094930
        Inherits JsonConverter

        Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object
            Dim jo As JObject = JObject.Load(reader)
            Dim targetObj As Object = Activator.CreateInstance(objectType)

            Dim flags = BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance
            For Each field As FieldInfo In objectType.GetFields(flags)
                Dim att As JsonPropertyAttribute = field.GetCustomAttributes(True).OfType(Of JsonPropertyAttribute)().FirstOrDefault()
                Dim jsonPath As String = (If(att IsNot Nothing, att.PropertyName, field.Name))
                Dim token As JToken = jo.SelectToken(jsonPath)

                If token IsNot Nothing AndAlso token.Type <> JTokenType.Null Then
                    Dim value As Object = token.ToObject(field.FieldType, serializer)
                    field.SetValue(targetObj, value)
                End If
            Next

            Return targetObj
        End Function

        Public Overrides Function CanConvert(objectType As Type) As Boolean
            Return False
        End Function

        Public Overrides ReadOnly Property CanWrite As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace