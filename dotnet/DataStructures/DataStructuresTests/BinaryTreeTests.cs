using System;
using Xunit;
using DataStructures;
using System.Collections.Generic;

namespace DataStructuresTests
{
  public class BinaryTreeTests
  {
    [Fact]
    public void AEmptyTree()
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      Assert.Null(tree.Root);
    }

    [Fact]
    public void BRootTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(tree.Root, 5);

      Assert.Equal(5, tree.Root.Value);
    }

    [Fact]
    public void CRootRightLeft()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(tree.Root, 5);
      tree.Add(tree.Root, 6);
      tree.Add(tree.Root, 3);

      Assert.Equal(5, tree.Root.Value);
      Assert.Equal(6, tree.Root.Right.Value);
      Assert.Equal(3, tree.Root.Left.Value);
    }

    [Fact]
    public void DPreOrderTraversal()
    {
      BinaryTree<int> tree = new();

      Node<int> a = new Node<int>(5);
      Node<int> b = new Node<int>(6);
      Node<int> c = new Node<int>(7);
      Node<int> d = new Node<int>(8);

      tree.Root = a;
      tree.Root.Left = b;
      tree.Root.Right = c;
      tree.Root.Left.Right = d;

      List<int> list = new();
      list.Add(5);
      list.Add(6);
      list.Add(8);
      list.Add(7);

      List<int> values = new();
      tree.PreOrderTraversal(tree.Root, values);

      Assert.Equal(list, values);
    }

    [Fact]
    public void EInOrderTraversal()
    {
      BinaryTree<int> tree = new();

      Node<int> a = new Node<int>(5);
      Node<int> b = new Node<int>(6);
      Node<int> c = new Node<int>(7);
      Node<int> d = new Node<int>(8);

      tree.Root = a;
      tree.Root.Left = b;
      tree.Root.Right = c;
      tree.Root.Left.Right = d;

      List<int> list = new();
      list.Add(6);
      list.Add(8);
      list.Add(5);
      list.Add(7);

      List<int> values = new();
      tree.InOrderTraversal(tree.Root, values);

      Assert.Equal(list, values);
    }

    [Fact]
    public void FPostOrderTraversal()
    {
      BinaryTree<int> tree = new();

      Node<int> a = new Node<int>(5);
      Node<int> b = new Node<int>(6);
      Node<int> c = new Node<int>(7);
      Node<int> d = new Node<int>(8);

      tree.Root = a;
      tree.Root.Left = b;
      tree.Root.Right = c;
      tree.Root.Left.Right = d;

      List<int> list = new();
      list.Add(8);
      list.Add(6);
      list.Add(7);
      list.Add(5);

      List<int> values = new();
      tree.PostOrderTraversal(tree.Root, values);

      Assert.Equal(list, values);
    }
  }
}
