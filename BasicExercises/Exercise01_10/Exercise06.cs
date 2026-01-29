using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise06
    {
        public static void Run()
        {
            Console.WriteLine("Please ender 3 numbers");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The multiplication of all three numbers are: " + c * d * e);
        }
    }
}
