using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex2
    {
        public static void Exercise2(string input)
        {
            
            string[] dict = input.Split(',');
            string keyword = "star";
            string keywordOrdered = SortString(keyword);
            List<string> anagrams = new List<string>();

            for (int i = 0; i < dict.Length; i++)
            {
                if (SortString(dict[i]) == keywordOrdered)
                {
                    anagrams.Add(dict[i]);
                }
            }

            string final = anagrams[0];
            for (int i = 1; i < anagrams.Count; i++)
            {
                final = final + ", " +anagrams[i];
            }
            Console.WriteLine("Words that are anagrams for " + keyword + ": " + final);

        }

        static string SortString(string str)
        {
            char[] characters = str.ToArray();
            Array.Sort(characters);
            string ordered = new string(characters);
            return ordered;
        }
    }
}
