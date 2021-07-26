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
        LinkedList<int> list = new LinkedList<int>();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertAfter(13, 12);
        Node<int> current = list.Head;
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
        LinkedList<int> list = new LinkedList<int>();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertBefore(11, 12);
        Node<int> current = list.Head;
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
        LinkedList<int> list = new LinkedList<int>();
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
        LinkedList<int> list = new LinkedList<int>();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.Append(19);
        Node<int> current = list.Head;
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
        LinkedList<int> list = new LinkedList<int>();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.Append(20);
        Node<int> current = list.Head;
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
        LinkedList<int> list = new LinkedList<int>();
        list.Append(3);
        list.Append(6);
        list.Append(9);
        list.Append(12);
        list.Append(15);
        list.Append(18);
        list.InsertAfter(13, 18);
        Node<int> current = list.Head;
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
      LinkedList<int> list = new LinkedList<int>();
      list.Append(3);

      Assert.Equal(3, list.Kth(0));
    }

    [Fact]

    public void KNegative()
    {
      LinkedList<int> list = new LinkedList<int>();
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
      LinkedList<int> list = new LinkedList<int>();
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
      LinkedList<int> list = new LinkedList<int>();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Throws<IndexOutOfRangeException>(() => list.Kth(6));
    }

    [Fact]

    public void KHappy()
    {
      LinkedList<int> list = new LinkedList<int>();
      list.Append(3);
      list.Append(6);
      list.Append(9);
      list.Append(12);
      list.Append(15);
      list.Append(18);

      Assert.Equal(12, list.Kth(2));
    }
  }

  public class StackTests
  {
    [Fact]

    public void APush()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);

      Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void BMultiplePush()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Peek());
    }

    [Fact]
    public void CPopOff()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Pop());
      Assert.Equal(2, stack.Peek());
    }

    [Fact]
    public void DPopAll()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Pop());
      Assert.Equal(2, stack.Pop());
      Assert.Equal(1, stack.Pop());
      Assert.Null(stack.Top);
    }

    [Fact]
    public void EPeek()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);

      Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void FInstantiate()
    {
      Stack<int> stack = new Stack<int>();

      Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void GException()
    {
      Stack<int> stack = new Stack<int>();

      Assert.Throws<Exception>(() =>stack.Pop());
    }
  }

  public class QueueTests
  {
    [Fact]
    public void AEnqueue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);

      Assert.Equal(1, queue.Front.Value);
    }

    [Fact]
    public void BEnqueueLots()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.Equal(1, queue.Front.Value);
      Assert.Equal(3, queue.Back.Value);
    }

    [Fact]
    public void CDequeue()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.Equal(1, queue.Dequeue());
      Assert.Equal(2, queue.Front.Value);
      Assert.Equal(3, queue.Back.Value);
    }

    [Fact]
    public void DPeek()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void EDequeueEmpty()
    {
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();

      Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void FInstantiateEmpty()
    {
      Queue<int> queue = new Queue<int>();

      Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void EEmptyException()
    {
      Queue<int> queue = new Queue<int>();

      Assert.Throws<NullReferenceException>(() => queue.Dequeue());
    }
  }
}
