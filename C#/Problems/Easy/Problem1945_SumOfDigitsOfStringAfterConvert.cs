namespace LeetCode.Problems.Easy
{
    internal static class Problem1945_SumOfDigitsOfStringAfterConvert
    {
        public static int GetLucky(string s, int k)
        {
            int sum = 0;
            foreach (var item in s)
            {
                var toAdd = item - 'a' + 1;
                if (toAdd > 9)
                {
                    sum += toAdd % 10;
                    toAdd /= 10;
                    sum += toAdd;
                }
                else
                {
                    sum += toAdd;
                }
            }

            for (int i = 0; i < k - 1; i++)
            {
                int tmp = sum;
                sum = 0;
                while (tmp > 0)
                {
                    sum += tmp % 10;
                    tmp /= 10;
                }
            }

            return sum;
        }
    }
}
