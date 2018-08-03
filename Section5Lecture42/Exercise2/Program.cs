using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number.");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter a second number.");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
                System.Console.WriteLine(string.Format("{0} is the max number", firstNumber));
            else if (firstNumber < secondNumber)
                System.Console.WriteLine(string.Format("{0} is the max number", secondNumber));
            else
                System.Console.WriteLine("The numbers are equal.");
        }
    }
}
