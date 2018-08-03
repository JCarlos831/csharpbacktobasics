using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a width (must be a number).");
            var width = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter a height (must be a number).");
            var height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
                System.Console.WriteLine("The image is in landscape.");
            else if (width < height)
                System.Console.WriteLine("The image is in Portait.");
            else
                System.Console.WriteLine("The image is square.");
        }
    }
}
