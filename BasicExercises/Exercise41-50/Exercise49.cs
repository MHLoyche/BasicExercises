using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise49
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, 9, 2, 4 };

            Console.WriteLine("The two arrays contain the following numbers:\n" +
                "{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, } and \n" +
                "{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, 9, 2, 4 }\n" +
                "Is the first index equal?");

            Console.WriteLine(numbers[0] == numbers2[0]);

            Console.WriteLine("Is the last index equal?");

            Console.WriteLine(numbers[numbers.Length-1] == numbers2[numbers2.Length-1]);


        }
    }
}
