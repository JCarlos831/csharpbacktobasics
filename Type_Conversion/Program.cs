using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte b = 1;
            // int i = b;
            // System.Console.WriteLine(i);

            // int i = 1000;
            // byte b = (byte)i;
            // System.Console.WriteLine(b);

            // try
            // {
            //     var number = "1234";
            //     byte b = Convert.ToByte(number);
            //     System.Console.WriteLine(b);
            // }
            // catch (System.Exception)
            // {
                
            //     System.Console.WriteLine("The number could not be converted to a byte.");
            // }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("The string could not be converted.");
            }


        }
    }
}
