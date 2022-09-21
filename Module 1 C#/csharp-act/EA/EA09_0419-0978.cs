using System;
namespace SwapValue {
    class Program {
        public static void Main(string[] args) {
        
            int x, y, temp;
            Console.Write("Enter value for X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter value for Y: ");
            y = int.Parse(Console.ReadLine());

            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("\n");
            Console.WriteLine("The value of X and Y after swapping\n");
            Console.WriteLine("Original values X = {0}, Y = {1}",y,x);
            Console.WriteLine("Swap values X = {0}, Y = {1}",x,y);
            Console.WriteLine("\n");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
