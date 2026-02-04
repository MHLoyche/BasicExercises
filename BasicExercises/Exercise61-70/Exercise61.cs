using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise61_70
{
    internal class Exercise61
    {
        public static void Run()
        {
            int[] numbers = { 3, 9, 3, -5, 6, 2, 8, -5 };

            Console.WriteLine("Originale array: " + string.Join(", ", numbers));

            SortArray(numbers);

            Console.WriteLine("Sorteret array: " + string.Join(", ", numbers));


        }

        private static void SortArray(int[] arr)
        {
            List<int> values = arr.Where(x => x != -5).ToList();
            
            values.Sort();
         
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -5)
                {
                    arr[i] = values[index];
                    index++;
                }
            }
        }
    }
}
