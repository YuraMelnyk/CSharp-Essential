using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            QuickSorting(arr, 0, arr.Length-1);
            ShowArray(arr);
            Console.ReadLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        public static void QuickSorting(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitioningIndex = partition(arr, low, high);

                QuickSorting(arr, low, partitioningIndex - 1);
                QuickSorting(arr, partitioningIndex + 1, high);
            }
        }

        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
