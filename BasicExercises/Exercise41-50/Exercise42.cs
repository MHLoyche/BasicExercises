using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise41_50
{
    internal class Exercise42
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning");

            string sen = Console.ReadLine();

            Console.WriteLine(sen.Length <= 4 ? sen.ToUpper() : sen.Substring(0, 4).ToLower() + sen.Substring(4, sen.Length-4).ToUpper());
        }
    }
}
