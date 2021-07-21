using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class LinkedList
  {

    public Node Head { get; set; }

    public LinkedList()
    {

    }

    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;
      }
      Head = node;
    }

    public void Append(int value)
    {
      Node node = new Node(value);
      if (Head == null)
      {
        Head = node;
        return;
      }

      Node current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }

      current.Next = node;
    }

    public void InsertBefore(int value, int before)
    {
      Node node = new Node(value);

      Node current = Head;

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

    public void InsertAfter(int value, int after)
    {
      Node node = new Node(value);

      Node current = Head;
      while (current.Value != after)
      {
        current = current.Next;
      }

      node.Next = current.Next;
      current.Next = node;
    }

    public int Kth(int k)
    {
      Node current = Head;
      int length = 0;

      while (current.Next != null)
      {
        current = current.Next;
        length++;
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
