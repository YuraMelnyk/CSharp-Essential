using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArray_multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(multiArray[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine(multiArray.GetLength(0));
            Console.WriteLine(multiArray.Length);
            Console.WriteLine(multiArray[2, 1]);

            Console.WriteLine("Jagged array:");
            char[][] mArray = new char[][] { new char[] { 'a', 'b', 'c' }, new char[] { 'b', 'c' } };
            Console.WriteLine(mArray[0].Length);
            Console.WriteLine(mArray.Length);

            Console.WriteLine("Multiply arrays:");
            Console.WriteLine("Enter the dimension of the array: ");
            int n1 = Int32.Parse(Console.ReadLine().ToString());
            int m1 = Int32.Parse(Console.ReadLine().ToString());
            Console.WriteLine("For the first array N={0} and M={1}", n1, m1);
            int[,] arr_1 = new int[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write($"=>[{i},{j}] = ");
                    arr_1[i, j] = Int32.Parse(Console.ReadLine().ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("First array:");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write($"{arr_1[i, j]}\t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the dimension of the second array: ");
            int n2 = Int32.Parse(Console.ReadLine().ToString());
            int m2 = Int32.Parse(Console.ReadLine().ToString());
            Console.WriteLine("For the second array N={0} and M={1}", n2, m2);
            int[,] arr_2 = new int[n2, m2];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write($"=>[{i},{j}] = ");
                    arr_2[i, j] = Int32.Parse(Console.ReadLine().ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second array:");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write($"{arr_2[i, j]}\t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Multiply arrays:");
            int[,] mul_arr = new int[n1, m2];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mul_arr[i, j] = 0;
                    for (int k = 0; k < n2; k++)
                    {
                        mul_arr[i, j] += arr_1[i, k] * arr_2[k, j];
                    }

                }
            }
            Console.WriteLine("Result:");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(" | " + mul_arr[i, j]);
                }
                Console.WriteLine(" | ");
            }

            Console.ReadLine();
        }
    }
}
