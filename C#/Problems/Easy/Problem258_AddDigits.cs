using System.Globalization;

namespace LeetCode.Problems.Easy
{
    internal static class Problem258_AddDigits
    {
        public static int AddDigits(int num)
        {
            var result = 0;

            while (num != 0)
            {
                var current = num % 10;
                num  /= 10;

                result += current;

                if (result >= 10)
                {
                    var resultPart = result % 10;
                    result /= 10;
                    result += resultPart;
                }
            }

            return result;
        }
    }
}
