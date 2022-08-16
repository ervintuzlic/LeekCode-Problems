using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{

    // 1.
    // Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
    //public class AlgorithmExercises
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Input two numbers:");
    //        int x = Convert.ToInt32(Console.ReadLine());
    //        int y = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine((x == y) ? (x + y) * 3 : "NOT SAME");
    //    }
    //}



    // 2.
    // Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
    // If the given string length is less than 2 return the original string.

    //public class Problem
    //{
    //    static void Main() { 
    //        Console.WriteLine("Input string: ");

    //        string myStr = Console.ReadLine();

    //        if (myStr.Length < 2)
    //            Console.WriteLine(myStr);
    //        else
    //        {
    //            string newStr = myStr.Substring(0, 2);
    //            Console.WriteLine(newStr + newStr + newStr + newStr);
    //        }
    //    } 
    //}



    // 3.
    // Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit

    public class Problem
    {
        static void Main()
        {
            Console.WriteLine("Input two numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());


            int x1 = x % 10;
            int y1 = y % 10;
            int z1 = z % 10;

            if (x1 == y1 || y1 == z1 || x1 == z1 )
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
