using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise05
    {
        public static void Run()
        {
            int a = 5;
            int b = 15;

            swapNumbers(a, b);
        }

        static void swapNumbers(int a, int b)
        {
            Console.WriteLine("The received numbers are: a=" + a + " and b=" + b);
            int placeholder;
            placeholder = a;
            a = b;
            b = placeholder;

            Console.WriteLine("After swap the new numbers are: a=" + a + " and b=" + b + "\n");
        }
    }
}
