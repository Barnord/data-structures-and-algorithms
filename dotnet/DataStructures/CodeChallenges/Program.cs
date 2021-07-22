using System;
using DataStructures;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

    public static LinkedList LinkedZipper(LinkedList list1, LinkedList list2)
    {
      LinkedList zippedList = new LinkedList();
      Node current1 = list1.Head;
      Node current2 = list2.Head;

      while (current1!=null || current2!=null)
      {
        if (current1!=null)
        {
          zippedList.Append(current1.Value);
        }
        if (current2!=null)
        {
          zippedList.Append(current2.Value);
        }
        current1 = current1.Next;
        current2 = current2.Next;
      }

      return zippedList;
    }
    }
}
