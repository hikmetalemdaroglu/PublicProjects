Imports System
Imports System.Net.Http
Imports System.IO

Module Program
    Sub Main()
        ' url de�i�keninin de�erini bir metin dosyas�ndan oku
        ' url.txt dosyasinin i�ine a�a��daki sat�r yaz�lacak.
        ' url.txt programa ayn� dizinde olacak.
        ' http://paylas.duckdns.org/getClientIpAddress.php?version=v4
        Dim urlPath As String = System.IO.Path.GetFullPath("./url.txt")
        Dim url As String = File.ReadAllText(urlPath)

        Dim version As String = "v4" ' veya "v6"
        url = url & "getClientIpAddress.php?version=" & version

        Dim client As New HttpClient()
        Dim response As String = ""
        Try
            Dim httpResponse = client.GetAsync(url).Result

            If httpResponse.IsSuccessStatusCode Then
                response = httpResponse.Content.ReadAsStringAsync().Result
            Else
                response = "Error: " + httpResponse.ReasonPhrase
            End If
        Catch e As Exception
            response = "Error: " + e.Message
        End Try
        ' al�nan cevab� bir metin dosyas�na kaydetme
        Dim outputPath As String = System.IO.Path.GetFullPath("./output_ip.txt")
        File.WriteAllText(outputPath, response)
    End Sub
End Module