using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise10
    {
        public static void Run()
        {
            Console.WriteLine("Please enter three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            formula(a, b, c);
        }

        private static void formula(int a, int b, int c)
        {
            double d = (a + b) * c;
            Console.WriteLine("The result of: (" + a + "+" + b + ")*" + c + " is: " + d);
            d = a * b + b * c;
            Console.WriteLine("The result of: " + a + "*" + b + "+" + b + "*" + c + " is: " + d);
        }
    }
}
