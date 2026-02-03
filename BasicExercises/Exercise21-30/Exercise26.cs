using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise26
    {
        public static void Run()
        {
            int sum = 0;
            int counter = 0;
            int factors = 0;


            for (int i = 1; counter < 500; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    if (i % j == 0)
                    {
                        factors++;
                    }
                }
                if (factors == 2) {
                    sum += i;
                    Console.WriteLine(i);
                    counter++;
                }
                factors = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
