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

        static int SearshIndexRowMaximumElem(int [,]arr)
        {
            int max = arr[0, 0];
            int indexRowMaxElement = 0;
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if(arr[i,j]>max)
                    {
                        max = arr[i, j];
                        indexRowMaxElement = i;
                    }
                }
            }
            return indexRowMaxElement;
        }

        private static void ArrayResize(ref int[,]arr,int sizeRow,int sizeColumn)
        {
            int[,] temp = new int[sizeRow, sizeColumn];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    temp[i, j] = arr[i, j];
                }
            }
            arr = temp;
        }

        static void ChangeArray(ref int[,] arr,int indexRow)
        {
            int[] maxRow = new int[arr.GetLength(1)];
            int sum = Math.Abs(arr[0, 0]) + Math.Abs(arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1]);
            for(int i=0;i<maxRow.Length;i++)
            {
                maxRow[i] = arr[indexRow, i];
            }
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    try
                    {
                        if (sum % arr[i, j] == 0)
                        {
                            if (i == (arr.GetLength(0) - 1))
                            {
                                ArrayResize(ref arr, arr.GetLength(0) + 1, arr.GetLength(1));
                                for (int k = 0; k < arr.GetLength(1); k++)
                                {
                                    arr[arr.GetLength(0) - 1, k] = maxRow[k];
                                }
                                i++;
                                break;
                            }
                            else
                            {
                                int[] temp = new int[arr.GetLength(1)];
                                for (int m = 0; m < arr.GetLength(1); m++)
                                {
                                    temp[m] = arr[arr.GetLength(0) - 1, m];
                                }
                                for (int n = arr.GetLength(0) - 1; n > i + 1; n--)
                                {
                                    for (int p = 0; p < arr.GetLength(1); p++)
                                    {
                                        arr[n, p] = arr[n - 1, p];
                                    }
                                }
                                for (int r = 0; r < arr.GetLength(1); r++)
                                {
                                    arr[i + 1, r] = maxRow[r];
                                }
                                ArrayResize(ref arr, arr.GetLength(0) + 1, arr.GetLength(1));
                                for (int s = 0; s < arr.GetLength(1); s++)
                                {
                                    arr[arr.GetLength(0) - 1, s] = temp[s];
                                }
                                i++;
                                break;
                            }
                        }
                    }
                    catch(DivideByZeroException dbze)
                    {
                        continue;
                    }
                   
                }
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[rand.Next(4, 9), rand.Next(4, 9)];
            InitArray(array, rand);
            PrintArray(array);
            int indexRow = SearshIndexRowMaximumElem(array);
            ChangeArray(ref array, indexRow);
            Console.WriteLine();
            PrintArray(array);
            Console.ReadKey();
        }
    }
}
