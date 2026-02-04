using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise56
    {
        public static void Run()
        {
            Console.WriteLine("skriv en sætning");

            string sen = Console.ReadLine();

            char[] c = sen.ToCharArray();

            Array.Reverse(c);

            Console.WriteLine(new string(c).Equals(sen));
        }
    }
}
