using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf
    {
        public static void Number()
        {
            Console.WriteLine("Please enter the range for the power to calculate");
            int value = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (int i = 1; i <= value; i++)
            {
                result = result * 2;
                Console.WriteLine("2^{0} = {1}", i, result);
            }
        }
    }
}
