using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Tree
{
	public class Tree
	{
        public TreeNode Insert(TreeNode root, int v)
        {
            if (root == null)
                root = new TreeNode(v);

            else if (v < root.Value)
                root.Left = Insert(root.Left, v);

            else
                root.Right = Insert(root.Right, v);

            return root;
        }
    }
}
