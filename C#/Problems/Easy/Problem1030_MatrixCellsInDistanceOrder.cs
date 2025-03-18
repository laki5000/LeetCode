namespace LeetCode.Problems.Easy
{
    internal static class Problem1030_MatrixCellsInDistanceOrder
    {
        public static int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            var rowsXcols = rows * cols;
            var matrix = new int[rowsXcols][];

            for (int i = 0; i < rowsXcols; i++)
            {
                var currentRow = i / cols;
                var currentCol = i % cols;

                matrix[i] = [currentRow, currentCol];
            }

            Array.Sort(matrix, (a, b) =>
                Math.Abs(a[0] - rCenter) + Math.Abs(a[1] - cCenter) -
                (Math.Abs(b[0] - rCenter) + Math.Abs(b[1] - cCenter))
            );

            return matrix;
        }
    }
}
