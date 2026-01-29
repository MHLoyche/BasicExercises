using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise09
    {
        public static void Run()
        {
            Console.WriteLine("Enter the first number: ");
            double o = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double avg = (o + p + q + r) / 4;
            Console.WriteLine("The average of these four numbers are: " + avg);
        }
    }
}
