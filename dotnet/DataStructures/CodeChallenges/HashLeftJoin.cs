using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class HashLeftJoin
  {
    public static List<string[]> LeftJoin(HashMap left, HashMap right)
    {
      List<string[]> joined = new();
      for (int i = 0; i<left.Map.Length; i++)
      {
        if (left.Map[i] !=null)
        {
          Node<KeyValuePair<string, string>> current = left.Map[i].Head;
          string[] newArr = new string[2];
          newArr[0] = current.Value.Key;
          newArr[1] = current.Value.Value;
          if (right.Contains(current.Value.Key))
          {
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[2] = right.Get(current.Value.Key);
          }
          joined.Add(newArr);
        }
      }
      return joined;
    }
  }
}
