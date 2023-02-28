using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class HarmonicNumber
    {
        internal static void Harmonic_Number()
        {
            throw new NotImplementedException();
        }

        class Program
        {

            public static void Harmonic_Number()
            {


                static void Main()
                {
                    Console.Write("Enter a positive integer N: ");
                    int n = int.Parse(Console.ReadLine());
                    double sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += 1.0 / i;
                    }
                    Console.WriteLine("The {0}th harmonic number is: {1}", n, sum);
                }
            }


        }
    }
}
