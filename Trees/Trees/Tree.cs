using System;
using System.Collections.Generic;

public class Tree<T>
{
   
    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>();

        foreach (var child in children)
        {
            this.Children.Add(child);
        }
    }

    public T Value { get; set; }

    public IList<Tree<T>> Children { get; private set; }

    public void Print(int indent = 0)
    {
        Print(this, indent);
    }

    public void Print(Tree<T> node , int indent)
    {
        Console.WriteLine($"{new string(' ', 2 * indent)} {node.Value}");

        foreach (var child in node.Children)
        {
            child.Print(indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);
        foreach (var child in this.Children)
        {
            child.Each(action);
        }
    }

    public IEnumerable<T> OrderDFS()
    {
        List<T> order = new List<T>();
        this.DFS(this, order);
        return order;

    }

    private void DFS(Tree<T> tree , List<T> order)
    {
        foreach (var child in tree.Children)
        
            this.DFS(child, order);
        order.Add(tree.Value);
        
    }

    public IEnumerable<T> OrderBFS()
    {
        var result = new List<T>();
        var queue = new Queue<Tree<T>>();
        queue.Enqueue(this);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            result.Add(current.Value);

            foreach (var child in current.Children)
                queue.Enqueue(child);
        }

        return result;
    }
}
