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

        static double AveragePositiveNumbers(int []arr)
        {
            double average = 0.0;
            double sum = 0.0;
            double numbersOfPositive=0.0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>0)
                {
                    numbersOfPositive++;
                    sum += arr[i];
                }
            }
            average = sum / numbersOfPositive;
            return average;
        }

        static void InsertZero(ref int[]arr,double average)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(Math.Abs(arr[i])>average)
                {
                    if (i == arr.Length - 1)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = 0;
                    }
                    else
                    {
                        int temp = arr[arr.Length - 1];
                        for (int j = arr.Length - 1; j > i + 1; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[i + 1] = 0;
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = temp;
                        i++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(10, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
            }

            ArrayShow(array);
            double average = AveragePositiveNumbers(array);
            Console.WriteLine();
            Console.WriteLine(average);
            InsertZero(ref array, average);
            ArrayShow(array);
            Console.ReadKey();
        }
    }
}
