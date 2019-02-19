using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    class Program
    {

        static void InitArray(int[,] array, Random rand)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-50, 50);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SortArray(int[,] arr)
        {
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                {
                    int current = arr[i, j];
                    int i_row = i;
                    int i_col = j;
                    for (int m = i; m >= 0; m--)
                    {
                        for (int n = (m == i) ? j : (arr.GetLength(1)-1); n >= 0; n--)
                        {
                            if (arr[m, n] > current)
                            {
                                current = arr[m, n];
                                i_row = m;
                                i_col = n;
                            }
                        }

                    }

                    int temp = arr[i, j];
                    arr[i, j] = current;
                    arr[i_row, i_col] = temp;
                }

            }
        }
    

    static void Main(string[] args)
    {
        Random rand = new Random();
        int[,] array = new int[rand.Next(4, 9), rand.Next(4, 9)];
        InitArray(array, rand);
        PrintArray(array);
        Console.WriteLine();
        SortArray(array);
        PrintArray(array);
        Console.ReadKey();
    }
}
    }

