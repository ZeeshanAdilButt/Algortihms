namespace Tree_Invert_Binary_Tree
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode right = InvertTree(root.right);
            TreeNode left = InvertTree(root.left);
            root.left = right;
            root.right = left;
            return root;
        }


        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
            TreeNode inverted = InvertTree(root);


            Console.WriteLine("Hello, World!");
        }
    }
}