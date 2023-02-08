using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void FindLeap()
        {
            Console.WriteLine("Enter the year");
            int YearVal = Convert.ToInt32(Console.ReadLine());

            if (YearVal % 400 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else if (YearVal % 4 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else if (YearVal % 100 == 0)
            {
                Console.WriteLine("This is not leap year");
            }
            else
            {
                Console.WriteLine("The year is not a leap year");
            }
        }
    }
}
