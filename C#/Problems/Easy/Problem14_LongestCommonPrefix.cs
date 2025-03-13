using System.Text;

namespace LeetCode.Problems.Easy
{
    internal static class Problem14_LongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var minLength = strs.Min(item => item.Length);

            for (int i = 0; i < minLength; i++)
            {
                var c = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0].Substring(0, minLength);
        }
    }
}
