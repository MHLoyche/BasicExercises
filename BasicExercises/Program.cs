using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter exercise name (Example: Exercise01):");
            string input = Console.ReadLine();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == input);

            if (type == null)
            {
                Console.WriteLine("Exercise not found.");
                return;
            }

            var method = type.GetMethod("Run");

            if (method == null)
            {
                Console.WriteLine("No Run() method found.");
                return;
            }

            method.Invoke(null, null);
        }
    }
}
