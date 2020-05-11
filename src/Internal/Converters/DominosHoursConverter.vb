Imports Gnominos.Entities.DominosStore
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Internal.Converters
    ''' <summary>Simply converts the hours received from Dominos to <see cref="ServiceOperatingHours"/> objects.</summary>
    Friend NotInheritable Class DominosHoursConverter
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
            Return objectType.Equals(GetType(ServiceOperatingHours))
        End Function

        Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object
            Dim token = JToken.Load(reader)

            If Not token.Type = JTokenType.Object Then
                Throw New ArgumentException($"Expected an Object, got {token.Type}")
            End If

            Dim jsonHours = token.ToObject(Of Dictionary(Of String, String))
            Dim hours As New ServiceOperatingHours With {
                ._openTime = TimeSpan.Parse(jsonHours("OpenTime")),
                ._closeTime = TimeSpan.Parse(jsonHours("CloseTime"))
            }

            Return hours
        End Function
    End Class
End Namespace