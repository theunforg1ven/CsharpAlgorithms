using System.Collections.Generic;

namespace Arrays.Tree
{
	public class TreeNode<T> 
	{ 
		public T Data { get; set; } 
		public TreeNode<T> Parent { get; set; } 
		
		public List<TreeNode<T>> Children { get; set; } 
 
		public int GetHeight() 
		{ 
			var height = 1; 
			var current = this; 
			while (current.Parent != null) 
			{ 
				height++; 
				current = current.Parent; 
			} 
			return height; 
		} 
	} 
}
