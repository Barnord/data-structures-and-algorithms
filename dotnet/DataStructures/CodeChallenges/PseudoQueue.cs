using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class PseudoQueue
  {
    DataStructures.Stack<int> Front = new DataStructures.Stack<int>();

    public void Enqueue(int value)
    {
      Front.Push(value);
    }

    public int DeQueue()
    {
      DataStructures.Stack<int> Back = new DataStructures.Stack<int>();

      while (Front.Top.Next != null)
      {
        int current = Front.Pop();
        Back.Push(current);
      }

      int ans = Front.Pop();

      while (Back.Top != null)
      {
        int current = Back.Pop();
        Front.Push(current);
      }

      return ans;
    }
  }
}
