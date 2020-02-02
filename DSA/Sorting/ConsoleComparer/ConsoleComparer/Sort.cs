using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleComparer
{
    public class Sort
    {
        private string SortingName;
        private string ComplexityAlgorithm;
        private int NumberOfIteration;
        private int NumberOfCompare;
        private int NumberOfUseShow;
        private int Time;
        private Stopwatch stopwatch;


        public void StraightInsertion(int[] array1) 
        {
            SortingName = "Straight Insertion";
            ComplexityAlgorithm = "O(n^2)";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;
            int[] array = new int[array1.Length];
            array1.CopyTo(array, 0);

            stopwatch = Stopwatch.StartNew();

            for (int i = 1; i < array.Length; i++)
            {
                ++NumberOfIteration;
                int x = array[i]; ;
                int j = i - 1;
                if (array[0]>array[1])
                {
                    ++NumberOfCompare;
                    int temp = array[0];
                    array[0] = array[1];
                    array[1] = temp;
                }

                while ((x < array[j]) && (j > 0))
                {
                    ++NumberOfIteration;
                    NumberOfCompare += 2;
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = x;
            }
            stopwatch.Stop();
            Time = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
        }

        public void BubbleSorting(int[] array)
        {
            SortingName = "Bubble Sort";
            ComplexityAlgorithm = "O(n^2)";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;
            int[] a = new int[array.Length];
            array.CopyTo(a, 0);

            stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < a.Length - 2; i++)
            {
                NumberOfIteration++;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    NumberOfIteration++;
                    if (a[j] > a[j + 1])
                    {
                        NumberOfCompare++;
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }

            stopwatch.Stop();
            Time = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
        }

        public void ShellSorting(int[] array)
        {
            SortingName = "Shell Sort";
            ComplexityAlgorithm = "O(n^2)";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);

            stopwatch = Stopwatch.StartNew();

            for (int i = arr.Length / 2; i > 2; i /= 2)
            {
                NumberOfIteration++;
                for (int j = 0; j < i; j++)
                {
                    NumberOfIteration++;
                    InsSort(arr, j, i);
                }

            }
            InsSort(arr, 0, 1);

            stopwatch.Stop();
            Time = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
        }

        private  void InsSort(int[] arr, int start, int incr)
        {
            for (int i = start + incr; i < arr.Length; i += incr)
            {
                NumberOfIteration++;
                for (int j = i; (j >= incr) && (arr[j] < arr[j - incr]); j -= incr)
                {
                    NumberOfIteration++;
                    NumberOfCompare += 2;
                    Swap(ref arr[j], ref arr[j - incr]);
                }
            }
        }

        private  void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public void ShowInformation()
        {
            if (NumberOfUseShow==0)
            {
                Console.WriteLine("------------Information-------------");
                Console.WriteLine($"{SortingName} algorithm.");
                Console.WriteLine($"Algorithm has {ComplexityAlgorithm}");
                Console.WriteLine($"Number of Iteration: {NumberOfIteration}");
                Console.WriteLine($"Number of Compare: {NumberOfCompare}");
                Console.WriteLine($"Time: {Time} mms");
                NumberOfUseShow++;
            }
            else
            {
                Console.WriteLine("Try use new algorithm.");
            }
        }

        public static void ShowArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
        public  void CreateArray(int[] array, int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                rnd.Next(0, count);
                array[i] = int.Parse(rnd.Next(0, count).ToString());
            }
        }
        public  void CreateArray(double[] array, int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                rnd.Next(0, count);
                array[i] = double.Parse(rnd.Next(0, count).ToString());
            }
        }



    }
}
