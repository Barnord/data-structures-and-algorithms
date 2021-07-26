using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Back { get; set; }

    public Queue()
    {

    }

    public void Enqueue(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Front == null)
      {
        Front = node;
      }
      else
      {
      Back.Next = node;
      }
      Back = node;
    }

    public T Dequeue()
    {
      if (Front == null)
      {
        new NullReferenceException("Empty Queue.");
      }
      Node<T> node = Front;
      Front = Front.Next;

      return node.Value;
    }

    public T Peek()
    {
      if (Front == null)
      {
        new NullReferenceException("Empty Queue.");
      }

      return Front.Value;
    }

    public bool IsEmpty()
    {
      bool empty = false;
      if (Front == null)
      {
        empty = true;
      }
      return empty;
    }
  }
}
