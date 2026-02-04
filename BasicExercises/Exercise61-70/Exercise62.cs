using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises.Exercise61_70
{
    internal class Exercise62
    {
        public static void Run()
        {
            string input = "Hej(gid(med))boi";

            Console.WriteLine("Original: " + input);
            Console.WriteLine("Resultat:   " + ReverseInParentheses(input));
        }

        private static string ReverseInParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(')
                {
                    stack.Push(i);
                }
                else if (chars[i] == ')')
                {
                    int start = stack.Pop();
                    int end = i;
                    Array.Reverse(chars, start + 1, end - start - 1);
                }
            }

            string result = "";

            foreach (char c in chars)
            {
                if (c != '(' && c != ')')
                    result += c;
            }

            return result;
        }
    }
}
