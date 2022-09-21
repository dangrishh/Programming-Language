Module Module1

    Sub Main()
        Try
            Dim nGradeArray() As Integer


            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("==================================================")
            Console.WriteLine("         Input Your Grade " & "Input X to Exit     ")
            Console.WriteLine("==================================================")





            Dim iArrayLength As Integer
            Dim xInput As Integer
            Dim intHigh As Integer
            Dim intLow As Integer
            Dim Sumtotal As Integer
            Dim Ave As Single





            Do
                Console.ForegroundColor = ConsoleColor.Yellow

                Console.Write("Grade: ")
                xInput = Console.ReadLine()


                If xInput = 0 Then
                    Exit Do

                Else

                    ReDim Preserve nGradeArray(iArrayLength)
                    nGradeArray(iArrayLength) = xInput
                    iArrayLength += 1

                End If

               
                If xInput >= 75 And xInput <= 99 Then

                    Console.WriteLine("Passed")

                Else

                    Console.WriteLine("Failed")

                End If

                Sumtotal = Sumtotal + xInput
                Ave = Sumtotal / iArrayLength





                For iCount As Integer = 0 To nGradeArray.Length - 1

                    Dim nGrade As Integer = nGradeArray(iCount)

                    If nGrade > intHigh Then
                        intHigh = nGrade

                    ElseIf nGrade < intHigh Then
                        intLow = nGrade
                    End If

                Next

            Loop While True

 
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("==================================================")


            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Average: " & Ave)
            Console.WriteLine("Total SUM: " & Sumtotal)
            Console.WriteLine("Input Count Total: " & iArrayLength)
            Console.WriteLine("LOW:" & intLow)
            Console.WriteLine("HIGH:" & intHigh)


        Catch ex As Exception

            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.Clear()

            Console.WriteLine("ERROR:" & ex.Message)

        Finally

            Console.WriteLine("==================================================")
            Console.WriteLine("         DONE, press any key to close ")
            Console.WriteLine("==================================================")
        End Try

        Console.ReadLine()

    End Sub




End Module
