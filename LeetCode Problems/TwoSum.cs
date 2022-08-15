﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class TwoSum
    {
        static private int[] SumTwo(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(var j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
