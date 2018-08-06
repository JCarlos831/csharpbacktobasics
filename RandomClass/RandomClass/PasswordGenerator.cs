using System;
namespace Passwords
{
    public class PasswordGenerator
    {
        public void RandomPasswordGenerator(int passwordLength)
        {
            var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10));
            //}
            for (int i = 1; i <= passwordLength; i++)
            {
                var pass = new char[passwordLength + 1];
                pass[i] = (char)('a' + random.Next(0, 26));
                Console.Write(pass);
            }
        }
    }
}
