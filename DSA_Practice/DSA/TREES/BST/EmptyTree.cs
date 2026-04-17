using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public class TreeNode{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int value)
    {
        Value=value;
    }
}

public class BinarySearchTree
{
    // Insert node into BST
    public TreeNode Insert(TreeNode root, int value)
    {
        if (root == null)
            return new TreeNode(value);

        if (value < root.Value)
            root.Left = Insert(root.Left, value);
        else if (value > root.Value)
            root.Right = Insert(root.Right, value);

        return root; // ignore duplicates
    }

  
  
}
		public static void Main(string[] args)
		{
		BinarySearchTree bst=new BinarySearchTree();
		TreeNode root = null;

        
        if(root==null)
         Console.WriteLine("Empty Tree ");
        else
         Console.WriteLine("Not Empty Tree");
      
        
       
		}
	
	}
}