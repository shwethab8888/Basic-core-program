﻿namespace Largest_among_3_numbers
{
    using System;

    namespace LargestAmongThreeNumbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter three numbers: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine(num1 + " is the largest number.");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(num2 + " is the largest number.");
                }
                else
                {
                    Console.WriteLine(num3 + " is the largest number.");
                }

                Console.ReadLine();
            }
        }
    }

}