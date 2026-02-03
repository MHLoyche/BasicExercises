using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise18
    {
        public static void Run()
        {
            Console.WriteLine("Please enter two numbers: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            IntBoolCheck(i, j);

        }

        private static void IntBoolCheck(int i, int j)
        {
            Console.WriteLine("Is the number: " + i + " positive?");
            Console.WriteLine(i > 0);
            Console.WriteLine("Is the number: " + j + " positive?");
            Console.WriteLine(j > 0);
        }
    }
}
