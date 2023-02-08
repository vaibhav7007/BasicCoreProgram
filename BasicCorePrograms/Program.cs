using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:FlipCoin\n2:LeapYear\n3:PowerOf2\n4:Harmonic Number\n5:PrimeFactors\n6:QuotientRemainder");
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

                    case 3:
                    PowerOf.Number();
                    break;

                    case 4:
                    HarmonicNumber.Number();
                    break;

                    case 5:
                    PrimeFactors.Number();
                    break;

                    case 6:
                    QuotientRemainder.Value();
                    break;
            }
        }
    }
}
