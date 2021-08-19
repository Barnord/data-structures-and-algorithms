using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class QuickSortTests
  {
    [Fact]
    public void AEmptyArr()
    {
      int[] arr = { };
      int[] bar = { };
      Sorting.QuickSort(arr, 0, 0);
      Assert.Equal(arr, bar);
    }

    [Fact]
    public void BSingleValueArr()
    {
      int[] arr = { 1 };
      int[] bar = { 1 };
      Sorting.QuickSort(arr,0,0);

      Assert.Equal(arr, bar);
    }

    [Fact]
    public void CProperReturn()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };
      Sorting.QuickSort(arr,0,3);

      Assert.Equal(bar, arr);
    }

    [Fact]
    public void DUnchangedArr()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };
      Sorting.QuickSort(arr,0,3);

      Assert.Equal(bar, arr);
    }
  }
}
