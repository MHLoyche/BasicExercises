using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise08
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a number to print it's multiplication table: ");
            multiTable(Convert.ToInt32(Console.ReadLine()));
        }

        private static void multiTable(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + " * " + i + " is: " + a * i);
            }
        }
    }
}
