namespace CSharpReference.LeetCode._0226
{
    public class InvertBinaryTree : ICode
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public TreeNode InvertTree(TreeNode root)
        {
            Invert(root);
            return root;
        }

        private static void Invert(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            (root.left, root.right) = (root.right, root.left);
            
            Invert(root.left);
            Invert(root.right);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0)
        {
            this.val = val;
        }
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}