﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Console.Write("Month : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Day : ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            string monthWord;

            switch (month)
            {
                case 1:
                    monthWord = "January";
                    break;
                case 2:
                    monthWord = "January";
                    break;
                case 3:
                    monthWord = "February";
                    break;
                case 4:
                    monthWord = "March";
                    break;
                case 5:
                    monthWord = "April";
                    break;
                case 6:
                    monthWord = "May";
                    break;
                case 7:
                    monthWord = "June";
                    break;
                case 8:
                    monthWord = "July";
                    break;
                case 9:
                    monthWord = "Augost";
                    break;
                case 10:
                    monthWord = "September";
                    break;
                case 11:
                    monthWord = "November";
                    break;
                case 12:
                    monthWord = "December";
                    break;
                default:
                    monthWord = "";
                    Console.WriteLine("Invalid Month Input");
                    break;

            }

            if (day >= 1 && day <= 31)
            {
                if (monthWord != "") Console.WriteLine(monthWord + " " + day + "," + year);
            }
            else
            {
                Console.WriteLine("Invalid Day, Day is only up to 31..");
            }

            Console.Read();
        }
    }
}
