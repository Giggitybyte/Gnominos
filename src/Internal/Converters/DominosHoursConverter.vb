Imports Gnominos.Models.DominosStore
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Internal.Converters
    ''' <summary>Simply converts the funky hour array received from Dominos to a <see cref="ServiceOperatingHours"/> object.</summary>
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

            If Not token.Type = JTokenType.Array Then Throw New ArgumentException($"Expected an Array, got {token.Type}")

            Dim hourStrings = token.ToObject(Of IEnumerable(Of Dictionary(Of String, String))).First
            Dim hoursObject As New ServiceOperatingHours With {
                ._openTime = TimeSpan.Parse(hourStrings("OpenTime")),
                ._closeTime = TimeSpan.Parse(hourStrings("CloseTime"))
            }

            Return hoursObject
        End Function
    End Class
End Namespace