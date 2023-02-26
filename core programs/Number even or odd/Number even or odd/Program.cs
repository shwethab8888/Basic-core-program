namespace Number_even_or_odd
{
    using System;

    class Program
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