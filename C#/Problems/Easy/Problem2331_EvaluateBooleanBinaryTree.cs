using LeetCode.Shared;

namespace LeetCode.Problems.Easy
{
    internal static class Problem2331_EvaluateBooleanBinaryTree
    {
        public static bool EvaluateTree(TreeNode root)
        {
            switch(root.val)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                case 2:
                    return EvaluateTree(root.left) || EvaluateTree(root.right);
                case 3:
                    return EvaluateTree(root.left) && EvaluateTree(root.right);
                default:
                    return false;
            }
        }
    }
}
