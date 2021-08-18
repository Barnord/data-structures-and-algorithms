using System;
using Xunit;
using CodeChallenges;
using DataStructures;

namespace CodeChallengesTests
{
  public class MergeSortTests
  {
    [Fact]
    public void AEmptyArr()
    {
      int[] arr = { };
      int[] bar = { };
      Sorting.MergeSort(arr);
      Assert.Equal(arr, bar);
    }

    [Fact]
    public void BSingleValueArr()
    {
      int[] arr = { 1 };
      int[] bar = { 1 };
      Sorting.MergeSort(arr);

      Assert.Equal(arr, bar);
    }

    [Fact]
    public void CProperReturn()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };
      Sorting.MergeSort(arr);

      Assert.Equal(bar, arr);
    }

    [Fact]
    public void DUnchangedArr()
    {
      int[] arr = { 1, 2, 3, 4 };
      int[] bar = { 1, 2, 3, 4 };
      Sorting.MergeSort(arr);

      Assert.Equal(bar, arr);
    }
  }
}
