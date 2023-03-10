using System;

namespace ConsoleApp1.Algorithms.Strings
{
    public class MarsExploration
    {
        public static int marsExploration(string s)
        {
            int countSOS = s.Length / 3;

            string sosString = "";

            for (int i = 0; i < countSOS; i++) 
            {
                sosString += "SOS";
            }

            int countChanges = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != sosString[i])
                {
                    countChanges++;
                }
            }

            return countChanges;
        }
    }
}
