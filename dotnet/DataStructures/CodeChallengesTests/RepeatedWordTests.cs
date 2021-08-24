using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class RepeatedWordTests
  {
    [Fact]
    public static void AEmptyString()
    {
      string phrase = "";

      Assert.Equal("no matches", RepeatWord.RepeatedWord(phrase));
    }

    [Fact]
    public static void BSingleWord()
    {
      string phrase = "banana";

      Assert.Equal("no matches", RepeatWord.RepeatedWord(phrase));
    }

    [Fact]
    public static void CProperReturn()
    {
      string phrase = "the commodor is cool, but the admiral is banana commodor";

      Assert.Equal("the", RepeatWord.RepeatedWord(phrase));
    }

    [Fact]
    public static void DLongerStringNoMatches()
    {
      string phrase = "the quick brown fox jumps over a lazy dog.";

      Assert.Equal("no matches", RepeatWord.RepeatedWord(phrase));
    }
  }
}
