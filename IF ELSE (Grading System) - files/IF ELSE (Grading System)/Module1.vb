Module Module1

    Sub Main()
        Dim grade As Integer
        Console.Write("enter grade ")
        grade = Console.ReadLine


        If grade >= 70 And grade <= 74 Then
            Console.WriteLine("failed")
        ElseIf grade >= 75 And grade <= 80 Then
            Console.WriteLine("average")
        ElseIf grade >= 81 And grade <= 85 Then
            Console.WriteLine("good")
        ElseIf grade >= 86 And grade <= 90 Then
            Console.WriteLine("great")
        ElseIf grade >= 91 And grade <= 95 Then
            Console.WriteLine("excellent")
        ElseIf grade >= 96 And grade <= 99 Then
            Console.WriteLine("awesome")
        Else
            Console.WriteLine("out of range")
        End If

        Dim x = Console.ReadKey()
    End Sub



End Module
