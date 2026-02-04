using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise54
    {
        public static void Run()
        {
            Console.WriteLine("The year 1991 is in the " + centuryCalc(1991) + "th century: ");
            Console.WriteLine("The year 2000 is in the " + centuryCalc(2000) + "th century: ");
            Console.WriteLine("The year 1840 is in the " + centuryCalc(1840) + "th century: ");
            Console.WriteLine("The year 1550 is in the " + centuryCalc(1550) + "th century: ");
            Console.WriteLine("The year 920 is in the " + centuryCalc(920) + "th century: ");
        }

        public static int centuryCalc(int year)
        {
            return (year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
