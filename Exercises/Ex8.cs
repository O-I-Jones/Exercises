using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Ex8
    {
        public static Tuple<int, int> FindTwoSum(List<int> list, int target)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {;
                    if (list[i] + list[j] == target)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return null;
        }
    }
}
