Module Module1

    Sub Main()

        Dim dateToday As Date = Date.Now.Date

        Console.Write("Enter your DOB: ")
        Dim dateDOB As Date = Date.Parse(Console.ReadLine)
        Dim intDateDiff As Integer = DateDiff(DateInterval.Day, dateDOB, dateToday)
        Console.WriteLine("Date of birth is: " + dateDOB)
        Console.WriteLine("There are {0} between DOB ({1}) and today's date ({2}).", intDateDiff, dateDOB, dateToday)
        Console.Read()

    End Sub

End Module
