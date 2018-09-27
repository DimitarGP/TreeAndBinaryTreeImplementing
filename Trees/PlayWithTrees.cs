using System;
using System.Runtime.InteropServices;

public class PlayWithTrees
{
    static void Main()
    {
        var tree =
            new Tree<int>(7,
                new Tree<int>(19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(31)),
                new Tree<int>(21),
                new Tree<int>(14,
                    new Tree<int>(23),
                    new Tree<int>(6)));

        Console.WriteLine("Tree (indented):");
        tree.Print();

        Console.Write("Tree nodes:");
        tree.Each(c => Console.Write(" " + c));
        Console.WriteLine();

        Console.WriteLine();

        var bt =
            new BinaryTree<int>(7,
                new BinaryTree<int>(5,
                    new BinaryTree<int>(1),
                    new BinaryTree<int>(6)),
                new BinaryTree<int>(9,
                    new BinaryTree<int>(8),
                    new BinaryTree<int>(15)));

        bt.PrintIndentedPreOrder();

        Console.Write("Binary tree (indented, pre-order):");
        bt.EachInOrder(c => Console.Write(" " + c));
        Console.WriteLine();

        Console.Write("Binary tree nodes (post-order):");
        bt.EachPostOrder(c => Console.Write(" " + c));

        Console.WriteLine();
        Console.WriteLine();

        var binaryTree =
            new BinaryTree<string>("*",
                new BinaryTree<string>("+",
                    new BinaryTree<string>("3"),
                    new BinaryTree<string>("2")),
                new BinaryTree<string>("-",
                    new BinaryTree<string>("9"),
                    new BinaryTree<string>("6")));

        Console.WriteLine("Binary tree (indented, pre-order):");
        binaryTree.PrintIndentedPreOrder();

        Console.Write("Binary tree nodes (in-order):");
        binaryTree.EachInOrder(c => Console.Write(" " + c));
        Console.WriteLine();

        Console.Write("Binary tree nodes (post-order):");
        binaryTree.EachPostOrder(c => Console.Write(" " + c));
        Console.WriteLine();
    }
}
