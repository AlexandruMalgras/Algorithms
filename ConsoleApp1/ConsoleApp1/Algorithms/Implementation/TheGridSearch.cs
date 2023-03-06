using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class TheGridSearch
    {
        public static string gridSearch(List<string> G, List<string> P)
        {
            List<int> indexes = new List<int>();

            int indexCap = 0;
            int index = -1;
            int count = 0;
            string substring = "";

            for (int i = 0; i < G.Count; i++)
            {
                if (G[i].Contains(P[0]))
                {
                    indexCap = G[i].Length - P[0].Length + 1;

                    for (int j = 0; j < indexCap; j++)
                    {
                        index = G[i].IndexOf(P[0], j);

                        if (index != -1)
                        {
                            j = index;
                            indexes.Add(index);
                        }
                        else
                        {
                            break;
                        }
                    }

                    foreach (int j in indexes)
                    {
                        count = 1;

                        for (int x = i + 1; x < G.Count; x++)
                        {
                            if (count == P.Count)
                            {
                                break;
                            }

                            substring = G[x].Substring(j, P[count].Length);

                            if (substring != P[count])
                            {
                                break;
                            }

                            count++;
                        }

                        if (count == P.Count)
                        {
                            return "YES";
                        }
                    }
                }
            }

            return "NO";
        }
    }
}
