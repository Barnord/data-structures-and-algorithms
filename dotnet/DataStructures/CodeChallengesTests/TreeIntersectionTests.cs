using System;
using Xunit;
using CodeChallenges;
using DataStructures;
using System.Collections.Generic;

namespace CodeChallengesTests
{
  public class TreeIntersectionTests
  {
    [Fact]
    public static void AEmptyTrees()
    {
      BinaryTree<int> tree1 = new();
      BinaryTree<int> tree2 = new();

      Assert.Throws<NullReferenceException>(() => TreeIntersectionHash.TreeIntersection(tree1, tree2));
    }

    [Fact]
    public static void BNoMatches()
    {
      BinaryTree<int> tree1 = new();
      tree1.Root = new Node<int>(14);
      tree1.Root.Right = new Node<int>(76);
      BinaryTree<int> tree2 = new();
      tree2.Root = new Node<int>(4);
      tree2.Root.Left = new Node<int>(2);

      int[] result = TreeIntersectionHash.TreeIntersection(tree1, tree2);
      int[] expected = { };

      Assert.Equal(result, expected);
    }

    [Fact]
    public static void CProperMatches()
    {
      BinaryTree<int> tree1 = new();
      tree1.Root = new Node<int>(14);
      tree1.Root.Right = new Node<int>(76);
      BinaryTree<int> tree2 = new();
      tree2.Root = new Node<int>(4);
      tree2.Root.Left = new Node<int>(76);

      int[] result = TreeIntersectionHash.TreeIntersection(tree1, tree2);
      int[] expected = { 76 };

      Assert.Equal(result, expected);
    }
  }
}
