using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {

        static int[,] Change(int[,] ChangedArray)
        {
            int[,] resultArray = new int[ChangedArray.GetLength(0),ChangedArray.GetLength(1)];
            for(int i=0;i<ChangedArray.GetLength(0);i++)
            {
              for(int j=0;j<ChangedArray.GetLength(1);j++)
              {
                    resultArray[i,j] = ChangedArray[ChangedArray.GetLength(0)-i-1, j];
              }
            }
            return resultArray;
        }

        static void PrintMatrix(int [,] Matrix)
        {
           for(int i=0;i<Matrix.GetLength(0);i++)
            {
                for(int j=0;j<Matrix.GetLength(1);j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        static void InitMatrix(int [,] matrix,Random rand)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                }
            }
        }


        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix = new int[11,12];
            InitMatrix(matrix,rand);
            PrintMatrix(matrix);
            Console.WriteLine();
           int[,] ChangeMatrix = Change(matrix);
            PrintMatrix(ChangeMatrix);
            String s = "HelloWorld";
            String s2 = s.Remove(s.IndexOf('W'), 1);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
