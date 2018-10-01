Module Module1

    Sub Main()

        Dim somenumbers(1) As Integer
        somenumbers = {15, 30}

        Swap(somenumbers(0), somenumbers(1))

        For i = 0 To somenumbers.Length - 1
            Console.WriteLine(somenumbers(i))
        Next

        Console.Read()

    End Sub

    Sub BubbleSort(ByVal x() As Integer)
        Do
            For i = 0 To x.Length - 1
                If x(i) > x(i + 1) Then
                    Swap(x(i), x(i + 1))

                End If
            Next
        Loop
    End Sub
    Sub Swap(ByRef x As Integer, ByRef y As Integer)
        Dim temp As Integer = x
        x = y
        y = temp
    End Sub

End Module
