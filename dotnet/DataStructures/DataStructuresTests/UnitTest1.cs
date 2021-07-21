using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class TestInsertAfter
  {
        [Fact]
        public void Test1()
        {
        bool isPresent = false;
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertAfter(13, 12);
        Node current = list.Head;
        while (current.Value != 12)
        {
            current = current.Next;
        }
        if (current.Next.Value == 13)
        {
            isPresent = true;
        }
        Assert.True(isPresent);
    }
    }
    public class TestInsertBefore
    {
        [Fact]
        public void Test2()
        {
        bool isPresent = false;
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertBefore(11, 12);
        Node current = list.Head;
        while (current.Value != 11)
        {
            current = current.Next;
        }
        if (current.Next.Value == 12)
        {
            isPresent = true;
        }
        Assert.True(isPresent);
        }
    }
    public class TestInsertAfter1
    {
        [Fact]
        public void Test3()
        {
        bool isPresent = false;
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertBefore(2,3);
        if(list.Head.Value == 2 && list.Head.Next.Value == 3)
        {
            isPresent = true;
        }
        Assert.True(isPresent);
        }
    }
    public class TestAppend
    {
        [Fact]
        public void Test4()
        {
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.Append(19);
        Node current = list.Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        Assert.Equal(19, current.Value);
        }
    }
    public class InsertMulti
    {
        [Fact]
        public void Test5()
        {
        bool isPresent = false;
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.Append(20);
        Node current = list.Head;
        while (current.Value != 18)
        {
        current = current.Next;
        }
        if (current.Value == 18 && current.Next.Value == 20)
        {
            isPresent = true;
        }
        Assert.True(isPresent);
        }
    }
    public class TestMiddle
    {
    [Fact]
    public void Test6()
    {
        bool isPresent = false;
        LinkedList list = new LinkedList();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertAfter(13, 18);
        Node current = list.Head;
        while (current.Value != 13)
        {
        current = current.Next;
        }
        if (current.Next == null)
        {
        isPresent = true;
        }
        Assert.True(isPresent);
    }
    }

  public class Kth
  {
    [Fact]
    public void ListOne()
    {
      LinkedList list = new LinkedList();
      list.Append(3);

      Assert.Equal(3, list.Kth(0));
    }

    [Fact]

    public void KNegative()
    {
      LinkedList list = new LinkedList();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Throws<IndexOutOfRangeException>(() => list.Kth(-1));
    }

    [Fact]

    public void KGreaterThanLength()
    {
      LinkedList list = new LinkedList();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Throws<IndexOutOfRangeException>(() => list.Kth(8));
    }

    [Fact]

    public void KEqualsLength()
    {
      LinkedList list = new LinkedList();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Throws<IndexOutOfRangeException>(() => list.Kth(6));
    }

    public void KHappy()
    {
      LinkedList list = new LinkedList();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Equal(12, list.Kth(2));
    }
  }
}
