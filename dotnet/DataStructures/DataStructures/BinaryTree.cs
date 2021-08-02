using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public static List<T> PreOrderTraversal(Node<T> node, List<T> values)
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

    public static List<T> InOrderTraversal(Node<T> node, List<T> values)
    {
      if (node.Left != null)
      {
        InOrderTraversal(node.Right, values);
      }
      values.Add(node.Value);
      if (node.Right != null)
      {
        InOrderTraversal(node.Right, values);
      }
      return values;
    }

    public static List<T> PostOrderTraversal(Node<T> node, List<T> values)
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

    public static List<int> LevelOrderTraversal(BinarySearchTree<int> tree)
    {
      List<int> values = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

      while(nodes.Peek() != null)
      {
        Node<int> node = nodes.Dequeue();
        Node<int> currentNode = node;

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
  }
}
