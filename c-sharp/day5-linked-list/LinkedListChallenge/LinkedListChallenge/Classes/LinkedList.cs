using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListChallenge.Classes
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
        node.Next=Head;
      }
      Head = node;
    }
  }
}
