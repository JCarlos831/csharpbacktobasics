using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            var numberEntered = Convert.ToInt32(Console.ReadLine());

            var result = (numberEntered > 0 && numberEntered <= 10) ? "Valid" : "Invalid";
            System.Console.WriteLine(result);
        }
    }
}
