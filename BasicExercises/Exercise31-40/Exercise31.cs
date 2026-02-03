using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise31_40
{
    internal class Exercise31
    {
        public static void Run()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            List<int> list = new List<int>();
            int placeholder = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                placeholder = array1[i] * array2[i];
                list.Add(placeholder);
            }

            foreach (int i in list) 
            {
                Console.Write(i + " ");
            }
        }
    }
}
