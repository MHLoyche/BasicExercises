using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise60
    {
        public static void Run()
        {
            int[,] numbers = { { 1, 2, 3, 0, 5 }, { 1, 0, 6, 3, 2 }, { 2, 1, 6, 3, 0 } };
            int sum = 0;

            foreach (int i in numbers)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
