using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class VowelConsonent
    {
        // Check Metthod will Identify the charecter either it's vowel or consonent
        public void Check()
        {
            Console.WriteLine("Enter the Character to Check as in Lower Case");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The given ch. is Vowel");
            }
            else
            {
                Console.WriteLine("The given ch. is Consonent");
            }
        }
    }
}