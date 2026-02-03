using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise23
    {
        public static void Run()
        {
            Console.WriteLine("Skriv en sætning for at få den lavet til lowercase");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToLower());
        }
    }
}
