﻿using System.Diagnostics.CodeAnalysis;

namespace Flip_H_or_T
{
 
   using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numFlips;
            while (true)
            {
                Console.Write("Enter the number of times to flip the coin: ");
                if (int.TryParse(Console.ReadLine(), out numFlips) && numFlips >0)
                {
                    break;
                }
                Console.WriteLine("Please enter a positive integer.");
            }

            Random rand = new Random();
            int heads = 0;
            int tails = 0;
            for (int i = 0; i < numFlips; i++)
            {
                if (rand.NextDouble() < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double headsPercent = (double)heads / numFlips * 100;
            double tailsPercent = (double)tails / numFlips * 100;
            Console.WriteLine("Percentage of Heads: {0:F2}%", headsPercent);
            Console.WriteLine("Percentage of Tails: {0:F2}%", tailsPercent);
        }
    }

}