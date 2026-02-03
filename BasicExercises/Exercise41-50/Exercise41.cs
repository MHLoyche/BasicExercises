using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise41
    {
        public static void Run()
        {
            string sen = "w3schools er en god hjemmeside til at lære at programmere";

            int count = sen.Count(c => c == 'w');

            Console.WriteLine(count <= 3 && count > 0);
        }
    }
}
