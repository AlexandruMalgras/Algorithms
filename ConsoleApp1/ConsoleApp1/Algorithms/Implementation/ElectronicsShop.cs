using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class ElectronicsShop
    {
        // The code for the HackerRank challenge ElectronicsShop
        // https://www.hackerrank.com/challenges/electronics-shop/problem?isFullScreen=true
        public static int getMoneySpent(int[] keyboards, int[] drives, int budget)
        {

            int priceCombined = 0;

            List<int> possibleResults = new List<int>();

            foreach (int i in keyboards)
            {
                foreach (int x in drives)
                {
                    priceCombined = i + x;

                    if (priceCombined <= budget)
                    {
                        possibleResults.Add(priceCombined);
                    }
                }
            }

            if (possibleResults.Count > 0)
            {
                return possibleResults.Max();
            }

            return -1;
        }
    }
}
