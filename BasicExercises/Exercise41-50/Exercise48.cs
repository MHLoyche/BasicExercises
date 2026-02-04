using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise48
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, };

            Console.WriteLine("The array contains the following: { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, }");

            Console.WriteLine("Is the first and last index of the array equal? ");

            Console.WriteLine(numbers[0] == numbers[numbers.Length-1]);
        }
    }
}
