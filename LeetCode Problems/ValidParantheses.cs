using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    //public class ValidParantheses
    //{
    //    public static bool Rekurzija(string a)
    //    {
    //        string brackets1 = "()";
    //        string brackets2 = "[]";
    //        string brackets3 = "{}";

    //        if (a == brackets1)
    //            return true;
    //        else if (a == brackets2)
    //            return true;
    //        else if (a == brackets3)
    //            return true;

    //        return false;
    //    }


    //    public static bool IsValid(string s)
    //    {

    //        if (s.Length % 2 != 0) return false;

    //        int brojac = 0;

    //        for (int i = 0; i < s.Length/2; i++)
    //        {
    //            string twobrackets = s.Substring(s.Length - 2);
    //            brojac += 2;
    //            if (!ValidParantheses.Rekurzija(twobrackets))
    //                return false;
    //        }
    //        return true;
    //    }
    //}

    //public class Program2
    //{
    //    //static void Main()
    //    //{
    //    //    Console.WriteLine("Input brackets: ");
    //    //    string name = Console.ReadLine();
    //    //    if (ValidParantheses.IsValid(name))
    //    //        Console.WriteLine("true");
    //    //    else
    //    //    Console.WriteLine("false");
    //    //}
    //}
}
