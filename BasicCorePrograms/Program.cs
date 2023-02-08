using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:FlipCoin\n2:LeapYear");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FindPercentage();
                    break;

                    case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.FindLeap();
                    break;
            }
        }
    }
}
