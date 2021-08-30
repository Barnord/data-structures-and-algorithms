using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class HashMap
  {
    public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
    public HashMap(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    public int Hash(string key)
    {
      int hashValue = 0;

      char[] letters = key.ToCharArray();

      for(int i = 0; i<letters.Length; i++)
      {
        hashValue += letters[i];
      }

      hashValue = (hashValue * 599) % Map.Length;

      return hashValue;
    }

    public void Set(string key, string value)
    {
      int hashKey = Hash(key);

      if (Map[hashKey] == null)
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
      Map[hashKey].Insert(entry);
    }

    public bool Contains(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey !] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key) { return true; }
          current = current.Next;
        }
      }
      return false;
    }

    public string Get(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey!] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[hashKey].Head;

        while (current != null)
        {
          if (current.Value.Key == key)
          {
            string got = $"{current.Value.Key}: {current.Value.Value}";
            return got;
          }
          current = current.Next;
        }
      }
      return $"Item: {key}, not found";
    }

    public void Print()
    {
      for (int i = 0; i < Map.Length; i++)
      {
        Console.Write($"{i} --");
        if (Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while(current != null)
          {
            Console.Write($"[{current.Value.Key}: {current.Value.Value}] =>");
            current = current.Next;
          }
        }
        Console.WriteLine();
      }
    }
  }
}
