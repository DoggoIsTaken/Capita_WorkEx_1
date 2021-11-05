using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "star" };
            string b = "star"; // bad daa a1b2c3 abc123

            string aa = String.Concat(a.OrderBy(c => c));
            string bb = String.Concat(b.OrderBy(c => c));

            if (aa == bb)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
