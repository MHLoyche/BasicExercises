using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise35
    {
        public static void Run()
        {
            Console.WriteLine("Indtast 2 numrer");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 < 100 && num2 > 200);
        }
    }
}
