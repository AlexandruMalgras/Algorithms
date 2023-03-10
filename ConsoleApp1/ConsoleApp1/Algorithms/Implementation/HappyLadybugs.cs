using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    internal class HappyLadybugs
    {
        public static string happyLadybugs(string b)
        {
            if (b.Length < 2 && b.Contains('_'))
            {
                return "YES";
            }
            
            if (b.Length < 2)
            {
                return "NO";
            }

            if (b.Contains('_'))
            {

                Dictionary<char, int> ladybugsCount = new Dictionary<char, int>();

                char current = 'A';

                for (int i = 0; i < b.Length; i++)
                {
                    current = b[i];

                    if (current == '_') continue;

                    if (ladybugsCount.ContainsKey(current))
                    {
                        ladybugsCount[current]++;
                    }
                    else
                    {
                        ladybugsCount.Add(current, 1);
                    }
                }

                foreach (char c in ladybugsCount.Keys)
                {
                    if (ladybugsCount[c] == 1)
                    {
                        return "NO";
                    }
                }
            }
            else
            {
                for (int i = 0; i < b.Length;i++)
                {
                    if (i > 0 && i < b.Length - 1)
                    {
                        if (!(b[i - 1] == b[i] || b[i + 1] == b[i]))
                        {
                            return "NO";
                        }
                    }
                    else if (i == 0)
                    {
                        if (!(b[i + 1] == b[i]))
                        {
                            return "NO";
                        }
                    }
                    else
                    {
                        if (!(b[i - 1] == b[i]))
                        {
                            return "NO";
                        }
                    }
                }

                return "YES";
            }

            return "YES";
        }
    }
}
