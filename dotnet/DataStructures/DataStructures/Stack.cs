using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  class Stack<T>
  {
    Node<T> Top { get; set; }

    public Stack()
    {

    }

    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Top;
      Top = node;
    }

    public T Pop()
    {
      if (Top == null)
      {
        throw new Exception("This stack is empty.");
      }

      Node<T> node = Top;
      Top = node.Next;

      return node.Value;
    }

    public T Peek()
    {
      if (Top == null)
      {
        throw new Exception("This stack is empty.");
      }

      Node<T> node = Top;

      return node.Value;
    }

    public bool IsEmpty()
    {
      if (Top == null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
