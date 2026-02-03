using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise28
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning");

            string sen = Console.ReadLine();
            int senLength = sen.Length;

            string[] words = sen.Split(" ");

            Array.Reverse(words);

            string reversedSen = string.Join(" ", words);

            Console.WriteLine(reversedSen);
        }
    }
}
