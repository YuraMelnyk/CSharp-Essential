using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 06, 67 };
            ShakerSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void ShakerSort(int[] a)
        {
            int l = 0;
            int r = a.Length;
            int k = a.Length-1;
            do
            {
                for (int i = r-1; i > l; i--)
                {
                    if (a[i-1]>a[i])
                    {
                        int temp = a[i - 1];
                        a[i - 1] = a[i];
                        a[i] = temp;
                        k = i;
                    }
                }
                l = k + 1;
                for (int j = l; j < r; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        int temp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = temp;
                        k = j;
                    }
                }
                r = k - 1;
            } while (l > r);
        }
    }
}
