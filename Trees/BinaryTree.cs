using System;

public class BinaryTree<T>
{
    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
    {
        this.Value = value;
        this.LefChild = leftChild;
        this.RightChild = rightChild;
    }

    public T Value { get; set; }
    public BinaryTree<T> LefChild { get; set; }
    public BinaryTree<T> RightChild { get; set; }

    public void PrintIndentedPreOrder(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + this.Value);

        if (this.LefChild != null)
        {
            this.LefChild.PrintIndentedPreOrder(indent + 2);
        }

        if (this.RightChild != null)
        {
            this.RightChild.PrintIndentedPreOrder(indent + 2);
        }
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this,action);
    }

    private void EachInOrder(BinaryTree<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }
        else
        {
            this.EachInOrder(node.LefChild,action);
            action(node.Value);
            this.EachInOrder(node.RightChild,action);
        }
    }

    public void EachPostOrder(Action<T> action)
    {
        EachPostOrder(this, action);
    }

    private void EachPostOrder(BinaryTree<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachPostOrder(node.LefChild, action);
        this.EachPostOrder(node.RightChild, action);
        action(node.Value);
    }
}
