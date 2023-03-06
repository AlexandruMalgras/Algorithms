using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class MigratoryBirds
    {
        // The code for the HackerRank challenge Migratory Birds
        // https://www.hackerrank.com/challenges/migratory-birds/problem?isFullScreen=true
        public static int migratoryBirds(List<int> arr)
        {
            int count = 0;
            int type = 0;

            List<int> distinctBirds = arr.Distinct().ToList();

            foreach (int i in distinctBirds)
            {
                int countAtStart = count;
                count = 0;

                foreach (int y in arr)
                {
                    if (i == y)
                    {
                        count++;
                    }
                }

                if (count > countAtStart)
                {
                    type = i;
                }
            }

            return type;
        }
    }
}
