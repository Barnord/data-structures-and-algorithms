using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class TreeIntersectionHash
  {
    public static int[] TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
    {
      List<int> answer = new();
      HashMap table = new(1024);

      HashTree(tree1.Root, table);
      TreeChecker(tree2.Root, table, answer);

      return answer.ToArray();
    }

    public static void HashTree(Node<int> node, HashMap table)
    {
      if (node.Left != null)
      {
        HashTree(node.Left, table);
      }
      table.Set(node.Value.ToString(), node.Value.ToString());
      if (node.Right != null)
      {
        HashTree(node.Right, table);
      }
    }

    public static void TreeChecker(Node<int> node, HashMap table, List<int> list)
    {
      if (node.Left != null)
      {
        TreeChecker(node.Left, table, list);
      }
      if (table.Contains(node.Value.ToString()))
      {
        list.Add(node.Value);
      }
      if (node.Right != null)
      {
        TreeChecker(node.Right, table, list);
      }
    }
  }
}
