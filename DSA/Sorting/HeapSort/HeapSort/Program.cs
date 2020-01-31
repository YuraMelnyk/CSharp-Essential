using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            int n = arr.Length;
            HeapSorting(arr, n);
            ShowArray(arr);
            Console.ReadLine();
        }

        public static void HeapSorting(int[] a, int n)
        {
            BuildMaxHeap(a, n);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref a[0], ref a[i]);
                Heapify(a, 0, i);
            }
        }

        private static void Heapify(int[] a, int v, int n)
        {
            int left = 2 * v + 1;
            int right = 2 * v + 2;
            int max = v;

            if ((left < n) && (a[left] > a[max]))
            {
                max = left;
            }

            if ((right < n) && (a[right] > a[max]))
            {
                max = right;
            }

            if (max != v)
            {
                Swap(ref a[v], ref a[max]);
                Heapify(a, max, n);
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        private static void BuildMaxHeap(int[] a, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(a, i, n);
            }
        }

        public static void ShowArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
