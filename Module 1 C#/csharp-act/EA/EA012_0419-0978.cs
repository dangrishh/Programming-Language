using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LabExer9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Enter 1st number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
 

            Console.WriteLine("C# code that will determine if the signs of two (2) numbers are the same or not.");
 

            bool check_sign = ((x < 0 && y >0) || (x > 0 && y >0));
            Console.WriteLine("Is the sign is the same? {0}",check_sign);
            Console.ReadLine();
        }
    }
}
