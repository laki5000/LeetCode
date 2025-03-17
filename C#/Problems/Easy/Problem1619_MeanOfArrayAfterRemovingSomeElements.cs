namespace LeetCode.Problems.Easy
{
    internal static class Problem1619_MeanOfArrayAfterRemovingSomeElements
    {
        public static double TrimMean(int[] arr)
        {
            int elementsToRemove = (int)Math.Ceiling(arr.Length * 0.05);
            Array.Sort(arr);
            var trimmedArray = arr.Skip(elementsToRemove).Take(arr.Length - 2 * elementsToRemove);
            return trimmedArray.Average();
        }
    }
}
