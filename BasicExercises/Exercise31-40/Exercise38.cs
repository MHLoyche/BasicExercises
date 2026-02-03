using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise38
    {
        public static void Run()
        {
            string sen = "PHP er et godt programmeringssprog";

            if (sen.StartsWith("PH"))
            {
                Console.WriteLine(sen.Substring(0, 2));
            }
        }
    }
}
