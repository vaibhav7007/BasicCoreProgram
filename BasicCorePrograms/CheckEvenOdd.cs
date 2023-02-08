using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CheckEvenOdd
    {
        public static void Compute()
        {
            Console.WriteLine("Enter the number to check even or odd");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
