using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    class Program
    {
        static void CheckWords(char[,] CharArray, string str)
        {
            string tempString = str;
            if (tempString == String.Empty)
            {
                Console.WriteLine("Нет");
                return;
            }
            for (int i = 0; i < CharArray.GetLength(0); i++)
            {
                for (int j = 0; j < CharArray.GetLength(1); j++)
                {
                    if (tempString == String.Empty)
                    {
                        Console.WriteLine("Да");
                        return;
                    }
                    int index = tempString.IndexOf(CharArray[i, j]);
                    if (index >= 0)
                    {
                       tempString= tempString.Remove(index, 1);
                    }
                }
            }
            if (tempString != String.Empty)
            {
                Console.WriteLine("Нет");
            }
        }

        static void InitCharArray(char[,]charArray,Random rand)
        {
            for(int i=0;i<charArray.GetLength(0);i++)
            {
                for(int j=0;j<charArray.GetLength(1);j++)
                {
                    charArray[i, j] =( char)rand.Next('а','я');
                }
            }
        }

        static void PrintArray(char [,] charArray)
        {
            for(int i=0;i<charArray.GetLength(0);i++)
            {
               for(int j=0;j<charArray.GetLength(1);j++)
                {
                    Console.Write(charArray[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Random rand = new Random();
            char[,] CharArray = new char[rand.Next(2,9), rand.Next(2,9)];
            InitCharArray(CharArray, rand);
            PrintArray(CharArray);
            Console.WriteLine("Введите слово:");
            string str = Console.ReadLine();
            CheckWords(CharArray, str);
            Console.ReadLine();
        }
    }
}
