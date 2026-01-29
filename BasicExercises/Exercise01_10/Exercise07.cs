using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise01_10
{
    internal class Exercise07
    {
        public static void Run()
        {
            Console.WriteLine("Please enter 2 numbers for arithmetic operations. ");
            Console.WriteLine("First enter the first number as a full number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

            while (b == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Please enter a number that is not 0 for the second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }

            arithmeticOperation(a, b);
        }

        private static void arithmeticOperation(int a, int b)
        {
            double v = a;

            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            double div = v / b;
            int mod = a % b;

            Console.WriteLine("The addition of " + a + " and " + b + " is: " + add);
            Console.WriteLine("The subtraction of " + a + " and " + b + " is: " + sub);
            Console.WriteLine("The multiplication of " + a + " and " + b + " is: " + mul);
            Console.WriteLine("The division of " + a + " and " + b + " is: " + div);
            Console.WriteLine("The modulo of " + a + " and " + b + " is: " + mod);
        }
    }
}
