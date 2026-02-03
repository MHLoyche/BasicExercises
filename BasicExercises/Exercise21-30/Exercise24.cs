using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise24
    {
        public static void Run()
        {
            int wordLength = 0;
            string longestWord = "";

            Console.WriteLine("Skriv en sætning");
            string s = Console.ReadLine();

            string[] words = s.Split(" ");

            foreach (var word in words)
            {
                
                int wordL = word.Length;
                if (wordL > wordLength)
                {
                    wordLength = wordL;
                    longestWord = word;
                }
            }

            Console.WriteLine("Det længste ord er: " + longestWord + " med en længde af: " + wordLength + " bogstaver");
        }
    }
}
