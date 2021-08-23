using System;
using System.Collections.Generic;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class HashMapTests
  {
    [Fact]
    public void ACanSetAndReturn()
    {
      DataStructures.HashMap SandwichRatings = new HashMap(24);

      SandwichRatings.Set("Reuben", "great");

      Assert.True(SandwichRatings.Contains("Reuben"));
    }

    [Fact]
    public void BCantReturnNull()
    {
      DataStructures.HashMap SandwichRatings = new HashMap(24);

      Assert.False(SandwichRatings.Contains("Reuben"));
    }

    [Fact]
    public void CCanGet()
    {
      DataStructures.HashMap SandwichRatings = new HashMap(24);

      SandwichRatings.Set("Reuben", "great");

      Assert.Equal("Reuben: great", SandwichRatings.Get("Reuben"));
    }
  }
}
