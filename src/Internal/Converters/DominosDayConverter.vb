Imports Newtonsoft.Json

Namespace Internal.Converters
    ''' <summary>Converts a short-hand day (e.g. "Thu") to its corresponding <see cref="DayOfWeek"/>.</summary>
    Friend NotInheritable Class DominosDayConverter ' Based off of https://stackoverflow.com/a/7010231
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
            Return objectType.IsA(GetType(IDictionary(Of,))) AndAlso objectType.GetGenericArguments()(0).IsA(GetType(DayOfWeek))
        End Function

        Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
            Throw New NotSupportedException()
        End Sub

        Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object
            If reader.TokenType = JsonToken.Null Then Return Nothing

            Dim valueType = objectType.GetGenericArguments()(1)
            Dim intermediateDictionaryType = GetType(Dictionary(Of,)).MakeGenericType(GetType(String), valueType)
            Dim intermediateDictionary = CType(Activator.CreateInstance(intermediateDictionaryType), IDictionary)

            serializer.Populate(reader, intermediateDictionary)
            Dim finalDictionary = CType(Activator.CreateInstance(objectType), IDictionary)

            For Each pair As DictionaryEntry In intermediateDictionary
                finalDictionary.Add(ConvertString(CType(pair.Key, String)), pair.Value)
            Next

            Return finalDictionary
        End Function

        Private Function ConvertString(value As String) As DayOfWeek
            Select Case value
                Case "Sun"
                    Return DayOfWeek.Sunday
                Case "Mon"
                    Return DayOfWeek.Monday
                Case "Tue"
                    Return DayOfWeek.Tuesday
                Case "Wed"
                    Return DayOfWeek.Wednesday
                Case "Thu"
                    Return DayOfWeek.Thursday
                Case "Fri"
                    Return DayOfWeek.Friday
                Case "Sat"
                    Return DayOfWeek.Saturday
                Case Else
                    Throw New ArgumentException($"Invalid day provided. Got {value}.")
            End Select
        End Function
    End Class
End Namespace
