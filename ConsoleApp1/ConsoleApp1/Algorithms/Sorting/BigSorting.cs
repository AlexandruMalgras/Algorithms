using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Sorting
{
    internal class BigSorting
    {
        public static List<string> bigSorting(List<string> unsorted)
        {   
            unsorted.Sort((a, b) =>
            {
                int result = a.Length.CompareTo(b.Length);

                if (result == 0)
                {
                    result = a.CompareTo(b);
                }

                return result;
            });

            return unsorted;
        }
    }
}
