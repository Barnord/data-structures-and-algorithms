using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class RepeatWord
  {
    public static string RepeatedWord(string phrase)
    {
      HashMap wordMap = new HashMap(1024);
      string[] words = phrase.Split();

      foreach (string word in words)
      {
        if (wordMap.Contains(word))
        {
          return word;
        } else
        {
          wordMap.Set(word, word);
        }
      }

      return "no matches";
    }
  }
}
