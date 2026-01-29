using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise12
    {
        public static void Run()
        {
            Console.WriteLine("Please give a full number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + a + " " + a + " " + a);
            Console.WriteLine(a + "" + a + "" + a + "" + a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);
            Console.WriteLine(a + "" + a + "" + a + "" + a);
        }
    }
}

