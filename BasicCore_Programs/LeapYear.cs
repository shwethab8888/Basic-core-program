using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class LeapYear
    {
        public static void Leap_Year()
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a year (4 digits): ");
                int year = int.Parse(Console.ReadLine());

                bool isLeapYear = DateTime.IsLeapYear(year);

                Console.WriteLine("{0} is{1} a leap year.", year, isLeapYear ? "" : " not");
            }
        }

    }
}
