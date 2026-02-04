using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise55
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 4, 6, 3, 7, 10, 1, 12 };
            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] + numbers[i] > sum)
                {
                    sum = numbers[i-1] + numbers[i];
                }
            }

            Console.WriteLine("the sum of the highest adjacent pair is: " + sum);
        }
    }
}
