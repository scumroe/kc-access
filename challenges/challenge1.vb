Module challenge1

    Class Joke
        Dim Setup As String
        Dim Punchline As String

        Sub GetSetUp(str As String)
            Setup = str
        End Sub

        Sub GetPunchLine(str As String)
            Punchline = str
        End Sub

        Sub TellJoke()
            Console.WriteLine(Setup)
            Console.Read()
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(Punchline)
            Console.Read()
        End Sub
    End Class

    Sub Main()

        Dim joke As New Joke

        joke.GetSetUp("What is a joke?")
        joke.GetPunchLine("I don't know.")
        joke.TellJoke()
        Console.Read()

    End Sub

End Module
