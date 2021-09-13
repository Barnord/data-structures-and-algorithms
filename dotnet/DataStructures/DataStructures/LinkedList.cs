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

    public bool Includes(T value)
    {
      Node<T> current = Head;

      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          return true;
        }
        current = current.Next;
      }

      return false;
    }

    public string ToString()
    {
      Node<T> current = Head;

      string answer = "";

      while (current != null)
      {
        answer += $"{{{current.Value.ToString()}}} -> ";
        current = current.Next;
      }

      return answer + "NULL";
    }

    public void InsertBefore(T value, int before)
    {
      Node<T> node = new Node<T>(value);
      Convert.ToInt32(node);

      Node<T> current = Head;

      if (Head.Value.Equals(before))
      {
        node.Next = Head;
        Head = node;
      }
      else
      {
        while (!current.Next.Value.Equals(before))
        {
          current = current.Next;
        }
      }

      if (current.Next.Value.Equals(before))
      {
        node.Next = current.Next;
        current.Next = node;
      }
    }

    public void InsertAfter(T value, T after)
    {
      Node<T> node = new Node<T>(value);

      Node<T> current = Head;
      while (!current.Value.Equals(after))
      {
        current = current.Next;
      }

      node.Next = current.Next;
      current.Next = node;
    }

    public T Kth(int k)
    {
      Node<T> current = Head;
      int length = 0;

      while (current.Next != null)
      {
        current = current.Next;
        length++;
      }
      if (k < 0 || k > length)
      {
        throw new IndexOutOfRangeException();
      }

      current = Head;

      for (int i = 0; i < length - k; i++)
      {
        current = current.Next;
      }

      return current.Value;
    }
  }
}
