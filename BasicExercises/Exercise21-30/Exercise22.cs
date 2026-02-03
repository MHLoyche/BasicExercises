using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise22
    {
        public static void Run()
        {
            Console.WriteLine("Indskriv en integer: ");
            int i = Convert.ToInt32(Console.ReadLine());

            bool closeTo100 = Math.Abs(i - 100) <= 20;
            bool closeTo200 = Math.Abs(i - 200) <= 20;

            Console.WriteLine(closeTo100 || closeTo200);
        }
    }
}
