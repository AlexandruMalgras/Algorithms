using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class FairRations
    {
        public static string fairRations(List<int> B)
        {
            int count = 0;

            for (int i = 0; i < B.Count; i++)
            {
                if (B[i] % 2 == 0)
                {
                    continue;
                }

                if (i < B.Count - 1)
                {
                    B[i]++;
                    B[i + 1]++;
                    count += 2;
                }

                if (i == B.Count - 1 && (B[i] % 2 != 0 || B[i - 1] % 2 != 0)) 
                {
                    return "NO";
                }
            }

            return count.ToString();
        }
    }
}
