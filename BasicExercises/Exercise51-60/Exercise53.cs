using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise53
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool oddCheck = false;

            Console.WriteLine("Does the array contain an odd number?");

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    continue;
                }
                else
                {
                    oddCheck = true;
                    break;
                }
            }
            Console.WriteLine(oddCheck);
        }
    }
}
