using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            RadixSorting(arr);
            ShowArray(arr);
            Console.ReadLine();
        }

        private static void RadixSorting(int[] arr)
        {
            int max = GetMax(arr);
            for (int exp = 1; max/exp > 0; exp*=10)
            {
                countSort(arr, exp);
            }
        }

        private static void countSort(int[] arr, int exp)
        {
            int[] temp = new int[arr.Length];
            int[] count = new int[10];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (int i = 1; i < count.Length ; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp[i];
            }

        }

        private static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
            
        }

        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
