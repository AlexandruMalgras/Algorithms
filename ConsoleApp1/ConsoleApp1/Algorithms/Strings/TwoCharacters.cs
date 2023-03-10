using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Strings
{
    internal class TwoCharacters
    {
        public static int alternate(string s)
        {
            List<char> duplicate = s.Where((a, b) => b < s.Length - 1 && s[b + 1] == a).ToList();

            foreach (char c in duplicate)
            {
                s = s.Replace(c.ToString(), "");
            }

            int count = 0;
            int result = 0;

            duplicate = s.Distinct().ToList();

            for (int i = 0; i < duplicate.Count - 1; i++)
            {
                for (int j = i + 1; j < duplicate.Count; j++)
                {
                    char first = duplicate[i];
                    char second = duplicate[j];

                    List<char> toCheck = s.Where(a => a == first || a == second).ToList();
                    
                    if (toCheck.Where((a, b) => b < toCheck.Count - 1 && toCheck[b + 1] == a).ToList().Count > 0)
                    {
                        continue;
                    }

                    count = 0;

                    count += s.Count(a => a == first || a == second);

                    if (result < count)
                    {
                        result = count;
                    }
                }
            }

            return result;
        }
    }
}
