namespace LeetCode.Problems.Easy
{
    internal static class Problem3095_ShortestSubarrayWithORAtLeastKI
    {
        public static int MinimumSubarrayLength(int[] nums, int k)
        {
            var numsLength = nums.Length;
            var subbarayLength = 1;
            while (subbarayLength <= numsLength)
            {
                for (int i = 0; i + subbarayLength <= numsLength; i++)
                {
                    var currentResult = 0;
                    for (int j = i; j < i + subbarayLength; j++)
                    {
                        currentResult = currentResult | nums[j];
                    }

                    if (currentResult >= k)
                    {
                        return subbarayLength;
                    }
                }

                subbarayLength++;
            }

            return -1;
        }
    }
}
