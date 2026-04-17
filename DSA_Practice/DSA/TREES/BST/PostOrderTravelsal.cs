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

    // PostOrder traversal (Left → Right → Root)
    public void PostOrder(TreeNode root)
    {
        if (root == null)
            return;
       
        PostOrder(root.Left);
        PostOrder(root.Right);
         Console.Write(root.Value + " ");
    }
  
}
		public static void Main(string[] args)
		{
		BinarySearchTree bst=new BinarySearchTree();
		TreeNode root = null;

        //Insert values
        root = bst.Insert(root, 50);
        root = bst.Insert(root, 30);
        root = bst.Insert(root, 70);
        root = bst.Insert(root, 20);
        root = bst.Insert(root, 40);
        root = bst.Insert(root, 60);
        root = bst.Insert(root, 80);

        Console.WriteLine("PreOrder Traversal of BST:");
        bst.PostOrder(root);
        
        // if(root==null)
        // Console.WriteLine("Empty Tree ");
        // else
        // Console.WriteLine("Not Empty Tree");
      
        
       
		}
	
	}
}