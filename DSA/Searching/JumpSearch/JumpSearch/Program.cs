using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            ShowArray(arr);
            Console.WriteLine("Enter the search element:");
            int x = int.Parse(Console.ReadLine().ToString());

            int result = jumpSearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
            Console.ReadLine();
        }

        public static int jumpSearch(int[] arr, int x)
        {
            int n = arr.Length;

            int step = (int)Math.Floor(Math.Sqrt(n));

            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while (arr[prev] < x)
            {
                prev++;

                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (arr[prev] == x)
                return prev;

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
