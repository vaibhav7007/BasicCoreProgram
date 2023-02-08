using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNum
    {
        public static void Result()
        {
            int a = 10, b = 20, temp = 0;
            Console.WriteLine("Before Swapping a:{0} and b:{1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping a:{0} and b:{1}", a, b);
        }
    }
}
