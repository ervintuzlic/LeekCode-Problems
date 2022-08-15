using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    void static Main()
    {

    }

    public class RomanToInt
    {
        int RomToInt(string s)
        {
            var dictionary = new Dictionary<char, int>();

            dictionary.Add('I', 1);
            dictionary.Add('V', 5);
            dictionary.Add('X', 10);
            dictionary.Add('L', 50);
            dictionary.Add('C', 100);
            dictionary.Add('D', 500);
            dictionary.Add('M', 1000);

            var solution = 0;

            s = s.Replace("IV", "IIII"); //4
            s.Replace("IX", "VIIII"); //9
            s.Replace("XL", "XXXX"); //40
            s.Replace("XC", "LXXXX"); //90
            s.Replace("CD", "CCCC"); // 400
            s.Replace("CM", "DCCCC"); // 900

            foreach (char c in s)
            {
                solution += dictionary[c];
            }
            return solution;
        }
    }
}
