using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex7
    {
        public static void Exercise7(int input)
        {
            string str = input.ToString();
            char[] characters = str.ToArray();
            int total = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                string c = characters[i].ToString();
                total += Int32.Parse(c);
            }
            Console.WriteLine("The total of the digits of " + str+ " is " + total);
        }
    }
}
