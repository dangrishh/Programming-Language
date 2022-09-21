using System;

namespace LabExer10
{
    class Program
    {
        public static void Main(string[] args)
        {
 

             Console.Write("Enter the amount of celsius: "); 
             int celsius = Convert.ToInt32(Console.ReadLine());
 

             Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
 

             Console.Write("Press any key to continue . . . ");
             Console.ReadKey(true);
    }
}
}
