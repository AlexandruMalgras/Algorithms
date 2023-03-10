using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Sorting
{
    internal class InsertionSortPartTwo
    {
        public static void insertionSort2(int n, List<int> arr)
        {
            int current = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                current = arr[i];

                for (int j = 0; j < i; j++)
                {
                    if (current < arr[j])
                    {
                        for (int x = i; x > j; x--)
                        {
                            arr[x] = arr[x - 1];
                        }

                        arr[j] = current;
                        break;
                    }
                }

                string result = "";

                foreach (int j in arr)
                {
                    result += j.ToString() + " ";
                }

                Console.WriteLine(result);
            }
        }
    }
}
