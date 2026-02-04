using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise47
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, };
            int sum = 0;

            Console.WriteLine("The array contains the following: { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, }");

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("The sum of the array is: " + sum);

        }
    }
}
