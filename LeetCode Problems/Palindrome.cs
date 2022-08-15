using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int a = 0;
            int counter = x.ToString().Length;
            int broj = x;
            do
            {
                a += x % 10; // 323 323/10= 32.3
                x /= 10;
                --counter;
            } while (counter > 0);

            if (a == broj)
                return true;
            return false;
        }
    }
}
