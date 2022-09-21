using System;

namespace LargeSmall {
    class Program {
        public static void Main(string[] args) {
        
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0; 
 
            Console.WriteLine("Enter 6-digit numbers: "); 
            num1 = int.Parse(Console.ReadLine()); 
            num2 = int.Parse(Console.ReadLine()); 
            num3 = int.Parse(Console.ReadLine());  
            num4 = int.Parse(Console.ReadLine());  
            num5 = int.Parse(Console.ReadLine());
            num6 = int.Parse(Console.ReadLine()); 

            Console.Write("\n");
          
            int lowest = ((num1 < num2 ? num1: num2) < num3 ? (num1 < num2 ? num1 : num2) : num3);
            int highest = ((num1 > num2 ? num1: num2) > num3 ? (num1 > num2 ? num1 : num2) : num3); 
            Console.WriteLine(" Lowest digit is {0} ", lowest); 

            Console.WriteLine(" Highest digit is {0} ", highest); 
            Console.ReadLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
