using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise11_20
{
    internal class Exercise15
    {
        public static void Run()
        {
            string title = "Mat er en god programmør";
            Console.WriteLine("Enter a a number between 1 and " + title.Length);
            int index = Convert.ToInt32(Console.ReadLine());
            RemoveIndex(index, title);
        }
           
        static void RemoveIndex(int index, string title)
        {
            title = title.Remove(index-1,1);
            Console.WriteLine(title);
        }
    }
}
