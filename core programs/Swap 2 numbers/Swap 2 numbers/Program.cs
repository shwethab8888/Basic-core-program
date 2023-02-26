namespace Swap_2_numbers
{
    using System;

    class Program
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