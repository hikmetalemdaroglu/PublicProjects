' Module Module1
' 
'     Sub Main()
'         MsgBox("selam")
'     End Sub
' 
' End Module
' usage : EmailValidate.exe "test@example.com" "22bff9d18b33473eb3da7e0304e3ba5d" "C:\temp\output.txt"

Imports System.Net.Http
Imports System.IO
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module Module1
    Sub Main(args As String())
        If args.Length <> 3 Then
            Console.WriteLine("Usage: EmailValidator <email> <apiKey> <outputFilePath>")
            Return
        End If

        Dim email As String = args(0)
        Dim apiKey As String = args(1)
        Dim outputFilePath As String = args(2)

        ' Async metodu senkron olarak çağır
        Dim task As Task = ValidateEmailAsync(email, apiKey, outputFilePath)
        task.Wait()
    End Sub

    ' Async email doğrulama metodu
    Private Async Function ValidateEmailAsync(email As String, apiKey As String, outputFilePath As String) As Task
        Dim result As String = "Invalid email address"
        Dim url As String = $"https://emailvalidation.abstractapi.com/v1?api_key={apiKey}&email={email}"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                result = responseBody
            Catch ex As Exception
                result = $"Error: {ex.Message}"
            End Try
        End Using

        ' Sonucu dosyaya yazma
        Try
            File.WriteAllText(outputFilePath, result)
            Console.WriteLine($"Result written to {outputFilePath}")
            Threading.Thread.Sleep(500)
            GetJsonValue(result)
        Catch ex As Exception
            Console.WriteLine($"Error writing to file: {ex.Message}")
        End Try
    End Function
    Sub GetJsonValue(ByVal jsonResults As String)
        Dim jsonString As String = jsonResults
        ' JsonConvert.DeserializeObject(Of JObject) yöntemi, öğesinden bağımsız bir JSON nesnesini çözümleyerek JObject nesnesini oluşturur
        Dim json As JObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)

        ' Okuma işlemleri gerçekleştirin
        Dim email As String = json.GetValue("email").ToString()
        Dim deliverability As String = json.GetValue("deliverability").ToString()

        Console.WriteLine("Email : " & email)
        Console.WriteLine("Deliverability : " & deliverability)

        MsgBox("Email : " & email & vbCr & "Deliverability : " & deliverability)

    End Sub
End Module