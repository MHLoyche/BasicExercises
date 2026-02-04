using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise52
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };
            int[] numbers3 = { 3, 9, 2 };

            int[] newNumbers = { numbers[1], numbers2[1], numbers[1] };

            Console.WriteLine("New array is: [{0}]", string.Join(", ", newNumbers));           
        }
    }
}
