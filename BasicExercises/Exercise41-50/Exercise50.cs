using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise50
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3 };
            int placeholder = numbers[0];

            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[numbers.Length-1] = placeholder;

            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", numbers));
        }
    }
}
