using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise21_30
{
    internal class Exercise29
    {

        public static void Run()
        {
            long fileLen = new FileInfo("../../../TestDoc.txt").Length;

            Console.WriteLine(fileLen);
        }
    }
}
