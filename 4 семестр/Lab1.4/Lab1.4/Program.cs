using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1._4
{
    class Program
    {
       static Boolean CheckString(string str)
        {
            Regex reg = new Regex(@"\d+");
            Match match = reg.Match(str);
            if(match.Value!=String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество строк в тексте:");
            n = Convert.ToInt32(Console.ReadLine());
            string str = "";
            Console.WriteLine("Введите текст:");
            for(int i=0;i< n;i++)
            {
                str = str + Console.ReadLine(); 
            }
            if(CheckString(str))
            {
                Console.WriteLine("В тексте присутствуют числа");
            }
            else
            {
                Console.WriteLine("В тексте отсутствуют числа");
            }
            Console.ReadLine();
        }
    }
}
