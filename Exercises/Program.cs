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

            Console.WriteLine("Runing Exercise 2...");
            Ex2.Exercise2("parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray");

            Console.WriteLine("Runing Exercise 3...");
            Ex3.Exercise3(5);

            Console.WriteLine("Runing Exercise 4...");
            Ex4.Exercise4(5);

            Console.WriteLine("Runing Exercise 5...");
            Ex5.Exercise5("hello world");

        }
    }
}
