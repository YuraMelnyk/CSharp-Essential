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
                "                   5. Heap Sorting Algorithm\n" +
                "                   6. Exit\n");
            
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
                        sort.QuickSort(array);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 4:
                        sort.StraightInsertion(array);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 5:
                        sort.HeapSorting(array, array.Length);
                        sort.ShowInformation();
                        stop = 0;
                        break;
                    case 6:                       
                        Console.WriteLine("Do you want enter new array length? Press \"Y\" key");
                        string ans = Console.ReadLine().ToString();
                        if ((ans == "y") || (ans == "Y"))
                        {
                            Console.WriteLine("Enter count in array:");
                            countNumbers = int.Parse(Console.ReadLine());
                            array = new int[countNumbers];
                            sort.CreateArray(array, countNumbers);
                            Console.WriteLine("Choose what kind of algorithm you want to see:\n" +
                "                   1. Shell algorithm\n" +
                "                   2. Bubble algorithm\n" +
                "                   3. Quick sort\n" +
                "                   4. Insertion algorithm\n " +
                "                   5. Heap Sorting Algorithm\n" +
                "                   6. Exit\n");
                            stop = 0;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Have a nice day!");
                            stop = 1;
                            break;
                        }
                    default:
                        Console.WriteLine("Enter corect number for algorithm");
                        stop = 0;
                        break;
                }

            }
            Console.ReadLine();
            
        }


    }
}
