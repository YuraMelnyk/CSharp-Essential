using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            Stopwatch stopwatch;
            int countNumbers;
            byte stop = 0;
            Console.WriteLine("Enter count in array:");
            countNumbers =int.Parse(Console.ReadLine());
            int[] array = new int[countNumbers];
            sort.CreateArray(array,countNumbers);
            Console.WriteLine("Choose what kind of algorithm you want to see:\n" +
                "                   1. Shell algorithm\n" +
                "                   2. Bubble algorithm\n" +
                "                   3. Quick sort\n" +
                "                   4. Insertion algorithm\n " +
                "                   5. Exit.\n");
            
            while (stop == 0)
            {
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        sort.ShellSorting(array);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 2:
                        sort.BubbleSorting(array);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 3:
                        QuickSort();
                        stop = 0;
                        break;
                    case 4:
                        sort.StraightInsertion(array);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 5:
                            stop = 1;
                        break;
                    default:
                        stop = 0;
                        break;
                }

            }
            Console.ReadLine();
            
        }

        private static void QuickSort()
        {
            Console.WriteLine("Quick");
        }

    }
}
