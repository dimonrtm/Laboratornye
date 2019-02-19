using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_10
{
    class Program
    {

        static void InitArray( ref int [,]arr)
        {
            using (StreamReader reader = File.OpenText("matrix.txt"))
            {
                String s;
                int row = 0, col = 0;
                try
                {
                    s = reader.ReadLine();
                    string[] strs = s.Split(' ');
                    row = Convert.ToInt32(strs[0]);
                    col = Convert.ToInt32(strs[1]);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Неверный формат файла");
                    return;
                }
                arr = new int[row, col];
                for (int i=0;i<arr.GetLength(0);i++)
            {
                 s = reader.ReadLine();
                String[] strs = s.Split(' ');
                for(int j=0;j<strs.Length;j++)
                {
                    try
                    {
                        arr[i, j] = Convert.ToInt32(strs[j]);
                    }
                    catch(FormatException fe)
                    {
                        Console.WriteLine("Неверный формат файла");
                            return;
                    }
                }
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

        static void SaveArray(int[,] arr)
        {
            using (StreamWriter writer = File.CreateText("output.txt"))
            {
                writer.Write(arr.GetLength(0));
                writer.Write(' ');
                writer.Write(arr.GetLength(1));
                writer.WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        writer.Write(arr[i, j] + " ");
                    }
                    writer.WriteLine();
                }
            }
        }

        static void SortArray(int[,] arr)
        {
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                {
                    int x = arr[i, j];
                    int i_row = i;
                    int i_col = j;
                    for (int m = i; m >= 0; m--)
                    {
                        for (int n = (m == i) ? j : (arr.GetLength(1) - 1); n >= 0; n--)
                        {
                            if (arr[m, n] > x)
                            {
                                x = arr[m, n];
                                i_row = m;
                                i_col = n;
                            }
                        }

                    }

                    int temp = arr[i, j];
                    arr[i, j] = x;
                    arr[i_row, i_col] = temp;
                }

            }
        }

        static void Main(string[] args)
        {
            int[,] array=null;
                InitArray(ref array);
            PrintArray(array);
            Console.WriteLine();
            SortArray(array);
            PrintArray(array);
                SaveArray(array);
            
                Console.ReadKey();
        }
    }
}
