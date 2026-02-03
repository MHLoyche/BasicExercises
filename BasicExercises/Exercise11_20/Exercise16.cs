using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise16
    {
        public static void Run()
        {
            Console.WriteLine("Skriv et ord: ");
            string s = Console.ReadLine();
            Swap(s);


        }

        private static void Swap(string s)
        {
            string start = s.Remove(1, s.Length - 1);
            string end = s.Remove(0, s.Length - 1);
            string mid = s.Remove(0, 1);
            mid = mid.Remove(s.Length - 2, 1); ;
            Console.WriteLine("start: " + start);
            Console.WriteLine("mid: " + mid);
            Console.WriteLine("end: " + end);
            s = end + mid + start;
            Console.WriteLine(s);
        }
    }
}
