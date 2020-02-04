using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfSameElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            List<int> count = new List<int>();
            
            int[] arr = { 2, 2, 4, 5, 6, 7, 7, 7 };
            #region IfArraySorted
            int num = 0;
            for (int i = num; i < arr.Length; i++)
            {
                if (num != arr.Length)
                {
                    i = num;
                    int there = 0;
                    for (int j = i; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            ++num;
                            ++there;

                        }
                        else break;
                    }
                    count.Add(there);
                }
                else break;
            }

            foreach (var item in count)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            #endregion
            #region Dictionary
            for (int i = 0; i < arr.Length; i++)
            {
                if (counter.ContainsKey(arr[i]))
                {
                    counter[arr[i]] += 1;
                }
                else
                {
                    counter.Add(arr[i], 1);
                }
            }
            
            foreach (var coun in counter)
            {
                Console.WriteLine("Key = {0}, Value = {1}", coun.Key, coun.Value);
            }
            #endregion
        }
    }
}
