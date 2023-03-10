using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Strings
{
    internal class CaesarCipher
    {
        public static string caesarCipher(string s, int k)
        {
            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Regex checkLowercase = new Regex("[a-z]");
            Regex checkUppercase = new Regex("[A-Z]");

            char current = 'a';

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                current = s[i];

                if (checkLowercase.IsMatch(current.ToString()))
                {
                    result += alphabet[(alphabet.IndexOf(current) + k) % alphabet.Count];
                }
                else if (checkUppercase.IsMatch(current.ToString()))
                {
                    current = current.ToString().ToLower()[0];

                    result += alphabet[(alphabet.IndexOf(current) + k) % alphabet.Count].ToString().ToUpper();
                }
                else
                {
                    result += current;
                }
            }

            return result;
        }
    }
}
