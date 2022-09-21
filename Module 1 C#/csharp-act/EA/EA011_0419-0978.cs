using System;
using System.Linq;

namespace LabExer8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Square, Cube, SumSquare, SumCube;
            Console.WriteLine("\tNumber\tSquare\tCube\tSumSquare\tSumCube");  

            for (int Number = 1; Number <= 5;  
            Number++)  
        {  
            Square = Number * Number;  
            Cube = Square * Number;
            SumSquare = Square + Square + Square;
            SumCube = Cube + Cube + Cube;

            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t\t{4}", Number, Square, Cube, SumSquare, SumCube);  
}      
 

            Console.ReadLine();  


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
