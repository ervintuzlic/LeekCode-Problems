using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{

    // 1.
    // Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
    public class AlgorithmExercises
    {
        static void Main()
        {
            Console.WriteLine("Input two numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((x == y) ? (x + y) * 3 : "NOT SAME");
        }
    }

}
