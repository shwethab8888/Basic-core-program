using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class PowerTwo
    {

        public static void Power_Two()
        {
        
        
            static void Main(string[] args)
            {
                int n;
                while (true)
                {
                    Console.Write("Enter a power value (0 <= N < 31): ");
                    if (int.TryParse(Console.ReadLine(), out n) && n >= 0 && n < 31)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid power value.");
                }

                int i = 0;
                int powerOfTwo = 1;
                while (i <= n)
                {
                    Console.WriteLine("2^{0} = {1}", i, powerOfTwo);
                    i++;
                    powerOfTwo *= 2;
                }
            }
        }
    
    }
}
