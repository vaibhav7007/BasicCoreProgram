using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public static void Number()
        {
            int a = 0, p = 2;
            Console.WriteLine("Please enter your integer: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 1)
            {
                if (a % p == 0)
                {
                    Console.WriteLine("Prime factors: {0}", p);
                    a = a / p;
                }
                else
                    p++;
            }
        }
    }
}
