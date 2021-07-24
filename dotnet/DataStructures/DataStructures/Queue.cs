using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  class Queue<T>
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
      Back.Next = node;
      Back = node;
    }

    public T Dequeue()
    {

    }
  }
}
