using System;

namespace Exercise4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            var winningNumber = random.Next(1, 10);
            var guesses = 4;

            while (guesses > 0)
            {
                Console.WriteLine("Please guess a number between 1 and 10.");
                var userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < 1 || userGuess > 10)
                {
                    Console.WriteLine("Number must be between 1 and 10");
                    continue;
                }

                if (userGuess == winningNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (userGuess != winningNumber)
                {
                    guesses--;
                    Console.WriteLine("You have {0} guesses remaining", guesses);

                    if (guesses == 0)
                        Console.WriteLine("You lost.");
                    else
                        continue;
                }
            }

        }
    }
}
