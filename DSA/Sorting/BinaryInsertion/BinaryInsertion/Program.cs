using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            binaryInsertion(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void binaryInsertion(int [] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i];
                int left = 0;
                int right = i ;
                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (x >= a[middle])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle;
                    }
                }
                for (int j = i; j > left; j--)
                {
                    int temp = a[j];
                    a[j] = a[j-1];
                    a[j-1] = temp;
                }
            }
        }
    }
}
