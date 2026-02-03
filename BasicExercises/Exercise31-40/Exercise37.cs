using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise37
    {
        public static void Run()
        {
            string sen = "PHP is a good language for coding";

            Console.WriteLine(sen.Substring(1, 2).Equals("HP") ? sen.Remove(1,2) : sen);
        }
    }
}
