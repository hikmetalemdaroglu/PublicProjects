Module Module1
    Private ReadOnly removeXmlHeader As String =
                    "xmlns:xsi=" + Chr(34) + "http://www.w3.org/2001/XMLSchema-instance" + Chr(34) + " " +
                    "xmlns:xsd=" + Chr(34) + "http://www.w3.org/2001/XMLSchema" + Chr(34) + " " +
                    "xmlns=" + Chr(34) + "http://tempuri.org/" + Chr(34)

    Sub Main()
        ' deleteString()
        replaceHeader()
        Console.ReadKey()
    End Sub
    Sub deleteString()
        Dim a As String
        Dim b As String
        a = "xmlns:xsi=" + Chr(34) + "http://www.w3.org/2001/XMLSchema-instance" + Chr(34) + " " +
            "xmlns:xsd=" + Chr(34) + "http://www.w3.org/2001/XMLSchema" + Chr(34) + " " +
            "xmlns=" + Chr(34) + "http://tempuri.org/" + Chr(34)
        Console.WriteLine(a)

        b = a
        b = b.Replace(a, "")
        'MsgBox(b)
        Console.WriteLine(b)
    End Sub
    Sub replaceHeader()
        Dim strMain As String =
            "<?xml version=" + Chr(34) + "1.0" + Chr(34) + " " + "encoding=" + Chr(34) + "utf-8" + Chr(34) + "?>" +
            "<anyType xmlns:q1=" + Chr(34) + "http://www.w3.org/2001/XMLSchema" + Chr(34) + " " +
            "d1p1:Type=" + Chr(34) + "q1:string" + Chr(34) + " " +
            "xmlns:d1p1=" + Chr(34) + "http://www.w3.org/2001/XMLSchema-instance" + Chr(34) + " " + "xmlns=" + Chr(34) + "http://tempuri.org/" + Chr(34) + ">"

        Dim strReplace As String = "<?xml version=" + Chr(34) + "1.0" + Chr(34) + " " + "encoding=" + Chr(34) + "utf-8" + Chr(34) + "?>" +
            "<isTokenValid xmlns:xsi=" + Chr(34) + "http://www.w3.org/2001/XMLSchema-instance" + Chr(34) + " " +
            "xmlns:xsd=" + Chr(34) + "http://www.w3.org/2001/XMLSchema" + Chr(34) + " " +
            "xmlns=" + Chr(34) + "oakService" + Chr(34) + ">"

        MsgBox(strMain + Chr(13) + Chr(13) + strReplace)

        strMain = strMain.Replace(strMain, strReplace)

        MsgBox(strMain + Chr(13) + Chr(13) + strReplace)

    End Sub
End Module
