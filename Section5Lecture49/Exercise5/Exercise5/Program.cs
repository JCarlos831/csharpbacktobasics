using System;

namespace Exercise5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of numbers separated by comma.");
            var numbersEntered = Console.ReadLine();
            var split = numbersEntered.Split(',');
            var maxNumber = 0;

            for (var i = 0; i < split.Length; i++)
            {
                var newNumber = Convert.ToInt32(split[i]);

                if (newNumber > maxNumber)
                {
                    maxNumber = newNumber;
                }
            }

            Console.WriteLine("The max number is {0}", maxNumber);
        }
    }
}
