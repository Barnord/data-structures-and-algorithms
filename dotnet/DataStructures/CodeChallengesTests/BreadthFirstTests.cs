using System;
using Xunit;
using CodeChallenges;
using DataStructures;
using System.Collections.Generic;

namespace CodeChallengesTests
{
  public class BreadthFirstTests
  {
    [Fact]
    public void AOrder()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new(1);
      tree.Root.Left = new(2);
      tree.Root.Right = new(3);
      tree.Root.Left.Right = new(4);
      tree.Root.Right.Left = new(5);

      List<int> list = new List<int>();
      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.Add(4);
      list.Add(5);

      Assert.Equal(list, treeBreadthFirst.LevelOrderTraversal(tree));
    }

    [Fact]
    public void BThrowsNull()
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      Assert.Throws<NullReferenceException>(() => treeBreadthFirst.LevelOrderTraversal(tree));
    }

    [Fact]
    public void CSingleItem()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new(1);
      List<int> list = new List<int>();
      list.Add(1);


      Assert.Equal(list, treeBreadthFirst.LevelOrderTraversal(tree));
    }
  }
}
