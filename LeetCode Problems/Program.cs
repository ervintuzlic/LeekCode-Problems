using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
public class PalindromeClass {
    public static bool IsPalindrome(int x)
    {
        int a = 0;
            int counter = x.ToString().Length;

            int broj = x;

            if (x < 0)
                return false;

        do
        {
            a = a * 10 + (x % 10); // 323 323/10= 32.3
            x /= 10;
            --counter;

            } while (counter > 0);
        if (a == broj)
            return true;
        return false;
    }
}


public class Program
    {
        //static void Main()
        //{
        //    Console.WriteLine("Input a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    if (PalindromeClass.IsPalindrome(number))
        //        Console.WriteLine("true");
        //    Console.WriteLine("false");
        //}
    }
}
