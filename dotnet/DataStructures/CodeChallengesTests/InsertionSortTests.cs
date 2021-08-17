using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class InsertionSortTests
  {
    [Fact]
    public void AEmptyArr()
    {
      int[] arr = { };

      Assert.Equal(arr, Sorting.InsertionSort(arr));
    }

    [Fact]
    public void BSingleValueArr()
    {
      int[] arr = { 1 };

      Assert.Equal(arr, Sorting.InsertionSort(arr));
    }

    [Fact]
    public void CProperReturn()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, Sorting.InsertionSort(arr));
    }

    [Fact]
    public void DUnchangedArr()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, Sorting.InsertionSort(arr));
    }
  }
}
