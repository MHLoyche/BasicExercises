using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise51_60
{
    internal class Exercise58
    {
        public static void Run()
        {
            List<int> numberList1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> numberList2 = new List<int>() { 4, 3, 2, 6, 8 };
            List<int> numberList3 = new List<int>() { 2, 1, 2, 5, 4 };

            missingInts(numberList1);
            missingInts(numberList2);
            missingInts(numberList3);
        }

        private static void missingInts(List<int> numbers)
        {
            Console.WriteLine("This list containts " + string.Join(", ", numbers));

            Console.WriteLine("The missing numbers are: ");

            for (int i = 1; i <= 9; i++)
            {
                if (!numbers.Contains(i))
                {
                    Console.WriteLine(i + " ");
                }
            }

            Console.WriteLine("\n");
        }
    }
}
