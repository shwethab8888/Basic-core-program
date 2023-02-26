namespace Leap_Year
{
    using System;

    class Program
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