using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class BillDivision
    {
        // The code for the HackerRank challenge Bill Division
        // https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int billCost = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                {
                    continue;
                }
                else
                {
                    billCost += bill[i];
                }
            }

            billCost /= 2;

            int amountOvercharged = b - billCost;

            if (billCost == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(amountOvercharged.ToString());
            }
        }
    }
}
