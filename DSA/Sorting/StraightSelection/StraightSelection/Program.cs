using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraightSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            StraightSelection(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void StraightSelection(int [] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int k = i;
                int x = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (x > a[j])
                    {
                        x = a[j];
                        k = j;
                    }                   
                }
                a[k] = a[i];
                a[i] = x;
            }
        }
    }
}
