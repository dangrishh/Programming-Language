using System;

namespace XYexpression {
    class Program {
        public static void Main(string[] args) {
            int x, y, ans1, ans2, ans3, ans4, ans5;
 
            Console.Write("Enter X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y: ");
            y = Convert.ToInt32(Console.ReadLine());
 
            ans1 = (x = y + 3);
            ans2 = (x = y - 2);
            ans3 = (x = y * 5);
            ans4 = (x = x / y);
            ans5 = (x = x % y);

            Console.WriteLine("-----------------------------------------------");            
            Console.Write("X-Value\t Y-Value\t Expression\t Result ");
            Console.WriteLine("\n{0}\t  {1}\t\t X = Y + 3\t  {2}",x,y,ans1);
            Console.WriteLine("{0}\t  {1}\t\t X = Y - 2\t  {2}",x,y,ans2);
            Console.WriteLine("{0}\t  {1}\t\t X = Y * 5\t  {2}",x,y,ans3);
            Console.WriteLine("{0}\t  {1}\t\t X = X / Y\t  {2}",x,y,ans4);
            Console.WriteLine("{0}\t  {1}\t\t X = X % Y\t  {2}",x,y,ans5);
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
