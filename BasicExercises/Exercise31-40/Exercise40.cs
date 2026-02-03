using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise40
    {
        public static void Run()
        {
            Console.WriteLine("Indtast to numrer");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int target = 20;


            var dif1 = Math.Abs(target - num1);
            var dif2 = Math.Abs(target - num2);

            Console.WriteLine(dif1 == dif2 ? 0 : (dif1 < dif2 ? num1 : num2));
        }
    }
}
