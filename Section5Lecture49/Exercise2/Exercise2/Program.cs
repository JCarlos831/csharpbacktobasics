using System;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 0;
            var exit = "ok";
            var input = "";

            while (true)
            {
                Console.WriteLine("Please enter a number or type [ok] to exit.");
                input = Console.ReadLine().ToLower();

                if (input == exit)
                    break;
                else
                {
                    int stringConverted = Convert.ToInt32(input);
                    number += stringConverted;
                }   
                Console.WriteLine(number);
            }
        }
    }
}
