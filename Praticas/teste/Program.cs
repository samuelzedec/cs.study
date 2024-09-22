Console.WriteLine("Invertendo um árvore binária");

TreeNode node = new(1);
node.Left = new(2);
node.Right = new(3);

BinaryTree tree = new();
tree.Invert(node);

public class TreeNode
{
    public int Value;
    public TreeNode Left;  // Filho esquerdo
    public TreeNode Right; // Filho direito

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public void Invert(TreeNode node)
    {
        if (node == null) throw new Exception("Não é possível continuar!");

        // Trocar os filhos esquerdo e direito
        TreeNode temp = node.Left;
        node.Left = node.Right;
        node.Right = temp;

        // Inverter recursivamente os subárvores
        Invert(node.Left);
        Invert(node.Right);
    }
}