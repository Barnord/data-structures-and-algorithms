using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
    public class ZippedListTests
    {
        [Fact]
      public void HappyPath()
      {
      LinkedList<int> list1 = new LinkedList<int>();
      list1.Append(1);
      list1.Append(3);
      list1.Append(5);

      LinkedList<int> list2 = new LinkedList<int>();
      list2.Append(2);
      list2.Append(4);
      list2.Append(6);

      LinkedList<int> ans = Program.LinkedZipper(list1, list2);

      Node<int> current = ans.Head;

      int[] ansArr = new int[6];
      int i = 0;
      while (current != null)
      {
        ansArr[i] = current.Value;
        current = current.Next;
        i++;
      }

      Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, ansArr);

      }
    }

  public class MistmatchedLists
  {
    [Fact]
    public void Test1()
    {
      LinkedList<int> list1 = new LinkedList<int>();
      list1.Append(1);
      list1.Append(3);
      list1.Append(5);

      LinkedList<int> list2 = new LinkedList<int>();
      list2.Append(2);
      list2.Append(4);
      list2.Append(6);
      list2.Append(8);

      LinkedList<int> ans = Program.LinkedZipper(list1, list2);

      Node<int> current = ans.Head;

      int[] ansArr = new int[7];
      int i = 0;
      while (current != null)
      {
        ansArr[i] = current.Value;
        current = current.Next;
        i++;
      }

      Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 8 }, ansArr);

    }
  }
}
