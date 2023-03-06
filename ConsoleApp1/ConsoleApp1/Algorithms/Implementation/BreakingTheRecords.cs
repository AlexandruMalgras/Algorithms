using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class BreakingTheRecords
    {
        // The code for the HackerRank challenge Breaking The Records
        // https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true
        public static List<int> breakingRecords(List<int> scores)
        {
            int countMinBreakthroughs = 0;
            int countMaxBreakthroughs = 0;

            int currentMin = scores[0];
            int currentMax = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < currentMin)
                {
                    countMinBreakthroughs++;
                    currentMin = scores[i];
                }

                if (scores[i] > currentMax)
                {
                    countMaxBreakthroughs++;
                    currentMax = scores[i];
                }
            }

            return new List<int>() { currentMax, currentMin };
        }
    }
}
