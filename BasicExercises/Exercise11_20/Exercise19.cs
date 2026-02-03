using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise19
    {
        public static void Run()
        {
            Console.WriteLine("Enter two integers to return the sum, if they are identical, it will triple the sum");

            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            if (i == j)
            {
                Console.WriteLine((i + j) * 3);
            } else
            {
                Console.WriteLine(i + j);
            }
        }
    }
}
