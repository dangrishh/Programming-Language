Module Module1

   Sub Main()
        Dim nLoop As Integer
        Dim nStdCount As Integer

        nLoop = 2

        Console.WriteLine("welcome to awesome loop counter by eric..") '+ NEW LINE(ENTER)
        Console.WriteLine("=================")

        Console.WriteLine("enter how many loops")
        nLoop = Console.ReadLine
        Console.WriteLine("run loop for " & nloop)

        nStdCount = 0

        Do
            nStdCount = nStdCount + 1

            Console.WriteLine(" loop counter N = " & nLoopCounter & " number of loops = " & nLoop)
        Loop While nStdCount < nLoop 'gawin lahat habang TRUE

        Console.WriteLine("=================")
        Console.WriteLine("goodbye")
        Console.ReadKey()
    End Sub
End Module
