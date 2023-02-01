using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex6
    {
        public static void Exercise6(string input)
        {
            char[] characters = input.ToArray();
            char[] reverseChars = characters; 
            Array.Reverse(reverseChars);
            string reversed = new string(reverseChars);
            if (input == reversed)
            {
                Console.WriteLine("\"" + input + "\" is a palindrome");
            }
            else
            {
                Console.WriteLine("\"" + input + "\" is not a palindrome");
            }
        }
    }
}
