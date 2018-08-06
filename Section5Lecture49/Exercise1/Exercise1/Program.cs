using System;

namespace Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers between 1 andd 100 that are divisible by three.", count);
        }
    }
}
