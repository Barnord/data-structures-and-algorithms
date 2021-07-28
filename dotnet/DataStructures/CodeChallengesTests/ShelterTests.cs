using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class ShelterTests
  {
    [Fact]
    public void AProperQueue()
    {
      Shelter shelter = new Shelter();
      shelter.AddCritter("Linus", "Cat");

      Assert.Equal("You adopted a new cat, named Linus.", shelter.Adopt("cat"));
    }

    [Fact]
    public void BProperDequeue()
    {
      Shelter shelter = new Shelter();
      shelter.AddCritter("Laika", "Dog");

      Assert.Equal("You adopted a new dog, named Laika.", shelter.Adopt("dog"));
    }

    [Fact]
    public void CNullQueue()
    {
      Shelter shelter = new Shelter();

      Assert.Throws<NullReferenceException>(() => shelter.Adopt("dog"));
    }

    [Fact]
    public void DStoreLizard()
    {
      Shelter shelter = new Shelter();

      Assert.Equal("We don't deal in that kind of critter", shelter.Adopt("lizard"));
    }
  }
}
