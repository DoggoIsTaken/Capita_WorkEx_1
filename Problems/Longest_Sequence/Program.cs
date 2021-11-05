using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            int streak = 0;
            int largestStreak = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 0)
                {
                    streak = 0;
                }

                if (sequence[i] > 0)
                {
                    streak+= 1;
                    if (streak > largestStreak)
                    {
                        largestStreak = streak;
                    }
                }
            }

            Console.WriteLine(largestStreak);
            Console.ReadLine();
        }
    }
}
