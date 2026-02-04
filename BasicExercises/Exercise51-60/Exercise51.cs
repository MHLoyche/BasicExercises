using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise51
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers[0] > numbers[numbers.Length-1] ? numbers[0] : numbers[numbers.Length-1]);
        }
    }
}
