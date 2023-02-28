using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programs
{
    public class VowelsConsonants
    {
        public static void Vowels_Consonants()
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
}
