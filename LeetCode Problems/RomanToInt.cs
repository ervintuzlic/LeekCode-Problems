using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{

    public class RomanToInt
    {
        static void Main()
        {
            Console.WriteLine("Enter Roman Number: ");
            string romanNumber = Console.ReadLine();
            var num = RomToInt(romanNumber);
            Console.WriteLine(num);
        }

        private static object RomToInt(string? s)
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

            s = s.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX").Replace("XC", "LXXXX").Replace("CD", "CCCC").Replace("CM", "DCCCC");

            foreach (char c in s)
            {
                solution += dictionary[c];
            }
            return solution;
        }
    }
}
