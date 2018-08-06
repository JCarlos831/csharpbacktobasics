using System;

namespace Exercise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            var userInput = Console.ReadLine();
            var number = Convert.ToInt32(userInput);
            int factorial = number;

            for (var i = number - 1; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(number + "! = {0}", factorial);
        }
    }
}
