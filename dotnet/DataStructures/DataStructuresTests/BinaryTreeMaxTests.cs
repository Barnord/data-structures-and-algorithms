using System;
using Xunit;
using DataStructures;


namespace DataStructuresTests
{
  public class BinaryTreeMaxTests
  {
    [Fact]

    public void AEmptyTree()
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      Assert.Throws<NullReferenceException>(() => tree.Max());
    }

    [Fact]

    public void BFindLargest()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new(1);
      tree.Root.Left = new(2);
      tree.Root.Right = new(3);

      BinaryTree<int> treee = new BinaryTree<int>();
      treee.Root = new(1);
      treee.Root.Left = new(2);
      treee.Root.Right = new(3);
      treee.Root.Right.Right = new(4);

      BinaryTree<int> treeee = new BinaryTree<int>();
      treeee.Root = new(1);
      treeee.Root.Left = new(2);
      treeee.Root.Right = new(3);
      treeee.Root.Left.Right = new(4);
      treeee.Root.Left.Left = new(5);


      Assert.Equal(3, tree.Max());
      Assert.Equal(4, treee.Max());
      Assert.Equal(5, treeee.Max());
    }

    [Fact]
    public void CDuplicates()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new(1);
      tree.Root.Left = new(2);
      tree.Root.Right = new(3);
      tree.Root.Right.Right = new(3);

      Assert.Equal(3, tree.Max());
    }
  }
}
