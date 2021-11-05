using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_at_Nth_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
            67, 71, 73, 79, 83, 89, 97 };

            Console.WriteLine("Input a number");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(prime[input-1]);
            Console.ReadLine();
        }
    }
}
