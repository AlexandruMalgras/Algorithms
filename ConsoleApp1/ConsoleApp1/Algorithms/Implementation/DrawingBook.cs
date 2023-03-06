using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class DrawingBook
    {
        // The code for the HackerRank challenge Drawing Book
        // https://www.hackerrank.com/challenges/drawing-book/problem?isFullScreen=true
        public static int pageCount(int n, int p)
        {
            int count = 0;

            int countFromLeft = 0;
            int countFromRight = 0;

            bool isRandomPageEven = false;

            if (p % 2 == 0)
            {
                isRandomPageEven = true;
            }

            // Count from left side

            if (!(p == 1))
            {
                if (isRandomPageEven)
                {
                    countFromLeft = p / 2;
                }
                else
                {
                    countFromLeft = (p - 1) / 2;
                }
            }

            // Count from right side

            bool isLastPageEven = false;

            if (n % 2 == 0)
            {
                isLastPageEven = true;
            }

            if (!(p == n))
            {
                if (isLastPageEven)
                {
                    p = (n + 1) - p;

                    if (p % 2 == 0)
                    {
                        isRandomPageEven = true;
                    }

                    if (isRandomPageEven)
                    {
                        countFromRight = p / 2;
                    }
                    else
                    {
                        countFromRight = (p - 1) / 2;
                    }
                }
                else
                {
                    p = n - p;

                    if (p % 2 == 0)
                    {
                        isRandomPageEven = true;
                    }

                    if (!(p == 1))
                    {
                        if (isRandomPageEven)
                        {
                            countFromRight = p / 2;
                        }
                        else
                        {
                            countFromRight = (p - 1) / 2;
                        }
                    }
                }
            }

            if (countFromLeft >= countFromRight)
            {
                count = countFromRight;
            }
            else
            {
                count = countFromLeft;
            }

            return count;
        }
    }
}
