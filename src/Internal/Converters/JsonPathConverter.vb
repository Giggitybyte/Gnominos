Imports System.Reflection
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Internal.Converters
    Friend NotInheritable Class JsonPathConverter 'Based off of https://stackoverflow.com/a/33094930
        Inherits JsonConverter

        Public Overrides ReadOnly Property CanRead As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property CanWrite As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Function CanConvert(objectType As Type) As Boolean
            Return False
        End Function

        Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Function ReadJson(reader As JsonReader, objType As Type, existingValue As Object, serializer As JsonSerializer) As Object
            Dim jsonObj = JObject.Load(reader)
            Dim targetObj = Activator.CreateInstance(objType)

            For Each field In objType.GetFields(BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance)
                Dim propAttribute = field.GetCustomAttributes(True).OfType(Of JsonPropertyAttribute)().FirstOrDefault()
                Dim jsonPath = If(propAttribute?.PropertyName, field.Name)
                Dim token = jsonObj.SelectToken(jsonPath)

                If token Is Nothing OrElse token.Type = JTokenType.Null Then Continue For

                Dim value = token.ToObject(field.FieldType, serializer)
                field.SetValue(targetObj, value)
            Next

            Return targetObj
        End Function
    End Class
End Namespace