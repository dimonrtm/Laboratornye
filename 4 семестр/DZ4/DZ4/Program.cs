using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    class Program
    {
        static int[] SearshMonotonycityInterval(int[] arr)
        {
            bool flag_neg = true;
            bool flag_pos = true;
            int monotony = 1;
            List<int> indexies = new List<int>();
            if(arr[1]>=arr[0])
            {
                flag_neg = false;
                flag_pos = true;
            }
            else if(arr[1]<arr[0])
            {
                flag_pos = false;
                flag_neg = true;
            }
            for (int i =2; i < arr.Length; i++)
            {
                if (arr[i]>=arr[i-1]&&flag_pos)
                {
                   continue;
                }
                else if (arr[i] < arr[i - 1] && flag_pos)
                    {
                        // в ерврм массиве фиксируем начало нового промежутка монотонноси

                        monotony++;
                        indexies.Add(i - 1);
                        flag_pos = false;
                        flag_neg = true;

                    }

                if(arr[i]>arr[i-1]&&flag_neg)
                {
                    monotony++;
                    indexies.Add(i - 1);
                    flag_pos = true;
                    flag_neg = false;
                }
               else if (arr[i] <= arr[i - 1] &&flag_neg)
                    {
                        // в ерврм массиве фиксируем начало нового промежутка монотоннос    
                    continue;
                }
                
            }
                Console.WriteLine("Количество промежутков монотонности {0}", monotony);
                Console.WriteLine();
                int[] array = new int[arr.Length];
            int arr1Length = indexies[0]+1;
            int arr1FirstIndex = array.Length-arr1Length;  
            int arr2FirstIndex = indexies[indexies.Count-1];
            int arr2Length = arr.Length-arr2FirstIndex;
            int arr3FirstIndex = arr1Length;
            int array3FirstIndex = arr2Length;
            //int arr3LastIndex = arr1Length + arr2Length;
            int arr3Length = arr.Length-(arr1Length+arr2Length);
                Array.Copy(arr, 0, array,arr1FirstIndex,arr1Length);
            Array.Copy(arr, arr2FirstIndex, array, 0,arr2Length );
            Array.Copy(arr, arr3FirstIndex, array, array3FirstIndex, arr3Length);
            //for (int i = 1; i < lengths.Count - 1; i++)
            //{
            //    sumLengths += lengths[i];
            //}
           // Array.Copy(arr, indexies[0]-1, array, (arr.Length - (indexies[indexies.Count - 1] - 1)),indexies[indexies.Count-1]-(indexies[0]-1));
            //Array.Copy(arr, 0, array, ((arr.Length - (indexies[indexies.Count - 1]))+ (indexies[indexies.Count] - (indexies[0] ))),indexies[0]);
           // Array.Copy(arr,0,array,array.Length-(indexies[0]),indexies[0]);
            return array;  
        }
        
        
        static void ArrayShow(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(10,10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
            }

            ArrayShow(array);
            int[] resultArray = SearshMonotonycityInterval(array);
            Console.WriteLine();
            ArrayShow(resultArray);
            Console.ReadKey();
        }
    }
}
