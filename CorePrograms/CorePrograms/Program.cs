using System;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-CoinFlip, 2-LeapYear, 3-PowerOfTwo, 4-HarmonicNumber, 5-Factors, 6-QuotientRemainder, 7-SwapNumber, 8-EvenOdd, 9-VowelConsonent,10-LargestOne,11-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CoinFlip cf = new CoinFlip();
                        cf.Play();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}