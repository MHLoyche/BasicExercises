using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise39
    {
        public static void Run()
        {
            Console.WriteLine("Indtast 3 numrer");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The largest number is: " + Math.Max(num1, Math.Max(num2, num3)));
            Console.WriteLine("The smallets number is: " + Math.Min(num1, Math.Min(num2, num3)));
        }
    }
}
