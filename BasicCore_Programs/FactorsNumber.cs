using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class FactorsNumber
    {
        public static void Factors_Number()
        {
            static void Main()
            {
                Console.Write("Enter a positive integer N: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("The prime factors of {0} are: ", n);
                for (int i = 2; i * i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        Console.Write(i + " ");
                        n /= i;
                    }
                }

                if (n > 1)
                    Console.Write(n);

                Console.WriteLine();
            }
        }
    }
}
