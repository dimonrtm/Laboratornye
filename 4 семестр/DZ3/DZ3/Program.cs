using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    class Program
    {
        static void ArrayShow(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static int [] maxProd(int [] arr)
        {
            int prod =-125000, max1=0, max2=0, max3=0;
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    for(int k=j+1;k<arr.Length;k++)
                    {
                        if(arr[i]*arr[j]*arr[k]>prod)
                        {
                            max1 = arr[i];
                            max2 = arr[j];
                            max3 = arr[k];
                            prod = arr[i] * arr[j] * arr[k];
                        }
                    }
                }
            }
            int[] maxArray = new int[3];
            maxArray[0] = max1;
            maxArray[1] = max2;
            maxArray[2] = max3;
            return maxArray;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(5,20)];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = rand.Next(-50,50);
            }
            ArrayShow(array);
            int[] maxArray = maxProd(array);
            Console.WriteLine();
            ArrayShow(maxArray);
            Console.ReadKey();
        }
    }
}
