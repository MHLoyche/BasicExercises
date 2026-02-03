using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise21
    {
        public static void Run()
        {
            Console.WriteLine("Enter two integers: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is one of these numbers 20 or is the sum 20?");
            Console.WriteLine(i == 20 || j == 20 || i + j == 20);
        }
    }
}
