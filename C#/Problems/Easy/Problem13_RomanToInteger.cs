namespace LeetCode.Problems.Easy
{
    internal static class Problem13_RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var dictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            var result = 0;
            var previous = 0;

            foreach (var item in s)
            {
                var current = dictionary[item];
                result += current;
                if (previous < current && previous != 0)
                {
                    result -= 2 * previous;
                }
                previous = current;
            }

            return result;
        }
    }
}
