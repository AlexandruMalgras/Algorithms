using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class SalesByMatch
    {
        // The code for the HackerRank challenge Sales by Match
        // https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true
        public static int sockMerchant(int n, List<int> ar)
        {
            HashSet<int> distinctNumbers = new HashSet<int>(ar);

            int count = 0;
            int result = 0;

            foreach (int x in distinctNumbers)
            {
                count = 0;

                foreach (int y in ar)
                {
                    if (x == y)
                    {
                        count++;
                    }
                }

                if (count % 2 == 0)
                {
                    result += count / 2;
                }
                else
                {
                    count -= 1;
                    result += count / 2;
                }
            }

            return result;
        }
    }
}
