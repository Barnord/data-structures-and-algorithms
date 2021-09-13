using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTests
  {
    [Fact]
    public static void AEmptyList()
    {
      LinkedList<string> list = new LinkedList<string>();

      Assert.Null(list.Head);
    }

    [Fact]
    public static void BAddToList()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("BIG MONEY");

      Assert.Equal("BIG MONEY", list.Head.Value);
    }

    [Fact]
    public static void CHeadIsFirstValue()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("BIG MONEY");
      list.Append("no money.");

      Assert.Equal("BIG MONEY", list.Head.Value);
    }

    [Fact]
    public static void DCanInsertMultipleNodes()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("no money.");
      list.Append("BIG MONEY");

      Assert.Equal("BIG MONEY", list.Head.Next.Value);
    }

    [Fact]
    public static void EIncludes()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("no money.");
      list.Append("BIG MONEY");

      Assert.True(list.Includes("BIG MONEY"));
    }

    [Fact]
    public static void FDoesntInclude()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("no money.");

      Assert.False(list.Includes("BIG MONEY"));
    }

    [Fact]
    public static void GToString()
    {
      LinkedList<string> list = new LinkedList<string>();
      list.Append("no money");
      list.Append("BIG MONEY");

      Assert.Equal("{no money} -> {BIG MONEY} -> NULL", list.ToString());
    }
  }
}
