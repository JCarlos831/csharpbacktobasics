using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var demeritPoints = 0;

            Console.WriteLine("Please enter the speed limit.");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the car's speed.");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("OK");
            else if (carSpeed > speedLimit)
            {
                var amountOverSpeedLimit = carSpeed - speedLimit;

                demeritPoints = amountOverSpeedLimit / 5;
                Console.WriteLine(string.Format("{0} demerit points were incurred.", demeritPoints));

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended!!!");
            }

        }
    }
}