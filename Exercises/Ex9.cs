using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex9
    {
        public static void Exercise9(int index)
        {
            List<int> list = GetPrimes(index);
            Console.WriteLine("The prime at position " + index + " is " + list.Last());
        }

        static List<int> GetPrimes(int input)
        {
            List<int> result = new List<int>();
            result.Add(2);
            int c = 3;

            while (result.Count < input)
            {
                if (IsPrime(c))
                {
                    result.Add(c);
                }
                c += 2;
            }


            return result;
        }

        static bool IsPrime(int input)
        {
            if (input < 2)
            {
                return false;
            }
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
