﻿namespace LeetCode.Problems.Easy
{
    internal class Problem1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    { 
                        return [i, j];
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
