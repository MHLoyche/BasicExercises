using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise33
    {
        public static void Run()
        {
            Console.WriteLine("Skriv et positivt nummer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Er dit nummer en mulig multiplikation af 3 eller 7?");
            Console.WriteLine(num % 3 == 0 || num % 7 == 0);
        }
    }
}
