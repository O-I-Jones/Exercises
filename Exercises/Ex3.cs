using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex3
    {
        public static void Exercise3(int input)
        {
            int total = (2 * input) - 1;
            int count = 1;
            string star = "*";

            for (int i = 0; i < input; i++)
            {
                int gap = (total - count) / 2;
                string gapstr = RepeatString(" ", gap);
                Console.WriteLine(gapstr + RepeatString(star, count));
                count += 2;
            }
        }

        static string RepeatString(string str, int reps)
        {
            if (reps == 0)
            {
                return string.Empty;
            }
            string repString = str;
            for (int i = 1; i < reps; i++)
            {
               repString += str;
            }
            return repString;
        }
    }
}
