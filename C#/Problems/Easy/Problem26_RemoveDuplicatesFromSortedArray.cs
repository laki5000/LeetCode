namespace LeetCode.Problems.Easy
{
    internal static class Problem26_RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var length = nums.Length;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        var tmp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = tmp;
                    }

                    length--;
                    i--;
                }
            }

            return length;
        }
    }
}
