using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class CatsAndMouse
    {
        // The code for the HackerRank challenge Cats and Mouse
        // https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=true
        public static string catAndMouse(int x, int y, int z)
        {
            int resultCatA = 0;
            int resultCatB = 0;

            resultCatA = Math.Abs(x - z);
            resultCatB = Math.Abs(y - z);

            if (resultCatA > resultCatB)
            {
                return "Cat B";
            }
            else if (resultCatA < resultCatB)
            {
                return "Cat A";
            }

            return "Mouse C";

        }
    }
}
