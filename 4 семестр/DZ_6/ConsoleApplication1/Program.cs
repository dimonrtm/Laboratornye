using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void ArrayShow(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static void DeleteItems(ref int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i] % arr[arr.Length-1]!=0)
                {
                    for(int j= i;(j+1)<arr.Length;j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                    i--;
                }
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(10, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }

            ArrayShow(array);
            Console.WriteLine();
            DeleteItems(ref array);
            ArrayShow(array);
            Console.ReadKey();
        }
    }
}
