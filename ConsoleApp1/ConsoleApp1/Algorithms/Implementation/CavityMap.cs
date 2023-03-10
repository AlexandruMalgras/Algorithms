using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class CavityMap
    {
        public static List<string> cavityMap(List<string> grid)
        {
             List<string> temporary = new List<string>();

            temporary.Add(grid[0]);

            int value = 0;

            int leftValue = 0;
            int rightValue = 0;
            int topValue = 0;
            int bottomValue = 0;

            for (int i = 1; i< grid.Count - 1; i++) 
            {
                temporary.Add(grid[i]);

                for (int j = 1; j < grid[i].Length - 1; j++)
                { 
                    value = int.Parse(grid[i][j].ToString());

                    leftValue = int.Parse(grid[i][j - 1].ToString());
                    rightValue = int.Parse(grid[i][j + 1].ToString());
                    topValue = int.Parse(grid[i - 1][j].ToString());
                    bottomValue = int.Parse(grid[i + 1][j].ToString());

                    if (value > leftValue && value > rightValue && value > topValue && value > bottomValue)
                    {
                        temporary[i] = temporary[i].Substring(0, j) + "X" + temporary[i].Substring(j + 1);
                    }
                }
            }

            if (grid.Count > 1)
            {
                temporary.Add(grid[grid.Count - 1]);
            }

            return temporary;
        }
    }
}
