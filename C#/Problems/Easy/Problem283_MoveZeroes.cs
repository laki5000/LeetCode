namespace LeetCode.Problems.Easy
{
    internal static class Problem283_MoveZeroes
    {
        public static void MoveZeroes(int[] nums)
        {
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < len - 1; j++)
                    {
                        var tmp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = tmp;
                    }
                    len--;
                    i--;
                }
            }
        }
    }
}
