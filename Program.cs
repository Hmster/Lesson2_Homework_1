using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min. and max day temp.:");

            decimal minT = decimal.Parse(Console.ReadLine());
            EvenWrite(minT);

            decimal maxT = decimal.Parse(Console.ReadLine());
            EvenWrite(maxT);

            decimal avTemp = Lesson2.AvTemp(minT, maxT);
            Console.WriteLine($"\nAverage day temp. : {avTemp}");

            Console.WriteLine("----------------");

            Console.WriteLine("\nEnter month number(1-12)");
            int monthNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Lesson2.WhatMonth(monthNum, avTemp));


            Console.ReadKey();

        }

        /// <summary>
        /// Console write for "AreEven"
        /// </summary>
        /// <param name="number">User number</param>
        /// <returns></returns>
        static bool EvenWrite(decimal number)
        {
            if (Lesson2.AreEven(number))
            {
                Console.WriteLine("Even number");
            }
            else Console.WriteLine("Not even number");
            return true;
        }
    }
}
