namespace Quotient_and_Remainder
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the dividend: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("Remainder = {0}", remainder);
        }
    }

}