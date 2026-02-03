using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise32
    {
        public static void Run()
        {
            Console.WriteLine("Enter a sentence");

            string sen = Console.ReadLine();
            string placeholder;

            if (sen.Length > 4)
            {
                Console.WriteLine(sen.Length < 4 ? sen + sen + sen + sen: 
                    sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4) + sen.Substring(sen.Length - 4));
            }
            
        }
    }
}
