using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class HarmonicNumber
    {
        public void Find()
        {
            double harmonicNumber = 0;
            Console.WriteLine("Enter the Harmonic Number as N Where N Should not be 0");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                harmonicNumber += 1 / (float)i;
            }
            Console.WriteLine(Math.Round(harmonicNumber, 2)); //Rounds a double-precision floating-point value to a specified number of fractional
                                                              //digits, and uses the specified rounding convention for midpoint values 
        }
    }
}