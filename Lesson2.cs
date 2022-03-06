using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Homework_1
{
    internal static class Lesson2
    {
        /// <summary>
        /// Average day temperature
        /// </summary>
        /// <param name="tempMin">Minimal day temperature</param>
        /// <param name="tempMax">Maximum day temperature</param>
        /// <returns>Average</returns>
        internal static decimal AvTemp(decimal tempMin, decimal tempMax)
        {
            return (tempMin + tempMax) / 2;
        }

        /// <summary>
        /// Check for even number
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>true/false</returns>
        internal static bool AreEven(decimal number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Return month name with month number & "rainy winter" check
        /// </summary>
        /// <param name="number">Month number</param>
        /// <param name="avTemp">Average temperature</param>
        /// <returns></returns>
        internal static string WhatMonth(int number, decimal avTemp)
        {
            string month;

            switch (number)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    month = "Not valid";
                    break;
            }
            if (avTemp > 0 && (number == 12 || number == 1 || number == 2))
                month += ". Rainy winter";

            return month;
        }

    }
}
