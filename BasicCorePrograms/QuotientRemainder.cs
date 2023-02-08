using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientRemainder
    {
        public static void Value()
        {
            int number = 0, Quotient = 0, Remainder = 0, Divisor = 0;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            Divisor = Convert.ToInt32(Console.ReadLine());

            Quotient = number / Divisor;
            Remainder = number - (Divisor * Quotient);
            Console.WriteLine("Remainder is:{0} and Quotient is:{1}", Remainder, Quotient);
        }
    }
}
