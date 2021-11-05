using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int l;

            Console.WriteLine("Input a string");
            str = Console.ReadLine();
            string lowerCase = str.ToLower();
           
            l = lowerCase.Length - 1;

            for (int i = l; i >= 0; i--)
            {
                str1 = str1 + lowerCase[i];
            }

            if (str1 == lowerCase)
            {
                Console.WriteLine("Is a Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.ReadLine();

            
        }
    }
}
