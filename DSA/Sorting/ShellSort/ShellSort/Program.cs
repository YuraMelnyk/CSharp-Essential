using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 06, 67 };
            ShellSorting(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void ShellSorting(int[] arr)
        {
            for (int i = arr.Length/2; i > 2; i/=2)
            {
                for (int j = 0; j < i; j++)
                {
                    InsSort(arr, j, i);
                }

            }
            InsSort(arr, 0, 1);
        }

        private static void InsSort(int[] arr, int start, int incr)
        {
            for (int i = start + incr; i < arr.Length; i+=incr)
            {
                for (int j = i; (j >=incr)&&(arr[j]<arr[j-incr]) ; j-=incr)
                {
                    Swap(ref arr[j], ref arr[j - incr]);
                }
            }
        }

        private static void ShellSortingExplain(int[] arr)  // it's just example for understand how to work this algorithm
        {
            int k = 1;
            for (int i = 0; i < arr.Length-4; i++)
            {
                if (k != 0)
                {
                    k = 0;
                    for (int j = 0; j < arr.Length - 4; j++)
                    {
                        if (arr[j] > arr[j + 4])
                        {
                            Swap(ref arr[j], ref arr[j + 4]);
                            ++k;
                        }
                    }
                }
                else break;
            }

            k = 1;
            for (int i = 0; i < arr.Length-2; i++)
            {
                if (k != 0)
                {
                    k = 0;
                    for (int j = 0; j < arr.Length - 2; j++)
                    {
                        if (arr[j] > arr[j + 2])
                        {
                            Swap(ref arr[j], ref arr[j + 2]);
                            ++k;
                        }
                    }
                }
                else break;
            }

            k = 1;
            for (int i = 0; i < arr.Length-1 ; i++)
            {
                if (k != 0)
                {
                    k = 0;
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                            ++k;
                        }
                    } 
                } 
                else break;
            }

        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
