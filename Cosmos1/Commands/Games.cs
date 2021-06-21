using System;

namespace LyandOS.Commands
{
    class Games
    {
        public static Random rnd = new Random();
        public static void LetMeGuess()
        {
            char again = 'y';
            while (again == 'y')
            {
                Console.WriteLine("Hm? You want to play?");
                Console.WriteLine("OK.");

                int i = rnd.Next(100);

                Console.WriteLine("You need to guess my number.");

                if (i < 50)
                {
                    Console.WriteLine("My number is smaller than 50.");
                }
                else
                {
                    Console.WriteLine("My number is bigger or equals 50.");
                }

                int x = Convert.ToInt32(Console.ReadLine());

                if (i == x)
                {
                    Console.WriteLine("Congratulations! You won!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You lose! I guessed the number {0}", i);
                    Console.WriteLine("");
                }

                Console.WriteLine("Do you want to try again?(y/n)");

                again = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
            }
        }
    }
}
