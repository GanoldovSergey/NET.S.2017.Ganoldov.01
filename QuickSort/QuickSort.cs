using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{
    public static class QuickSort
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length-1);
        }
        private static void Sort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int tmp;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                Sort(arr, left, j);
            if (i < right)
                Sort(arr, i, right);
        }
    }
}
