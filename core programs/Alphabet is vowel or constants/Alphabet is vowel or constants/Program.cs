namespace Alphabet_is_vowel_or_constants
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter an alphabet: ");
            char ch = Console.ReadLine().ToLower()[0];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("{0} is a vowel.", ch);
            }
            else
            {
                Console.WriteLine("{0} is a consonant.", ch);
            }
        }
    }

}