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

        #region StraightInsertion
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
        #endregion

        #region BubbleSorting
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
        #endregion

        #region ShellSorting
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
        #endregion

        #region HeapSorting
        public void HeapSorting(int[] array, int n)
        {
            SortingName = "Heap Sorting Algorithm";
            ComplexityAlgorithm = "O(n^2)";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;
            int[] a = new int[array.Length];
            array.CopyTo(a, 0);

            stopwatch = Stopwatch.StartNew();

            BuildMaxHeap(a, n);
            for (int i = n - 1; i >= 0; i--)
            {
                NumberOfIteration++;
                Swap(ref a[0], ref a[i]);
                Heapify(a, 0, i);
            }

            stopwatch.Stop();
            Time = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
        }

        private  void Heapify(int[] a, int v, int n)
        {
            int left = 2 * v + 1;
            int right = 2 * v + 2;
            int max = v;

            if ((left < n) && (a[left] > a[max]))
            {
                NumberOfCompare += 2;
                max = left;
            }

            if ((right < n) && (a[right] > a[max]))
            {
                NumberOfCompare += 2;
                max = right;
            }

            if (max != v)
            {
                NumberOfCompare++;
                Swap(ref a[v], ref a[max]);
                Heapify(a, max, n);
            }
        }
        private void BuildMaxHeap(int[] a, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                NumberOfIteration++;
                Heapify(a, i, n);
            }
        }
        #endregion

        #region QuickSort
        public void QuickSort(int[] array)
        {
            SortingName = "Quick Sorting algorithm";
            ComplexityAlgorithm = "O(n*log(n))";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);

            QuickSorting(arr, 0, arr.Length - 1);

        }
        private int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                NumberOfIteration++;
                if (arr[j] < pivot)
                {
                    NumberOfCompare++;
                    i++;

                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        private void QuickSorting(int[] arr, int low, int high)
        {          
            stopwatch = Stopwatch.StartNew();

            if (low < high)
            {
                NumberOfCompare++;
                int partitioningIndex = partition(arr, low, high);

                QuickSorting(arr, low, partitioningIndex - 1);
                QuickSorting(arr, partitioningIndex + 1, high);
            }

            stopwatch.Stop();
            Time = int.Parse(stopwatch.ElapsedMilliseconds.ToString());
        }

        #endregion

        #region Addition methods
        private void Swap(ref int v1, ref int v2)
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
        #endregion


    }
}
