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


        public void StraightInsertion(int[] array) 
        {
            SortingName = "Straight Insertion";
            ComplexityAlgorithm = "O(n^2)";
            NumberOfCompare = 0;
            NumberOfIteration = 0;
            NumberOfUseShow = 0;

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
