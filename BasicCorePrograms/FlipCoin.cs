using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public void FindPercentage()
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Number of times the coin to flip");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= num; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("Tailcount:{0} and Headcount:{1}", tailCount, headCount);
            double tailpercentage = (tailCount * 100) / 10;
            double headpercentage = (headCount * 100) / 10;
            Console.WriteLine("The percentage of tail count is :" + tailpercentage);
            Console.WriteLine("The percentage of head count is :" + headpercentage);
        }
    }
}
