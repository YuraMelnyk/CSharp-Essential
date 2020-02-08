using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            ShowArray(arr);
            Console.WriteLine("Enter the search element:");
            int x = int.Parse(Console.ReadLine().ToString());

            int result = binarySearch(arr, 0, arr.Length-1, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
            Console.ReadLine();
        }

        private static int binarySearch(int[] arr, int l, int r, int x)
        {
            
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }

            return -1;
        }

        public static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
