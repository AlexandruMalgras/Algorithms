using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Search
{
    internal class MissingNumbers
    {
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            List<int> missing = new List<int>();

            for (int i = 0; i < brr.Count; i++)
            {
                if (arr.Contains(brr[i]))
                {
                    arr.Remove(brr[i]);
                }
                else
                {
                    missing.Add(brr[i]);
                }
            }

            missing.Sort();

            return missing;
        }
    }
}
