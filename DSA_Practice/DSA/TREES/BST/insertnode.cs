public class Program
{
public class TreeNode
{
    public TreeNode Left;
    public TreeNode Right;
    public int Value;
    public TreeNode(int value)
    {
        Value=value;
    }
}
public class BST
{
    public void InsertNode(TreeNode root,int value)
    {
        if(root==null)
        return new TreeNode(value);
        else if(root.Left<value)
        root.Left=InsertNode(root.Left,value);
        else if(root.Right>value)
        root.Right=InsertNode(root.Right,value);
        return root;
    }
}

public void InorderTraversal(TreeNode root)
    {
        if(root==null)
        return ;
        InorderTraversal(root.Left);
        Console.Write(root.Value+" ");
        InorderTraversal(root.Right);
    }

public static void Main(string[] args)
{
    BST bst=new BST();
    TreeNode root=null;
    root=bst.InsertNode(root,30);
    root=bst.InsertNode(root,20);
    root=bst.InsertNode(root,40);
    root=bst.InsertNode(root,10);
    root=bst.InsertNode(root,25);
    root=bst.InsertNode(root,35);
    root=bst.InsertNode(root,50);
    
    Console.WriteLine("Inorder Traversal of the BST:");
    InorderTraversal(root);
}

}