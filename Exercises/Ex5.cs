using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex5
    {
        public static void Exercise5(string input)
        {
            char[] characters = input.ToArray();
            Array.Reverse(characters);
            string reversed = new string(characters);
            Console.WriteLine(input + " reversed is: " + reversed);
        }
    }
}
