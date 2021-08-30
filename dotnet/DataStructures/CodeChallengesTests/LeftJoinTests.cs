using System;
using Xunit;
using CodeChallenges;
using DataStructures;
using System.Collections.Generic;

namespace CodeChallengesTests
{
  public class LeftJoinTests
  {
    [Fact]
    public void AEmptyMaps()
    {
      HashMap left = new(5);
      HashMap right = new(5);

      List<string[]> expected = new();
      List<string[]> answer = HashLeftJoin.LeftJoin(right, left);

      Assert.Equal(expected, answer);
    }

    [Fact]
    public void BSingleValues()
    {
      HashMap left = new(5);
      left.Set("big", "huge");
      HashMap right = new(5);
      right.Set("big", "small");

      List<string[]> expected = new();
      string[] thing = { "big", "small", "big: huge" };
      expected.Add(thing);
      List<string[]> answer = HashLeftJoin.LeftJoin(right, left);

      Assert.Equal(expected, answer);
    }

    [Fact]
    public void CProperReturns()
    {
      HashMap left = new(50);
      left.Set("big", "huge");
      left.Set("hot", "burning");
      left.Set("fast", "speedy");
      HashMap right = new(50);
      right.Set("big", "small");
      right.Set("hot", "cold");
      right.Set("slow", "quick");

      List<string[]> expected = new();
      string[] thing = { "big", "huge", "big: small" };
      string[] ding = { "hot", "burning", "hot: cold" };
      string[] wing = { "fast", "speedy" };
      expected.Add(ding);
      expected.Add(wing);
      expected.Add(thing);

      List<string[]> answer = HashLeftJoin.LeftJoin(left, right);

      Assert.Equal(expected, answer);
    }
  }
}
