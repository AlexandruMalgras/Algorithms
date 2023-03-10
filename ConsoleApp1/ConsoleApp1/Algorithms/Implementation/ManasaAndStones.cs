using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    internal class ManasaAndStones
    {
        public static List<int> stones(int n, int a, int b)
        {
            List<int> permutations = new List<int>();

            for (int i = 0; i < n; i++) 
            {
                permutations.Add(a * i + b * (n - 1 - i));
            }

            permutations = permutations.Distinct().ToList();
            permutations.Sort();

            return permutations;
        }
    }
}
