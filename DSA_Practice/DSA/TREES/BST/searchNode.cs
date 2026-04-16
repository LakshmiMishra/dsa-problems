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

    // Inorder traversal (Left → Root → Right)
    public void Inorder(TreeNode root)
    {
        if (root == null)
            return;

        Inorder(root.Left);
        Console.Write(root.Value + " ");
        Inorder(root.Right);
    }
    public TreeNode SearchNode(TreeNode root,int val){
      if(root==null || root.Value==val)
      return root;
      if(val<root.Value)
      SearchNode(root.Left,val);
    
      return SearchNode(root.Right,val);
      
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

        Console.WriteLine("Inorder Traversal of BST:");
        bst.Inorder(root);
      int nodeVal=0;
      Console.WriteLine("Find the node : "+ nodeVal);
      
        
       var result= bst.SearchNode(root,nodeVal);
       if(result!=null)
       Console.WriteLine("Node Found");
       else
       Console.WriteLine("Node Not Found");
		}
	
	}
}