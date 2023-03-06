using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class FormingAMagicSquare
    {
        // The code for the HackerRank challenge Forming a Magic Square
        // https://www.hackerrank.com/challenges/magic-square-forming/problem?isFullScreen=true
        public static int formingMagicSquare(List<List<int>> s)
        {
            int cost = int.MaxValue;

            int[][][] magicSquares = new[] {
            new[] {
                new[] {8, 1, 6},
                new[] {3, 5, 7},
                new[] {4, 9, 2}
            },
            new[] {
                new[] {6, 1, 8},
                new[] {7, 5, 3},
                new[] {2, 9, 4}
            },
            new[] {
                new[] {4, 9, 2},
                new[] {3, 5, 7},
                new[] {8, 1, 6}
            },
            new[] {
                new[] {2, 9, 4},
                new[] {7, 5, 3},
                new[] {6, 1, 8}
            },
            new[] {
                new[] {8, 3, 4},
                new[] {1, 5, 9},
                new[] {6, 7, 2}
            },
            new[] {
                new[] {4, 3, 8},
                new[] {9, 5, 1},
                new[] {2, 7, 6}
            },
            new[] {
                new[] {6, 7, 2},
                new[] {1, 5, 9},
                new[] {8, 3, 4}
            },
            new[] {
                new[] {2, 7, 6},
                new[] {9, 5, 1},
                new[] {4, 3, 8}
            }
        };

            int currentCost = 0;

            for (int i = 0; i < magicSquares.Length; i++)
            {
                currentCost = 0;

                for (int j = 0; j < magicSquares[i].Length; j++)
                {
                    for (int x = 0; x < magicSquares[i][j].Length; x++)
                    {
                        currentCost += Math.Abs(magicSquares[i][j][x] - s[j][x]);
                    }
                }

                if (currentCost < cost)
                {
                    cost = currentCost;
                }
            }

            return cost;
        }

    }
}
