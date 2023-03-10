using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Sorting
{
    internal class FindTheMedian
    {
        public static int findMedian(List<int> arr)
        {
            int middle = (int)Math.Ceiling(arr.Count / 2.0);

            arr.Sort();

            return arr[middle - 1];
        }
    }
}
