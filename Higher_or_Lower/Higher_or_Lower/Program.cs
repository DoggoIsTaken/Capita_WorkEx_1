using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higher_or_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomValue = random.Next(1, 100);

            int userInput = 0;

            bool flag = true;

            Console.WriteLine("Guess a number");
            //Console.WriteLine(randomValue); this code is just for testing purposes

            while (flag)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < randomValue)
                {
                    Console.WriteLine("Higher");
                    userInput += 1;
                }
                else if(guess > randomValue)
                {
                    Console.WriteLine("Lower");
                    userInput += 1;
                }
                else if(guess == randomValue)
                {
                    Console.WriteLine("You win");
                    flag = false;
                }

                if (userInput == 6)
                {
                    flag = false;
                    Console.WriteLine("You Lose");
                }
            }
            Console.ReadLine();
        }
    }
}
