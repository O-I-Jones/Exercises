using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex10
    {
        public static void Exercise10(int input)
        {
            int n = input;
            bool found = false;
            while (!found)
            {
                n += 1;
                found = IsPrime(n);
            }
            Console.WriteLine("Next prime from " + input + " is " + n);
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

//def nextPrime(n):
//    def isPrime(n):
//        if n < 2:
//            return False
//        for i in range(2, n):
//            if (n == 1) or(n % i == 0):
//                return False

//        return True
//    found = False
//    while not found:
//    n += 1
//        found = isPrime(n)
//    return n
