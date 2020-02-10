using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            ShowArray(arr);
            Console.WriteLine("Enter the search element:");
            int x = int.Parse(Console.ReadLine().ToString());

            int result = fibonacciSearch(arr, x);
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

        public static int fibonacciSearch(int[] arr, int x)
        {
            int n = arr.Length;
            int fibMMm2 = 0; // (m-2)'th Fibonacci  
            int fibMMm1 = 1; // (m-1)'th Fibonacci  
            int fibM = fibMMm2 + fibMMm1; // m'th Fibonacci 

            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }
 
            int offset = -1;

            while (fibM > 1)
            {
                int i = minimum(offset + fibMMm2, n - 1);

                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                else return i;
            }

           if (fibMMm1 == 1 && arr[offset + 1] == x)
                return offset + 1;

            return -1;
        }

        public static int minimum(int x, int y)
        {
            return (x <= y) ? x : y;
        }
    }
}
