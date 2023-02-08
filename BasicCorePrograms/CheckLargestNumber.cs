using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CheckLargestNumber
    {
        public static void Number()
        {
            int A = 0, B = 0, C = 0;
            Console.WriteLine("Enter the number");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine("A is greater", A);
            }
            else if (B > C)
            {
                Console.WriteLine("B is greater", B);
            }
            else
            {
                Console.WriteLine("C is greater", C);
            }
        }
    }
}
