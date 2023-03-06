using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class SubarrayDivision
    {
        // The code for the HackerRank challenge Subarray Division
        // https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true
        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            int result = 0;
            List<int> division = new List<int>();

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                division = s.Skip(i).Take(m).ToList();

                result = 0;

                if (division.Count == m)
                {
                    foreach (int z in division)
                    {
                        result += z;
                    }
                }

                if (result == d)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
