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
                        LeapYear lp = new LeapYear();
                        lp.Check();
                        break;
                    case 3:
                        PowerOfTwo pft = new PowerOfTwo();
                        pft.Calculation();
                        break;
                    case 4:
                        HarmonicNumber hn = new HarmonicNumber();
                        hn.Find();
                        break;
                    case 5:
                        Factors fc = new Factors();
                        fc.Calculation();
                        break;
                    case 6:
                        QuotientRemainder qr = new QuotientRemainder();
                        qr.Calculation();
                        break;
                    case 7:
                        SwapNumber sn = new SwapNumber();
                        sn.Calculation();
                        break;
                    case 8:
                        EvenOdd ev = new EvenOdd();
                        ev.Calculation();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}