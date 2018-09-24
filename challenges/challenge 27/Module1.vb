Imports System


Public Module Module1
    Sub Main()
        Console.WriteLine("Enter a word to guess: ")
        Dim str_word As String = Console.ReadLine
        GuessWord(str_word)
        Console.Read()

    End Sub

    Sub GuessWord(ByRef word As String)

        Console.Clear()

        Dim str_hide As String
        Dim playerLives = 5

        str_hide = HideWord(word)

        Do
            Console.WriteLine("Word to guess: " + str_hide)
            Console.WriteLine("You have {0} lives left.", playerLives)
            Console.WriteLine("Enter a letter to guess: ")

            Dim guess As String = Console.ReadLine()

            If guess.Length > 1 Then
                Console.WriteLine("Invalid.")
            Else
                If word.Contains(guess) Then

                    Console.WriteLine("Right.")

                    Dim temp As Integer

                    If str_hide.Contains(guess) Then
                        temp = word.LastIndexOf(guess)
                    Else

                        temp = word.IndexOf(guess)
                    End If


                    str_hide = str_hide.Remove(temp, 1)
                    str_hide = str_hide.Insert(temp, guess)
                Else
                    Console.WriteLine("Wrong.")
                    playerLives -= 1
                End If


            End If

        Loop While (str_hide <> word) And (playerLives > 0)

        If playerLives = 0 Then
            Console.WriteLine("Ran out of lives.")
        Else
            Console.WriteLine(str_hide)
            Console.WriteLine("You win.")
        End If
    End Sub

    Function HideWord(str As String)

        Dim hidden As String

        For i = 1 To str.Length Step 1
            hidden += "*"
        Next

        Return hidden
    End Function

End Module

Class Player
    Dim pName As String
    Enum Role
        Player
    End Enum
End Class