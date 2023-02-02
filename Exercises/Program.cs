using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runing Exercise 1...");
            Ex1.Exercise1("1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0");

            Console.WriteLine("\nRuning Exercise 2...");
            Ex2.Exercise2("parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray");

            Console.WriteLine("\nRuning Exercise 3...");
            Ex3.Exercise3(5);

            Console.WriteLine("\nRuning Exercise 4...");
            Ex4.Exercise4(5);

            Console.WriteLine("\nRuning Exercise 5...");
            Ex5.Exercise5("hello world");

            Console.WriteLine("\nRuning Exercise 6...");
            Ex6.Exercise6("madam");
            Ex6.Exercise6("step on no pets");
            Ex6.Exercise6("book");

            Console.WriteLine("\nRuning Exercise 7...");
            Ex7.Exercise7(12);
            Ex7.Exercise7(123);
            Ex7.Exercise7(5000);

            Console.WriteLine("\nRuning Exercise 8...");
            Tuple<int, int> indices = Ex8.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            Console.WriteLine("Found target sum at indices " + indices.Item1 + " and " + indices.Item2);

            Console.WriteLine("\nRuning Exercise 9...");
            Ex9.Exercise9(3);
            Ex9.Exercise9(5);

            Console.WriteLine("\nRuning Exercise 10...");
            Ex10.Exercise10(6);
            Ex10.Exercise10(11);
            Ex10.Exercise10(15);

        }
    }
}
