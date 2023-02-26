namespace Power_of_2
{
    using System;

    class Program
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