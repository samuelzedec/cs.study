Console.WriteLine("Invertendo um árvore binária");

public class TreeNode
{
    public readonly int Number;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int number)
    {
        Number = number;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public static TreeNode Investing(TreeNode tree)
    {
        if (tree is null) return null;
        
        TreeNode temp = tree.Right;
        tree.Right = tree.Left;
        tree.Left = temp;
        
        Investing(tree.Left);
        Investing(tree.Right);

        return tree;
    }
}