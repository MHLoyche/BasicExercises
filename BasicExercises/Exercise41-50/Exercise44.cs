using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise44
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning ");

            string sen = Console.ReadLine();
            string result = "";

            for (int i = 0; i < sen.Length; i += 2)
            {
                result += sen[i].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
