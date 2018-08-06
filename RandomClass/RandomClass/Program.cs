using System;
using Passwords;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator p = new PasswordGenerator();
            p.RandomPasswordGenerator(20);
        }
    }
}
