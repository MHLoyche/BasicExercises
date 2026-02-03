using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise43
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning");

            string sen = Console.ReadLine();

            Console.WriteLine(sen.ToLower().StartsWith('w') && sen.ToLower().Substring(1,2) == "ww");
        }
    }
}
