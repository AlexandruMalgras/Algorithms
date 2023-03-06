using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class DivisibleSumPairs
    {
        // The code for the HackerRank challenge Divisible Sum Pairs
        // https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int x = i + 1; x < ar.Count; x++)
                {
                    int result = ar[i] + ar[x];

                    if (result % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
