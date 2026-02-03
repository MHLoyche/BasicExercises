using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise20
    {
        public static void Run()
        {
            Console.WriteLine("Please enter two integers to get the absolute difference.\n" +
                " If the first number entered is larger than the 2nd, the absolute value will double");

            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            if (i > j)
            {
                Console.WriteLine((i - j) * 2);
            }
            else if (j > i)
            {
                Console.WriteLine(j - i);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
