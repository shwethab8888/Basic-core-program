namespace Harmonic_value
{
    using System;

    class Program
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