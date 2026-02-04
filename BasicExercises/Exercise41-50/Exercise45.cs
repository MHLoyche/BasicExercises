using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise45
    {
        public static void Run()
        {
            Console.WriteLine("Indtast et nummer:");

            int num = Convert.ToInt32(Console.ReadLine());

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 3, };

            Console.WriteLine(numbers.Count(n => n == num));
        }
    }
}
