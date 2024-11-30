using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_.Problems.Easy
{
    internal class Problem1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++) {
                for (var j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target) { 
                        return [i, j];
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
