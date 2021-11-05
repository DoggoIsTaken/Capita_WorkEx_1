using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int l;

            Console.WriteLine("Input a string");
            str = Console.ReadLine();

            l = str.Length - 1;

            for (int i = l; i>=0; i--)
            {
                str1 = str1 + str[i];
            }

            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
            Console.ReadLine();
        }
    }
}
