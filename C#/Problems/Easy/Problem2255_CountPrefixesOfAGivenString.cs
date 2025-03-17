namespace LeetCode.Problems.Easy
{
    internal static class Problem2255_CountPrefixesOfAGivenString
    {
        public static int CountPrefixes(string[] words, string s)
        {
            var sLength = s.Length;
            var count = 0;

            foreach (var item in words)
            {
                var itemLength = item.Length;
                if (itemLength > sLength)
                {
                    continue;
                }
                var currentLength = sLength > itemLength ? itemLength : sLength;
                

                for (int i = 0; i < currentLength; i++)
                {
                    if (item[i] != s[i])
                    {
                        break;
                    }

                    if (i == currentLength - 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
