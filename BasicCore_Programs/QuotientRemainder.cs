using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class QuotientRemainder
    {
        public static void Quotient_Remainder()
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
}
