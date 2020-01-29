using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            BubbleSorting2(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void BubbleSorting(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = a.Length-1; j > i; j--)
                {
                    if (a[j] < a[j-1])
                    {
                        int tmp = a[j-1];
                        a[j - 1] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }

        public static void BubbleSorting2(int[] a)
        {
            for (int i = 0; i < a.Length - 2; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
