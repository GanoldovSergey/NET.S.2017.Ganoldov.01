using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlg
{
    public static class Sort
    {
        public static void QuickSort(int[] arr)
        {
            CheckInputArray(arr);
            QuickSort(arr, 0, arr.Length-1);
        }
        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);
        }
        public static void MergeSort(int[] arr)
        {
            CheckInputArray(arr);
            MergeSort(arr, 0, arr.Length - 1);
        }
        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left / 2) + (right / 2);

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
        private static void Merge(int[] array, int left, int middle, int right)
        {
            int[] helper = new int[array.Length];

            for (int i = left; i <= right; i++)
            {
                helper[i] = array[i];
            }

            int helperLeft = left,
              helperRight = middle + 1,
              current = left;

            while (helperLeft <= middle && helperRight <= right)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }

            if (helperLeft > middle)
            {
                for (; helperRight <= right; helperRight++, current++)
                {
                    array[current] = helper[helperRight];
                }
            }
            else
            {
                for (; helperLeft <= middle; helperLeft++, current++)
                {
                    array[current] = helper[helperLeft];
                }
            }
        }
        private static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        private static void CheckInputArray(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
