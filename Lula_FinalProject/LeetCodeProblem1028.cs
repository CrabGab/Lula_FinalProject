using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula_FinalProject
{
    public class LeetCodeProblem1028
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

        public TreeNode RecoverFromPreorder(string traversal)
        {
            Stack<(TreeNode node, int depth)> stack = new Stack<(TreeNode, int)>();
            int i = 0;

            while (i < traversal.Length)
            {
                int depth = 0;
                while (i < traversal.Length && traversal[i] == '-')
                {
                    depth++;
                    i++;
                }

                int val = 0;
                while (i < traversal.Length && Char.IsDigit(traversal[i]))
                {
                    val = val * 10 + (traversal[i] - '0');
                    i++;
                }

                TreeNode newNode = new TreeNode(val);

                while (stack.Count > depth)
                    stack.Pop();

                if (stack.Count > 0)
                {
                    TreeNode parent = stack.Peek().node;
                    if (parent.left == null)
                        parent.left = newNode;
                    else
                        parent.right = newNode;
                }

                stack.Push((newNode, depth));
            }

            return stack.Count > 0 ? stack.ToArray()[0].node : null;
        }

        public string SolveExample()
        {
            var root = RecoverFromPreorder("1-2--3--4-5--6--7");
            return InOrderTraversal(root).Trim();
        }

        private string InOrderTraversal(TreeNode node)
        {
            if (node == null) return "";
            return InOrderTraversal(node.left) + node.val + " " + InOrderTraversal(node.right);
        }
    }
}
