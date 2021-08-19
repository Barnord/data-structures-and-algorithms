using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class Sorting
  {
    public static int[] InsertionSort(int[] arr)
    {
      for(int i =1; i < arr.Length; i++)
      {
        int j = i - 1;
        int temp = arr[i];

        while (j>=0 && temp < arr[j])
        {
          arr[j + 1] = arr[j];
          j = j - 1;
        }

        arr[j + 1] = temp;
      }

      return arr;
    }

    public static void MergeSort(int[] arr)
    {
      int n = arr.Length;
      if (n>1) {
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i=0; i<mid; i++)
        {
          left[i] = arr[i];
        }

        int j = 0;

        for (int i =mid; i<n; i++)
        {
          right[j] = arr[i];
          j++;
        }

        MergeSort(left);
        MergeSort(right);

        Merge(left, right, arr);
      }
    }

    public static void Merge(int[] left, int[] right, int[] arr)
    {
      int i = 0;
      int j = 0;
      int k = 0;

      while (i < left.Length || j< right.Length)
      {
        if (i < left.Length && j < right.Length)
        {
          if (left[i] <= right[j])
          {
            arr[k] = left[i];
            i++;
          }
          else
          {
            arr[k] = right[j];
            j++;
          }
        }
        else if (i < left.Length)
        {
          arr[k] = left[i];
          i++;
        }
        else if (j < right.Length)
        {
          arr[k] = right[j];
          j++;
        }

          k++;
      }
    }

    public static void QuickSort(int[] arr, int left, int right)
    {
      if (left < right)
      {
        int position = Partition(arr, left, right);
        QuickSort(arr, left, position - 1);
        QuickSort(arr, position + 1, right);
      }
    }

    public static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];
      int low = left-1;
      for (int i = left; i < right; i++)
      {
        if (arr[i] <= pivot)
        {
          low++;
          Swap(arr, i, low);
        }
      }

      Swap(arr, right, low + 1);

      return low + 1;
    }

    public static void Swap(int[] arr, int i, int low)
    {
      int temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
    }
  }
}
