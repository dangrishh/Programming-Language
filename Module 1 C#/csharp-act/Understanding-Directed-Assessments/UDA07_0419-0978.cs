using System;

namespace LAbExer7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            double sum = 0, avg = 0, pro = 0, sumsq = 0;
 

            Console.WriteLine("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 4th number: ");
            num4 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 5th number: ");
            num5 = Convert.ToInt32(Console.ReadLine()); 
 
			sum = num1 + num2 + num3 + num4 + num5;
			avg = (num1 + num2 + num3 + num4 + num5) / 5;
			pro = num1 * num2 * num3 * num4 * num5;
			sumsq = num1 * num1 + num2 * num2 + num3 * num3 + num4 * num4 + num5 * num5; 
			
            Console.Write("\n");
            Console.WriteLine("Sum --> {0} + {1} + {2} + {3} + {4} = {5:F2}",num1,num2,num3,num4,num5,sum);
            Console.WriteLine("Average --> ( {0} + {1} + {2} + {3} + {4} ) / 5 = {5:F2}",num1,num2,num3,num4,num5,avg);
            Console.WriteLine("Product --> {0} x {1} x {2} x {3} x {4} = {5:F2}",num1,num2,num3,num4,num5,pro);
            Console.WriteLine("Sum of Squares = {0} x {0} + {1} x {1} + {2} x {2} + {3} x {3} + {4} x {4} = {5:F2}",num1,num2,num3,num4,num5,sumsq);
            Console.ReadLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
