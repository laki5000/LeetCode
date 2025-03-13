namespace LeetCode.Problems.Easy
{
    internal static class Problem20_ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var pairs = new Dictionary<char, char>
            {
                {')', '('},
                {']', '['},
                {'}', '{'}
            };
            var stack = new Stack<char>();

            foreach (var item in s)
            {
                if (pairs.TryGetValue(item, out var value))
                {
                    if (stack.Count == 0 || pairs[item] != stack.Pop())
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }

            return stack.Count == 0;
        }
    }
}
