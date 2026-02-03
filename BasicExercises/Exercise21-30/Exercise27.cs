using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise27
    {
        public static void Run()
        {
            Console.WriteLine("Giv et nummer: ");

            int num = Convert.ToInt32(Console.ReadLine());

            DigitSum(num);


        }

        private static void DigitSum(int i)
        {
            int sum = 0;

            while(i != 0)
            {
                sum += i % 10;
                i /= 10;
            }

            Console.WriteLine("Summen af tallene i dit nummer er: " + sum);
        }
    }
}