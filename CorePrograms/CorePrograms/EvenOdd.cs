using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class EvenOdd
    {
        public void Calculation()
        {
            Console.WriteLine("Enter the Number to Check it is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + "is a even no.");
            }
            else
            {
                Console.WriteLine(num + "is a odd no.");
            }
        }
    }
}