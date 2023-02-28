using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class EvenOdd
    {
        public static void Even_Odd()
        {
            static void Main()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is an even number.", num);
                }
                else
                {
                    Console.WriteLine("{0} is an odd number.", num);
                }
            }
        }
    }
}
