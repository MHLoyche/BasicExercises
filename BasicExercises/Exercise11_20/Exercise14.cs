using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise14
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number of celsius: ");
            int cel = Convert.ToInt32(Console.ReadLine());
            CelToKel(cel);
            CelToFar(cel);

        }

        static void CelToKel(int cel)
        {
            double kelvin = Convert.ToDouble(cel) + 273.15;
            Console.WriteLine(cel + " celsius is " + kelvin + " kelvin");
        }

        static void CelToFar(int cel)
        {
            double far = Convert.ToDouble(cel) * 1.8 + 32;
            Console.WriteLine(cel + " celsius is " + far + " fahrenheit");
        }
    }
}
