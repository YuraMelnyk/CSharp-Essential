using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            ShowArray(arr);
            Console.WriteLine("Enter the search element:");
            int x = int.Parse(Console.ReadLine().ToString());

            int result = interpolationSearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
            Console.ReadLine();
        }
        public static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int interpolationSearch(int[] arr, int x)
        {

            int lo = 0;
            int hi = (arr.Length - 1);

            while (lo <= hi &&
                    x >= arr[lo] &&
                    x <= arr[hi])
            {
                if (lo == hi)
                {
                    if (arr[lo] == x) return lo;
                    return -1;
                }

                int pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));

                if (arr[pos] == x)
                    return pos;

                if (arr[pos] < x)
                    lo = pos + 1;

                else
                    hi = pos - 1;
            }
            return -1;
        }
    }
}
