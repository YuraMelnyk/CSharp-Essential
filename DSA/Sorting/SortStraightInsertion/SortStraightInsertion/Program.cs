using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStraightInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 55, 12, 42, 94, 18, 6, 67 };
            StraightInsertion(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(arr);
            Console.ReadLine();
        }
         
        public static void StraightInsertion(int [] a)
        {
            for (int i = 1; i < a.Length ; i++)
            {
                int x = a[i];;
                int j = i - 1;
                if (a[0]>a[1])
                {
                    int temp = a[0];
                    a[0] = a[1];
                    a[1] = temp;
                }
                
                    while ((x < a[j])&& (j > 0))
                    {
                        a[j + 1] = a[j];
                        j = j - 1;
                    }
                
                a[j + 1] = x;
            }
        }
    }
}
