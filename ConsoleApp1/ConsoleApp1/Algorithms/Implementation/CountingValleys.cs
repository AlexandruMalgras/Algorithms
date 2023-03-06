using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class CountingValleys
    {
        // The code for the HackerRank challenge Counting Valleys
        // https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true
        public static int countingValleys(int steps, string path)
        {
            int level = 0;
            int valleys = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'D')
                {
                    level--;

                    if (level == -1)
                    {
                        valleys++;
                    }
                }
                else
                {
                    level++;
                }
            }

            return valleys;
        }
    }
}
