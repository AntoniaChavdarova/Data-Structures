﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        List<int> res = tree.OrderBFS().ToList();
        Console.WriteLine(String.Join(" " , res));

        List<int> res2 = tree.OrderDFS().ToList();
        Console.WriteLine(String.Join(" ", res));

        //var binaryTree =
        //    new BinaryTree<string>("*",
        //        new BinaryTree<string>("+",
        //            new BinaryTree<string>("3"),
        //            new BinaryTree<string>("2")),
        //        new BinaryTree<string>("-",
        //            new BinaryTree<string>("9"),
        //            new BinaryTree<string>("6")));

        //Console.WriteLine("Binary tree (indented, pre-order):");
        //binaryTree.PrintIndentedPreOrder();

        //Console.Write("Binary tree nodes (in-order):");
        //binaryTree.EachInOrder(c => Console.Write(" " + c));
        //Console.WriteLine();

        //Console.Write("Binary tree nodes (post-order):");
        //binaryTree.EachPostOrder(c => Console.Write(" " + c));
        //Console.WriteLine();
    }
}