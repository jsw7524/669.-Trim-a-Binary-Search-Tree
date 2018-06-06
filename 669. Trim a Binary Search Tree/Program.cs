using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _669.Trim_a_Binary_Search_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            root = TrimLower(root, L);
            root = TrimUpper(root, R);
            return root;
        }
        public TreeNode TrimLower(TreeNode root, int L)
        {
            if (null == root)
            {
                return null;
            }
            else if (L==root.val)
            {
                root.left = null;
            }
            else if (L < root.val)
            {
                root.left=TrimLower(root.left,L);
            }
            else if (L > root.val)
            {
                root = TrimLower(root.right, L);
            }
            return root;
        }
        public TreeNode TrimUpper(TreeNode root, int R)
        {
            if (null == root)
            {
                return null;
            }
            else if (R == root.val)
            {
                root.right = null;
            }
            else if (R < root.val)
            {
                root = TrimUpper(root.left, R);
            }
            else if (R > root.val)
            {
                root.right = TrimUpper(root.right, R);
            }
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
