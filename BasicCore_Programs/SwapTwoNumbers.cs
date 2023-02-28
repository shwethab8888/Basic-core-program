using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class SwapTwoNumbers
    {
        public static void SwapTwo_Numbers()
        {
            static void Main()
            {
                Console.Write("Enter the first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Before swapping:");
                Console.WriteLine("a = {0}, b = {1}", a, b);

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine("After swapping:");
                Console.WriteLine("a = {0}, b = {1}", a, b);
            }
        }
    }
}
