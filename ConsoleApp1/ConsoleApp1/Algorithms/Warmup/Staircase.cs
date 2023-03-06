using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Warmup
{
    static class Staircase
    {
        // The code for the HackerRank challenge Staircase
        // https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true
        public static void staircase(int n)
        {
            int spaces = n - 1;
            int sharp = 1;

            string result = "";

            for (int i = 0; i < n; i++)
            {
                result = "";

                for (int x = 0; x < spaces; x++)
                {
                    result += " ";
                }

                for (int y = 0; y < sharp; y++)
                {
                    result += "#";
                }

                spaces--;
                sharp++;

                Console.WriteLine(result);
            }
        }
    }
}
