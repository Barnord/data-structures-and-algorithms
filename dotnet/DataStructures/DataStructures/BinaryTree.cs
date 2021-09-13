using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T> where T : IComparable
  {
    public Node<T> Root { get; set; }

    public List<T> PreOrderTraversal(Node<T> node, List<T> values)
    {
      values.Add(node.Value);
      if (node.Left != null)
      {
        PreOrderTraversal(node.Left, values);
      }
      if (node.Right != null)
      {
        PreOrderTraversal(node.Right, values);
      }
      return values;
    }

    public List<T> InOrderTraversal(Node<T> node, List<T> values)
    {
      if (node.Left != null)
      {
        InOrderTraversal(node.Left, values);
      }
      values.Add(node.Value);
      if (node.Right != null)
      {
        InOrderTraversal(node.Right, values);
      }
      return values;
    }

    public List<T> PostOrderTraversal(Node<T> node, List<T> values)
    {
      if (node.Left != null)
      {
        PostOrderTraversal(node.Left, values);
      }
      if (node.Right != null)
      {
        PostOrderTraversal(node.Right, values);
      }
      values.Add(node.Value);

      return values;
    }

    public static List<int> LevelOrderTraversal(BinaryTree<int> tree)
    {
      List<int> values = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

      while(nodes.Peek() != null)
      {
        Node<Node<int>> node = nodes.Dequeue();
        Node<int> currentNode = node.Value;

        values.Add(currentNode.Value);

        if (currentNode.Left != null)
        {
          nodes.Enqueue(currentNode.Left);
        }
        if (currentNode.Right != null)
        {
          nodes.Enqueue(currentNode.Right);
        }
      }

      return values;
    }

    public T Max()
    {
      T largest = Root.Value;
      Queue<Node<T>> q = new Queue<Node<T>>();
      q.Enqueue(Root);

      while (!q.IsEmpty())
      {
        Node<Node<T>> node = q.Dequeue();
        Node<T> current = node.Value;
        if (current.Value.CompareTo(largest) > 0)
        {
          largest = current.Value;
        }
        if (current.Left != null)
        {
          q.Enqueue(current.Left);
        }
        if (current.Right != null)
        {
          q.Enqueue(current.Right);
        }
      }
      return largest;
    }
  }
}
