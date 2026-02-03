using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise34
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning");

            string sen = Console.ReadLine();

            string[] words = sen.Split(" ");

            Console.WriteLine(words[0] == "Hello");
        }
    }
}
