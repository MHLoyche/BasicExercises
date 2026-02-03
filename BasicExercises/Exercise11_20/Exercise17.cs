using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise17
    {
        public static void Run()
        {
            Console.WriteLine("Write a sentence: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.Length);

            while (true)
            {
                if (s.Length <= 2)
                {
                    Console.WriteLine("The sentence is too short");
                    s = Console.ReadLine();
                }
                else
                {
                    AddChars(s);
                    break;
                }
            }
        }

        private static void AddChars(string s)
        {
            string startLetter = s.Remove(1, s.Length - 1);

            Console.WriteLine(startLetter + s + startLetter);
        }
    }
}
