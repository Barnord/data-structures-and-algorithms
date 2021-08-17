using System;
using Xunit;
using DataStructures;

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
      BinarySearchTree<int> tree = new();
      tree.Add(tree.Root, 5);

      //List<int> list
    }
  }
}
