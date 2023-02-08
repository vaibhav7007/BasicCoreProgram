using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CheckAlphabet
    {
        public static void Alphabet()
        {
            string[] Vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            string alpha = " ";
            Console.WriteLine("Enter the alphabet");
            alpha = Convert.ToString(Console.ReadLine());
            if ((alpha == "a") || (alpha == "e") || (alpha == "i") || (alpha == "o") || (alpha == "u") ||
                (alpha == "A") || (alpha == "E") || (alpha == "I") || (alpha == "O") || (alpha == "U"))
            {
                Console.WriteLine("Is vowels :{0}", alpha);
            }
            else
            {
                Console.WriteLine("Is Consonent:{0}", alpha);
            }



        }
    }
}
