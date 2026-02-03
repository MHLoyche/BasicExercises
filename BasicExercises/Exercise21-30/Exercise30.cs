using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise30
    {
        public static void Run()
        {
            string hexValue = "4B0";
            int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("The hexdecimal is: " + hexValue);
            Console.WriteLine("The decimal value of the hex is: " + decValue);

            Console.WriteLine("Try to write another: ");
            hexValue = Console.ReadLine();

            decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("The decimal number of your hex is: " + decValue);
        }
    }
}
