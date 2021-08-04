using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class treeBreadthFirst
  {
    public static List<int> LevelOrderTraversal(BinaryTree<int> tree)
    {
      List<int> values = new List<int>();
      DataStructures.Queue<Node<int>> q = new DataStructures.Queue<Node<int>>();
      q.Enqueue(tree.Root);

      while (!q.IsEmpty())
      {
        Node<Node<int>> node = q.Dequeue();
        Node<int> current = node.Value;
        values.Add(current.Value);

        if(current.Left != null)
        {
          q.Enqueue(current.Left);
        }
        if (current.Right != null)
        {
          q.Enqueue(current.Right);
        }
      }

      return values;
    }
  }
}
