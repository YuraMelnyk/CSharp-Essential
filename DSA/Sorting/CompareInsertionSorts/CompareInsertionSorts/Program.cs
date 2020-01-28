using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CompareInsertionSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1;
            Stopwatch sw2;
            int count = 100000;
            int[] arr = generatorArray(count);
            int[] arr2 = new int[count];
            arr.CopyTo(arr2, 0);
            
            sw1 = Stopwatch.StartNew();
            StraightInsertion(arr);           
            sw1.Stop();
            Console.WriteLine("Time StraightInsertion = " + sw1.ElapsedMilliseconds + " mms");

            sw2 = Stopwatch.StartNew();
            binaryInsertion(arr2);
            sw2.Stop();
            Console.WriteLine("Time binaryInsertion = " + sw2.ElapsedMilliseconds + " mms");
            
            Console.WriteLine();
            Console.ReadLine();
            
        }

        public static int[] generatorArray(int count)
        {
            Random rnd = new Random();
            int[] a = new int[count];
            for (int i = 0; i < a.Length; i++)
            {
                rnd.Next(0, count);
                a[i] = int.Parse(rnd.Next(0, count).ToString());
            }
            return a;
        }

        public static void StraightInsertion(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i]; ;
                int j = i - 1;
                if (a[0] > a[1])
                {
                    int temp = a[0];
                    a[0] = a[1];
                    a[1] = temp;
                }

                while ((x < a[j]) && (j > 0))
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }

                a[j + 1] = x;
            }
        }
        public static void binaryInsertion(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i];
                int left = 0;
                int right = i;
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
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }
        }
    }
}
