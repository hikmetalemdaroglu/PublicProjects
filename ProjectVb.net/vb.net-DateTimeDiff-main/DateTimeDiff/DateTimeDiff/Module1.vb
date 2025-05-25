Module Module1

    Sub Main()
        Dim startTime As DateTime = DateTime.Now
        Dim endTime As DateTime = DateTime.Now.AddDays(12)

        endTime = endTime.AddHours(1)
        endTime = endTime.AddSeconds(2200)

        ' Dim span As TimeSpan = endTime.Subtract(startTime)
        ' Dim dayToMinute As Integer = span.Days * 24 * 60
        ' Dim hourToMinute As Integer = span.Hours * 60
        ' Dim startDate As DateTime = Now
        ' Dim endDate As DateTime = Now
        ' Dim date2Entered As String = InputBox("Enter a date")

        ' Dim testDate As DateTime = New DateTime(2000, 1, 1)
        ' Console.WriteLine("Test Date : " & testDate)

        Console.WriteLine("Start Time : " & startTime)
        Console.WriteLine("End Time : " & endTime)
        ' Console.WriteLine(span)
        ' Console.WriteLine(dayToMinute)
        ' Console.WriteLine((dayToMinute + hourToMinute))

        'Console.WriteLine("Time Difference (seconds): " + span.Seconds)
        'Console.WriteLine("Time Difference (minutes): " + span.Minutes)
        'Console.WriteLine("Time Difference (hours): " + span.Hours)
        'Console.WriteLine("Time Difference (days): " + span.Days)

        ' Dim timeDif As Long = DateDiff(DateInterval.Hour, startDate, endDate)
        Dim timeDif As Long = DateDiff(DateInterval.Minute, startTime, endTime)
        Console.WriteLine("TimeDiff : min " & timeDif)

        Console.ReadKey()


    End Sub

End Module


