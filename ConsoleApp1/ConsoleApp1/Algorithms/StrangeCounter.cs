using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    static class StrangeCounter
    {
        public static long strangeCounter(long t)
        {
            long left = 1;
            long right = 3;

            while (left + right <= t)
            {
                left = left + right;
                right *= 2;
            }

            long decrease = t - left;
            long result = right - decrease;

            return result;
        }
    }
}
