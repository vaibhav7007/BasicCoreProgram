using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void Number()
        {
            double value = 0, res = 0, i = 0;
            Console.WriteLine("Enter the number");
            value = Convert.ToDouble(Console.ReadLine());

            for (i = 1; i <= value; i++)
            {
                res = res + 1 / i;
            }
            Console.WriteLine("Harmonic number value is:" + res);
        }
    }
}
