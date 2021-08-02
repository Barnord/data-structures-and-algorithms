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

    }
  }
}
