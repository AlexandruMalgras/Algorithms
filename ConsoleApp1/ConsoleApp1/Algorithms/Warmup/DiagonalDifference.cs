using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Warmup
{
    static class DiagonalDifference
    {
        // The code for the HackerRank challenge Diagonal Difference
        // https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true
        public static int diagonalDifference(List<List<int>> arr)
        {
            int first = 0;
            int second = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                List<int> row = arr[i];

                first += row[i];
            }

            for (int i = 0; i < arr.Count; i++)
            {
                List<int> row = arr[i];

                second += row[arr.Count - 1 - i];
            }

            return Math.Abs(first - second);
        }
    }
}
