namespace LeetCode.Problems.Easy
{
    internal static class Problem9_PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            int result = 0;
            int xCopy = x;

            while (xCopy > 0)
            {
                result *= 10;
                result += xCopy % 10;
                xCopy /= 10;
            }

            return result == x;
        }
    }
}
