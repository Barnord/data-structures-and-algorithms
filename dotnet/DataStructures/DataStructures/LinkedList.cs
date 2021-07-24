using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class LinkedList<T>
  {

    public Node<T> Head { get; set; }

    public LinkedList()
    {

    }

    public void Insert(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head != null)
      {
        node.Next = Head;
      }
      Head = node;
    }

    public void Append(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head == null)
      {
        Head = node;
        return;
      }

      Node<T> current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }

      current.Next = node;
    }

    public void InsertBefore(T value, T before)
    {
      Node<T> node = new Node<T>(value);

      Node<T> current = Head;

      if (Head.Value == before)
      {
        node.Next = Head;
        Head = node;
      }
      else
      {
        while (current.Next.Value != before)
        {
          current = current.Next;
        }
      }

      if (current.Next.Value == before)
      {
        node.Next = current.Next;
        current.Next = node;
      }
    }

    public void InsertAfter(T value, T after)
    {
      Node<T> node = new Node<T>(value);

      Node<T> current = Head;
      while (current.Value != after)
      {
        current = current.Next;
      }

      node.Next = current.Next;
      current.Next = node;
    }

    public int Kth(T k)
    {
      Node<T> current = Head;
      int length = 0;

      while (current.Next != null)
      {
        current = current.Next;
        length++;
      }
      if (k<0 || k>length)
      {
        throw new IndexOutOfRangeException();
      }

      current = Head;

      for (int i=0; i<length-k; i++)
      {
        current = current.Next;
      }

      return current.Value;
    }
  }
}
