using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void InitArray(int[,] array, Random rand)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void SearchIndex(int[,] arr,ref int firstIndex,ref int secondIndex)
        {
            for(int i=0;i<arr.GetLength(1);i++)
            {
                if (arr[0,i]<0)
                {
                    firstIndex = i;
                    break;
                }
            }
            for(int i=(arr.GetLength(1)-1);i>=0;i--)
            {
             if( arr[arr.GetLength(0)-1,i]>0)
                {
                    secondIndex = i;
                    break;
                }  
            }
        }

        public static void ChangeArray(  int[,] arr,int firstIndex,int secondIndex)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                if (secondIndex == firstIndex)
                {
                    Console.WriteLine("Индексы равны");
                    break;
                }
                else
                {
                    Swap(ref arr[i, firstIndex], ref arr[i, secondIndex]);
                }
            }
        }

        private static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[rand.Next(4, 9), rand.Next(4, 9)];
            InitArray(array, rand);
            PrintArray(array);
            int firstIndex = 0;
            int secondIndex = 0;
            SearchIndex(array, ref firstIndex, ref secondIndex);
            ChangeArray(array, firstIndex, secondIndex);
            Console.WriteLine();
            PrintArray(array);
            Console.ReadKey();
        }
    }
}
