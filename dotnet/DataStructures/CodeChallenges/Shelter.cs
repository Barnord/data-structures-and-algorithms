using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class Shelter
  {
    DataStructures.Queue<Critter> CatQ = new DataStructures.Queue<Critter>();
    DataStructures.Queue<Critter> DogQ = new DataStructures.Queue<Critter>();

    public void AddCritter(string name, string species)
    {
      Critter critter = new Critter(name, species);
      if (critter.Species.ToLower() == "dog")
      {
        DogQ.Enqueue(critter);
      }
      if (critter.Species.ToLower() == "cat")
      {
        CatQ.Enqueue(critter);
      }
    }

    public string Adopt(string pref)
    {
      if (pref.ToLower() == "cat")
      {
        Critter critter = CatQ.Dequeue();
        return $"You adopted a new cat, named {critter.Name}.";
      }
      if (pref.ToLower() == "dog")
      {
        Critter critter = DogQ.Dequeue();
        return $"You adopted a new dog, named {critter.Name}.";
      }
      else
      {
        return "We don't deal in that kind of critter";
      }
    }
  }

  public class Critter
  {
    public string Name { get; set; }
    public string Species { get; set; }
    public Critter(string name, string species)
    {
      Name = name;
      Species = species;
    }
  }
}
