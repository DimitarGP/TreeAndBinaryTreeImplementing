﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class Tree<T>
{
    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>(children);
    }

    public T Value { get; set; }
    public List<Tree<T>> Children { get; set; }

    public void Print(int indent = 0)
    {
        Console.Write(new string(' ',2 * indent));
        Console.WriteLine(this.Value);
        foreach (var child in this.Children)
        {
            child.Print(indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);
        foreach (var child in Children)
        {
            child.Each(action);
        }
    }

    public IEnumerable<T> OrderDFS()
    {
        var result = new List<T>();
        DFS(this, result);
        return result;
    }

    private void DFS(Tree<T> tree, List<T> result)
    {
        foreach (var child in tree.Children)
        {
            DFS(child,result);
        }

        result.Add(tree.Value);
    }

    public IEnumerable<T> OrderBFS()
    {
        var result = new List<T>();
        var queue = new Queue<Tree<T>>();

        queue.Enqueue(this);
        while (queue.Count > 0)
        {
            Tree<T> current = queue.Dequeue();
            result.Add(current.Value);
            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }
        return result;
    }
}
